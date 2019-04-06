using System;
using System.IO;
using MyFirstXamarin.Data;
using MyFirstXamarin.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelperAndroid))]
namespace MyFirstXamarin.Droid
{
    public class FileHelperAndroid : IFileHelper
    {
        public string GetLocalFilePath(string fileName)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }

            return Path.Combine(libFolder, fileName);
        }
    }
}