using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstXamarin.Data
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string fileName);
    }
}
