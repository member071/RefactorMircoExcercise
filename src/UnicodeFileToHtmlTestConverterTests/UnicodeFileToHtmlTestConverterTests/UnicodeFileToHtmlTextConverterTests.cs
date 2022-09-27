using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDMicroExercises.UnicodeFileToHtmlTextConverter;

namespace UnicodeFileToHtmlTextConverterTests
{
    [TestClass]
    public class UnicodeFileToHtmlTextConverterTests
    {
        private static readonly string testFilePath = Path.Combine(Environment.CurrentDirectory, "../../TestFile.txt");

        [TestMethod]
        public void ConvertToHtmlTest()
        {
            var result = new UnicodeFileToHtmlTextConverter(testFilePath).ConvertToHtml();
            Assert.IsTrue(result.Contains("5. The end...<br />"));
            Assert.IsTrue(result.Equals("1. This is a first line of the text.<br />2. Second line is a bit different.<br />3. But the third one is completely magnific.<br />4. One before the end.<br />5. The end...<br />"));
        }

        [TestMethod]
        public void ConvertToHtmlNotExistingFileTest()
        {
            Assert.ThrowsException<FileNotFoundException>(() => new UnicodeFileToHtmlTextConverter(Guid.NewGuid().ToString()));
        }
    }
}
