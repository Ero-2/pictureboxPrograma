using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureboxPrograma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog abrir = new OpenFileDialog();

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = abrir.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Form fullscreenForm = new Form();
            fullscreenForm.WindowState = FormWindowState.Maximized;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = pictureBox1.Image;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            fullscreenForm.Controls.Add(pictureBox);
            fullscreenForm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            int step = 10;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    pictureBox1.Left -= step;
                    break;
                case Keys.Right:
                    pictureBox1.Left += step;
                    break;
                case Keys.Up:
                    pictureBox1.Top -= step;
                    break;
                case Keys.Down:
                    pictureBox1.Top += step;

                    break;
            }
        }
    }
} 
