using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MyFirstXamarin.Data;
using MyFirstXamarin.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileAndroid))]
namespace MyFirstXamarin.Droid
{
    public class FileAndroid : IFile
    {
        public string ClearFile(string fileName)
        {
            var filePath = GetFilePath(fileName);
            File.Delete(filePath);
            return filePath;
        }

        public bool FileExists(string fileName)
        {
            return File.Exists(GetFilePath(fileName));
        }

        public string LoadText(string fileName)
        {
            return FileExists(fileName) ? File.ReadAllText(GetFilePath(fileName)) : "";
        }

        public void SaveText(string fileName, string text)
        {
            var filePath = GetFilePath(fileName);
            File.Delete(filePath);
            File.WriteAllText(filePath, text);
        }

        private string GetFilePath(string fileName)
        {
            var docsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(docsPath, fileName);
        }
    }
}