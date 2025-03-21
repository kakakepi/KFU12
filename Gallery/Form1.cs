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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void OpenTXT_Click(object sender, EventArgs e)
        {
            if (OpenerTXT.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = OpenerTXT.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            foreach (string line in fileText.Split("\n"))
            {
                ListIMG.Items.Add($"{line}");
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
                
            }
            File.WriteAllLines(.FileName, lines);
            MessageBox.Show("Файл сохранен");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
