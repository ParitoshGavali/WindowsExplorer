using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Specialized;
using System.IO;



namespace Image_Handelling
{
    public partial class Form1 : Form
    {
        private string[] filePathPrev = new string[100];
        private int prevIndex = 0;
        private string filePath = "F:";
        private bool isFile = false;
        private bool isBack = false;
        private string currentlySelectedItemName = "";
        private int numbericons = 3;
        ImageList imgs = new ImageList();

        public Form1()
        {
            InitializeComponent();
        }

        /*public Bitmap ResizeBitmap(Bitmap b, int nWidth, int nHeight)
        {
            Bitmap result = new Bitmap(nWidth, nHeight);

            using (Graphics g = Graphics.FromImage((Image)result))
                //g.DrawImage(b,)
                g.DrawImage(b, 0, 0, nWidth, nHeight);
            return result;
        }*/

        public Bitmap ResizeBitmap(Bitmap b, int nWidth, int nHeight)
        {
            int MaxSide = nWidth > nHeight ? nWidth : nHeight;
            Bitmap result = new Bitmap(MaxSide, MaxSide);
            using (Graphics g = Graphics.FromImage((Image)result)) {
                g.Clear(Color.Transparent);
                int xOffset = (MaxSide - nWidth) / 2;
                int yOffset = (MaxSide - nHeight) / 2;
                g.DrawImage(b, new Point(xOffset, yOffset));
            }
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Path.Text = filePath;
            filePathPrev[prevIndex] = filePath; 
            loadFilesAndDirectories();
            //iconList.ImageSize = new Size(64,64);
            //for image icon:
            //fileExporer.View = View.Details;

            //list of image icons
        }

        public void loadButtonAction()
        {
            filePath = Path.Text;
            loadFilesAndDirectories();
            isFile = false;
        }


        public void loadFilesAndDirectories()
        {
            DirectoryInfo filelist;
            string tempFilePath = "";
            FileAttributes fileAttr;
            try
            {
                if (isFile)
                {
                    tempFilePath = filePath + "/" + currentlySelectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    //Path.Text = fileDetails
                    fileAttr = File.GetAttributes(tempFilePath);
                    Process.Start(tempFilePath);
                }
                else
                {
                    fileAttr = File.GetAttributes(filePath);
                }

                if((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    if (!isBack)
                    {
                        filePathPrev[++prevIndex] = filePath;
                    }
                    else
                    {
                        isBack = false;
                    }
                    filelist = new DirectoryInfo(filePath);
                    FileInfo[] files = filelist.GetFiles();
                    DirectoryInfo[] dirs = filelist.GetDirectories();
                    string fileExtension = "";

                    fileExporer.Items.Clear();
                    for(int i = numbericons; i < iconList.Images.Count; i++)
                    {
                        iconList.Images.RemoveAt(i);
                    }

                    //fileExporer.SmallImageList = imgs;
                    for (int i = 0; i < files.Length; i++)
                    {
                        fileExtension = files[i].Extension.ToUpper();
                        GC.Collect();
                        switch (fileExtension)
                        {
                            case ".PNG":
                            case ".JPG":
                            case ".JPEG":
                                //imgs.Images.Add(Image.FromFile(files[i].FullName));
                                //MessageBox.Show(imgs.Images.Count);
                                Bitmap image = new Bitmap(files[i].FullName);
                                //MessageBox.Show(image.Width.ToString() + "x" + image.Height.ToString());
                                image = ResizeBitmap(image, image.Width, image.Height);
                                iconList.Images.Add(image);
                                fileExporer.Items.Add(files[i].Name,iconList.Images.Count-1);
                                //iconList.Images.RemoveAt(iconList.Images.Count - 1);
                                break;
                            case ".MP4":
                            case ".AVI":
                                fileExporer.Items.Add(files[i].Name,2);
                                break;
                            default:
                                fileExporer.Items.Add(files[i].Name,1);
                                break;
                        }
                        //fileExporer.Items.Add(files[i].Name);
                    }
                    GC.Collect();
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        fileExporer.Items.Add(dirs[i].Name,0);
                    }
                }
                else
                {
                    //imageDesp.Text = this.currentlySelectedItemName;
                }

            }
            catch(Exception e)
            {

            }
        }

        private void btnFwd_Click(object sender, EventArgs e)
        {
            loadButtonAction();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    //fileExplorer.Url = new Uri(fbd.SelectedPath);
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fbd = new FolderBrowserDialog() { Description="Select your path"})
            {
                if(fbd.ShowDialog()== DialogResult.OK)
                {
                    //fileExplorer.Url = new Uri(fbd.SelectedPath);
                    //Path.Text = fileExplorer.Url.ToString();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            /*if(fileExplorer.CanGoBack == true)
            {
                fileExplorer.GoBack();
            }*/
            prevIndex--;
            if(prevIndex >= 0)
            {
                Path.Text = filePathPrev[prevIndex];
                isBack = true;
                loadButtonAction();
            }
            else
            {
                filePathPrev = new string[100];
                prevIndex = 0;
                filePathPrev[prevIndex] = Path.Text;
            }
            
        }

        

        

        private void fileExplorer_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fileExporer_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItemName = e.Item.Text;

            FileAttributes fileAttr = File.GetAttributes(filePath + "/" + currentlySelectedItemName);
            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                Path.Text = filePath + "/" + currentlySelectedItemName;
            }
            else
            {
                isFile = true;
            }
        }

        private void fileExporer_DoubleClick(object sender, EventArgs e)
        {
            loadButtonAction();
        }

        public bool isImage(string s)
        {
            if(s.EndsWith(".jpg") || s.EndsWith(".png") || s.EndsWith(".jpeg") || s.EndsWith(".bmp"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        

        private void fileExporer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //imageDesp.Text = currentlySelectedItemName;
            //var item = fileExporer.SelectedItems[0];
            //imageDesp.Text = item.Text + "\n" + item.Tag;
            try
            {
                //var selectedobj = fileExporer.SelectedItems[0].ToString();
                if(!string.IsNullOrEmpty(currentlySelectedItemName) && !string.IsNullOrEmpty(filePath))
                {
                    var fullpath = filePath + "/" + currentlySelectedItemName;
                    FileInfo file = new FileInfo(fullpath);
                    label1.Text = "Name : " + file.Name + "\nCreated on : " + file.CreationTime.ToShortDateString() + "\nSize : " + Math.Round(file.Length/(1024.0*1024.0),2) + " MB";
                    if (isImage(currentlySelectedItemName))
                    {
                        pictureBox.Image = Image.FromFile(fullpath);
                    }
                    else
                    {
                        pictureBox.Image = null;
                    }
                    
                }
            }
            catch(Exception)
            {

            }
            GC.Collect();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
