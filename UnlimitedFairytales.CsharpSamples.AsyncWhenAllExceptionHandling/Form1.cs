namespace UnlimitedFairytales.CsharpSamples.AsyncWhenAllExceptionHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.raisesException = false;
        }

        private　async void btnDoAsync_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnChangeMode.Enabled = false;
                var results = await DoAsync(raisesException);
                var text = results.Aggregate((a, b) => a + Environment.NewLine + b);
                MessageBox.Show($"{text}");
            }
            catch (Exception ex)
            {
                var nl = Environment.NewLine;
                var inners = (ex as AggregateException)?.InnerExceptions;
                if (inners != null && 0 < inners.Count)
                {
                    foreach (var innerEx in inners)
                    {
                        MessageBox.Show($"{innerEx.Message}{nl}{innerEx.StackTrace}");
                    }
                }
                else
                {
                    MessageBox.Show($"{ex.Message}{nl}{ex.StackTrace}");
                }
            }
            finally
            {
                this.btnChangeMode.Enabled = true;
            }
        }

        private int counter = 0;
        private void btnCountUp_Click(object sender, EventArgs e)
        {
            this.txtCount.Text = $"{++counter}";
        }

        private bool _raisesException = false;
        private bool raisesException {
            get { return this._raisesException; }
            set
            {
                this._raisesException = value;
                this.txtMode.Text = this._raisesException ? "Raise Exception" : "Return Value";
            }
        }
        private void btnChangeMode_Click(object sender, EventArgs e)
        {
            this.raisesException = !this.raisesException;
        }

        // Handler
        ////////////////////////////////////////////////////////////////////////
        // Logic

        private async Task<string[]> DoAsync(bool raisesException)
        {
            var taskList = new List<Task<string>>();
            try
            {
                taskList.Add(Task.Run(async () =>
                {
                    var i = 1;
                    await Task.Delay(i * 1000);
                    if (raisesException)
                    {
                        throw new Exception($"Exception ({i})");
                    }
                    return $"finish({i})";
                }));
                taskList.Add(Task.Run(async () =>
                {
                    var i = 2;
                    await Task.Delay(i * 1000);
                    if (raisesException)
                    {
                        throw new Exception($"Exception ({i})");
                    }
                    return $"finish({i})";
                }));
                taskList.Add(Task.Run(async () =>
                {
                    var i = 3;
                    await Task.Delay(i * 1000);
                    if (raisesException)
                    {
                        throw new Exception($"Exception ({i})");
                    }
                    return $"finish({i})";
                }));
                // async/awaitでそのまま伝播させた場合、各Task内で例外が発生した時、最初の一つしか報告されない
                // 全てのtask内例外を補足するには、予めtaskリストを変数で保持しておき、trycatchで囲んだ上でtaskListから例外状況を取得してそれをthrowする
                return await Task.WhenAll(taskList);
            }
            catch (Exception)
            {
#pragma warning disable CS8602 // null 参照の可能性があるものの逆参照です。
                var inners = taskList
                    .Where(task => task.IsFaulted && task.Exception != null && task.Exception.InnerException != null)
                    .Select(task => task.Exception.InnerException);
#pragma warning restore CS8602 // null 参照の可能性があるものの逆参照です。
#pragma warning disable CS8620 // 参照型の NULL 値の許容の違いにより、パラメーターに引数を使用できません。
                throw new AggregateException(inners);
#pragma warning restore CS8620 // 参照型の NULL 値の許容の違いにより、パラメーターに引数を使用できません。
            }
        }
    }
}