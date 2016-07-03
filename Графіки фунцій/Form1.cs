using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grafic
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int flagGraphic = 0;//змінна для перевірки який графік намальовано
        private void buttonCreateGraphic_Click(object sender, EventArgs e)
        {
            flagGraphic = 1;
            double  x, y,
           promizhok,
            a = Convert.ToDouble(textBox_a.Text),
            b = Convert.ToDouble(textBox_b.Text),
            k = Convert.ToDouble(textBox_kk.Text);
           promizhok = (Math.Abs(a) + Math.Abs(b)) / k;
           
            dataGridView1.Rows.Clear();
            chart1.ChartAreas.Clear();
            chart1.Series.Clear();

            chart1.ChartAreas.Add("graphic");
            chart1.Series.Add("y = f(x)");
            chart1.Series[0].ChartArea = "graphic";

            //підписуємо осі
            chart1.ChartAreas[0].AxisX.Title = "x";
            chart1.ChartAreas[0].AxisY.Title = "f(x)";

            //переміщуємо підписи
            chart1.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Far;
            chart1.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Far;

            //стрілки на кінцях 
            chart1.ChartAreas[0].AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chart1.ChartAreas[0].AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;

            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart1.Series[0].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            //екстремуми функції x=x^(1/x)
            double ymin, ymax;
            ymin = Math.Pow(a, 1 /2);
            ymax = Math.Pow(b, 1 / 2);
            for (x = a; x <=b; x +=promizhok)
            {              
                y = Math.Pow(x, 1 / x);
                if (y < ymin)
                {
                    ymin = y;
                }
                if (y > ymax)
                {
                    ymax = y;
                }
                chart1.Series[0].Points.AddXY(x, y);
                dataGridView1.Rows.Add(x, y);
               
            }
            labelMin.Text = Convert.ToString(ymin);
            labelMax.Text = Convert.ToString(ymax);
        }
        //змінюємо масштаб
        private void changeScale_Click(object sender, EventArgs e)
        {
            if (flagGraphic == 1)
            {
                chart1.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(textBoxMax_X.Text);
                chart1.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(textBoxMin_X.Text);
                chart1.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(textBoxMax_Y.Text);
                chart1.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(textBoxMin_Y.Text);
            }
            if (flagGraphic == 2)
            {
                chart1.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(textBoxMax_X.Text);
                chart1.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(textBoxMin_X.Text);
                chart1.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(textBoxMax_Y.Text);
                chart1.ChartAreas[1].AxisY.Minimum = Convert.ToDouble(textBoxMin_Y.Text); 
                chart1.ChartAreas[1].AxisX.Maximum = Convert.ToDouble(textBoxMax_X.Text);
                chart1.ChartAreas[1].AxisX.Minimum = Convert.ToDouble(textBoxMin_X.Text);
                chart1.ChartAreas[1].AxisY.Maximum = Convert.ToDouble(textBoxMax_Y.Text);
                chart1.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(textBoxMin_Y.Text);
            }
        }
        // сітка
        static int flag = 0;
        private void buttonPickGrid_Click(object sender, EventArgs e)
        {
            if (flagGraphic == 2)
            {
                if (flag == 0)
                {
                    chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                    chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                    chart1.ChartAreas[1].AxisX.MajorGrid.Enabled = false;
                    chart1.ChartAreas[1].AxisY.MajorGrid.Enabled = false;

                    flag++;
                }
                else
                {
                    chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
                    chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
                    chart1.ChartAreas[1].AxisX.MajorGrid.Enabled = true;
                    chart1.ChartAreas[1].AxisY.MajorGrid.Enabled = true;

                    flag--;
                }
            }
            else
            {
                if (flagGraphic == 1)
                {
                    if (flag == 0)
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        flag++;
                    }
                    else
                    {
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
                        flag--;
                    }
                }
            }
        }
        
        private void buttonCreateParametricGarphic_Click(object sender, EventArgs e)
        {   

            flagGraphic = 2;
            double
            x, y,
           promizhok,//проміжок розбиття

            a = Convert.ToDouble(textBox_a.Text),
            b = Convert.ToDouble(textBox_b.Text),
            k = Convert.ToDouble(textBox_kk.Text),
            t = Convert.ToDouble(textBoxParametrT.Text),

            ymin = (a - 1) * (a - 1) / 4,
            ymax = (b - 1) * (b - 1) / 4;

           promizhok = (Math.Abs(a) + Math.Abs(b)) / k;

            dataGridView1.Rows.Clear();
            chart1.ChartAreas.Clear();
            chart1.Series.Clear();
            
            chart1.ChartAreas.Add("parametric");
            chart1.ChartAreas.Add("graphic");
            chart1.Series.Add("y = f(x)");
            chart1.Series.Add("x = f(t)");
            chart1.Series.Add("y = f(t)");
            
            //підписуваня осей координат
            chart1.ChartAreas[0].AxisX.Title = "x";
            chart1.ChartAreas[0].AxisY.Title = "f(x)";
            chart1.ChartAreas[0].AxisX.Title = "t";
            chart1.ChartAreas[0].AxisY.Title = "f(t)";
            
            //переміщення підписів 
            chart1.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Far;
            chart1.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Far;
            chart1.ChartAreas[1].AxisX.TitleAlignment = StringAlignment.Far;
            chart1.ChartAreas[1].AxisY.TitleAlignment = StringAlignment.Far;
            
            //малювання стрілок на кінцях осей координат
            chart1.ChartAreas[0].AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chart1.ChartAreas[0].AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chart1.ChartAreas[1].AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chart1.ChartAreas[1].AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            
            //записування серій в Chart Area 
            chart1.Series[0].ChartArea = "parametric";
            chart1.Series[1].ChartArea = "graphic";
            chart1.Series[2].ChartArea = "graphic";

            //ініціалізація серій
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart1.Series[0].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[1].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart1.Series[1].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[2].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart1.Series[2].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            //Параметрична функція
            for (t = a; t <= b; t +=promizhok)
            {
                x = (t + 1) * (t + 1) / 4;
                y = (t - 1) * (t - 1) / 4;
                chart1.Series[0].Points.AddXY(x , y);
                chart1.Series[1].Points.AddXY(t,  x);
                chart1.Series[2].Points.AddXY(t, y);

                if (y < ymin)
                {
                    ymin = y;
                }
                if (y > ymax)
                {
                    ymax = y;
                }
     
                dataGridView1.Rows.Add(x, y);
            }
            labelMin.Text = Convert.ToString(ymin);
            labelMax.Text = Convert.ToString(ymax);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
            textBox_a.Text = "0";
            textBox_b.Text = "10";
            textBox_kk.Text = "10";
            textBoxParametrT.Text = "5";
            textBoxMin_X.Text = "-10";
            textBoxMax_X.Text = "10";
            textBoxMin_Y.Text = "-10";
            textBoxMax_Y.Text = "10";
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            string _FileName = textboxWayToFile.Text;
            chart1.SaveImage(_FileName + "chartDiagram.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            using (System.IO.StreamWriter textFile = new System.IO.StreamWriter(_FileName + "C:\\Users\\Назар\\Desktop\\dataGridView.txt"))
            {
                textFile.WriteLine("x\t\t\tf(x)");
                textFile.WriteLine("\n");
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {   
                   
                    textFile.Write(dataGridView1[0, i].Value.ToString() + "\t\t");
                    if (dataGridView1[0, i].Value.ToString().Length < 10) textFile.Write("\t");
                    textFile.WriteLine(dataGridView1[1, i].Value.ToString());
                }
            }
        }

    }
}
