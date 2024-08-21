namespace WeatherAPI
{
    partial class WeatherAPIForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWeatherXML = new System.Windows.Forms.Button();
            this.btnWeatherJSON = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.txtFeelsLike = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWind = new System.Windows.Forms.TextBox();
            this.txtClouds = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWeatherXML
            // 
            this.btnWeatherXML.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnWeatherXML.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeatherXML.Location = new System.Drawing.Point(60, 46);
            this.btnWeatherXML.Name = "btnWeatherXML";
            this.btnWeatherXML.Size = new System.Drawing.Size(408, 42);
            this.btnWeatherXML.TabIndex = 0;
            this.btnWeatherXML.Text = "Get Weather (XML)";
            this.btnWeatherXML.UseVisualStyleBackColor = false;
            this.btnWeatherXML.Click += new System.EventHandler(this.btnWeatherXML_Click_1);
            // 
            // btnWeatherJSON
            // 
            this.btnWeatherJSON.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnWeatherJSON.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeatherJSON.Location = new System.Drawing.Point(60, 105);
            this.btnWeatherJSON.Name = "btnWeatherJSON";
            this.btnWeatherJSON.Size = new System.Drawing.Size(408, 42);
            this.btnWeatherJSON.TabIndex = 1;
            this.btnWeatherJSON.Text = "Get Weather (JSON)";
            this.btnWeatherJSON.UseVisualStyleBackColor = false;
            this.btnWeatherJSON.Click += new System.EventHandler(this.btnWeatherJSON_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label1.Location = new System.Drawing.Point(57, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter A Zip Code:";
            // 
            // txtZip
            // 
            this.txtZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZip.Location = new System.Drawing.Point(60, 193);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(409, 20);
            this.txtZip.TabIndex = 3;
            this.txtZip.TextChanged += new System.EventHandler(this.txtZip_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label2.Location = new System.Drawing.Point(57, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Enabled = false;
            this.txtCity.Location = new System.Drawing.Point(59, 252);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(409, 20);
            this.txtCity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label3.Location = new System.Drawing.Point(57, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Latitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label4.Location = new System.Drawing.Point(278, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Longitude";
            // 
            // txtLatitude
            // 
            this.txtLatitude.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtLatitude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLatitude.Enabled = false;
            this.txtLatitude.Location = new System.Drawing.Point(60, 319);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.ReadOnly = true;
            this.txtLatitude.Size = new System.Drawing.Size(190, 20);
            this.txtLatitude.TabIndex = 8;
            // 
            // txtLongitude
            // 
            this.txtLongitude.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtLongitude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLongitude.Enabled = false;
            this.txtLongitude.Location = new System.Drawing.Point(281, 319);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.ReadOnly = true;
            this.txtLongitude.Size = new System.Drawing.Size(190, 20);
            this.txtLongitude.TabIndex = 9;
            // 
            // txtTemperature
            // 
            this.txtTemperature.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTemperature.Enabled = false;
            this.txtTemperature.Location = new System.Drawing.Point(60, 387);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.ReadOnly = true;
            this.txtTemperature.Size = new System.Drawing.Size(100, 20);
            this.txtTemperature.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label5.Location = new System.Drawing.Point(60, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Temperature";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label6.Location = new System.Drawing.Point(188, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Low";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label7.Location = new System.Drawing.Point(278, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "High";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label8.Location = new System.Drawing.Point(363, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Feels Like";
            // 
            // txtLow
            // 
            this.txtLow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtLow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLow.Enabled = false;
            this.txtLow.Location = new System.Drawing.Point(191, 386);
            this.txtLow.Name = "txtLow";
            this.txtLow.ReadOnly = true;
            this.txtLow.Size = new System.Drawing.Size(59, 20);
            this.txtLow.TabIndex = 15;
            // 
            // txtHigh
            // 
            this.txtHigh.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtHigh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHigh.Enabled = false;
            this.txtHigh.Location = new System.Drawing.Point(281, 386);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.ReadOnly = true;
            this.txtHigh.Size = new System.Drawing.Size(59, 20);
            this.txtHigh.TabIndex = 16;
            // 
            // txtFeelsLike
            // 
            this.txtFeelsLike.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFeelsLike.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFeelsLike.Enabled = false;
            this.txtFeelsLike.Location = new System.Drawing.Point(366, 386);
            this.txtFeelsLike.Name = "txtFeelsLike";
            this.txtFeelsLike.ReadOnly = true;
            this.txtFeelsLike.Size = new System.Drawing.Size(105, 20);
            this.txtFeelsLike.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label9.Location = new System.Drawing.Point(57, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Wind";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label10.Location = new System.Drawing.Point(188, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Clouds";
            // 
            // txtWind
            // 
            this.txtWind.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtWind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWind.Enabled = false;
            this.txtWind.Location = new System.Drawing.Point(59, 456);
            this.txtWind.Name = "txtWind";
            this.txtWind.ReadOnly = true;
            this.txtWind.Size = new System.Drawing.Size(100, 20);
            this.txtWind.TabIndex = 20;
            // 
            // txtClouds
            // 
            this.txtClouds.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtClouds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClouds.Enabled = false;
            this.txtClouds.Location = new System.Drawing.Point(191, 456);
            this.txtClouds.Name = "txtClouds";
            this.txtClouds.ReadOnly = true;
            this.txtClouds.Size = new System.Drawing.Size(100, 20);
            this.txtClouds.TabIndex = 21;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(163, 502);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 42);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // WeatherAPIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(525, 577);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtClouds);
            this.Controls.Add(this.txtWind);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFeelsLike);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWeatherJSON);
            this.Controls.Add(this.btnWeatherXML);
            this.Name = "WeatherAPIForm";
            this.Text = "Weather API Application";
            this.Load += new System.EventHandler(this.WeatherAPIForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWeatherXML;
        private System.Windows.Forms.Button btnWeatherJSON;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.TextBox txtFeelsLike;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWind;
        private System.Windows.Forms.TextBox txtClouds;
        private System.Windows.Forms.Button btnClose;
    }
}

