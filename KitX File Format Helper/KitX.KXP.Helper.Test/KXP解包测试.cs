namespace KitX.KXP.Helper.Test
{
    [TestClass]
    public class KXP解包测试
    {
        [TestMethod]
        public void 基准测试()
        {
            string package = @"D:\tmp\test.kxp";
            Decoder decoder = new(package);
            Console.WriteLine(decoder.Decode(@"D:\tmp\decode\"));
        }

        [TestMethod]
        public void 新KXP结构解包测试()
        {
            string package = @"D:\tmp\pack\pack.kxp";
            Decoder decoder = new(package);
            Console.WriteLine(decoder.Decode(@"D:\tmp\decode\"));
        }
    }
}
