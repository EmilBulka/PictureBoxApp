using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxApp
{
    
    
    public partial class Form1 : Form
    {
        public string FilePath { get; set; }
        public PictureExplorer PictureExplorer;
        public LastPathTrigger LastPathTrigger;
        public Form1()
        {
            InitializeComponent();
            PictureExplorer = new PictureExplorer();
            LastPathTrigger = new LastPathTrigger();
            DisplayLastPicture();
            HideOrShowDeleteButton();





        }

        private void btnAdd_Click(object sender, EventArgs e)
        {     
          SetPicturePath();
          HideLabelInsideTheictureBox();
          SetLastPath();
          HideOrShowDeleteButton();
            

        }

       
        private void SetPicturePath()
        {
            PictureExplorer.SearchPicture();
            pb.ImageLocation = PictureExplorer.PicturePath;
            FilePath = PictureExplorer.PicturePath;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pb.ImageLocation = null;
            HideLabelInsideTheictureBox();
            SetLastPath();
            HideOrShowDeleteButton();
        }

        private void HideLabelInsideTheictureBox()
        {
           
            if (pb.ImageLocation != null)
            {
                lblPictureBox.Visible = false;
            }
            else
                lblPictureBox.Visible = true;
        }

        private void SetLastPath()
        {
            LastPathTrigger.PicturePath = PictureExplorer.PicturePath;
            LastPathTrigger.AddFilePathToFile();
        }

        private void DisplayLastPicture()
        {
       
                pb.ImageLocation = LastPathTrigger.ReadFilePathToFile();
                HideLabelInsideTheictureBox();

        }

        private void HideOrShowDeleteButton()
        {
            if (pb.ImageLocation == null)
            {
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
            
        }
    }
}
