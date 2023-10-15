// See https://aka.ms/new-console-template for more information

Console.WriteLine("Eを押すとErrorを出します。それ以外は通常メッセージを出します。");
var key1 = Console.ReadKey(true);
if (key1.Key == ConsoleKey.E)
{
    Console.Error.WriteLine("標準Error出力");
}
else
{
    Console.WriteLine("標準出力");
}

Console.WriteLine("zを押すと終了コード1、それ以外は終了コード0で終了");
var key2 = Console.ReadKey(true);
if (key2.Key == ConsoleKey.Z)
{
    return 1;
}
return 0;