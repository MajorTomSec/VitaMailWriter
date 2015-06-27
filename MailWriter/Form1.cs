using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MailWriter
{
    public partial class Form1 : Form
    {
        string file;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            DialogResult ret = opf.ShowDialog();
            if (ret == DialogResult.OK)
            {
                file = opf.FileName;
                textBox1.Text = opf.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Thunderbird file (*.eml)|*.eml";
                DialogResult ret = sfd.ShowDialog();
                if (ret == DialogResult.OK)
                {
                    string eml = MailWriter.Properties.Resources.MailTemplate;
                    byte[] buffer = System.IO.File.ReadAllBytes(file);

                    string path = textBox2.Text;
                    string encBuf = Convert.ToBase64String(buffer, Base64FormattingOptions.InsertLineBreaks);

                    path = path.Replace("\\", "\\\\");
                    path = path.Replace("/", "\\\\");

                    eml = eml.Replace("%path%", path);
                    eml = eml.Replace("%content%", encBuf);

                    System.IO.File.WriteAllText(sfd.FileName, eml);
                    MessageBox.Show("File successfully created !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
