using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using File = System.IO.File;

namespace ModernLifeInstaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBrows_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            if (folderBrowserDialog1.SelectedPath != "")
            {
                txt_installPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        public static class Globals
        {
            public static List<string> FTPFilesFound = new List<string>();
        }

        public async void StartInstall()
        {
            FtpWebRequest listRequest = (FtpWebRequest)WebRequest.Create("ftp://51.68.207.111/");
            listRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            NetworkCredential credentials = new NetworkCredential("LauncherUpdate", "launcher123");
            listRequest.Credentials = credentials;

            List<string> lines = new List<string>();

            using (FtpWebResponse listResponse = (FtpWebResponse)listRequest.GetResponse())
            using (Stream listStream = listResponse.GetResponseStream())
            using (StreamReader listReader = new StreamReader(listStream))
            {
                while (!listReader.EndOfStream)
                {
                    lines.Add(listReader.ReadLine());
                }
            }

            Globals.FTPFilesFound.Clear();

            foreach (string line in lines)
            {
                string[] tokens = line.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[8];
                string permissions = tokens[0];

                Globals.FTPFilesFound.Add(name);
            }

            button1.Enabled = false;
            BtnBrows.Enabled = false;

            foreach (string file in Globals.FTPFilesFound)
            {
                label_fileinstalling.Text = "Installing: " + file;

                if (file != "ModernLifeInstaller.exe")
                {
                    await Task.Run(() => Download(file));
                }

                if (file == "ModernLifeInstaller.exe" && File.Exists(txt_installPath.Text + "\\ModernLifeInstaller.exe") == false) {
                    await Task.Run(() => Download(file));
                }
            }

            label_fileinstalling.Text = "Installasion success!";

            string Dekstop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileShortcut = Dekstop + "\\Modern Life RPG Launcher.ink";

            if (File.Exists(fileShortcut) == false)
            {
                object shDesktop = (object)"Desktop";
                WshShell shell = new WshShell();
                string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\Modern Life RPG Launcher.lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                shortcut.Description = "Modern Life RPG Launcher Shortcut";
                shortcut.TargetPath = txt_installPath.Text + "\\Modern Life RPG Launcher.exe";
                shortcut.Save();
            }           

            System.Diagnostics.Process.Start(txt_installPath.Text + "\\Modern Life RPG Launcher.exe");
            Close();
        }

        private void Download(string file)
        {
            try
            {
                string url = "ftp://51.68.207.111/" + file;
                NetworkCredential credentials = new NetworkCredential("LauncherUpdate", "launcher123");

                // Query size of the file to be downloaded
                WebRequest sizeRequest = WebRequest.Create(url);
                sizeRequest.Credentials = credentials;
                sizeRequest.Method = WebRequestMethods.Ftp.GetFileSize;
                int size = (int)sizeRequest.GetResponse().ContentLength;

                progressBar1.Invoke((MethodInvoker)(() => progressBar1.Maximum = size));

                // Download the file
                WebRequest request = WebRequest.Create(url);
                request.Credentials = credentials;
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                using (Stream ftpStream = request.GetResponse().GetResponseStream())
                using (Stream fileStream = File.Create(txt_installPath.Text + "\\" + file))
                {
                    byte[] buffer = new byte[10240];
                    int read;
                    while ((read = ftpStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fileStream.Write(buffer, 0, read);
                        int position = (int)fileStream.Position;
                        progressBar1.Invoke((MethodInvoker)(() => progressBar1.Value = position));
                    }                   
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Invoke((MethodInvoker)(() => this.Close()));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_installPath.Text == "")
            {
                MessageBox.Show("Please enter a installasion path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                if (Directory.Exists(txt_installPath.Text) == false)
                {
                    System.IO.Directory.CreateDirectory(txt_installPath.Text);
                }
                StartInstall();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_installPath.Text = System.AppDomain.CurrentDomain.BaseDirectory;
        }
    }
}
