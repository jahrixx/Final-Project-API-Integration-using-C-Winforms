namespace WeatherApp
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
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            flowLayoutPanel5 = new FlowLayoutPanel();
            logoApp = new PictureBox();
            titleApp = new Label();
            panel1 = new Panel();
            textLocation = new TextBox();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            label2 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            temperatureLabel = new Label();
            locationLabel = new Label();
            descriptionLabel = new Label();
            humidityLabel = new Label();
            forecastList = new DataGridView();
            splitContainer1 = new SplitContainer();
            label6 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            todayLabel = new Label();
            sunriseLabel = new Label();
            sunsetLabel = new Label();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoApp).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)forecastList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(54, 84, 134);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(54, 84, 134);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(47, 54, 69);
            button1.Location = new Point(885, 3);
            button1.Name = "button1";
            button1.Size = new Size(33, 34);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += exit_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(54, 84, 134);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(921, 42);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(54, 84, 134);
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(54, 84, 134);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(47, 54, 69);
            button2.Location = new Point(847, 3);
            button2.Name = "button2";
            button2.Size = new Size(32, 34);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            button2.Click += maximize_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(54, 84, 134);
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.FromArgb(54, 84, 134);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(47, 54, 69);
            button3.Location = new Point(808, 3);
            button3.Name = "button3";
            button3.Size = new Size(33, 34);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = false;
            button3.Click += minimize_Click;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(logoApp);
            flowLayoutPanel5.Controls.Add(titleApp);
            flowLayoutPanel5.Location = new Point(3, 3);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(799, 40);
            flowLayoutPanel5.TabIndex = 19;
            // 
            // logoApp
            // 
            logoApp.Image = (Image)resources.GetObject("logoApp.Image");
            logoApp.Location = new Point(3, 3);
            logoApp.Name = "logoApp";
            logoApp.Size = new Size(37, 41);
            logoApp.TabIndex = 0;
            logoApp.TabStop = false;
            // 
            // titleApp
            // 
            titleApp.AutoSize = true;
            titleApp.Font = new Font("Harlow Solid Italic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            titleApp.ForeColor = Color.FromArgb(255, 224, 192);
            titleApp.Location = new Point(43, 0);
            titleApp.Margin = new Padding(0);
            titleApp.Name = "titleApp";
            titleApp.Padding = new Padding(0, 12, 0, 0);
            titleApp.Size = new Size(114, 34);
            titleApp.TabIndex = 13;
            titleApp.Text = "WeatherApp";
            titleApp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = Color.FromArgb(238, 237, 235);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Cursor = Cursors.SizeAll;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(921, 43);
            panel1.TabIndex = 2;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // textLocation
            // 
            textLocation.Font = new Font("Gadugi", 12F);
            textLocation.Location = new Point(156, 12);
            textLocation.Name = "textLocation";
            textLocation.Size = new Size(240, 34);
            textLocation.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 224, 192);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(143, 36);
            label1.TabIndex = 5;
            label1.Text = "Location:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.FromArgb(47, 54, 69);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(402, 3);
            button4.Name = "button4";
            button4.Size = new Size(49, 51);
            button4.TabIndex = 6;
            button4.UseVisualStyleBackColor = true;
            button4.Click += search;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.FromArgb(47, 54, 69);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(390, 3);
            button5.Name = "button5";
            button5.Size = new Size(44, 54);
            button5.TabIndex = 7;
            button5.UseVisualStyleBackColor = true;
            button5.Click += refreshWeatherData;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 224, 192);
            label2.Location = new Point(8, 51);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(153, 46);
            label2.TabIndex = 10;
            label2.Text = "Location:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Controls.Add(label2);
            flowLayoutPanel3.Controls.Add(label4);
            flowLayoutPanel3.Controls.Add(label5);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(5, 120);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(5);
            flowLayoutPanel3.Size = new Size(247, 198);
            flowLayoutPanel3.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 224, 192);
            label3.Location = new Point(8, 5);
            label3.Name = "label3";
            label3.Padding = new Padding(5);
            label3.Size = new Size(215, 46);
            label3.TabIndex = 11;
            label3.Text = "Temperature:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 224, 192);
            label4.Location = new Point(8, 97);
            label4.Name = "label4";
            label4.Padding = new Padding(5);
            label4.Size = new Size(195, 46);
            label4.TabIndex = 12;
            label4.Text = "Description:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(255, 224, 192);
            label5.Location = new Point(8, 143);
            label5.Name = "label5";
            label5.Padding = new Padding(5);
            label5.Size = new Size(166, 46);
            label5.TabIndex = 13;
            label5.Text = "Humidity:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.Controls.Add(temperatureLabel);
            flowLayoutPanel4.Controls.Add(locationLabel);
            flowLayoutPanel4.Controls.Add(descriptionLabel);
            flowLayoutPanel4.Controls.Add(humidityLabel);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(255, 120);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Padding = new Padding(5);
            flowLayoutPanel4.Size = new Size(234, 198);
            flowLayoutPanel4.TabIndex = 14;
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            temperatureLabel.ForeColor = Color.FromArgb(255, 224, 192);
            temperatureLabel.Location = new Point(8, 5);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Padding = new Padding(5);
            temperatureLabel.Size = new Size(10, 46);
            temperatureLabel.TabIndex = 11;
            temperatureLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            locationLabel.ForeColor = Color.FromArgb(255, 224, 192);
            locationLabel.Location = new Point(8, 51);
            locationLabel.Name = "locationLabel";
            locationLabel.Padding = new Padding(5);
            locationLabel.Size = new Size(10, 46);
            locationLabel.TabIndex = 10;
            locationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descriptionLabel.ForeColor = Color.FromArgb(255, 224, 192);
            descriptionLabel.Location = new Point(8, 97);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Padding = new Padding(5);
            descriptionLabel.Size = new Size(10, 46);
            descriptionLabel.TabIndex = 12;
            descriptionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // humidityLabel
            // 
            humidityLabel.AutoSize = true;
            humidityLabel.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            humidityLabel.ForeColor = Color.FromArgb(255, 224, 192);
            humidityLabel.Location = new Point(8, 143);
            humidityLabel.Name = "humidityLabel";
            humidityLabel.Padding = new Padding(5);
            humidityLabel.Size = new Size(10, 46);
            humidityLabel.TabIndex = 13;
            humidityLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // forecastList
            // 
            forecastList.BackgroundColor = Color.FromArgb(47, 54, 69);
            forecastList.BorderStyle = BorderStyle.None;
            forecastList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            forecastList.Dock = DockStyle.Bottom;
            forecastList.Location = new Point(0, 334);
            forecastList.Name = "forecastList";
            forecastList.RowHeadersWidth = 51;
            forecastList.Size = new Size(921, 170);
            forecastList.TabIndex = 15;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Top;
            splitContainer1.Location = new Point(0, 43);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(button4);
            splitContainer1.Panel1.Controls.Add(textLocation);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(button5);
            splitContainer1.Size = new Size(921, 60);
            splitContainer1.SplitterDistance = 471;
            splitContainer1.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 224, 192);
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(14, 12);
            label6.Name = "label6";
            label6.Size = new Size(365, 36);
            label6.TabIndex = 7;
            label6.Text = "Refresh Current Weather";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(label7);
            flowLayoutPanel2.Controls.Add(label8);
            flowLayoutPanel2.Controls.Add(label9);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(503, 120);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(5);
            flowLayoutPanel2.Size = new Size(210, 148);
            flowLayoutPanel2.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(255, 224, 192);
            label7.Location = new Point(8, 5);
            label7.Name = "label7";
            label7.Padding = new Padding(5);
            label7.Size = new Size(194, 46);
            label7.TabIndex = 11;
            label7.Text = "Date Today:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(255, 224, 192);
            label8.Location = new Point(8, 51);
            label8.Name = "label8";
            label8.Padding = new Padding(5);
            label8.Size = new Size(136, 46);
            label8.TabIndex = 10;
            label8.Text = "Sunrise:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(255, 224, 192);
            label9.Location = new Point(8, 97);
            label9.Name = "label9";
            label9.Padding = new Padding(5);
            label9.Size = new Size(127, 46);
            label9.TabIndex = 12;
            label9.Text = "Sunset:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // todayLabel
            // 
            todayLabel.AutoSize = true;
            todayLabel.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            todayLabel.ForeColor = Color.FromArgb(255, 224, 192);
            todayLabel.Location = new Point(716, 125);
            todayLabel.Name = "todayLabel";
            todayLabel.Padding = new Padding(5);
            todayLabel.Size = new Size(10, 46);
            todayLabel.TabIndex = 14;
            todayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sunriseLabel
            // 
            sunriseLabel.AutoSize = true;
            sunriseLabel.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sunriseLabel.ForeColor = Color.FromArgb(255, 224, 192);
            sunriseLabel.Location = new Point(716, 171);
            sunriseLabel.Name = "sunriseLabel";
            sunriseLabel.Padding = new Padding(5);
            sunriseLabel.Size = new Size(10, 46);
            sunriseLabel.TabIndex = 17;
            sunriseLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sunsetLabel
            // 
            sunsetLabel.AutoSize = true;
            sunsetLabel.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sunsetLabel.ForeColor = Color.FromArgb(255, 224, 192);
            sunsetLabel.Location = new Point(717, 220);
            sunsetLabel.Name = "sunsetLabel";
            sunsetLabel.Padding = new Padding(5);
            sunsetLabel.Size = new Size(10, 46);
            sunsetLabel.TabIndex = 18;
            sunsetLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 54, 69);
            ClientSize = new Size(921, 504);
            Controls.Add(sunsetLabel);
            Controls.Add(sunriseLabel);
            Controls.Add(splitContainer1);
            Controls.Add(forecastList);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(todayLabel);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoApp).EndInit();
            panel1.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)forecastList).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private TextBox textLocation;
        private Label label1;
        private Button button4;
        private Button button5;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label3;
        private Label label4;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label temperatureLabel;
        private Label locationLabel;
        private Label descriptionLabel;
        private Label humidityLabel;
        private DataGridView forecastList;
        private SplitContainer splitContainer1;
        private Label label6;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label todayLabel;
        private Label sunriseLabel;
        private Label sunsetLabel;
        private FlowLayoutPanel flowLayoutPanel5;
        private PictureBox logoApp;
        private Label titleApp;
    }
}
