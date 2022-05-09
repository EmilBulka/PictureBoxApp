using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureBoxApp
{
    public class LastPathTrigger
    {
        private string _picturePath;
        public string PicturePath 
        {
            get => _picturePath;
            set => _picturePath = value;
        }




        public void AddFilePathToFile()
        {
            
            File.WriteAllText(Program.FilePath, _picturePath);
             

        }
        public string ReadFilePathToFile()
        {
          return File.ReadAllText(Program.FilePath);
        }
    }
}
