namespace KitX.KXP.Helper.Test
{
    [TestClass]
    public class KXP�������
    {
        [TestMethod]
        public void ��׼����()
        {
            string package = @"D:\tmp\test.kxp";
            Decoder decoder = new(package);
            Console.WriteLine(decoder.Decode(@"D:\tmp\decode\"));
        }
    }
}
