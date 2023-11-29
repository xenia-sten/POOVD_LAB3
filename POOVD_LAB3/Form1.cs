using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace POOVD_LAB3
{
    public partial class Form1 : Form
    {
        bool isHidden = false;
        double D = 8;
        double B;
        double N;

        public Form1()
        {
            InitializeComponent();
            B = 0;
            N = 1;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Interval = 1;
            chart1.Series[0].BorderWidth = 3;
            chart1.Series[0].Color = Color.Red;
            chart1.Series[1].Color = Color.Black;
            chart1.Series[1].BorderWidth = 3;
        }

        private void NNumeric_ValueChanged(object sender, EventArgs e)
        {
            N = (double)NNumeric.Value;
        }

        private void BIntNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (BIntNumeric.Value == BIntNumeric.Maximum || BIntNumeric.Value == BIntNumeric.Minimum)
            {
                B = (double)BIntNumeric.Value;
                DotLabel.Hide();
                BFloatNumeric.Value = 0;
                BFloatNumeric.Hide();
                isHidden = true;
            }
            else
            {
                if (isHidden)
                {
                    isHidden = false;
                    DotLabel.Show();
                    BFloatNumeric.Show();
                }
                B = (double)BIntNumeric.Value < 0 ? (double)BIntNumeric.Value - (double)BFloatNumeric.Value * 0.1 : (double)BIntNumeric.Value + (double)BFloatNumeric.Value * 0.1;
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            /*Проверка параметров на адекватность*/
            if(Math.Abs(B / N) >= 1)
            {
                MessageBox.Show("Неразумные параметры, введите параметры с условием |B/N| < 1", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /*Очищаем график*/
            chart1.Series[1].Points.Clear();
            chart1.Series[0].Points.Clear();
            List<double> pzsL = new List<double>();//список левых границ ПЗС ячеек
            List<double> pzsR = new List<double>();//список правых границ ПЗС ячеек
            double h = (1 + (B / N)) * D;//величина шага луча
            int L;  //Начало первой ПЗС ячейкки
            int yCount;//Кол-во рассматриваемых лучей
            if(B == 0)//случай отсутствия смаза 
            {
                L = (int)D;             
                yCount = 2 * (int)D  + 1;
            }
            else if(B > 0)//случай положительного смаза
            {
                
                yCount = (int)(D * 3 + D * (B - 1)) + 1;
                L = yCount - (int)D - 1;
            }
            else//случай отрицательного смаза
            {
                L = (int)D;
                yCount = (int)(D * 3 + D * (-B - 1)) + 1;
            }
            for(int i = 0; i < N; i++)
            {
                pzsL.Add(L + D * i);
                pzsR.Add(L + D * i + D);
            }
            double[] TimeExp = new double[yCount];
            for(int y = 0; y < yCount; y++)
            {
                double H = y; 
                for(int n = 0; n < N; n++)
                {
                    H += h;
                    //l - длина пересечения расстояния преодолеваемого зарядом за такт и расстоянием
                    //преодолеваемым рассматриваемым лучём за такт
                    double l = Math.Max(Math.Min(H, pzsR[n]) - Math.Max(H - h, pzsL[n]), 0);
                    //расчёт приращения времени для рассматриваемого луча на данном такте
                    double dT = l * N / (N + B)/D;
                    TimeExp[y] += dT;
                }
            }
            /*Добавление значений на график*/
            for (int y = 0; y < yCount; y++)
                chart1.Series[0].Points.AddXY(y, TimeExp[y]);
            /*Добавление начала первой ПЗС ячейки*/
            chart1.Series[1].Points.AddXY(L, 0);
            chart1.Series[1].Points.AddXY(L, TimeExp[L]);
        }

        private void BFloatNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (BIntNumeric.Value != BIntNumeric.Maximum || BIntNumeric.Value != BIntNumeric.Minimum)
            {
                B = B < 0 ? (double)BIntNumeric.Value - (double)BFloatNumeric.Value * 0.1 : (double)BIntNumeric.Value + (double)BFloatNumeric.Value * 0.1;
            }
        }
    }
}
