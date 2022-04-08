using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_FaleEEG
{
    public partial class UserControlWave : UserControl
    {
        public string WaveName
        {
            get
            {
                return groupBoxName.Text; ;
            }
        }
        public double WaveFrequency
        {
            get
            {
                return (double)numericUpDownFrequency.Value;
            }
        }
        public double WaveAmplitude
        {
            get
            {
                return (double)numericUpDownAmplitude.Value;
            }
        }
        public bool WaveVisible
        {
            get
            {
                return checkBoxVisible.Checked;
            }
        }
        public Color WaveColor
        {
            get
            {
                return groupBoxName.ForeColor;
            }
        }
        public UserControlWave()
        {
            InitializeComponent();
        }

        public UserControlWave(string name, int frequency, int amplitude, Color color)
        {
            InitializeComponent();
            groupBoxName.ForeColor = color;
            groupBoxName.Text = name;
            numericUpDownFrequency.Value = (decimal)frequency;
            numericUpDownAmplitude.Value = (decimal)amplitude;
        }

        public delegate void EventHandlerWave(UserControlWave wave);
        public event EventHandlerWave ParametersChanged;
        private void parameter_Changed(object sender, EventArgs e)
        {
            if (ParametersChanged != null)
            {
                ParametersChanged(this);
            }
        }
    }
}
