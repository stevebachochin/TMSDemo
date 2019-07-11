using System;

namespace $safeprojectname$
{
    partial class Navigation
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnGoToAdd = new System.Windows.Forms.Button();
            this.btnGoToFillOrCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnInitalize = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoToAdd
            // 
            this.btnGoToAdd.Location = new System.Drawing.Point(453, 87);
            this.btnGoToAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoToAdd.Name = "btnGoToAdd";
            this.btnGoToAdd.Size = new System.Drawing.Size(75, 35);
            this.btnGoToAdd.TabIndex = 1;
            this.btnGoToAdd.Text = "Add an account";
            this.btnGoToAdd.UseVisualStyleBackColor = true;
            this.btnGoToAdd.Click += new System.EventHandler(this.btnGoToAdd_Click);
            // 
            // btnGoToFillOrCancel
            // 
            this.btnGoToFillOrCancel.Location = new System.Drawing.Point(453, 126);
            this.btnGoToFillOrCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoToFillOrCancel.Name = "btnGoToFillOrCancel";
            this.btnGoToFillOrCancel.Size = new System.Drawing.Size(75, 35);
            this.btnGoToFillOrCancel.TabIndex = 2;
            this.btnGoToFillOrCancel.Text = "Fill or Cancel an order";
            this.btnGoToFillOrCancel.UseVisualStyleBackColor = true;
            this.btnGoToFillOrCancel.Click += new System.EventHandler(this.btnGoToFillOrCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(453, 177);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 19);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(43, 12);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series7.Legend = "Legend1";
            series7.Name = "Cows";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series8.Legend = "Legend1";
            series8.Name = "Bulls";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series9.Legend = "Legend1";
            series9.Name = "Calves";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(386, 492);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // btnInitalize
            // 
            this.btnInitalize.Location = new System.Drawing.Point(453, 50);
            this.btnInitalize.Name = "btnInitalize";
            this.btnInitalize.Size = new System.Drawing.Size(75, 23);
            this.btnInitalize.TabIndex = 5;
            this.btnInitalize.Text = "Refresh";
            this.btnInitalize.UseVisualStyleBackColor = true;
            this.btnInitalize.Click += new System.EventHandler(this.btnInitalize_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(647, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 197);
            this.dataGridView1.TabIndex = 6;
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 648);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnInitalize);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoToFillOrCancel);
            this.Controls.Add(this.btnGoToAdd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Navigation";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.FillOrCancel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Button btnGoToAdd;
        private System.Windows.Forms.Button btnGoToFillOrCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnInitalize;
        private System.Windows.Forms.DataGridView dataGridView1;
    }


}

