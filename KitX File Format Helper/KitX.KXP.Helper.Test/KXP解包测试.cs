using KitX.KXP.Helper;
using KitX.Web.Rules;
using System.Text.Json;

namespace KitX.KXP.Helper.Test
{
    [TestClass]
    public class KXP�������
    {
        [TestMethod]
        public void ��׼����()
        {
            string package = @"D:\tmp\test.kxp";
            Decoder decoder = new()
            {
                PackagePath = package
            };
            Console.WriteLine(decoder.Decode(@"D:\tmp\decode\"));
        }
    }
}
