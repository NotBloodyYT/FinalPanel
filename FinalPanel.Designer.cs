namespace FinalPanel
{
    partial class FinalPanel
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalPanel));
            pictureBox1 = new PictureBox();
            ExitButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            MinimizeButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            Enable1000Hz = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            Enable500Hz = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            Enable125Hz = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            label1 = new Label();
            label2 = new Label();
            siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            Enable3200DPI = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            Enable1600DPI = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            Enable800DPI = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            Enable400DPI = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            Timer = new System.Windows.Forms.Timer(components);
            siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            siticonePanel1.SuspendLayout();
            siticonePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(2, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 99);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ExitButton
            // 
            ExitButton.DisabledState.BorderColor = Color.DarkGray;
            ExitButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ExitButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ExitButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ExitButton.FillColor = Color.Black;
            ExitButton.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(735, 12);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(53, 45);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "X";
            ExitButton.Click += ExitButton_Click;
            // 
            // MinimizeButton
            // 
            MinimizeButton.DisabledState.BorderColor = Color.DarkGray;
            MinimizeButton.DisabledState.CustomBorderColor = Color.DarkGray;
            MinimizeButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            MinimizeButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            MinimizeButton.FillColor = Color.Black;
            MinimizeButton.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            MinimizeButton.ForeColor = Color.White;
            MinimizeButton.Location = new Point(676, 12);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(53, 45);
            MinimizeButton.TabIndex = 2;
            MinimizeButton.Text = "-";
            MinimizeButton.Click += MinimizeButton_Click;
            // 
            // siticonePanel1
            // 
            siticonePanel1.BorderColor = Color.White;
            siticonePanel1.BorderThickness = 2;
            siticonePanel1.Controls.Add(Enable1000Hz);
            siticonePanel1.Controls.Add(Enable500Hz);
            siticonePanel1.Controls.Add(Enable125Hz);
            siticonePanel1.Controls.Add(label1);
            siticonePanel1.Location = new Point(2, 96);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.Size = new Size(184, 435);
            siticonePanel1.TabIndex = 3;
            siticonePanel1.DragEnter += siticonePanel1_DragEnter;
            siticonePanel1.MouseClick += siticonePanel1_MouseClick;
            siticonePanel1.MouseMove += siticonePanel1_MouseMove;
            // 
            // Enable1000Hz
            // 
            Enable1000Hz.BorderColor = Color.White;
            Enable1000Hz.BorderThickness = 2;
            Enable1000Hz.DisabledState.BorderColor = Color.DarkGray;
            Enable1000Hz.DisabledState.CustomBorderColor = Color.DarkGray;
            Enable1000Hz.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Enable1000Hz.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Enable1000Hz.FillColor = Color.Black;
            Enable1000Hz.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Enable1000Hz.ForeColor = Color.White;
            Enable1000Hz.Location = new Point(38, 324);
            Enable1000Hz.Name = "Enable1000Hz";
            Enable1000Hz.Size = new Size(84, 45);
            Enable1000Hz.TabIndex = 7;
            Enable1000Hz.Text = "1000Hz";
            Enable1000Hz.Click += Enable1000Hz_Click;
            // 
            // Enable500Hz
            // 
            Enable500Hz.BorderColor = Color.White;
            Enable500Hz.BorderThickness = 2;
            Enable500Hz.DisabledState.BorderColor = Color.DarkGray;
            Enable500Hz.DisabledState.CustomBorderColor = Color.DarkGray;
            Enable500Hz.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Enable500Hz.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Enable500Hz.FillColor = Color.Black;
            Enable500Hz.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Enable500Hz.ForeColor = Color.White;
            Enable500Hz.Location = new Point(38, 201);
            Enable500Hz.Name = "Enable500Hz";
            Enable500Hz.Size = new Size(84, 45);
            Enable500Hz.TabIndex = 6;
            Enable500Hz.Text = "500Hz";
            Enable500Hz.Click += Enable500Hz_Click;
            // 
            // Enable125Hz
            // 
            Enable125Hz.BorderColor = Color.White;
            Enable125Hz.BorderThickness = 2;
            Enable125Hz.DisabledState.BorderColor = Color.DarkGray;
            Enable125Hz.DisabledState.CustomBorderColor = Color.DarkGray;
            Enable125Hz.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Enable125Hz.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Enable125Hz.FillColor = Color.Black;
            Enable125Hz.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Enable125Hz.ForeColor = Color.White;
            Enable125Hz.Location = new Point(38, 87);
            Enable125Hz.Name = "Enable125Hz";
            Enable125Hz.Size = new Size(84, 45);
            Enable125Hz.TabIndex = 5;
            Enable125Hz.Text = "125Hz";
            Enable125Hz.Click += Enable125Hz_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 15);
            label1.Name = "label1";
            label1.Size = new Size(93, 19);
            label1.TabIndex = 5;
            label1.Text = "Polling Rate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(78, 23);
            label2.Name = "label2";
            label2.Size = new Size(35, 19);
            label2.TabIndex = 8;
            label2.Text = "DPI";
            // 
            // siticonePanel2
            // 
            siticonePanel2.BorderColor = Color.White;
            siticonePanel2.BorderThickness = 2;
            siticonePanel2.Controls.Add(Enable3200DPI);
            siticonePanel2.Controls.Add(Enable1600DPI);
            siticonePanel2.Controls.Add(Enable800DPI);
            siticonePanel2.Controls.Add(Enable400DPI);
            siticonePanel2.Controls.Add(label2);
            siticonePanel2.Location = new Point(616, 88);
            siticonePanel2.Name = "siticonePanel2";
            siticonePanel2.Size = new Size(184, 443);
            siticonePanel2.TabIndex = 4;
            siticonePanel2.MouseMove += siticonePanel2_MouseMove;
            // 
            // Enable3200DPI
            // 
            Enable3200DPI.BorderColor = Color.White;
            Enable3200DPI.BorderThickness = 2;
            Enable3200DPI.DisabledState.BorderColor = Color.DarkGray;
            Enable3200DPI.DisabledState.CustomBorderColor = Color.DarkGray;
            Enable3200DPI.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Enable3200DPI.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Enable3200DPI.FillColor = Color.Black;
            Enable3200DPI.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Enable3200DPI.ForeColor = Color.White;
            Enable3200DPI.Location = new Point(49, 332);
            Enable3200DPI.Name = "Enable3200DPI";
            Enable3200DPI.Size = new Size(84, 45);
            Enable3200DPI.TabIndex = 11;
            Enable3200DPI.Text = "3200DPI";
            Enable3200DPI.Click += Enable3200DPI_Click;
            // 
            // Enable1600DPI
            // 
            Enable1600DPI.BorderColor = Color.White;
            Enable1600DPI.BorderThickness = 2;
            Enable1600DPI.DisabledState.BorderColor = Color.DarkGray;
            Enable1600DPI.DisabledState.CustomBorderColor = Color.DarkGray;
            Enable1600DPI.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Enable1600DPI.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Enable1600DPI.FillColor = Color.Black;
            Enable1600DPI.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Enable1600DPI.ForeColor = Color.White;
            Enable1600DPI.Location = new Point(49, 236);
            Enable1600DPI.Name = "Enable1600DPI";
            Enable1600DPI.Size = new Size(84, 45);
            Enable1600DPI.TabIndex = 10;
            Enable1600DPI.Text = "1600DPI";
            Enable1600DPI.Click += Enable1600DPI_Click;
            // 
            // Enable800DPI
            // 
            Enable800DPI.BorderColor = Color.White;
            Enable800DPI.BorderThickness = 2;
            Enable800DPI.DisabledState.BorderColor = Color.DarkGray;
            Enable800DPI.DisabledState.CustomBorderColor = Color.DarkGray;
            Enable800DPI.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Enable800DPI.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Enable800DPI.FillColor = Color.Black;
            Enable800DPI.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Enable800DPI.ForeColor = Color.White;
            Enable800DPI.Location = new Point(49, 156);
            Enable800DPI.Name = "Enable800DPI";
            Enable800DPI.Size = new Size(84, 45);
            Enable800DPI.TabIndex = 9;
            Enable800DPI.Text = "800DPI";
            Enable800DPI.Click += Enable800DPI_Click;
            // 
            // Enable400DPI
            // 
            Enable400DPI.BorderColor = Color.White;
            Enable400DPI.BorderThickness = 2;
            Enable400DPI.DisabledState.BorderColor = Color.DarkGray;
            Enable400DPI.DisabledState.CustomBorderColor = Color.DarkGray;
            Enable400DPI.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Enable400DPI.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Enable400DPI.FillColor = Color.Black;
            Enable400DPI.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Enable400DPI.ForeColor = Color.White;
            Enable400DPI.Location = new Point(49, 60);
            Enable400DPI.Name = "Enable400DPI";
            Enable400DPI.Size = new Size(84, 45);
            Enable400DPI.TabIndex = 8;
            Enable400DPI.Text = "400DPI";
            Enable400DPI.Click += Enable400DPI_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(235, 271);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(343, 223);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(363, 111);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 12;
            label3.Text = "Battery %";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(235, 148);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(330, 32);
            progressBar1.TabIndex = 13;
            // 
            // Timer
            // 
            Timer.Tick += Timer_Tick;
            // 
            // siticoneButton1
            // 
            siticoneButton1.BorderColor = Color.White;
            siticoneButton1.BorderThickness = 2;
            siticoneButton1.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton1.FillColor = Color.Black;
            siticoneButton1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton1.ForeColor = Color.White;
            siticoneButton1.Location = new Point(235, 203);
            siticoneButton1.Name = "siticoneButton1";
            siticoneButton1.Size = new Size(343, 45);
            siticoneButton1.TabIndex = 14;
            siticoneButton1.Text = "Battery Status";
            siticoneButton1.Click += siticoneButton1_Click;
            // 
            // FinalPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 531);
            Controls.Add(siticoneButton1);
            Controls.Add(progressBar1);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(siticonePanel2);
            Controls.Add(siticonePanel1);
            Controls.Add(MinimizeButton);
            Controls.Add(ExitButton);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FinalPanel";
            Text = "Form1";
            Load += FinalPanel_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            siticonePanel1.ResumeLayout(false);
            siticonePanel1.PerformLayout();
            siticonePanel2.ResumeLayout(false);
            siticonePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ExitButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton MinimizeButton;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton Enable1000Hz;
        private Siticone.Desktop.UI.WinForms.SiticoneButton Enable500Hz;
        private Siticone.Desktop.UI.WinForms.SiticoneButton Enable125Hz;
        private Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton Enable3200DPI;
        private Siticone.Desktop.UI.WinForms.SiticoneButton Enable1600DPI;
        private Siticone.Desktop.UI.WinForms.SiticoneButton Enable800DPI;
        private Siticone.Desktop.UI.WinForms.SiticoneButton Enable400DPI;
        private PictureBox pictureBox2;
        private Label label3;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer Timer;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
    }
}