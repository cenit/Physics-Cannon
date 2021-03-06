﻿namespace Progetto_Fisica
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "0,0");
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Input_Angle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Input_Target_X = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Input_Target_Y = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Output_Speed = new System.Windows.Forms.Label();
            this.Input_Bullet_Diameter = new System.Windows.Forms.Label();
            this.Output_Height = new System.Windows.Forms.Label();
            this.Output_Energy = new System.Windows.Forms.Label();
            this.Output_Distance = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Input_Time = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Input_Speed = new System.Windows.Forms.TextBox();
            this.Input_Mass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Input_Target_Diameter = new System.Windows.Forms.TextBox();
            this.Output_Target_Hit = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Input_Air_Speed = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Input_Angle
            // 
            this.Input_Angle.Location = new System.Drawing.Point(380, 3);
            this.Input_Angle.Name = "Input_Angle";
            this.Input_Angle.Size = new System.Drawing.Size(126, 31);
            this.Input_Angle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Angolo (in gradi)";
            // 
            // Input_Target_X
            // 
            this.Input_Target_X.Location = new System.Drawing.Point(380, 145);
            this.Input_Target_X.Name = "Input_Target_X";
            this.Input_Target_X.Size = new System.Drawing.Size(126, 31);
            this.Input_Target_X.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(960, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Distanza Percorsa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tempo Totale (in secondi)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(960, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "BERSAGLIO COLPITO ?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Distanza bersaglio (metri)";
            // 
            // Input_Target_Y
            // 
            this.Input_Target_Y.Location = new System.Drawing.Point(380, 209);
            this.Input_Target_Y.Name = "Input_Target_Y";
            this.Input_Target_Y.Size = new System.Drawing.Size(126, 31);
            this.Input_Target_Y.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Altezza bersaglio (metri)";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.4551F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.5449F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 478F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 494F));
            this.tableLayoutPanel1.Controls.Add(this.Output_Speed, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.Input_Bullet_Diameter, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.Output_Height, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Output_Energy, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Output_Distance, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.Input_Time, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Input_Angle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Input_Target_X, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Input_Target_Y, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Input_Speed, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Input_Mass, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.Input_Target_Diameter, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.Output_Target_Hit, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label13, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.Input_Air_Speed, 3, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(52, 933);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.28205F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.71795F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1930, 539);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // Output_Speed
            // 
            this.Output_Speed.AutoSize = true;
            this.Output_Speed.Location = new System.Drawing.Point(1438, 206);
            this.Output_Speed.Name = "Output_Speed";
            this.Output_Speed.Size = new System.Drawing.Size(33, 25);
            this.Output_Speed.TabIndex = 21;
            this.Output_Speed.Text = "---";
            // 
            // Input_Bullet_Diameter
            // 
            this.Input_Bullet_Diameter.AutoSize = true;
            this.Input_Bullet_Diameter.Location = new System.Drawing.Point(380, 469);
            this.Input_Bullet_Diameter.Name = "Input_Bullet_Diameter";
            this.Input_Bullet_Diameter.Size = new System.Drawing.Size(33, 25);
            this.Input_Bullet_Diameter.TabIndex = 17;
            this.Input_Bullet_Diameter.Text = "---";
            // 
            // Output_Height
            // 
            this.Output_Height.AutoSize = true;
            this.Output_Height.Location = new System.Drawing.Point(1438, 142);
            this.Output_Height.Name = "Output_Height";
            this.Output_Height.Size = new System.Drawing.Size(33, 25);
            this.Output_Height.TabIndex = 20;
            this.Output_Height.Text = "---";
            // 
            // Output_Energy
            // 
            this.Output_Energy.AutoSize = true;
            this.Output_Energy.Location = new System.Drawing.Point(1438, 0);
            this.Output_Energy.Name = "Output_Energy";
            this.Output_Energy.Size = new System.Drawing.Size(33, 25);
            this.Output_Energy.TabIndex = 18;
            this.Output_Energy.Text = "---";
            // 
            // Output_Distance
            // 
            this.Output_Distance.AutoSize = true;
            this.Output_Distance.Location = new System.Drawing.Point(1438, 73);
            this.Output_Distance.Name = "Output_Distance";
            this.Output_Distance.Size = new System.Drawing.Size(33, 25);
            this.Output_Distance.TabIndex = 19;
            this.Output_Distance.Text = "---";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 469);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(188, 25);
            this.label14.TabIndex = 32;
            this.label14.Text = "Diametro Proiettile";
            // 
            // Input_Time
            // 
            this.Input_Time.AutoSize = true;
            this.Input_Time.Location = new System.Drawing.Point(380, 73);
            this.Input_Time.Name = "Input_Time";
            this.Input_Time.Size = new System.Drawing.Size(33, 25);
            this.Input_Time.TabIndex = 17;
            this.Input_Time.Text = "---";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(960, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Energia Cinetica";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Velocità (m/s)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(232, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Massa Proiettile (in kg)";
            // 
            // Input_Speed
            // 
            this.Input_Speed.Location = new System.Drawing.Point(380, 267);
            this.Input_Speed.Name = "Input_Speed";
            this.Input_Speed.Size = new System.Drawing.Size(126, 31);
            this.Input_Speed.TabIndex = 23;
            // 
            // Input_Mass
            // 
            this.Input_Mass.Location = new System.Drawing.Point(380, 333);
            this.Input_Mass.Name = "Input_Mass";
            this.Input_Mass.Size = new System.Drawing.Size(126, 31);
            this.Input_Mass.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(960, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Altezza Massima Raggiunta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(960, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Velocità finale";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 407);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(194, 25);
            this.label12.TabIndex = 27;
            this.label12.Text = "Diametro Bersaglio";
            // 
            // Input_Target_Diameter
            // 
            this.Input_Target_Diameter.Location = new System.Drawing.Point(380, 410);
            this.Input_Target_Diameter.Name = "Input_Target_Diameter";
            this.Input_Target_Diameter.Size = new System.Drawing.Size(126, 31);
            this.Input_Target_Diameter.TabIndex = 31;
            // 
            // Output_Target_Hit
            // 
            this.Output_Target_Hit.AutoSize = true;
            this.Output_Target_Hit.Location = new System.Drawing.Point(1438, 469);
            this.Output_Target_Hit.Name = "Output_Target_Hit";
            this.Output_Target_Hit.Size = new System.Drawing.Size(43, 25);
            this.Output_Target_Hit.TabIndex = 34;
            this.Output_Target_Hit.Text = "NO";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(960, 264);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(271, 25);
            this.label13.TabIndex = 35;
            this.label13.Text = "Aria (componente Velocità)";
            // 
            // Input_Air_Speed
            // 
            this.Input_Air_Speed.Location = new System.Drawing.Point(1438, 267);
            this.Input_Air_Speed.Name = "Input_Air_Speed";
            this.Input_Air_Speed.Size = new System.Drawing.Size(138, 31);
            this.Input_Air_Speed.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1566, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 116);
            this.button1.TabIndex = 17;
            this.button1.Text = "Avvia Simulazione";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1624, 553);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 130);
            this.button2.TabIndex = 18;
            this.button2.Text = "Genera Posizione Bersaglio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Graph
            // 
            chartArea3.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Graph.Legends.Add(legend3);
            this.Graph.Location = new System.Drawing.Point(3, -2);
            this.Graph.Name = "Graph";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series9.Legend = "Legend1";
            series9.Name = "Series_Cannon";
            series9.Points.Add(dataPoint3);
            series9.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series9.YValuesPerPoint = 2;
            series9.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "Series_Curve";
            series10.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series10.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series11.Legend = "Legend1";
            series11.Name = "Series_Target";
            series11.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series11.YValuesPerPoint = 2;
            series11.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series12.Legend = "Legend1";
            series12.Name = "Series_Set_Axis_Scale";
            this.Graph.Series.Add(series9);
            this.Graph.Series.Add(series10);
            this.Graph.Series.Add(series11);
            this.Graph.Series.Add(series12);
            this.Graph.Size = new System.Drawing.Size(1930, 766);
            this.Graph.TabIndex = 4;
            this.Graph.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Graph);
            this.panel1.Location = new System.Drawing.Point(52, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1930, 771);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2024, 1648);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input_Angle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Input_Target_X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Input_Target_Y;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Input_Speed;
        private System.Windows.Forms.TextBox Input_Mass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Output_Target_Hit;
        private System.Windows.Forms.Label Input_Bullet_Diameter;
        private System.Windows.Forms.Label Input_Time;
        private System.Windows.Forms.TextBox Input_Target_Diameter;
        private System.Windows.Forms.Label Output_Energy;
        private System.Windows.Forms.Label Output_Distance;
        private System.Windows.Forms.Label Output_Height;
        private System.Windows.Forms.Label Output_Speed;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Input_Air_Speed;
    }
}

