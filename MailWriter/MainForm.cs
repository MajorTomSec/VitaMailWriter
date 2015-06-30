using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MailWriter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bt_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            DialogResult ret = opf.ShowDialog();
            if (ret == DialogResult.OK)
            {
                txtbox_filePath.Text = opf.FileName;
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if (txtbox_filePath.Text != "" && txtbox_vitaPath.Text != "")
            {
                list_files.Items.Add(new ListViewItem(new string[2] { txtbox_vitaPath.Text, txtbox_filePath.Text }));
            }
            else
            {
                MessageBox.Show("Please enter a valid path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_gen_Click(object sender, EventArgs e)
        {
            if (list_files.Items.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Thunderbird file (*.eml)|*.eml";
                DialogResult ret = sfd.ShowDialog();
                if (ret == DialogResult.OK)
                {
                    string eml = MailWriter.Properties.Resources.MailTemplate;
                    string subject = string.Empty;

                    foreach (ListViewItem file in list_files.Items)
                    {
                        string path = file.SubItems[0].Text;
                        byte[] buffer = System.IO.File.ReadAllBytes(file.SubItems[1].Text);

                        string encBuf = Convert.ToBase64String(buffer, Base64FormattingOptions.InsertLineBreaks);

                        path = path.Replace(@"\", @"\\");
                        path = path.Replace(@"/", @"\\");

                        eml += "\n" + MailWriter.Properties.Resources.AttachmentTemplate;

                        eml = eml.Replace("%path%", path);
                        eml = eml.Replace("%content%", encBuf);

                        subject += path + "; ";
                    }

                    eml = eml.Replace("%subject%", subject);

                    System.IO.File.WriteAllText(sfd.FileName, eml);
                    MessageBox.Show("File successfully created !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please add files before generating the EML file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
