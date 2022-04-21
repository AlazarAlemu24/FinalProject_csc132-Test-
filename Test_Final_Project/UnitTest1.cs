using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSC132_FinalProject;
namespace Test_Final_Project
{
    [TestClass]
    public class UnitTest1
    {
        //Daniela did this part
        [TestMethod]
        public void TestMethod1()
        {
            Major newMaj = new Major();
            newMaj.Credits = 22;
            Assert.AreEqual(newMaj.Credits, 22);

        }
        //David groom did this
        [TestMethod]
        public void TestMethod2()
        {
            Computer_science csmajor = new Computer_science("Desc_of_major", 12,12);
           // csmajor.total_credits = -1;
            Assert.AreEqual(csmajor.Credit_calculator(), );
        }
        //Abeni
        [TestMethod]
        public void TestMethod3()
        {
            Computer_science lesscredit = new Computer_science();
            object.total_credits = 8;
            Assert.AreEqual(object.total_credits, 12);
        }
        //Redi8
        [TestMethod]
        public void GradCredits()
        {
            Major newMaj = new Major();
            newMaj.Credits = 130;
            Assert.AreEqual(newMaj.Credits, 120);
            
        }

    }
}
