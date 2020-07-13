using System;
namespace Image_Handelling
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFwd = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.Path = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.fileExporer = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(48, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFwd
            // 
            this.btnFwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFwd.Location = new System.Drawing.Point(100, 13);
            this.btnFwd.Name = "btnFwd";
            this.btnFwd.Size = new System.Drawing.Size(36, 23);
            this.btnFwd.TabIndex = 1;
            this.btnFwd.Text = ">>";
            this.btnFwd.UseVisualStyleBackColor = true;
            this.btnFwd.Click += new System.EventHandler(this.btnFwd_Click);
            // 
            // labelPath
            // 
            this.labelPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(151, 18);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(37, 17);
            this.labelPath.TabIndex = 2;
            this.labelPath.Text = "Path";
            this.labelPath.Click += new System.EventHandler(this.label1_Click);
            // 
            // Path
            // 
            this.Path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Path.Location = new System.Drawing.Point(190, 18);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(462, 22);
            this.Path.TabIndex = 3;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpen.Location = new System.Drawing.Point(664, 18);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(67, 23);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(589, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 398);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 8;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(29, 15);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(182, 133);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // fileExporer
            // 
            this.fileExporer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fileExporer.HideSelection = false;
            this.fileExporer.LargeImageList = this.iconList;
            this.fileExporer.Location = new System.Drawing.Point(12, 53);
            this.fileExporer.Name = "fileExporer";
            this.fileExporer.Size = new System.Drawing.Size(570, 410);
            this.fileExporer.SmallImageList = this.iconList;
            this.fileExporer.TabIndex = 7;
            this.fileExporer.UseCompatibleStateImageBehavior = false;
            this.fileExporer.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.fileExporer_ItemSelectionChanged);
            this.fileExporer.SelectedIndexChanged += new System.EventHandler(this.fileExporer_SelectedIndexChanged);
            this.fileExporer.DoubleClick += new System.EventHandler(this.fileExporer_DoubleClick);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "icons8-folder-48.png");
            this.iconList.Images.SetKeyName(1, "file.png");
            this.iconList.Images.SetKeyName(2, "video.jpeg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 478);
            this.Controls.Add(this.fileExporer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.btnFwd);
            this.Controls.Add(this.btnBack);
            this.MinimumSize = new System.Drawing.Size(850, 525);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFwd;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView fileExporer;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
    }
}

