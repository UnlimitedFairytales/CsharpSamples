using System.Xml;

namespace UnlimitedFairytales.CsharpSamples.Xml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var doc = new XmlDocument();
            doc.Load("NameListRPX.rpx");
            var body = doc.SelectSingleNode("ActiveReportsLayout");
            WriteXmlNode(body!, "");
            Console.ReadKey();
        }

        static void WriteXmlNode(XmlNode node, string indent)
        {
            var attributesText = "";
            if (node.Attributes != null)
            {
                foreach (XmlAttribute attribute in node.Attributes)
                {
                    attributesText += $" {attribute.Name}=\"{attribute.Value}\"";
                }
            }

            if (node.ChildNodes.Count == 0)
            {
                Console.WriteLine($"{indent}<{node.Name}{attributesText} />");
                return;
            }
            Console.WriteLine($"{indent}<{node.Name}{attributesText}>");
            foreach (XmlNode child in node.ChildNodes)
            {
                WriteXmlNode(child, indent + "  ");
            }
            Console.WriteLine($"{indent}</{node.Name}>");
        }
    }
}