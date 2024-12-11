using AppModule;

namespace AppTests
{
    [TestClass]
    public class AESOperationTest
    {
        [TestMethod]
        public void EncryptTest()
        {
            Assert.AreEqual(AESOperation.Encrypt("helloworld"), "mYhFhpLR7UOfGciTbcxyNQ==");
        }

        [TestMethod]
        public void DecryptTest()
        {
            Assert.AreEqual(AESOperation.Decrypt("mYhFhpLR7UOfGciTbcxyNQ=="), "helloworld");
        }

        [TestMethod]
        public void EncryptDecryptTest()
        {
            Assert.AreEqual(AESOperation.Decrypt(AESOperation.Encrypt("helloworld")), "helloworld");
        }
    }
}
