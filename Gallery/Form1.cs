using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Gallery
{
    public partial class Gallery : Form
    {
        public Gallery()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ImageMember? image = ListIMG.SelectedItem as ImageMember;
            if (image != null && File.Exists(image.path))
            {
                ShowIMG.Image = Image.FromFile(image.path);
                NameIMG.Text = image.title;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (ListIMG.SelectedItem != null)
            {
                ImageMember? image = ListIMG.SelectedItem as ImageMember;
                image.title = NameIMG.Text;
            }
        }
        private void OpenTXT_Click(object sender, EventArgs e)
        {
            if (OpenerTXT.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = OpenerTXT.FileName;
            string fileText = System.IO.File.ReadAllText(filename);

            foreach (string line in fileText.Split('\n'))
            {
                string[] imageMembers = line.Split(',');
                if (imageMembers.Length >= 2)
                {
                    string[] imageName1 = imageMembers[0].Split('\\');
                    string imageName = imageName1[imageName1.Length - 1];
                    if (!string.IsNullOrEmpty(imageMembers[0]))
                    {
                        ImageMember imageMember = new ImageMember(imageName, imageMembers[0], imageMembers[1]);
                        ListIMG.Items.Add(imageMember);
                    }
                }
                if (imageMembers.Length == 1)
                {
                    string[] imageName1 = imageMembers[0].Split('\\');
                    string imageName = imageName1[imageName1.Length - 1];
                    if (!string.IsNullOrEmpty(imageMembers[0]))
                    {
                        ImageMember imageMember = new ImageMember(imageName, imageMembers[0]);
                        ListIMG.Items.Add(imageMember);
                    }
                }
            }
            MessageBox.Show("Файл открыт");
        }

        private void SaveIMG_Click(object sender, EventArgs e)
        {
            if (SaverTXT.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = SaverTXT.FileName;
            string[] lines = new string[ListIMG.Items.Count];
            for (int i = 0; i < ListIMG.Items.Count; i++)
            {
                var image = ListIMG.Items[i] as ImageMember;
                if (image != null)
                {
                    lines[i] = string.IsNullOrEmpty(image.title) ? image.path : $"{image.path},{image.title}";
                }
            }
            System.IO.File.WriteAllText(filename, string.Join("\n", lines));
            MessageBox.Show("Файл сохранен");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            ListIMG.Items.Remove(ListIMG.SelectedItem);
            ShowIMG.Image = null;
            ListIMG.SelectedIndex = -1;
            NameIMG.Text = null;
        }

        private void Clear_Click_1(object sender, EventArgs e)
        {
            ListIMG.Items.Clear();
            ShowIMG.Image = null;
            ListIMG.SelectedIndex = -1;
            NameIMG.Text = null;
        }
        private void OpenFileIM_Click(object sender, EventArgs e)
        {
            if (openerIMG.ShowDialog() == DialogResult.Cancel)
                return;
            string imagePath = openerIMG.FileName;
            string[] imageName1 = imagePath.Split('\\');
            string imageName = imageName1[imageName1.Length - 1];
            if (!string.IsNullOrEmpty(imagePath))
            {
                ImageMember imageMember = new ImageMember(imageName, imagePath);
                ListIMG.Items.Add(imageMember);
            }
            MessageBox.Show("Файл открыт");
        }
    }
}
