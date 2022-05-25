namespace UnlimitedFairytales.CsharpSamples.AsyncWhenAllExceptionHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.raisesException = false;
        }

        private�@async void btnDoAsync_Click(object sender, EventArgs e)
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
                // async/await�ł��̂܂ܓ`�d�������ꍇ�A�eTask���ŗ�O�������������A�ŏ��̈�����񍐂���Ȃ�
                // �S�Ă�task����O��⑫����ɂ́A�\��task���X�g��ϐ��ŕێ����Ă����Atrycatch�ň͂񂾏��taskList�����O�󋵂��擾���Ă����throw����
                return await Task.WhenAll(taskList);
            }
            catch (Exception)
            {
#pragma warning disable CS8602 // null �Q�Ƃ̉\����������̂̋t�Q�Ƃł��B
                var inners = taskList
                    .Where(task => task.IsFaulted && task.Exception != null && task.Exception.InnerException != null)
                    .Select(task => task.Exception.InnerException);
#pragma warning restore CS8602 // null �Q�Ƃ̉\����������̂̋t�Q�Ƃł��B
#pragma warning disable CS8620 // �Q�ƌ^�� NULL �l�̋��e�̈Ⴂ�ɂ��A�p�����[�^�[�Ɉ������g�p�ł��܂���B
                throw new AggregateException(inners);
#pragma warning restore CS8620 // �Q�ƌ^�� NULL �l�̋��e�̈Ⴂ�ɂ��A�p�����[�^�[�Ɉ������g�p�ł��܂���B
            }
        }
    }
}