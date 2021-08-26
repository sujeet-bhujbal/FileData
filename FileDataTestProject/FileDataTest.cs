using FileData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileDataTestProject
{
    [TestClass]
    public class FileDataTest
    {
        [TestMethod]
        public void GivenFileVersion_processFileVersion_ReturnFileVersion()
        {
            var inputParameters = new[] {"-v", " C:/test.txt"};

            var output = Program.ReadVersion(inputParameters);
            Assert.IsTrue(!string.IsNullOrEmpty(output));
        }


        [TestMethod]
        public void GivenFileInvalidVersionName_DoesNotProcessFileVersion_ReturnFileVersion()
        {
            var inputParameters = new[] {"1", " C:/test.txt"};

            var output = Program.ReadVersion(inputParameters);
            Assert.IsTrue(string.IsNullOrEmpty(output));
        }


        [TestMethod]
        public void GivenFileSize_processFileSize_ReturnFileSize()
        {
            var inputParameters = new[] {"-s", " C:/test.txt"};
            var output = Program.ReadSize(inputParameters);
            Assert.IsTrue(output > 0);
        }


        [TestMethod]
        public void GivenInvalidFileSizeName_DoesNotProcessFileSize_ReturnFileSize()
        {
            var inputParameters = new[] {"-suj", " C:/test.txt"};
            var output = Program.ReadSize(inputParameters);
            Assert.IsTrue(output == 0);
        }
    }
}