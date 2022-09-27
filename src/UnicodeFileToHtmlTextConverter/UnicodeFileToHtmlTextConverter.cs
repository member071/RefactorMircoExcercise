using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter
{
    public class UnicodeFileToHtmlTextConverter
    {
        private readonly string _fullFilenameWithPath;
        private readonly IUnicodeTextReader _unicodeTextReader;

        public UnicodeFileToHtmlTextConverter(string fullFilenameWithPath) : this(fullFilenameWithPath, new UnicodeTextReader(fullFilenameWithPath))
        {
        }

        public UnicodeFileToHtmlTextConverter(string fullFilenameWithPath, IUnicodeTextReader unicodeTextReader)
        {
            _fullFilenameWithPath = fullFilenameWithPath;
            _unicodeTextReader = unicodeTextReader;
        }
        public string ConvertToHtml()
        {
            string[] allLines = _unicodeTextReader.ReadLines();

            return allLines.Aggregate(new StringBuilder(), (x, y) => x.Append(string.Format("{0}<br />", y))).ToString();
           
        }
    }
}
