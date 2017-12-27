using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Y2K_IMZGenReloaded
{
    public partial class Form1 : Form
    {
        debugConsole d = new debugConsole();

        int imdCount = 0;
        int curImd = 0;

        public Form1()
        {
            InitializeComponent();

            saveIMGZToolStripMenuItem.Enabled = false;

            dcPrintLn("~ IMZGen Reloaded - Y2K: Debug Console ~");
            dcPrintLn("----------------------------------------");

            Directory.CreateDirectory("imd");
        }

        private void enableDebugConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imdCount = Convert.ToInt32(imdCnt.Value);

            if (imdCount > 0)
            {
                for (int i = 0; i < imdCount; i++)
                {
                    File.Create("imd/" + i + ".imd").Close();
                }

                dcPrintLn("Success: " + imdCount + " blank IMD(s) has been generated.");
                saveIMGZToolStripMenuItem.Enabled = false;
                imdCImg.Image = Properties.Resources.check;
                imdSelImg.Image = Properties.Resources._2;
                imdSavImg.Image = Properties.Resources._3;

                width.Value = 0;
                length.Value = 0;
                currentImd.Value = 0;

            }
            else
            {
                clearFolder("imd");
                dcPrintLn("Notice: All generated IMDs have been cleared.");
                imdCImg.Image = Properties.Resources._1;
                imdSelImg.Image = Properties.Resources._2;
                imdSavImg.Image = Properties.Resources._3;
                saveIMGZToolStripMenuItem.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (imdCount > 0)
            {
                curImd = Convert.ToInt32(currentImd.Value);

                if (curImd < imdCount)
                {
                    imdSelImg.Image = Properties.Resources.check;
                    dcPrintLn("Success: IMD " + curImd + " was found and is now active.");

                    string file = "imd/" + curImd + ".imd";

                    if (new FileInfo(file).Length == 0L)
                    {
                        width.Value = 0;
                        length.Value = 0;

                        imdSavImg.Image = Properties.Resources._3;
                    }
                    else
                    {
                        short widthVal;
                        short lengthVal;

                        using (BinaryReader br = new BinaryReader(File.OpenRead(file)))
                        {
                            br.BaseStream.Position = 28L;
                            widthVal = br.ReadInt16();
                            lengthVal = br.ReadInt16();
                        }

                        width.Value = widthVal;
                        length.Value = lengthVal;

                        imdSavImg.Image = Properties.Resources.check;
                    }
                }
                else
                {
                    curImd = 0;
                    dcPrintLn("Error: Selected IMD does not exsist.");
                }
            }
            else
            {
                imdSelImg.Image = Properties.Resources._2;
                imdSavImg.Image = Properties.Resources._3;
                saveIMGZToolStripMenuItem.Enabled = false;

                dcPrintLn("Error: Selected IMD does not exsist.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool isEmpty = false;

            short[] wl = {Convert.ToInt16(width.Value), Convert.ToInt16(length.Value)};

            if (imdCount > 0)
            {
                writeImd(wl, curImd);

                dcPrintLn("Success: IMD " + curImd + "was written.");

                for (var i = 0; i < imdCount; i++)
                {
                    string file = "imd/" + i + ".imd";

                    if (new FileInfo(file).Length == 0L)
                    {
                        isEmpty = true;
                        saveIMGZToolStripMenuItem.Enabled = false;
                        break;
                    }
                }

                if (isEmpty == false)
                {
                    saveIMGZToolStripMenuItem.Enabled = true;
                }

                imdSavImg.Image = Properties.Resources.check;
            }
            else
            {
                dcPrintLn("Error: Selected IMD does not exsist.");
                saveIMGZToolStripMenuItem.Enabled = false;
            }
            
        }

        private void saveIMGZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "IMGD Container (*.imz)|*.imz|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fullPath = Path.GetFullPath(saveFileDialog.FileName);
                char[] chars = new char[4]
                {
                'I',
                'M',
                'G',
                'Z'
                };
                int num = Convert.ToInt32(this.imdCnt.Value);
                long[] array = new long[num];
                using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(fullPath, FileMode.Create)))
                {
                    binaryWriter.Write(chars);
                    binaryWriter.Write(256);
                    binaryWriter.Write(16);
                    binaryWriter.Write(num);
                    for (int j = 0; j < num; j++)
                    {
                        binaryWriter.Write(0);
                        binaryWriter.Write(0);
                    }
                }
                long num2 = new FileInfo(fullPath).Length;
                if (num2 % 16 != 0L)
                {
                    using (BinaryWriter binaryWriter2 = new BinaryWriter(File.Open(fullPath, FileMode.Open)))
                    {
                        binaryWriter2.BaseStream.Position = num2;
                        binaryWriter2.Write(0);
                        binaryWriter2.Write(0);
                    }
                }
                for (int k = 0; k < num; k++)
                {
                    using (Stream stream2 = File.OpenRead("imd/" + k + ".imd"))
                    {
                        using (Stream stream = new FileStream(fullPath, FileMode.Append, FileAccess.Write, FileShare.None))
                        {
                            array[k] = stream.Position;
                            stream2.CopyTo(stream);
                        }
                    }
                }
                using (BinaryWriter binaryWriter3 = new BinaryWriter(File.Open(fullPath, FileMode.Open)))
                {
                    binaryWriter3.BaseStream.Position = 16L;
                    for (int l = 0; l < num; l++)
                    {
                        int value = Convert.ToInt32(new FileInfo("imd/" + l + ".imd").Length);
                        binaryWriter3.Write(Convert.ToInt32(array[l]));
                        binaryWriter3.Write(value);
                    }
                }
            }
            else
            {
                dcPrintLn("Error: A unknown error occurred while saving.");
            }

            dcPrintLn("Success: IMGZ was saved to desired location.");
        }

        private void dcPrintLn(string text)
        {
            d.console.Text += text + "\n";
        }

        public void clearFolder(string dir)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(dir);
            FileInfo[] files = directoryInfo.GetFiles();
            for (int i = 0; i < files.Length; i++)
            {
                files[i].Delete();
            }
            DirectoryInfo[] directories = directoryInfo.GetDirectories();
            foreach (DirectoryInfo directoryInfo2 in directories)
            {
                this.clearFolder(directoryInfo2.FullName);
                directoryInfo2.Delete();
            }
        }

        public void writeImd(short[] data, int imd)
        {
            string path = "imd/" + imd + ".imd";

            char[] chars = new char[4]
            {
                'I',
                'M',
                'G',
                'D'
            };

            int num = data[0] * data[1];
            int num2 = num + 64;

            using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Open)))
            {
                //write header
                binaryWriter.Write(chars);
                binaryWriter.Write(256);
                binaryWriter.Write(64);
                binaryWriter.Write(num);
                binaryWriter.Write(num2);
                binaryWriter.Write(1024);
                binaryWriter.Write(0xFFFFFFFF);
                binaryWriter.Write(data[0]);
                binaryWriter.Write(data[1]);
                binaryWriter.Write(BitConverter.GetBytes((ushort)Convert.ToString((int)data[0], 2).Length));
                binaryWriter.Write(BitConverter.GetBytes((ushort)Convert.ToString((int)data[1], 2).Length));
                binaryWriter.Write(1245184u);
                binaryWriter.Write(0xFFFFFFFF);
                binaryWriter.Write(1048592);
                binaryWriter.Write(1);
                binaryWriter.Write(196613);
                binaryWriter.Write(0);
                binaryWriter.Write(7);

                //write padding
                binaryWriter.BaseStream.Position = 0L;
                binaryWriter.BaseStream.Position = num2 + 60 + 960;
                binaryWriter.Write(0);
            }
        }


    }
}
