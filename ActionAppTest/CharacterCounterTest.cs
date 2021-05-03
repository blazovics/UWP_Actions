using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ActionApp.Test
{
    [TestClass]
    public class CharacterCounterTest
    {
        [TestMethod]
        public void CountingEmpty()
        {
            CharacterCounter cc = new CharacterCounter();
            int length = cc.Characters("");

            Assert.IsTrue(length == 0);
        }

        [TestMethod]
        public void WhitespaceCounting()
        {
            CharacterCounter cc = new CharacterCounter();
            int length = cc.WhitespaceCharacters(" ");

            Assert.IsTrue(length == 1);
        }
    }
}
