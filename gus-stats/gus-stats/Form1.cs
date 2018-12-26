using gus_stats.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace gus_stats
{
    public partial class Form1 : Form
    {
        Api bdlApiObj = new ApiBdl();
        Api regonApiObj = new ApiRegon();
        Api terytApiObj = new ApiTeryt();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            if (bdlApiObj.status)
            {
                button1.BackColor = Color.LawnGreen;
            }
            else
            {
                button1.BackColor = Color.Red;
            }

            if (regonApiObj.status)
            {
                button2.BackColor = Color.LawnGreen;
            }
            else
            {
                button2.BackColor = Color.Red;
            }

            if (terytApiObj.status)
            {
                button3.BackColor = Color.LawnGreen;
            }
            else
            {
                button3.BackColor = Color.Red;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// wyrzucana gdy user zamknie combo-boxa (czyli pewnie wybrał sobie cos z listy (ale nie jest to pewne) ) 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxApiClosed(object sender, EventArgs e)
        {
            // czy user wybral cos z listy? 
            if (!string.IsNullOrWhiteSpace(comboBoxApi.Text))
            {
                switch (comboBoxApi.Text)
                {
                    case "BDL":
                        if(bdlApiObj.status)
                        {
                            labelTemat.Visible = true;
                            comboBoxTemat.Visible = true;
                        }
                        else
                        {
                            //TODO: handle this - api nie odpowiada
                        }
                        break;
                    case "Regon":
                        if (regonApiObj.status)
                        {

                        }
                        else
                        {
                            //TODO: handle this - api nie odpowiada
                        }
                        break;
                    case "Teryt":
                        if (terytApiObj.status)
                        {

                        }
                        else
                        {
                            //TODO: handle this - api nie odpowiada
                        }
                        break;
                    default:
                        //TODO: handle this - bo to error ewidentny
                        break;
                }
                    

                
            }
        }


    }
}
