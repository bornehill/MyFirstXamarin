using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstXamarin.Data
{
    public interface IFile
    {
        void SaveText(string fileName, string text);
        string LoadText(string fileName);
        string ClearFile(string fileName);
        bool FileExists(string fileName);
    }
}
