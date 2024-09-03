namespace XmlElementOrdering
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this._path = new System.Windows.Forms.TextBox();
            this._selectFolder = new System.Windows.Forms.Button();
            this._orderContent = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path:";
            // 
            // _path
            // 
            this._path.Location = new System.Drawing.Point(50, 12);
            this._path.Name = "_path";
            this._path.Size = new System.Drawing.Size(568, 20);
            this._path.TabIndex = 1;
            // 
            // _selectFolder
            // 
            this._selectFolder.Location = new System.Drawing.Point(624, 10);
            this._selectFolder.Name = "_selectFolder";
            this._selectFolder.Size = new System.Drawing.Size(57, 23);
            this._selectFolder.TabIndex = 2;
            this._selectFolder.Text = "...";
            this._selectFolder.UseVisualStyleBackColor = true;
            this._selectFolder.Click += new System.EventHandler(this._selectFolder_Click);
            // 
            // _orderContent
            // 
            this._orderContent.Location = new System.Drawing.Point(687, 10);
            this._orderContent.Name = "_orderContent";
            this._orderContent.Size = new System.Drawing.Size(75, 23);
            this._orderContent.TabIndex = 3;
            this._orderContent.Text = "Order";
            this._orderContent.UseVisualStyleBackColor = true;
            this._orderContent.Click += new System.EventHandler(this._orderContent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 47);
            this.Controls.Add(this._orderContent);
            this.Controls.Add(this._selectFolder);
            this.Controls.Add(this._path);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Xml Elements Oredring";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _path;
        private System.Windows.Forms.Button _selectFolder;
        private System.Windows.Forms.Button _orderContent;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

