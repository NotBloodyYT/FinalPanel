using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing.Text;
using System.Configuration;

namespace FinalPanel
{
    public partial class FinalPanel : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public FinalPanel()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void FinalPanel_Load(object sender, EventArgs e)
        {

        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticonePanel1_DragEnter(object sender, DragEventArgs e)
        {
            //nvm
        }

        private void siticonePanel1_MouseClick(object sender, MouseEventArgs e)
        {
            //nvm
        }

        private void siticonePanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void siticonePanel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Enable125Hz_Click(object sender, EventArgs e)
        {
            if (Enable125Hz.Enabled == true)
            {
                Enable125Hz.BorderColor = Color.White;
                MessageBox.Show("125Hz Is Enabled!");
                Enable500Hz.BorderColor = Color.Gray;
                Enable1000Hz.BorderColor = Color.Gray;
            }
        }

        private void Enable500Hz_Click(object sender, EventArgs e)
        {
            if (Enable500Hz.Enabled == true)
            {
                Enable500Hz.BorderColor = Color.White;
                MessageBox.Show("500Hz Is Enabled!");
                Enable125Hz.BorderColor = Color.Gray;
                Enable1000Hz.BorderColor = Color.Gray;
            }
        }

        private void Enable1000Hz_Click(object sender, EventArgs e)
        {
            if (Enable1000Hz.Enabled == true)
            {
                Enable1000Hz.BorderColor = Color.White;
                MessageBox.Show("1000Hz Is Enabled!");
                Enable125Hz.BorderColor = Color.Gray;
                Enable500Hz.BorderColor = Color.Gray;
            }
        }

        private void Enable400DPI_Click(object sender, EventArgs e)
        {
            if (Enable400DPI.Enabled == true)
            {
                Enable400DPI.BorderColor = Color.White;
                MessageBox.Show("400DPI Is Enabled!");
                Enable800DPI.BorderColor = Color.Gray;
                Enable1600DPI.BorderColor = Color.Gray;
                Enable3200DPI.BorderColor = Color.Gray;
            }
        }

        private void Enable800DPI_Click(object sender, EventArgs e)
        {
            if (Enable800DPI.Enabled == true)
            {
                Enable800DPI.BorderColor = Color.White;
                MessageBox.Show("800DPI Is Enabled!");
                Enable400DPI.BorderColor = Color.Gray;
                Enable1600DPI.BorderColor = Color.Gray;
                Enable3200DPI.BorderColor = Color.Gray;
            }
        }

        private void Enable1600DPI_Click(object sender, EventArgs e)
        {
            if (Enable1600DPI.Enabled == true)
            {
                Enable1600DPI.BorderColor = Color.White;
                MessageBox.Show("1600DPI Is Enabled!");
                Enable800DPI.BorderColor = Color.Gray;
                Enable400DPI.BorderColor = Color.Gray;
                Enable3200DPI.BorderColor = Color.Gray;
            }
        }

        private void Enable3200DPI_Click(object sender, EventArgs e)
        {
            if (Enable3200DPI.Enabled == true)
            {
                Enable3200DPI.BorderColor = Color.White;
                MessageBox.Show("3200DPI Is Enabled!");
                Enable800DPI.BorderColor = Color.Gray;
                Enable1600DPI.BorderColor = Color.Gray;
                Enable400DPI.BorderColor = Color.Gray;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.PerformStep();
            if (progressBar1.Value == 100)
            {
                Timer.Enabled = false;   //Add this line
                FinalPanel f2 = new FinalPanel();   //Add this line
                f2.Show();
                this.Hide();
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Step = 4;
            Timer.Start();
        }
    }
}