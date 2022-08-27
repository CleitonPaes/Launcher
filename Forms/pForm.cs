//using Real.Mu.Source_files;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Launcher
{
    public partial class pForm : Form
    {
        public pForm()
        {
            InitializeComponent();
            Globals.pForm = this;
            Globals.pForm.pictureBox1.Enabled = false;
        }

        private void pForm_Shown(object sender, EventArgs e)
        {
            Networking.CheckNetwork();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = @"minecraft.exe";
            //process.StartInfo.Arguments = @"";
            //process.StartInfo.CreateNoWindow = false;
            //process.StartInfo.UseShellExecute = false;
            process.Start();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void pForm_Load(object sender, EventArgs e)
        {

            using (WebClient c = new WebClient())
            {
                try
                {
                    //Custom BackGround
                    c.DownloadFile("http://localhost/minecraft/background.png", "background.png");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            if (File.Exists("background.png"))
            {
                try
                {
                    BackgroundImage = Image.FromFile("background.png");
                    BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch (System.IO.IOException eita)
                {
                    Console.WriteLine(eita.Message);
                    return;
                }
            }
        }

        private void Status_Click(object sender, EventArgs e)
        {

        }
    }
}
