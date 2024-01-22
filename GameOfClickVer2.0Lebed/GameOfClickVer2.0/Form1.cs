using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfClickVer2._0
{
    public partial class MainForm : Form
    {
        private int _s = 15;
        private int Score = 0;
        private int Count = 4;
        public MainForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }
        class Picture
        {
            public void SetPictureBoxImagesPepe(PictureBox ptb1, PictureBox ptb2, PictureBox ptb3, PictureBox ptb4)
            {
                ptb1.Image = Image.FromFile("C:\\Users\\860-16\\Desktop\\GameOfClickVer2.0\\GameOfClickPicture\\Pepe.png");
                ptb2.Image = Image.FromFile("C:\\Users\\860-16\\Desktop\\GameOfClickVer2.0\\GameOfClickPicture\\Pepe.png");
                ptb3.Image = Image.FromFile("C:\\Users\\860-16\\Desktop\\GameOfClickVer2.0\\GameOfClickPicture\\Pepe.png");
                ptb4.Image = Image.FromFile("C:\\Users\\860-16\\Desktop\\GameOfClickVer2.0\\GameOfClickPicture\\Pepe.png");
            }
            public void SetPictureBoxImagePig(PictureBox ptb1, PictureBox ptb2, PictureBox ptb3, PictureBox ptb4)
            {
                ptb1.Image = Image.FromFile("C:\\Users\\860-16\\Desktop\\GameOfClickVer2.0\\GameOfClickPicture\\Свинтя.png");
                ptb2.Image = Image.FromFile("C:\\Users\\860-16\\Desktop\\GameOfClickVer2.0\\GameOfClickPicture\\Свинтя.png");
                ptb3.Image = Image.FromFile("C:\\Users\\860-16\\Desktop\\GameOfClickVer2.0\\GameOfClickPicture\\Свинтя.png");
                ptb4.Image = Image.FromFile("C:\\Users\\860-16\\Desktop\\GameOfClickVer2.0\\GameOfClickPicture\\Свинтя.png");
            }
            public void SetPictureBoxImageYad(PictureBox ptb1, PictureBox ptb2, PictureBox ptb3, PictureBox ptb4)
            {
                ptb1.Image = Image.FromFile("C:\\Users\\860-16\\Desktop\\GameOfClickVer2.0\\GameOfClickPicture\\Яд.png");
                ptb2.Image = Image.FromFile("C:\\Users\\860-16\\Desktop\\GameOfClickVer2.0\\GameOfClickPicture\\Яд.png");
                ptb3.Image = Image.FromFile("C:\\Users\\860-16\\Desktop\\GameOfClickVer2.0\\GameOfClickPicture\\Яд.png");
                ptb4.Image = Image.FromFile("C:\\Users\\860-16\\Desktop\\GameOfClickVer2.0\\GameOfClickPicture\\Яд.png");
            }

        }

        private void PictureVisible()
        {
            ptb1.Visible = true;
            ptb2.Visible = true;
            ptb3.Visible = true;
            ptb4.Visible = true;
        }
        private void PictureNotVisible()
        {
            ptb1.Visible = false;
            ptb2.Visible = false;
            ptb3.Visible = false;
            ptb4.Visible = false;
        }
        private void PictureLocationYad()
        {
            ptb1.Location = new Point(480, 180);
            ptb2.Location = new Point(800, 80);
            ptb3.Location = new Point(360, 430);
        }
        private void ResetResultGame()
        {
            this.Score = 0;
            this.Count = 4;
            this._s = 15;
            lblCountPointResult.Text = this.Score.ToString();
            lblCountObjectResult.Text = this.Count.ToString();
            lblTimerResult.Text = this._s.ToString();
        }
        private void низкаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            PictureNotVisible();
            pnlMap.Visible = true;
            Picture picture = new Picture();
            picture.SetPictureBoxImagesPepe(ptb1, ptb2, ptb3, ptb4);
            pnlMap.BackgroundImage = Image.FromFile("C:\\Users\\860-16\\Desktop\\GameOfClickVer2.0\\GameOfClickPicture\\Easy.jpg");
            pnlMap.BackgroundImageLayout = ImageLayout.Stretch;
            pnlInfo.Visible = true;
            btnStartGame.Enabled = true;
            lblTimerResult.Text = "15";
            this.Score = 0;
            this.Count = 4;
            lblCountPointResult.Text = this.Score.ToString();
            lblCountObjectResult.Text = this.Count.ToString();
            pnlMap.Enabled = false;
            

        }
        
        private void средняяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            PictureNotVisible();
            pnlMap.Visible = true;
            Picture picture = new Picture();
            picture.SetPictureBoxImagePig(ptb1, ptb2, ptb3, ptb4);
            pnlMap.BackgroundImage = Image.FromFile("C:\\Users\\860-16\\Desktop\\GameOfClickVer2.0\\GameOfClickPicture\\Normal.jpg");
            pnlMap.BackgroundImageLayout = ImageLayout.Stretch;
            pnlInfo.Visible = true;
            btnStartGame.Enabled = true;
            lblTimerResult.Text = "15";
            this.Score = 0;
            this.Count = 4;
            lblCountPointResult.Text = this.Score.ToString();
            lblCountObjectResult.Text = this.Count.ToString();
            pnlMap.Enabled = false;
        }
        private void высокаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureNotVisible();
            pnlMap.Visible = true;
            pnlMap.BackgroundImage = Image.FromFile("C:\\Users\\860-16\\Desktop\\GameOfClickVer2.0\\GameOfClickPicture\\Hard.jpg");
            Picture picture = new Picture();
            picture.SetPictureBoxImageYad(ptb1, ptb2, ptb3, ptb4);
            PictureLocationYad();
            pnlMap.BackgroundImageLayout = ImageLayout.Stretch;
            pnlInfo.Visible = true;
            btnStartGame.Enabled = true;
            lblTimerResult.Text = "15";
            this.Score = 0;
            this.Count = 4;
            lblCountPointResult.Text = this.Score.ToString();
            lblCountObjectResult.Text = this.Count.ToString();
            pnlMap.Enabled = false;
        }
        private void ClickPicture_Click(object sender, EventArgs e)
        {
            ((PictureBox)sender).Visible = false;
            this.Score++;
            lblCountPointResult.Text = this.Score.ToString();
            this.Count--;
            lblCountObjectResult.Text = this.Count.ToString();

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            pnlInfo.Visible = false;
            foreach (PictureBox pictureBox in pnlMap.Controls)
            {
                pictureBox.BackColor = Color.Transparent;
            }
            lblCountPointResult.Text = Score.ToString();
            lblCountObjectResult.Text = Count.ToString();
        }
        private void tmr_Tick(object sender, EventArgs e)
        {
            _s = int.Parse(lblTimerResult.Text);
            _s--;
            lblTimerResult.Text = _s.ToString();
            if (_s == 0)
            {
                tmr.Stop();
                MessageBox.Show($"Ваше время вышло!\nВы не успели найти {lblCountObjectResult.Text} предмета\nПопробуйте снова", "Упс...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pnlMap.Enabled = false;
            }
            else if (Score == 4)
            {
                tmr.Stop();
                MessageBox.Show($"Поздравляем!\nВы успели найти все предметы за {15 - _s} секунд", "Ура",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlMap.Enabled = false;
               
            }
            if (tmr.Enabled)
            {
                menuStrip1.Enabled = false;
            }
            else { menuStrip1.Enabled = true; }
        }
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            tmr.Start();
            btnStartGame.Enabled = false;
            pnlMap.Enabled = true;
            PictureVisible();
            this._s = 15;
            
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            tmr.Start();
            ResetResultGame();
            PictureVisible();
            pnlMap.Enabled = true;

        }
        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ваша задача заключается в том, чтобы за отведенное время найти все предметы на картинке", "Правила",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pnlMap_Paint(object sender, PaintEventArgs e)
        {
            int radius = 70;

            
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddArc(0, 0, radius, radius, 180, 90);
            graphicsPath.AddArc(pnlMap.Width - radius, 0, radius, radius, 270, 90);
            graphicsPath.AddArc(pnlMap.Width - radius, pnlMap.Height - radius, radius, radius, 0, 90);
            graphicsPath.AddArc(0, pnlMap.Height - radius, radius, radius, 90, 90);
            graphicsPath.CloseFigure();

            
            pnlMap.Region = new Region(graphicsPath);
        }

        private void pnlMap_Resize(object sender, EventArgs e)
        {
            pnlMap.Invalidate();
        }

        private void pnlInfo_Paint(object sender, PaintEventArgs e)
        {
            int radius = 70;


            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddArc(0, 0, radius, radius, 180, 90);
            graphicsPath.AddArc(pnlInfo.Width - radius, 0, radius, radius, 270, 90);
            graphicsPath.AddArc(pnlInfo.Width - radius, pnlInfo.Height - radius, radius, radius, 0, 90);
            graphicsPath.AddArc(0, pnlInfo.Height - radius, radius, radius, 90, 90);
            graphicsPath.CloseFigure();


            pnlInfo.Region = new Region(graphicsPath);
        }

        private void pnlInfo_Resize(object sender, EventArgs e)
        {
            pnlInfo.Invalidate();
        }

       
    }
}
