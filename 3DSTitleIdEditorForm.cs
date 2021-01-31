using System;
using System.IO;
using System.Windows.Forms;

namespace _3DSTitleIdEditor
{
    public partial class Form1 : Form
    {
        private string filename;

        public Form1()
        {
            InitializeComponent();
        }

        private void loadGameImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.filename = openFileDialog.FileName;
                byte[] fileType = this.GetFileType();
                int startingOffset = -1;
                if (this.IsFileTypeNCSD(fileType))
                {
                    startingOffset = 0x4000;
                }
                else if (this.IsFileTypeNCCH(fileType))
                {
                    startingOffset = 0x0;
                }
                else
                {
                    throw new ArgumentException("Supplied game image is not an NCSD or NCCH.");
                }

                string titleId = this.ReadTitleIdFromGameImage(startingOffset);
                titleIdTextBox.Text = titleId;
                overwriteGameImageToolStripMenuItem.Enabled = true;
            }
        }

        private byte[] GetFileType()
        {
            byte[] buffer = new byte[4];
            using (FileStream fs = new FileStream(this.filename, FileMode.Open, FileAccess.Read))
            {
                fs.Seek(0x100, SeekOrigin.Begin);
                fs.Read(buffer, 0, buffer.Length);
            }

            return buffer;
        }

        private bool IsFileTypeNCSD(byte[] fileType)
        {
            return fileType[0] == 0x4E && fileType[1] == 0x43 && fileType[2] == 0x53 && fileType[3] == 0x44;
        }

        private bool IsFileTypeNCCH(byte[] fileType)
        {
            return fileType[0] == 0x4E && fileType[1] == 0x43 && fileType[2] == 0x43 && fileType[3] == 0x48;
        }

        private string ReadTitleIdFromGameImage(int startingOffset)
        {
            byte[] programCode = new byte[0x8];
            using (FileStream fs = new FileStream(this.filename, FileMode.Open, FileAccess.Read))
            {
                fs.Seek(startingOffset + 0x118, SeekOrigin.Begin);
                fs.Read(programCode, 0, programCode.Length);
            }

            Array.Reverse(programCode);
            return BitConverter.ToString(programCode).Replace("-", String.Empty);
        }

        private void overwriteGameImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string titleId = titleIdTextBox.Text;
            byte[] titleIdBytes = new byte[titleId.Length / 2];
            for (int i = 0; i < titleId.Length; i += 2)
            {
                titleIdBytes[i / 2] = Convert.ToByte(titleId.Substring(i, 2), 16);
            }

            Array.Reverse(titleIdBytes);
            byte[] fileType = this.GetFileType();
            int startingOffset = -1;
            if (this.IsFileTypeNCSD(fileType))
            {
                startingOffset = 0x4000;
            }
            else if (this.IsFileTypeNCCH(fileType))
            {
                startingOffset = 0x0;
            }
            else
            {
                throw new ArgumentException("Supplied game image is not an NCSD or NCCH.");
            }
            this.WriteTitleIdToGameImage(titleIdBytes, startingOffset);
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show("Successfully saved the new title ID!", "", buttons);
        }

        private void WriteTitleIdToGameImage(byte[] titleIdBytes, int startingOffset)
        {
            using (FileStream fs = new FileStream(this.filename, FileMode.Open, FileAccess.Write))
            {
                fs.Seek(startingOffset + 0x118, SeekOrigin.Begin);
                fs.Write(titleIdBytes, 0, titleIdBytes.Length);
            }
        }

        private void titleIdTextBox_TextChanged(object sender, EventArgs e)
        {
            bool valid = true;
            if (titleIdTextBox.Text.Length != 16)
            {
                valid = false;
            }
            else
            {
                long unused;
                if (!long.TryParse(titleIdTextBox.Text, System.Globalization.NumberStyles.HexNumber, null, out unused))
                {
                    valid = false;
                }
            }

            if (valid)
            {
                titleIdTextBox.BackColor = System.Drawing.Color.White;
                titleIdTextBox.ForeColor = System.Drawing.Color.Black;
                overwriteGameImageToolStripMenuItem.Enabled = true;
            }
            else
            {
                titleIdTextBox.BackColor = System.Drawing.Color.Red;
                titleIdTextBox.ForeColor = System.Drawing.Color.White;
                overwriteGameImageToolStripMenuItem.Enabled = false;
            }
        }
    }
}
