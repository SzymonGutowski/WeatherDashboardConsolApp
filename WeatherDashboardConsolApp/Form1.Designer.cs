namespace WeatherDashboardConsolApp
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.GenerateWeather = new System.Windows.Forms.Button();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NorthSouth = new System.Windows.Forms.TextBox();
            this.EastWest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.Pressure = new System.Windows.Forms.Label();
            this.TemperatureJSON = new System.Windows.Forms.TextBox();
            this.PressureJSON = new System.Windows.Forms.TextBox();
            this.humidity = new System.Windows.Forms.Label();
            this.HumidityJSON = new System.Windows.Forms.TextBox();
            this.wind = new System.Windows.Forms.Label();
            this.WindJSON = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GenerateWeather
            // 
            this.GenerateWeather.BackColor = System.Drawing.SystemColors.Highlight;
            this.GenerateWeather.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GenerateWeather.BackgroundImage")));
            this.GenerateWeather.Location = new System.Drawing.Point(25, 219);
            this.GenerateWeather.Name = "GenerateWeather";
            this.GenerateWeather.Size = new System.Drawing.Size(165, 44);
            this.GenerateWeather.TabIndex = 0;
            this.GenerateWeather.Text = "Show Weather";
            this.GenerateWeather.UseVisualStyleBackColor = false;
            this.GenerateWeather.Click += new System.EventHandler(this.GenerateWeather_Click);
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(850, 68);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(135, 27);
            this.DateBox.TabIndex = 3;
            this.DateBox.TextChanged += new System.EventHandler(this.DateBox_TextChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(28, 274);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(97, 27);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.Value = new System.DateTime(2022, 12, 16, 0, 0, 0, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // NorthSouth
            // 
            this.NorthSouth.Location = new System.Drawing.Point(28, 68);
            this.NorthSouth.Name = "NorthSouth";
            this.NorthSouth.Size = new System.Drawing.Size(129, 27);
            this.NorthSouth.TabIndex = 17;
            // 
            // EastWest
            // 
            this.EastWest.Location = new System.Drawing.Point(28, 152);
            this.EastWest.Name = "EastWest";
            this.EastWest.Size = new System.Drawing.Size(135, 27);
            this.EastWest.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "N/S Cooridnates";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "W/E Cooridnates";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(862, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Current Date";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.BackColor = System.Drawing.Color.Transparent;
            this.TemperatureLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TemperatureLabel.Location = new System.Drawing.Point(844, 112);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(141, 28);
            this.TemperatureLabel.TabIndex = 13;
            this.TemperatureLabel.Text = "TEMPERATURE";
            // 
            // Pressure
            // 
            this.Pressure.AutoSize = true;
            this.Pressure.BackColor = System.Drawing.Color.Transparent;
            this.Pressure.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pressure.Location = new System.Drawing.Point(882, 194);
            this.Pressure.Name = "Pressure";
            this.Pressure.Size = new System.Drawing.Size(103, 28);
            this.Pressure.TabIndex = 14;
            this.Pressure.Text = "PRESSURE";
            // 
            // TemperatureJSON
            // 
            this.TemperatureJSON.BackColor = System.Drawing.Color.White;
            this.TemperatureJSON.Location = new System.Drawing.Point(850, 152);
            this.TemperatureJSON.Name = "TemperatureJSON";
            this.TemperatureJSON.Size = new System.Drawing.Size(135, 27);
            this.TemperatureJSON.TabIndex = 15;
            // 
            // PressureJSON
            // 
            this.PressureJSON.Location = new System.Drawing.Point(850, 225);
            this.PressureJSON.Name = "PressureJSON";
            this.PressureJSON.Size = new System.Drawing.Size(135, 27);
            this.PressureJSON.TabIndex = 16;
            // 
            // humidity
            // 
            this.humidity.AutoSize = true;
            this.humidity.BackColor = System.Drawing.Color.Transparent;
            this.humidity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.humidity.Location = new System.Drawing.Point(882, 274);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(103, 28);
            this.humidity.TabIndex = 18;
            this.humidity.Text = "HUMIDITY";
            // 
            // HumidityJSON
            // 
            this.HumidityJSON.Location = new System.Drawing.Point(850, 315);
            this.HumidityJSON.Name = "HumidityJSON";
            this.HumidityJSON.Size = new System.Drawing.Size(135, 27);
            this.HumidityJSON.TabIndex = 19;
            // 
            // wind
            // 
            this.wind.AutoSize = true;
            this.wind.BackColor = System.Drawing.Color.Transparent;
            this.wind.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wind.Location = new System.Drawing.Point(920, 357);
            this.wind.Name = "wind";
            this.wind.Size = new System.Drawing.Size(65, 28);
            this.wind.TabIndex = 20;
            this.wind.Text = "WIND";
            // 
            // WindJSON
            // 
            this.WindJSON.Location = new System.Drawing.Point(850, 400);
            this.WindJSON.Name = "WindJSON";
            this.WindJSON.Size = new System.Drawing.Size(135, 27);
            this.WindJSON.TabIndex = 21;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(997, 525);
            this.Controls.Add(this.WindJSON);
            this.Controls.Add(this.wind);
            this.Controls.Add(this.HumidityJSON);
            this.Controls.Add(this.humidity);
            this.Controls.Add(this.PressureJSON);
            this.Controls.Add(this.TemperatureJSON);
            this.Controls.Add(this.Pressure);
            this.Controls.Add(this.TemperatureLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EastWest);
            this.Controls.Add(this.NorthSouth);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.GenerateWeather);
            this.Name = "MainWindow";
            this.Text = "Weather Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button GenerateWeather;
        private TextBox DateBox;
        private DateTimePicker dateTimePicker;
        private TextBox NorthSouth;
        private TextBox EastWest;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label TemperatureLabel;
        private Label Pressure;
        private TextBox TemperatureJSON;
        private TextBox PressureJSON;
        private Label humidity;
        private TextBox HumidityJSON;
        private Label wind;
        private TextBox WindJSON;
    }
}