namespace WeatherApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAmanecer = new System.Windows.Forms.Label();
            this.lblAtardecer = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPresion = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTemMax = new System.Windows.Forms.Label();
            this.lblTemMin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLon = new System.Windows.Forms.Label();
            this.lblLat = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(88, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciudad:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(138, 38);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(176, 20);
            this.txtCity.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(338, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.BackColor = System.Drawing.Color.Transparent;
            this.lblCondition.Location = new System.Drawing.Point(135, 218);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(27, 13);
            this.lblCondition.TabIndex = 3;
            this.lblCondition.Text = "N/A";
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.BackColor = System.Drawing.Color.Transparent;
            this.lblDetalles.Location = new System.Drawing.Point(135, 256);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(27, 13);
            this.lblDetalles.TabIndex = 4;
            this.lblDetalles.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(395, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sunrise:";
            // 
            // lblAmanecer
            // 
            this.lblAmanecer.AutoSize = true;
            this.lblAmanecer.BackColor = System.Drawing.Color.Transparent;
            this.lblAmanecer.Location = new System.Drawing.Point(446, 118);
            this.lblAmanecer.Name = "lblAmanecer";
            this.lblAmanecer.Size = new System.Drawing.Size(27, 13);
            this.lblAmanecer.TabIndex = 6;
            this.lblAmanecer.Text = "N/A";
            // 
            // lblAtardecer
            // 
            this.lblAtardecer.AutoSize = true;
            this.lblAtardecer.BackColor = System.Drawing.Color.Transparent;
            this.lblAtardecer.Location = new System.Drawing.Point(446, 154);
            this.lblAtardecer.Name = "lblAtardecer";
            this.lblAtardecer.Size = new System.Drawing.Size(27, 13);
            this.lblAtardecer.TabIndex = 8;
            this.lblAtardecer.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(397, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sunset:";
            // 
            // lblPresion
            // 
            this.lblPresion.AutoSize = true;
            this.lblPresion.BackColor = System.Drawing.Color.Transparent;
            this.lblPresion.Location = new System.Drawing.Point(446, 185);
            this.lblPresion.Name = "lblPresion";
            this.lblPresion.Size = new System.Drawing.Size(27, 13);
            this.lblPresion.TabIndex = 12;
            this.lblPresion.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(389, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Pressure:";
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.BackColor = System.Drawing.Color.Transparent;
            this.lblVelocidad.Location = new System.Drawing.Point(285, 218);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(27, 13);
            this.lblVelocidad.TabIndex = 10;
            this.lblVelocidad.Text = "N/A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(238, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Speed:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(46, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Temp_Max:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Temp_Min:";
            // 
            // lblTemMax
            // 
            this.lblTemMax.AutoSize = true;
            this.lblTemMax.BackColor = System.Drawing.Color.Transparent;
            this.lblTemMax.Location = new System.Drawing.Point(446, 218);
            this.lblTemMax.Name = "lblTemMax";
            this.lblTemMax.Size = new System.Drawing.Size(27, 13);
            this.lblTemMax.TabIndex = 16;
            this.lblTemMax.Text = "N/A";
            // 
            // lblTemMin
            // 
            this.lblTemMin.AutoSize = true;
            this.lblTemMin.BackColor = System.Drawing.Color.Transparent;
            this.lblTemMin.Location = new System.Drawing.Point(446, 256);
            this.lblTemMin.Name = "lblTemMin";
            this.lblTemMin.Size = new System.Drawing.Size(27, 13);
            this.lblTemMin.TabIndex = 17;
            this.lblTemMin.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Lon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Lat:";
            // 
            // lblLon
            // 
            this.lblLon.AutoSize = true;
            this.lblLon.BackColor = System.Drawing.Color.Transparent;
            this.lblLon.Location = new System.Drawing.Point(284, 154);
            this.lblLon.Name = "lblLon";
            this.lblLon.Size = new System.Drawing.Size(27, 13);
            this.lblLon.TabIndex = 20;
            this.lblLon.Text = "N/A";
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.BackColor = System.Drawing.Color.Transparent;
            this.lblLat.Location = new System.Drawing.Point(284, 189);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(27, 13);
            this.lblLat.TabIndex = 21;
            this.lblLat.Text = "N/A";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(75, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Condition:";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(86, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Details:";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(284, 118);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(27, 13);
            this.lblTemp.TabIndex = 25;
            this.lblTemp.Text = "N/A";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(106, 93);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(27, 13);
            this.lblCiudad.TabIndex = 24;
            this.lblCiudad.Text = "N/A";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(208, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Temperature:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(73, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "City:";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(285, 256);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(27, 13);
            this.lblHumidity.TabIndex = 27;
            this.lblHumidity.Text = "N/A";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(229, 256);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Humidity:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(528, 437);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblLat);
            this.Controls.Add(this.lblLon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTemMin);
            this.Controls.Add(this.lblTemMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPresion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblVelocidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblAtardecer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAmanecer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Weather App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAmanecer;
        private System.Windows.Forms.Label lblAtardecer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPresion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblVelocidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTemMax;
        private System.Windows.Forms.Label lblTemMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblLon;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label label12;
    }
}

