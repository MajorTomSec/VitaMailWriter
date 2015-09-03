namespace MailWriter
{
    partial class Main
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
            System.Windows.Forms.Label _fileL;
            System.Windows.Forms.Label _pathL;
            System.Windows.Forms.ColumnHeader _vitaPaths;
            System.Windows.Forms.ColumnHeader _localPaths;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this._computerPath = new System.Windows.Forms.TextBox();
            this._browse = new System.Windows.Forms.Button();
            this._vitaPath = new System.Windows.Forms.TextBox();
            this._add = new System.Windows.Forms.Button();
            this._files = new System.Windows.Forms.ListView();
            this._generate = new System.Windows.Forms.Button();
            this._removeSelected = new System.Windows.Forms.Button();
            _fileL = new System.Windows.Forms.Label();
            _pathL = new System.Windows.Forms.Label();
            _vitaPaths = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _localPaths = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // _fileL
            // 
            _fileL.AutoSize = true;
            _fileL.Location = new System.Drawing.Point(324, 9);
            _fileL.Name = "_fileL";
            _fileL.Size = new System.Drawing.Size(29, 13);
            _fileL.TabIndex = 4;
            _fileL.Text = "File :\r\n";
            // 
            // _pathL
            // 
            _pathL.AutoSize = true;
            _pathL.Location = new System.Drawing.Point(324, 36);
            _pathL.Name = "_pathL";
            _pathL.Size = new System.Drawing.Size(70, 13);
            _pathL.TabIndex = 6;
            _pathL.Text = "Path :     ux0:\r\n";
            // 
            // _vitaPaths
            // 
            _vitaPaths.Text = "Path on PSVita";
            _vitaPaths.Width = 150;
            // 
            // _localPaths
            // 
            _localPaths.Text = "File Path";
            _localPaths.Width = 151;
            // 
            // _computerPath
            // 
            this._computerPath.Location = new System.Drawing.Point(391, 6);
            this._computerPath.Name = "_computerPath";
            this._computerPath.Size = new System.Drawing.Size(153, 20);
            this._computerPath.TabIndex = 0;
            // 
            // _browse
            // 
            this._browse.Location = new System.Drawing.Point(550, 4);
            this._browse.Name = "_browse";
            this._browse.Size = new System.Drawing.Size(34, 23);
            this._browse.TabIndex = 2;
            this._browse.Text = "...";
            this._browse.UseVisualStyleBackColor = true;
            this._browse.Click += new System.EventHandler(this._browse_Click);
            // 
            // _vitaPath
            // 
            this._vitaPath.Location = new System.Drawing.Point(391, 33);
            this._vitaPath.Name = "_vitaPath";
            this._vitaPath.Size = new System.Drawing.Size(193, 20);
            this._vitaPath.TabIndex = 5;
            this._vitaPath.Text = "mms/photo/AVContent.db";
            // 
            // _add
            // 
            this._add.Location = new System.Drawing.Point(488, 59);
            this._add.Name = "_add";
            this._add.Size = new System.Drawing.Size(96, 23);
            this._add.TabIndex = 7;
            this._add.Text = "Add File";
            this._add.UseVisualStyleBackColor = true;
            this._add.Click += new System.EventHandler(this._add_Click);
            // 
            // _files
            // 
            this._files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _vitaPaths,
            _localPaths});
            this._files.FullRowSelect = true;
            this._files.GridLines = true;
            this._files.Location = new System.Drawing.Point(12, 9);
            this._files.Name = "_files";
            this._files.Size = new System.Drawing.Size(306, 142);
            this._files.TabIndex = 8;
            this._files.UseCompatibleStateImageBehavior = false;
            this._files.View = System.Windows.Forms.View.Details;
            // 
            // _generate
            // 
            this._generate.Location = new System.Drawing.Point(327, 128);
            this._generate.Name = "_generate";
            this._generate.Size = new System.Drawing.Size(257, 23);
            this._generate.TabIndex = 9;
            this._generate.Text = "Generate EML File";
            this._generate.UseVisualStyleBackColor = true;
            this._generate.Click += new System.EventHandler(this._generate_Click);
            // 
            // _removeSelected
            // 
            this._removeSelected.Location = new System.Drawing.Point(327, 99);
            this._removeSelected.Name = "_removeSelected";
            this._removeSelected.Size = new System.Drawing.Size(257, 23);
            this._removeSelected.TabIndex = 10;
            this._removeSelected.Text = "Remove Selection";
            this._removeSelected.UseVisualStyleBackColor = true;
            this._removeSelected.Click += new System.EventHandler(this._removeSelection_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(594, 163);
            this.Controls.Add(this._removeSelected);
            this.Controls.Add(this._generate);
            this.Controls.Add(this._files);
            this.Controls.Add(this._add);
            this.Controls.Add(_pathL);
            this.Controls.Add(this._vitaPath);
            this.Controls.Add(_fileL);
            this.Controls.Add(this._browse);
            this.Controls.Add(this._computerPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "EML File generator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _computerPath;
        private System.Windows.Forms.Button _browse;
        private System.Windows.Forms.TextBox _vitaPath;
        private System.Windows.Forms.Button _add;
        private System.Windows.Forms.ListView _files;
        private System.Windows.Forms.Button _generate;
        private System.Windows.Forms.Button _removeSelected;
    }
}

