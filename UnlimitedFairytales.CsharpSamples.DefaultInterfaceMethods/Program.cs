using System.Reflection;

namespace UnlimitedFairytales.CsharpSamples.DefaultInterfaceMethods
{
    interface A {
        string ThisIs() { return "This is A    "; }
    }
    interface B
    {
        string ThisIs() { return "B!!!!!!!!    "; }
    }
    class ImplAuto : A, B
    {
    }
    class ImplImpl : A, B
    {
        public string ThisIs() { return "Impl!!!!!    "; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            {
                var obj = new ImplAuto();
                Console.Write("ImplAutoの場合：");
                // Console.Write(obj.ThisIs()); // 不可能
                A castedA = obj;
                Console.Write(castedA.ThisIs());
                B castedB = obj;
                Console.Write(castedB.ThisIs());
                Console.WriteLine();
            }
            {
                var obj = new ImplImpl();
                Console.Write("ImplImplの場合：");
                Console.Write(obj.ThisIs()); // OK
                A castedA = obj;
                Console.Write(castedA.ThisIs());
                B castedB = obj;
                Console.Write(castedB.ThisIs());
                Console.WriteLine();
            }
        }
    }
}