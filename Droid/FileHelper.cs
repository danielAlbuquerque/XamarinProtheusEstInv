using System;
using System.IO;
using SigaMATA270.Contracts;

namespace SigaMATA270.Droid
{
    public class FileHelper : IFileHelper
    {
        public FileHelper()
        {
        }

        public string GetLocalFilePath(string filename)
        {
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			return Path.Combine(path, filename);
        }
    }
}
