using System;
using System.IO;
using System.Windows.Forms;

namespace MailWriter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void _browse_Click(object sender, EventArgs e)
        {
            using (var fileSelector = new OpenFileDialog())
            {
                if (fileSelector.ShowDialog() == DialogResult.OK)
                {
                    _computerPath.Text = fileSelector.FileName;
                }
            }
        }

        private void _removeSelection_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in _files.SelectedItems)
            {
                _files.Items.Remove(selectedItem);
            }
        }

        private void _add_Click(object sender, EventArgs e)
        {
            if (_computerPath.Text != "" && _vitaPath.Text != "")
            {
                _files.Items.Add(new ListViewItem(new[] { _vitaPath.Text, _computerPath.Text }));
            }
            else
            {
                MessageBox.Show("Please enter a valid path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _generate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_files.Items.Count > 0)
                {
                    using (var fileSelector = new SaveFileDialog() { Filter = "Thunderbird file (*.eml)|*.eml" })
                    {
                        if (fileSelector.ShowDialog() == DialogResult.OK)
                        {
                            string mail = Properties.Resources.MailTemplate;
                            string subject = "";

                            foreach (ListViewItem file in _files.Items)
                            {
                                var vitaPath = file.SubItems[0].Text.Replace(@"\", @"\\").Replace("/", "//");

                                mail += '\n' + Properties.Resources.AttachmentTemplate;
                                mail = mail.Replace("%path%", vitaPath)
                                           .Replace("%content%", Convert.ToBase64String(File.ReadAllBytes(file.SubItems[1].Text), Base64FormattingOptions.InsertLineBreaks));

                                subject += vitaPath + "; ";
                            }

                            mail = mail.Replace("%subject%", subject);
                            File.WriteAllText(fileSelector.FileName, mail);
                            MessageBox.Show("File successfully created !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please add files before generating the EML file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("An error occured, please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
