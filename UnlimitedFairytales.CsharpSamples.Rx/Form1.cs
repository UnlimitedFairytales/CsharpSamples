using System;
using System.Diagnostics;
using System.Net.Http;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using System.Windows.Forms;

namespace UnlimitedFairytales.CsharpSamples.Rx
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] numArray = new int[3] { 1, 5, 10 };
            Button btn = this.button1;
            HttpClient hc = new HttpClient();
            string url = "https://example.com/";

            // 例1：従来のコレクションをObservableにラップした場合
            var srcObs1 = numArray.ToObservable();
            srcObs1.Subscribe(onNextI =>
            {
                // 実質foreachと同じ
                Trace.WriteLine(onNextI);
            });

            // 例2：従来のイベントハンドラをObservableにラップした場合
            var srcObs2 = Observable.FromEvent<EventHandler, EventArgs>(
                h => (sender, e) => h(e),
                h => btn.Click += h,
                h => btn.Click -= h);
            srcObs2.Subscribe(onNextE =>
            {
                // 実質イベントハンドラの記述と同じ。
                Trace.WriteLine($"button clicked : {onNextE}");
            });

            // 例3：Httpリクエスト非同期オブジェクトをObservableに変換した場合
            var srcObs3 = hc.GetAsync(url).ToObservable();
            srcObs3.Subscribe(onNextResponse =>
            {
                // 実質非同期メソッドに対するawait後の記述と同じ
                var str = onNextResponse.Content.ReadAsStringAsync().Result;
                Trace.WriteLine($"response : {str}");
            });
        }
    }
}
