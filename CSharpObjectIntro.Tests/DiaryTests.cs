using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpObjectIntro.Classes.Diary;

namespace CSharpObjectIntro.Tests
{
    [TestClass]
    public class DiaryTests
    {
        [TestMethod]
        public void TestDiaryName()
        {
            var diary = new Diary("Bob Smith");
            Assert.AreEqual("Bob Smith", diary.Name);
        }
    }
}