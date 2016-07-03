namespace Grafic
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.buttonCreateGraphic = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Kk_tab = new System.Windows.Forms.Label();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_kk = new System.Windows.Forms.TextBox();
            this.buttonCreateParametricGarphic = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMin_X = new System.Windows.Forms.TextBox();
            this.textBoxMax_X = new System.Windows.Forms.TextBox();
            this.textBoxMax_Y = new System.Windows.Forms.TextBox();
            this.textBoxMin_Y = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.changeScale = new System.Windows.Forms.Button();
            this.buttonPickGrid = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textboxWayToFile = new System.Windows.Forms.TextBox();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.textBoxParametrT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateGraphic
            // 
            this.buttonCreateGraphic.Location = new System.Drawing.Point(210, 4);
            this.buttonCreateGraphic.Name = "buttonCreateGraphic";
            this.buttonCreateGraphic.Size = new System.Drawing.Size(131, 36);
            this.buttonCreateGraphic.TabIndex = 0;
            this.buttonCreateGraphic.Text = "Побудувати графік явно заданої функці\r\n";
            this.buttonCreateGraphic.UseVisualStyleBackColor = true;
            this.buttonCreateGraphic.Click += new System.EventHandler(this.buttonCreateGraphic_Click);
            // 
            // chart1
            // 
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(390, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(392, 260);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Межі табулювання ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "b:";
            // 
            // Kk_tab
            // 
            this.Kk_tab.AutoSize = true;
            this.Kk_tab.Location = new System.Drawing.Point(12, 51);
            this.Kk_tab.Name = "Kk_tab";
            this.Kk_tab.Size = new System.Drawing.Size(131, 13);
            this.Kk_tab.TabIndex = 4;
            this.Kk_tab.Text = "К-ть точок табулювання:\r\n";
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(145, 1);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(43, 20);
            this.textBox_a.TabIndex = 5;
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(145, 25);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(43, 20);
            this.textBox_b.TabIndex = 6;
            // 
            // textBox_kk
            // 
            this.textBox_kk.Location = new System.Drawing.Point(145, 49);
            this.textBox_kk.Name = "textBox_kk";
            this.textBox_kk.Size = new System.Drawing.Size(43, 20);
            this.textBox_kk.TabIndex = 7;
            // 
            // buttonCreateParametricGarphic
            // 
            this.buttonCreateParametricGarphic.Location = new System.Drawing.Point(210, 51);
            this.buttonCreateParametricGarphic.Name = "buttonCreateParametricGarphic";
            this.buttonCreateParametricGarphic.Size = new System.Drawing.Size(131, 36);
            this.buttonCreateParametricGarphic.TabIndex = 8;
            this.buttonCreateParametricGarphic.Text = "Побудувати графік параметрично заданої функці\r\n\r\n";
            this.buttonCreateParametricGarphic.UseVisualStyleBackColor = true;
            this.buttonCreateParametricGarphic.Click += new System.EventHandler(this.buttonCreateParametricGarphic_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Масштаб";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "<  x  <";
            // 
            // textBoxMin_X
            // 
            this.textBoxMin_X.Location = new System.Drawing.Point(244, 145);
            this.textBoxMin_X.Name = "textBoxMin_X";
            this.textBoxMin_X.Size = new System.Drawing.Size(29, 20);
            this.textBoxMin_X.TabIndex = 12;
            // 
            // textBoxMax_X
            // 
            this.textBoxMax_X.Location = new System.Drawing.Point(321, 149);
            this.textBoxMax_X.Name = "textBoxMax_X";
            this.textBoxMax_X.Size = new System.Drawing.Size(29, 20);
            this.textBoxMax_X.TabIndex = 13;
            // 
            // textBoxMax_Y
            // 
            this.textBoxMax_Y.Location = new System.Drawing.Point(321, 188);
            this.textBoxMax_Y.Name = "textBoxMax_Y";
            this.textBoxMax_Y.Size = new System.Drawing.Size(29, 20);
            this.textBoxMax_Y.TabIndex = 16;
            // 
            // textBoxMin_Y
            // 
            this.textBoxMin_Y.Location = new System.Drawing.Point(244, 188);
            this.textBoxMin_Y.Name = "textBoxMin_Y";
            this.textBoxMin_Y.Size = new System.Drawing.Size(29, 20);
            this.textBoxMin_Y.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "<  y  <";
            // 
            // changeScale
            // 
            this.changeScale.Location = new System.Drawing.Point(242, 226);
            this.changeScale.Name = "changeScale";
            this.changeScale.Size = new System.Drawing.Size(124, 60);
            this.changeScale.TabIndex = 19;
            this.changeScale.Text = "Змінити масштаб";
            this.changeScale.UseVisualStyleBackColor = true;
            this.changeScale.Click += new System.EventHandler(this.changeScale_Click);
            // 
            // buttonPickGrid
            // 
            this.buttonPickGrid.Location = new System.Drawing.Point(404, 285);
            this.buttonPickGrid.Name = "buttonPickGrid";
            this.buttonPickGrid.Size = new System.Drawing.Size(147, 60);
            this.buttonPickGrid.TabIndex = 20;
            this.buttonPickGrid.Text = "Забрати/\r\nдобавити сітку";
            this.buttonPickGrid.UseVisualStyleBackColor = true;
            this.buttonPickGrid.Click += new System.EventHandler(this.buttonPickGrid_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_X,
            this.Column_Y});
            this.dataGridView1.Location = new System.Drawing.Point(2, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(186, 184);
            this.dataGridView1.TabIndex = 21;
            // 
            // Column_X
            // 
            this.Column_X.HeaderText = "x";
            this.Column_X.Name = "Column_X";
            this.Column_X.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_X.Width = 74;
            // 
            // Column_Y
            // 
            this.Column_Y.HeaderText = "f(x)";
            this.Column_Y.Name = "Column_Y";
            this.Column_Y.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_Y.Width = 74;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(108, 327);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(0, 13);
            this.labelMin.TabIndex = 22;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(241, 327);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(0, 13);
            this.labelMax.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-1, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 26);
            this.label9.TabIndex = 24;
            this.label9.Text = " Параметр  для параметричної функції :\r\n\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Мін.знач.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Макс. знач.:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(574, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Вкажіть шлях :\r\n";
            // 
            // textboxWayToFile
            // 
            this.textboxWayToFile.Location = new System.Drawing.Point(661, 289);
            this.textboxWayToFile.Name = "textboxWayToFile";
            this.textboxWayToFile.Size = new System.Drawing.Size(97, 20);
            this.textboxWayToFile.TabIndex = 29;
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.Location = new System.Drawing.Point(619, 318);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(154, 31);
            this.buttonSaveData.TabIndex = 30;
            this.buttonSaveData.Text = "Зберегти графік";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // textBoxParametrT
            // 
            this.textBoxParametrT.Location = new System.Drawing.Point(55, 91);
            this.textBoxParametrT.Name = "textBoxParametrT";
            this.textBoxParametrT.Size = new System.Drawing.Size(100, 20);
            this.textBoxParametrT.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 353);
            this.Controls.Add(this.textBoxParametrT);
            this.Controls.Add(this.buttonSaveData);
            this.Controls.Add(this.textboxWayToFile);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonPickGrid);
            this.Controls.Add(this.changeScale);
            this.Controls.Add(this.textBoxMax_Y);
            this.Controls.Add(this.textBoxMin_Y);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMax_X);
            this.Controls.Add(this.textBoxMin_X);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCreateParametricGarphic);
            this.Controls.Add(this.textBox_kk);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.Kk_tab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonCreateGraphic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateGraphic;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Kk_tab;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_kk;
        private System.Windows.Forms.Button buttonCreateParametricGarphic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMin_X;
        private System.Windows.Forms.TextBox textBoxMax_X;
        private System.Windows.Forms.TextBox textBoxMax_Y;
        private System.Windows.Forms.TextBox textBoxMin_Y;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button changeScale;
        private System.Windows.Forms.Button buttonPickGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Y;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textboxWayToFile;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.TextBox textBoxParametrT;
    }
}

