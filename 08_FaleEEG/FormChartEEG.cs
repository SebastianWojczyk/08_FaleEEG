using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _08_FaleEEG
{
    public partial class FormChartEEG : Form
    {
        Series sum;
        public FormChartEEG()
        {
            InitializeComponent();

            flowLayoutPanelConfig.Controls.Add(new UserControlWave("Delta", 5, 20, Color.Red));
            flowLayoutPanelConfig.Controls.Add(new UserControlWave("Teta", 10, 10, Color.Blue));
            flowLayoutPanelConfig.Controls.Add(new UserControlWave("Alfa", 8, 8, Color.Green));
            flowLayoutPanelConfig.Controls.Add(new UserControlWave("SMR", 16, 4, Color.Magenta));
            flowLayoutPanelConfig.Controls.Add(new UserControlWave("Beta", 18, 3, Color.Orange));
            flowLayoutPanelConfig.Controls.Add(new UserControlWave("Beta 2", 35, 7, Color.Brown));
            foreach (var item in flowLayoutPanelConfig.Controls)
            {
                if (item is UserControlWave)
                {
                    (item as UserControlWave).ParametersChanged += Wave_ParametersChanged;
                    Wave_ParametersChanged(item as UserControlWave);
                }
            }
            sum = new Series();
            sum.Color = Color.Black;
            sum.BorderWidth = 5;
            sum.ChartType = SeriesChartType.Line;
            chartEEG.Series.Add(sum);
        }

        private void Wave_ParametersChanged(UserControlWave sender)
        {
            Series s;
            if (sender.Tag == null)
            {
                s = new Series();
                sender.Tag = s;
                s.ChartType = SeriesChartType.Line;
                s.Color = sender.WaveColor;
                chartEEG.Series.Add(s);
            }
            else
            {
                s = sender.Tag as Series;
            }
            s.Points.Clear();
            if (sender.WaveVisible)
            {
                for (double x = 0; x < 5; x += 0.01)
                {
                    s.Points.AddXY(x, Math.Sin(x * sender.WaveFrequency) * sender.WaveAmplitude);
                }
            }
            refreshSum();
            chartEEG.ChartAreas.First().RecalculateAxesScale();
        }

        private void checkBoxSum_CheckedChanged(object sender, EventArgs e)
        {
            refreshSum();
        }

        private void refreshSum()
        {
            if (sum != null)
            {
                sum.Points.Clear();
                if (checkBoxSum.Checked)
                {
                    for (double x = 0; x < 5; x += 0.01)
                    {
                        //wartość Y liczę jako sumę wartości poszczególnych fal składowych
                        sum.Points.AddXY(x, chartEEG.Series.Where(s => s != sum && s.Points.Count > 0) //pomijam serię sumy i inne wyłączone serie
                                                           .Sum(s => s.Points.Single(p => p.XValue == x) //z punktów wybieram jeden o odpowiedniej wartości X
                                                           .YValues[0])); //dla wybanego punktu biorę pierwszą z wielu możliwych wartości Y
                    }
                }
            }
        }
    }
}
