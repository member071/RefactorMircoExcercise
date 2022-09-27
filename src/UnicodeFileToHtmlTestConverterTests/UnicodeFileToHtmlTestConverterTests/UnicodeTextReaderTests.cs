using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDMicroExercises.UnicodeFileToHtmlTextConverter;

namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter.UnicodeFileToHtmlTextConverterTests
{
    [TestClass]
    public class UnicodeTextReaderTests
    {
        private static readonly string testFilePath = Path.Combine(Environment.CurrentDirectory, "../../TestFile.txt");

        [TestMethod]
        public void FileNotFoundTest()
        {
            string fullFilenameWithPath = "abc";
            Assert.ThrowsException<FileNotFoundException>(() => new UnicodeTextReader(fullFilenameWithPath));
        }

        [TestMethod]
        public void ExistingFileFirstLineTest()
        {
            var result = new UnicodeTextReader(testFilePath).ReadLine();
            Assert.IsTrue(result.Contains("1."));
        }

        [TestMethod]
        public void ExistingFileAllLinesTest()
        {
            var result = new UnicodeTextReader(testFilePath).ReadLines();
            Assert.IsTrue(result.Count() == 5);
        }

    }
}
