using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba6._2
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }
        public interface IPlanet
        {
             string ReportAboutMovement();
             string ReportAboutLife();
        }
        public class Earth : IPlanet
        {
            public string ReportAboutMovement()
            {
                return "Земля обертається навколо Сонця";

            }
            public string ReportAboutLife()
            {
                return "На Землі існує життя";
            }
        }
        public class Moon : IPlanet
        {
            public string ReportAboutMovement()
            {
                return "Місяць обертається навколо Землі";
            }
            public string ReportAboutLife()
            {
                return "На Місяці немає життя";
            }
        }


        private void btnEarth_Click(object sender, EventArgs e)
        {
            IPlanet planet = new Earth();
            txtOutput.Text = planet.ReportAboutMovement() + Environment.NewLine + planet.ReportAboutLife();
        }

        private void btnMoon_Click(object sender, EventArgs e)
        {
            IPlanet planet = new Moon();
            txtOutput.Text = planet.ReportAboutMovement() + Environment.NewLine + planet.ReportAboutLife();
        }
    }
}
