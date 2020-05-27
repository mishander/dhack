namespace recognition_test
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainText = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.wrongText = new System.Windows.Forms.TextBox();
            this.DocNumberText = new System.Windows.Forms.RichTextBox();
            this.DocNumberDate = new System.Windows.Forms.RichTextBox();
            this.INNumberText = new System.Windows.Forms.RichTextBox();
            this.INNumberDate = new System.Windows.Forms.RichTextBox();
            this.NameText = new System.Windows.Forms.RichTextBox();
            this.RecognizedMainText = new System.Windows.Forms.RichTextBox();
            this.InventionText = new System.Windows.Forms.RichTextBox();
            this.ApplicantText = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(60, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 802);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1602, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // MainText
            // 
            this.MainText.AutoSize = true;
            this.MainText.Location = new System.Drawing.Point(749, 28);
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(548, 731);
            this.MainText.TabIndex = 2;
            this.MainText.Text = resources.GetString("MainText.Text");
            // 
            // buttonNext
            // 
            this.buttonNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(1542, 28);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(60, 904);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1139, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Тип документа";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1139, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Номер заявки (21)";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1139, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Дата заявки";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1140, 500);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Заявник (71)";
            // 
            // buttonPrev
            // 
            this.buttonPrev.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(0, 28);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(60, 904);
            this.buttonPrev.TabIndex = 14;
            this.buttonPrev.Text = "prev";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1139, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Номер міжнародної заявки (86)";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1139, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Дата міжнародної заявки";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1139, 580);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Назва винаходу";
            // 
            // wrongText
            // 
            this.wrongText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wrongText.Location = new System.Drawing.Point(60, 832);
            this.wrongText.Multiline = true;
            this.wrongText.Name = "wrongText";
            this.wrongText.Size = new System.Drawing.Size(1482, 100);
            this.wrongText.TabIndex = 21;
            // 
            // DocNumberText
            // 
            this.DocNumberText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DocNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocNumberText.Location = new System.Drawing.Point(1140, 75);
            this.DocNumberText.Name = "DocNumberText";
            this.DocNumberText.Size = new System.Drawing.Size(310, 25);
            this.DocNumberText.TabIndex = 22;
            this.DocNumberText.Text = "";
            // 
            // DocNumberDate
            // 
            this.DocNumberDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DocNumberDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocNumberDate.Location = new System.Drawing.Point(1140, 123);
            this.DocNumberDate.Name = "DocNumberDate";
            this.DocNumberDate.Size = new System.Drawing.Size(310, 25);
            this.DocNumberDate.TabIndex = 23;
            this.DocNumberDate.Text = "";
            // 
            // INNumberText
            // 
            this.INNumberText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.INNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.INNumberText.Location = new System.Drawing.Point(1140, 187);
            this.INNumberText.Name = "INNumberText";
            this.INNumberText.Size = new System.Drawing.Size(310, 25);
            this.INNumberText.TabIndex = 24;
            this.INNumberText.Text = "";
            // 
            // INNumberDate
            // 
            this.INNumberDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.INNumberDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.INNumberDate.Location = new System.Drawing.Point(1140, 239);
            this.INNumberDate.Name = "INNumberDate";
            this.INNumberDate.Size = new System.Drawing.Size(310, 25);
            this.INNumberDate.TabIndex = 25;
            this.INNumberDate.Text = "";
            // 
            // NameText
            // 
            this.NameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameText.Location = new System.Drawing.Point(1140, 334);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(310, 25);
            this.NameText.TabIndex = 26;
            this.NameText.Text = "";
            // 
            // RecognizedMainText
            // 
            this.RecognizedMainText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RecognizedMainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecognizedMainText.Location = new System.Drawing.Point(1140, 362);
            this.RecognizedMainText.Name = "RecognizedMainText";
            this.RecognizedMainText.Size = new System.Drawing.Size(310, 100);
            this.RecognizedMainText.TabIndex = 27;
            this.RecognizedMainText.Text = "";
            // 
            // InventionText
            // 
            this.InventionText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InventionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InventionText.Location = new System.Drawing.Point(1140, 602);
            this.InventionText.Name = "InventionText";
            this.InventionText.Size = new System.Drawing.Size(310, 100);
            this.InventionText.TabIndex = 28;
            this.InventionText.Text = "";
            // 
            // ApplicantText
            // 
            this.ApplicantText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplicantText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplicantText.Location = new System.Drawing.Point(1140, 523);
            this.ApplicantText.Name = "ApplicantText";
            this.ApplicantText.Size = new System.Drawing.Size(310, 45);
            this.ApplicantText.TabIndex = 29;
            this.ApplicantText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1623, 731);
            this.Controls.Add(this.ApplicantText);
            this.Controls.Add(this.InventionText);
            this.Controls.Add(this.RecognizedMainText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.INNumberDate);
            this.Controls.Add(this.INNumberText);
            this.Controls.Add(this.DocNumberDate);
            this.Controls.Add(this.DocNumberText);
            this.Controls.Add(this.wrongText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.MainText);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label MainText;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox wrongText;
        private System.Windows.Forms.RichTextBox DocNumberText;
        private System.Windows.Forms.RichTextBox DocNumberDate;
        private System.Windows.Forms.RichTextBox INNumberText;
        private System.Windows.Forms.RichTextBox INNumberDate;
        private System.Windows.Forms.RichTextBox NameText;
        private System.Windows.Forms.RichTextBox RecognizedMainText;
        private System.Windows.Forms.RichTextBox InventionText;
        private System.Windows.Forms.RichTextBox ApplicantText;
    }
}

