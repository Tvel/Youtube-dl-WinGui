namespace Youtube_dl_WinGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Checkbutton = new System.Windows.Forms.Button();
            this.GoButton = new System.Windows.Forms.Button();
            this.Formatbox = new System.Windows.Forms.ListBox();
            this.URLbox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.DestinationBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DebugLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Checkbutton
            // 
            this.Checkbutton.Location = new System.Drawing.Point(446, 12);
            this.Checkbutton.Name = "Checkbutton";
            this.Checkbutton.Size = new System.Drawing.Size(86, 42);
            this.Checkbutton.TabIndex = 0;
            this.Checkbutton.Text = "Check";
            this.Checkbutton.UseVisualStyleBackColor = true;
            this.Checkbutton.Click += new System.EventHandler(this.Checkbutton_Click);
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(446, 120);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(86, 43);
            this.GoButton.TabIndex = 1;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // Formatbox
            // 
            this.Formatbox.FormattingEnabled = true;
            this.Formatbox.Location = new System.Drawing.Point(73, 50);
            this.Formatbox.Name = "Formatbox";
            this.Formatbox.Size = new System.Drawing.Size(355, 186);
            this.Formatbox.TabIndex = 2;
            // 
            // URLbox
            // 
            this.URLbox.Location = new System.Drawing.Point(73, 12);
            this.URLbox.Name = "URLbox";
            this.URLbox.Size = new System.Drawing.Size(355, 20);
            this.URLbox.TabIndex = 3;
            this.URLbox.Click += new System.EventHandler(this.URLbox_Click);
            // 
            // DestinationBox
            // 
            this.DestinationBox.Location = new System.Drawing.Point(73, 251);
            this.DestinationBox.Name = "DestinationBox";
            this.DestinationBox.Size = new System.Drawing.Size(355, 20);
            this.DestinationBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 22);
            this.button1.TabIndex = 5;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Destination";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Format";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(446, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 48);
            this.label4.TabIndex = 9;
            this.label4.Text = "Check URL\r\nSelect Format\r\nPress GO";
            // 
            // DebugLabel
            // 
            this.DebugLabel.AutoSize = true;
            this.DebugLabel.Location = new System.Drawing.Point(73, 278);
            this.DebugLabel.Name = "DebugLabel";
            this.DebugLabel.Size = new System.Drawing.Size(0, 13);
            this.DebugLabel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 299);
            this.Controls.Add(this.DebugLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DestinationBox);
            this.Controls.Add(this.URLbox);
            this.Controls.Add(this.Formatbox);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.Checkbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Youtube-dl-WinGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Checkbutton;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.ListBox Formatbox;
        private System.Windows.Forms.TextBox URLbox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox DestinationBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DebugLabel;
    }
}

