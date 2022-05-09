
namespace PictureBoxApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAdd = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblPictureBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(94, 63);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(187, 49);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Dodaj zdjęcie";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pb
            // 
            this.pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb.InitialImage")));
            this.pb.Location = new System.Drawing.Point(351, 45);
            this.pb.Margin = new System.Windows.Forms.Padding(200, 50, 100, 50);
            this.pb.MaximumSize = new System.Drawing.Size(1200, 700);
            this.pb.MinimumSize = new System.Drawing.Size(600, 400);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(1141, 700);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 1;
            this.pb.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(94, 134);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(187, 49);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Usuń zdjęcie";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblPictureBox
            // 
            this.lblPictureBox.AutoSize = true;
            this.lblPictureBox.Location = new System.Drawing.Point(833, 373);
            this.lblPictureBox.Name = "lblPictureBox";
            this.lblPictureBox.Size = new System.Drawing.Size(198, 17);
            this.lblPictureBox.TabIndex = 4;
            this.lblPictureBox.Text = "Wybierz zdjęcie aby wyświetlić";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1422, 829);
            this.Controls.Add(this.lblPictureBox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.btnAdd);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2560, 1440);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PictureBoxApp";
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblPictureBox;
    }
}

