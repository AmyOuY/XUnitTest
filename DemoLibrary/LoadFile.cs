using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public static class LoadFile
    {
        public static string Load(string file)
        {
            if (file.Length < 10)
            {
                //throw new System.IO.FileNotFoundException();
                throw new ArgumentException("The file name is too short", "file");
            }

            return "File was successfully loaded";
        }
    }
}
