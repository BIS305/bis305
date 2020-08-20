using System;
using System.Windows.Forms;

namespace DigitalBooks
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            lblInstructions.Visible = false;
            btnExit.Enabled = true;
            btnAudio.Enabled = false;
            btnEBook.Enabled = false;
            lblThankYou.Visible = true;
        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            DigitalPicBox.Image = Properties.Resources.audioBook;
            btnSelect.Enabled = true;
        }

        private void btnEBook_Click(object sender, EventArgs e)
        {
            DigitalPicBox.Image = Properties.Resources.ebook;
            btnSelect.Enabled = true;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            lblThankYou.Visible = false;
            btnSelect.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
