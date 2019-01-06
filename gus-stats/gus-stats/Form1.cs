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

        private string topicValue = "";
        private string subTopicValue = "";
        private string valueValue = "";
        private string rangeValue = "";

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
                        if (bdlApiObj.status)
                        {
                            labelTopic.Visible = true;
                            comboBoxTopic.Visible = true;

                            ApiBdl bdlObj = new ApiBdl();
                            comboBoxTopic.Items.AddRange(bdlObj.getTopicsNames()); //wywolanie GetTopics ktore zwraca topiki w array i wrzucenie do comboboxa
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

        private void comboBoxTopicClosed(object sender, EventArgs e)
        {
            // czy user wybral cos z listy? 
            if (!string.IsNullOrWhiteSpace(comboBoxTopic.Text))
            {
                switch (comboBoxApi.Text)
                {
                    case "BDL":
                        if (bdlApiObj.status)
                        {
                            label7.Visible = true;
                            comboBoxSubtopic.Visible = true;
                            ApiBdl bdlObj = new ApiBdl();
                            this.topicValue = bdlObj.translateNameToId(comboBoxTopic.Text);
                            comboBoxSubtopic.Items.AddRange(bdlObj.getTopicsNames("adr%subjects?parent-id="+ topicValue + "&format=xml"));
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

        private void comboBoxSubtopicClosed(object sender, EventArgs e)
        {
            // czy user wybral cos z listy? 
            if (!string.IsNullOrWhiteSpace(comboBoxSubtopic.Text))
            {
                switch (comboBoxApi.Text)
                {
                    case "BDL":
                        if (bdlApiObj.status)
                        {

                            label6.Visible = true;
                            comboBoxValue.Visible = true;
                            ApiBdl bdlObj = new ApiBdl();
                            string[] argums = { "adr%subjects?parent-id=" + bdlObj.translateNameToId(comboBoxTopic.Text) + "&format=xml" }; //wrzucamy to w array, bo 2gi argument przeladowanej metody translateNameToId to array :(
                            this.subTopicValue = bdlObj.translateNameToId(comboBoxSubtopic.Text, argums);
                            comboBoxValue.Items.AddRange(bdlObj.getTopicsNames("adr%subjects?parent-id=" + subTopicValue + "&format=xml"));
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
        private void comboBoxValueClosed(object sender, EventArgs e)
        {
            // czy user wybral cos z listy? 
            if (!string.IsNullOrWhiteSpace(comboBoxValue.Text))
            {
                switch (comboBoxApi.Text)
                {
                    case "BDL":
                        if (bdlApiObj.status)
                        {
                            label8.Visible = true;
                            comboBoxRange.Visible = true;
                            ApiBdl bdlObj = new ApiBdl();
                            string[] argums = { "adr%subjects?parent-id=" + subTopicValue + "&format=xml" }; //wrzucamy to w array, bo 2gi argument przeladowanej metody translateNameToId to array :(
                            this.valueValue = bdlObj.translateNameToId(comboBoxValue.Text, argums);
                            comboBoxRange.Items.AddRange(bdlObj.getTopicsNames("adr%variables?subject-id=" + valueValue + "&format=xml","name%n1", "node%/variableList/results/variable"));
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
        private void comboBoxRangeClosed(object sender, EventArgs e)
        {
            // czy user wybral cos z listy? 
            if (!string.IsNullOrWhiteSpace(comboBoxValue.Text))
            {
                switch (comboBoxApi.Text)
                {
                    case "BDL":
                        if (bdlApiObj.status)
                        {
                            /*
                             * TODO: w przyszlosci mozna by uzyc reszty kontrolek i zrobic jakies fajne filtry
                            label2.Visible = true;
                            label3.Visible = true;
                            label4.Visible = true;
                            label5.Visible = true;
                            button4.Visible = true;
                            textBox1.Visible = true;
                            textBox2.Visible = true;
                            textBox3.Visible = true;

                            4878


                            */
                            ApiBdl bdlObj = new ApiBdl();
                            string[] argums = { "adr%variables?subject-id=" + valueValue + "&format=xml", "name%n1", "node%/variableList/results/variable" }; //wrzucamy to w array, bo 2gi argument przeladowanej metody translateNameToId to array :(
                            this.rangeValue = bdlObj.translateNameToId(comboBoxRange.Text, argums);
                            //MessageBox.Show(rangeValue);
                            richTextBox1.Text = bdlObj.getValues("data/by-variable/" + rangeValue + "?format=xml");
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
