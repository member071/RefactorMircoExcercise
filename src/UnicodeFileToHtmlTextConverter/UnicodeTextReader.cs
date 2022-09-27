using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter
{
    public class UnicodeTextReader : IUnicodeTextReader
    {
        private TextReader unicodeFileStream;

        private readonly string _fullFilenameWithPath;

        public UnicodeTextReader(string fullFilenameWithPath)
        {
            _fullFilenameWithPath = fullFilenameWithPath;
            OpenTextFile();
        }

        private void OpenTextFile()
        {
            if (!File.Exists(_fullFilenameWithPath))
                throw new FileNotFoundException(string.Format("{0} not exists!", _fullFilenameWithPath));
            unicodeFileStream = File.OpenText(_fullFilenameWithPath);
        }

        public string ReadLine()
        {
            return unicodeFileStream.ReadLine();
        }

        public string[] ReadLines()
        {
            return File.ReadAllLines(_fullFilenameWithPath);
        }

        public void Dispose()
        {
            if(unicodeFileStream != null)  unicodeFileStream.Dispose();
        }
    }
}
