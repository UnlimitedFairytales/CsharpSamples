using System.Text.Json;

namespace UnlimitedFairytales.CsharpSamples.JsonSample
{
    class Staff
    {
        public long? StaffId { get; set; }
        public string StaffCd { get; set; }
        public string StaffNm { get; set; }
    }
    class ResultModel
    {
        public IList<Staff>? StaffList { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var result = new ResultModel()
            {
                StaffList = new List<Staff>() {
                    new Staff() { StaffId = 85, StaffCd ="d0000093", StaffNm="山田太郎", },
                    new Staff() { StaffId = 96, StaffCd ="d0000104", StaffNm="山田花子", },
                }
            };
            Console.WriteLine(JsonSerializer.Serialize(result));
        }
    }
}