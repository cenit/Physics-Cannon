namespace Progetto_Fisica
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "0,0");
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Input_Angle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Output_Distance = new System.Windows.Forms.TextBox();
            this.Input_Time = new System.Windows.Forms.TextBox();
            this.Input_Target_X = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Input_Target_Y = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Output_Time = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Input_Speed = new System.Windows.Forms.TextBox();
            this.Input_Mass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Output_Height = new System.Windows.Forms.TextBox();
            this.Output_Speed = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Input_Time_Rise = new System.Windows.Forms.TextBox();
            this.Input_Time_Fall = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Output_Target_Hit = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Input_Angle
            // 
            this.Input_Angle.Location = new System.Drawing.Point(389, 3);
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
            // Output_Distance
            // 
            this.Output_Distance.Location = new System.Drawing.Point(1459, 77);
            this.Output_Distance.Name = "Output_Distance";
            this.Output_Distance.Size = new System.Drawing.Size(126, 31);
            this.Output_Distance.TabIndex = 6;
            // 
            // Input_Time
            // 
            this.Input_Time.Location = new System.Drawing.Point(389, 77);
            this.Input_Time.Name = "Input_Time";
            this.Input_Time.Size = new System.Drawing.Size(126, 31);
            this.Input_Time.TabIndex = 7;
            // 
            // Input_Target_X
            // 
            this.Input_Target_X.Location = new System.Drawing.Point(389, 147);
            this.Input_Target_X.Name = "Input_Target_X";
            this.Input_Target_X.Size = new System.Drawing.Size(126, 31);
            this.Input_Target_X.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(981, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Distanza Percorsa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tempo Totale (in secondi)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(981, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "BERSAGLIO COLPITO ?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Distanza bersaglio (metri)";
            // 
            // Input_Target_Y
            // 
            this.Input_Target_Y.Location = new System.Drawing.Point(389, 211);
            this.Input_Target_Y.Name = "Input_Target_Y";
            this.Input_Target_Y.Size = new System.Drawing.Size(126, 31);
            this.Input_Target_Y.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Altezza bersaglio (metri)";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.4551F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.5449F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 478F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 473F));
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Input_Angle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Output_Distance, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Output_Time, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Input_Time, 1, 1);
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
            this.tableLayoutPanel1.Controls.Add(this.Output_Height, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Output_Speed, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label13, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox12, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.Input_Time_Rise, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.Output_Target_Hit, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.Input_Time_Fall, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(53, 1008);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.28205F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.71795F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1930, 539);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 470);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(184, 25);
            this.label14.TabIndex = 32;
            this.label14.Text = "Tempo di Discesa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(981, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Energia Cinetica";
            // 
            // Output_Time
            // 
            this.Output_Time.Location = new System.Drawing.Point(1459, 3);
            this.Output_Time.Name = "Output_Time";
            this.Output_Time.Size = new System.Drawing.Size(126, 31);
            this.Output_Time.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Velocità (m/s)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(232, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Massa Proiettile (in kg)";
            // 
            // Input_Speed
            // 
            this.Input_Speed.Location = new System.Drawing.Point(389, 269);
            this.Input_Speed.Name = "Input_Speed";
            this.Input_Speed.Size = new System.Drawing.Size(126, 31);
            this.Input_Speed.TabIndex = 23;
            // 
            // Input_Mass
            // 
            this.Input_Mass.Location = new System.Drawing.Point(389, 335);
            this.Input_Mass.Name = "Input_Mass";
            this.Input_Mass.Size = new System.Drawing.Size(126, 31);
            this.Input_Mass.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(981, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Altezza Massima Raggiunta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(981, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Velocità finale";
            // 
            // Output_Height
            // 
            this.Output_Height.Location = new System.Drawing.Point(1459, 147);
            this.Output_Height.Name = "Output_Height";
            this.Output_Height.Size = new System.Drawing.Size(126, 31);
            this.Output_Height.TabIndex = 17;
            // 
            // Output_Speed
            // 
            this.Output_Speed.Location = new System.Drawing.Point(1459, 211);
            this.Output_Speed.Name = "Output_Speed";
            this.Output_Speed.Size = new System.Drawing.Size(126, 31);
            this.Output_Speed.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(981, 332);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 25);
            this.label13.TabIndex = 28;
            this.label13.Text = "--";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(1459, 335);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(126, 31);
            this.textBox12.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 408);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 25);
            this.label12.TabIndex = 27;
            this.label12.Text = "Tempo di Salita";
            // 
            // Input_Time_Rise
            // 
            this.Input_Time_Rise.Location = new System.Drawing.Point(389, 411);
            this.Input_Time_Rise.Name = "Input_Time_Rise";
            this.Input_Time_Rise.Size = new System.Drawing.Size(126, 31);
            this.Input_Time_Rise.TabIndex = 31;
            // 
            // Input_Time_Fall
            // 
            this.Input_Time_Fall.Location = new System.Drawing.Point(389, 473);
            this.Input_Time_Fall.Name = "Input_Time_Fall";
            this.Input_Time_Fall.Size = new System.Drawing.Size(126, 31);
            this.Input_Time_Fall.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1657, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 62);
            this.button1.TabIndex = 17;
            this.button1.Text = "Draw line";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1657, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 62);
            this.button2.TabIndex = 18;
            this.button2.Text = "Hit Target ?";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Graph
            // 
            chartArea1.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Graph.Legends.Add(legend1);
            this.Graph.Location = new System.Drawing.Point(3, -1);
            this.Graph.Name = "Graph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series1.Legend = "Legend1";
            series1.Name = "Series_Cannon";
            series1.Points.Add(dataPoint1);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValuesPerPoint = 2;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series_Curve";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series3.Legend = "Legend1";
            series3.Name = "Series_Target";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.YValuesPerPoint = 2;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Legend = "Legend1";
            series4.Name = "Series_Set_Axis_Scale";
            this.Graph.Series.Add(series1);
            this.Graph.Series.Add(series2);
            this.Graph.Series.Add(series3);
            this.Graph.Series.Add(series4);
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
            this.panel1.Location = new System.Drawing.Point(53, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1930, 770);
            this.panel1.TabIndex = 4;
            // 
            // Output_Target_Hit
            // 
            this.Output_Target_Hit.AutoSize = true;
            this.Output_Target_Hit.Location = new System.Drawing.Point(1459, 470);
            this.Output_Target_Hit.Name = "Output_Target_Hit";
            this.Output_Target_Hit.Size = new System.Drawing.Size(43, 25);
            this.Output_Target_Hit.TabIndex = 34;
            this.Output_Target_Hit.Text = "NO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2474, 1743);
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

        }

        #endregion

        private System.Windows.Forms.TextBox Input_Angle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Output_Distance;
        private System.Windows.Forms.TextBox Input_Time;
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
        private System.Windows.Forms.TextBox Output_Speed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Output_Height;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Input_Speed;
        private System.Windows.Forms.TextBox Input_Mass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Output_Time;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox Input_Time_Rise;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Input_Time_Fall;
        private System.Windows.Forms.Label Output_Target_Hit;
    }
}

