namespace MailWriter
{
    partial class MainForm
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
            this.txtbox_filePath = new System.Windows.Forms.TextBox();
            this.bt_browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_vitaPath = new System.Windows.Forms.TextBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.list_files = new System.Windows.Forms.ListView();
            this.txt_vitaPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_localPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_gen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_filePath
            // 
            this.txtbox_filePath.Location = new System.Drawing.Point(391, 6);
            this.txtbox_filePath.Name = "txtbox_filePath";
            this.txtbox_filePath.Size = new System.Drawing.Size(153, 20);
            this.txtbox_filePath.TabIndex = 0;
            // 
            // bt_browse
            // 
            this.bt_browse.Location = new System.Drawing.Point(550, 4);
            this.bt_browse.Name = "bt_browse";
            this.bt_browse.Size = new System.Drawing.Size(34, 23);
            this.bt_browse.TabIndex = 2;
            this.bt_browse.Text = "...";
            this.bt_browse.UseVisualStyleBackColor = true;
            this.bt_browse.Click += new System.EventHandler(this.bt_browse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "File :\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Path       ux0:\r\n";
            // 
            // txtbox_vitaPath
            // 
            this.txtbox_vitaPath.Location = new System.Drawing.Point(391, 33);
            this.txtbox_vitaPath.Name = "txtbox_vitaPath";
            this.txtbox_vitaPath.Size = new System.Drawing.Size(193, 20);
            this.txtbox_vitaPath.TabIndex = 5;
            this.txtbox_vitaPath.Text = "mms/photo/AVContent.db";
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(488, 59);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(96, 23);
            this.bt_add.TabIndex = 7;
            this.bt_add.Text = "Add file";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // list_files
            // 
            this.list_files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.txt_vitaPath,
            this.txt_localPath});
            this.list_files.Location = new System.Drawing.Point(12, 9);
            this.list_files.Name = "list_files";
            this.list_files.Size = new System.Drawing.Size(306, 142);
            this.list_files.TabIndex = 8;
            this.list_files.UseCompatibleStateImageBehavior = false;
            this.list_files.View = System.Windows.Forms.View.Details;
            // 
            // txt_vitaPath
            // 
            this.txt_vitaPath.Text = "Path on PSVita";
            this.txt_vitaPath.Width = 150;
            // 
            // txt_localPath
            // 
            this.txt_localPath.Text = "File Path";
            this.txt_localPath.Width = 150;
            // 
            // bt_gen
            // 
            this.bt_gen.Location = new System.Drawing.Point(327, 128);
            this.bt_gen.Name = "bt_gen";
            this.bt_gen.Size = new System.Drawing.Size(257, 23);
            this.bt_gen.TabIndex = 9;
            this.bt_gen.Text = "Generate EML File";
            this.bt_gen.UseVisualStyleBackColor = true;
            this.bt_gen.Click += new System.EventHandler(this.bt_gen_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(607, 163);
            this.Controls.Add(this.bt_gen);
            this.Controls.Add(this.list_files);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_vitaPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_browse);
            this.Controls.Add(this.txtbox_filePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "EML File generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_filePath;
        private System.Windows.Forms.Button bt_browse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_vitaPath;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.ListView list_files;
        private System.Windows.Forms.ColumnHeader txt_vitaPath;
        private System.Windows.Forms.ColumnHeader txt_localPath;
        private System.Windows.Forms.Button bt_gen;
    }
}

