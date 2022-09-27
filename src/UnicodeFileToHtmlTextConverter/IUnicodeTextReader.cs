using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter
{
    public interface IUnicodeTextReader : IDisposable
    {
        string ReadLine();
        string[] ReadLines();

    }
}
