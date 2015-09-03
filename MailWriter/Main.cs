using System;
using System.IO;
using System.Windows.Forms;

namespace MailWriter
{
    // Main Class
    public partial class Main : Form
    {
        // Main Entry Point
        public Main()
        {
            InitializeComponent();
        }

        // On Load of Form Do
        private void Main_Load(object sender, EventArgs e)
        {
            // Drag&Drop Event Handler
            _computerPath.AllowDrop = true;
            _computerPath.DragEnter += new DragEventHandler(computerPath_DragEnter);
            _computerPath.DragDrop += new DragEventHandler(computerPath_DragDrop);
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Main_DragEnter);
            this.DragDrop += new DragEventHandler(Main_DragDrop);
        }

        // Check if input is a valid file
        private void computerPath_DragEnter(object  sender, DragEventArgs e )
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        // On valid file input
        private void computerPath_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 1)
                MessageBox.Show("Please Drop only one File!");
            else
                _computerPath.Text = files[0];
        }

        // Check if input is a valid file
        private void Main_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        // On valid file input
        private void Main_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 1)
                MessageBox.Show("Please Drop only one File!");
            else
                _computerPath.Text = files[0];
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
                                var vitaPath = file.SubItems[0].Text.Replace(@"\", @"\\").Replace("/", @"\\");

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
