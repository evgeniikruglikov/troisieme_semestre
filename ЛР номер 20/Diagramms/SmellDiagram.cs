using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Diagramms
{
    public partial class SmellDiagram : Form
    {
        private Color[] palette =
            { Color.White, Color.FromArgb(245, 252, 198), Color.FromArgb(223, 237, 139), Color.FromArgb(206, 222, 87), Color.FromArgb(177, 200, 48), Color.FromArgb(145, 167, 24), Color.FromArgb(111, 131, 0) };

        private List<Tuple<string, float>> data;
        private float diagramAngle = 270;

        public SmellDiagram()
        {
            InitializeComponent();

            data = File.ReadAllText("Smell.csv", System.Text.Encoding.UTF8).Split('\n').Select(s => new Tuple<string, float>(s.Split('_')[0], float.Parse(s.Split('_')[1]))).ToList();

            UpdateChart(diagramAngle);
        }

        public void UpdateChart(float startAngle)
        {
            MyChart.Series[0].Points.Clear();
            for (int i = 0; i < data.Count; i++)
            {
                MyChart.Series[0].Points.AddXY(data[i].Item1, data[i].Item2);
                MyChart.Series[0].Points[i].Color = palette[Math.Min(i, palette.Length - 1)];
            }
            MyChart.Series[0].SetCustomProperty("PieStartAngle", startAngle.ToString());
        }

        private void buttonShiftLeft_Click(object sender, EventArgs e)
        {
            diagramAngle -= 15;
            if (diagramAngle < 0)
                diagramAngle += 360;
            UpdateChart(diagramAngle);
        }

        private void buttonShiftRight_Click(object sender, EventArgs e)
        {
            diagramAngle += 15;
            if (diagramAngle > 360)
                diagramAngle -= 360;
            UpdateChart(diagramAngle);
        }
    }
}