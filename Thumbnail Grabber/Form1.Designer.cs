namespace Thumbnail_Grabber
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            vorschaubildButton = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            urlBox = new TextBox();
            label2 = new Label();
            vorschauBild = new PictureBox();
            downloadButton = new Button();
            fehler = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vorschauBild).BeginInit();
            SuspendLayout();
            // 
            // vorschaubildButton
            // 
            vorschaubildButton.Location = new Point(187, 240);
            vorschaubildButton.Name = "vorschaubildButton";
            vorschaubildButton.Size = new Size(166, 34);
            vorschaubildButton.TabIndex = 0;
            vorschaubildButton.Text = "Hier klicken für Vorschaubild";
            vorschaubildButton.UseVisualStyleBackColor = true;
            vorschaubildButton.Click += vorschaubildButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MADE TOMMY", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 62);
            label1.Name = "label1";
            label1.Size = new Size(358, 45);
            label1.TabIndex = 1;
            label1.Text = "Thumbnail Grabber";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(121, 51);
            pictureBox1.MaximumSize = new Size(1920, 1080);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // urlBox
            // 
            urlBox.Location = new Point(162, 198);
            urlBox.Multiline = true;
            urlBox.Name = "urlBox";
            urlBox.Size = new Size(364, 23);
            urlBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MADE TOMMY", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(197, 159);
            label2.Name = "label2";
            label2.Size = new Size(288, 36);
            label2.TabIndex = 4;
            label2.Text = "Gib hier die URL ein";
            // 
            // vorschauBild
            // 
            vorschauBild.Location = new Point(121, 295);
            vorschauBild.Name = "vorschauBild";
            vorschauBild.Size = new Size(455, 237);
            vorschauBild.SizeMode = PictureBoxSizeMode.Zoom;
            vorschauBild.TabIndex = 5;
            vorschauBild.TabStop = false;
            // 
            // downloadButton
            // 
            downloadButton.Location = new Point(361, 240);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(124, 34);
            downloadButton.TabIndex = 6;
            downloadButton.Text = "Download";
            downloadButton.UseVisualStyleBackColor = true;
            downloadButton.Click += downloadButton_Click;
            // 
            // fehler
            // 
            fehler.AutoSize = true;
            fehler.Location = new Point(127, 554);
            fehler.Name = "fehler";
            fehler.Size = new Size(0, 15);
            fehler.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 600);
            Controls.Add(fehler);
            Controls.Add(downloadButton);
            Controls.Add(vorschauBild);
            Controls.Add(label2);
            Controls.Add(urlBox);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(vorschaubildButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Thumbnail Grabber";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vorschauBild).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button vorschaubildButton;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox urlBox;
        private Label label2;
        private PictureBox vorschauBild;
        private Button downloadButton;
        private Label fehler;
    }
}
