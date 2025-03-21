using System.Windows.Forms;

namespace Gallery
{
    public class ImageMember
    {
        string name;
        string path;
        public ImageMember(string name, string path)
        {
            this.name = name;
            this.path = path;
        }
    }
    partial class Gallery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gallery));
            OpenTXT = new Button();
            SaveIMG = new Button();
            ListIMG = new ListBox();
            NameIMG = new TextBox();
            ShowIMG = new PictureBox();
            Russia = new PictureBox();
            OpenerTXT = new OpenFileDialog();
            SaverTXT = new SaveFileDialog();
            OpenFileIMG = new Button();
            DeleteIMG = new Button();
            ((System.ComponentModel.ISupportInitialize)ShowIMG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Russia).BeginInit();
            SuspendLayout();
            // 
            // OpenTXT
            // 
            OpenTXT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OpenTXT.AutoSize = true;
            OpenTXT.Location = new Point(1458, 12);
            OpenTXT.Name = "OpenTXT";
            OpenTXT.Size = new Size(424, 42);
            OpenTXT.TabIndex = 0;
            OpenTXT.Text = "Открыть .txt файл с изображениями";
            OpenTXT.UseVisualStyleBackColor = true;
            OpenTXT.Click += OpenTXT_Click;
            // 
            // SaveIMG
            // 
            SaveIMG.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveIMG.Location = new Point(1458, 819);
            SaveIMG.Name = "SaveIMG";
            SaveIMG.Size = new Size(179, 178);
            SaveIMG.TabIndex = 1;
            SaveIMG.Text = "Сохранить .txt файл с изображениями";
            SaveIMG.UseVisualStyleBackColor = true;
            SaveIMG.Click += SaveIMG_Click;
            // 
            // ListIMG
            // 
            ListIMG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ListIMG.FormattingEnabled = true;
            ListIMG.Location = new Point(1458, 108);
            ListIMG.Name = "ListIMG";
            ListIMG.Size = new Size(424, 612);
            ListIMG.TabIndex = 2;
            ListIMG.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // NameIMG
            // 
            NameIMG.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NameIMG.Location = new Point(1458, 774);
            NameIMG.Name = "NameIMG";
            NameIMG.Size = new Size(424, 39);
            NameIMG.TabIndex = 3;
            NameIMG.TextChanged += textBox1_TextChanged;
            // 
            // ShowIMG
            // 
            ShowIMG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ShowIMG.Location = new Point(12, 12);
            ShowIMG.Name = "ShowIMG";
            ShowIMG.Size = new Size(1440, 985);
            ShowIMG.SizeMode = PictureBoxSizeMode.Zoom;
            ShowIMG.TabIndex = 4;
            ShowIMG.TabStop = false;
            // 
            // Russia
            // 
            Russia.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Russia.Image = (Image)resources.GetObject("Russia.Image");
            Russia.Location = new Point(1643, 819);
            Russia.Name = "Russia";
            Russia.Size = new Size(239, 178);
            Russia.SizeMode = PictureBoxSizeMode.StretchImage;
            Russia.TabIndex = 6;
            Russia.TabStop = false;
            // 
            // OpenerTXT
            // 
            OpenerTXT.FileName = "Выберите .txt файл с ссылками на изображения";
            OpenerTXT.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            // 
            // SaverTXT
            // 
            SaverTXT.FileName = "Сохраните .txt файл с изображениями";
            SaverTXT.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            // 
            // OpenFileIMG
            // 
            OpenFileIMG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OpenFileIMG.AutoSize = true;
            OpenFileIMG.Location = new Point(1458, 60);
            OpenFileIMG.Name = "OpenFileIMG";
            OpenFileIMG.Size = new Size(424, 42);
            OpenFileIMG.TabIndex = 7;
            OpenFileIMG.Text = "Открыть файл изображения";
            OpenFileIMG.UseVisualStyleBackColor = true;
            // 
            // DeleteIMG
            // 
            DeleteIMG.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeleteIMG.AutoSize = true;
            DeleteIMG.Location = new Point(1458, 726);
            DeleteIMG.Name = "DeleteIMG";
            DeleteIMG.Size = new Size(424, 42);
            DeleteIMG.TabIndex = 9;
            DeleteIMG.Text = "Удалить изображение из списка";
            DeleteIMG.UseVisualStyleBackColor = true;
            // 
            // Gallery
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1894, 1009);
            Controls.Add(DeleteIMG);
            Controls.Add(OpenFileIMG);
            Controls.Add(Russia);
            Controls.Add(ShowIMG);
            Controls.Add(NameIMG);
            Controls.Add(ListIMG);
            Controls.Add(SaveIMG);
            Controls.Add(OpenTXT);
            MinimizeBox = false;
            Name = "Gallery";
            Text = "Gallery";
            ((System.ComponentModel.ISupportInitialize)ShowIMG).EndInit();
            ((System.ComponentModel.ISupportInitialize)Russia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OpenTXT;
        private Button SaveIMG;
        private ListBox ListIMG;
        private TextBox NameIMG;
        private PictureBox ShowIMG;
        private PictureBox Russia;
        private OpenFileDialog OpenerTXT;
        private SaveFileDialog SaverTXT;
        private Button OpenFileIMG;
        private Button DeleteIMG;
    }
}
