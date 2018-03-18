using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Thread newform;
        private object comboBox7;

        public Form2()
        {
            InitializeComponent();
            comboBox1.Items.Add("Ongelukken en merken");
            comboBox1.Items.Add("Ongelukken en leeftijd");
            comboBox1.Items.Add("Ongelukken en nationaliteit");
            comboBox1.Items.Add("Man/vrouwelijke slachtoffers");
            comboBox1.Items.Add(" Ongeluks hoofdoorzaken");

            comboBox2.Items.Add("Ongelukken en merken");
            comboBox2.Items.Add("Ongelukken en leeftijd");
            comboBox2.Items.Add("Ongelukken en nationaliteit");
            comboBox2.Items.Add("Man/vrouwelijke slachtoffers");
            comboBox2.Items.Add(" Ongeluks hoofdoorzaken");

            comboBox3.Items.Add("Ongelukken en merken");
            comboBox3.Items.Add("Ongelukken en leeftijd");
            comboBox3.Items.Add("Ongelukken en nationaliteit");
            comboBox3.Items.Add("Man/vrouwelijke slachtoffers");
            comboBox3.Items.Add(" Ongeluks hoofdoorzaken");

            comboBox4.Items.Add("Ongelukken en merken");
            comboBox4.Items.Add("Ongelukken en leeftijd");
            comboBox4.Items.Add("Ongelukken en nationaliteit");
            comboBox4.Items.Add("Man/vrouwelijke slachtoffers");
            comboBox4.Items.Add(" Ongeluks hoofdoorzaken");

            comboBox5.Items.Add("Ongelukken en merken");
            comboBox5.Items.Add("Ongelukken en leeftijd");
            comboBox5.Items.Add("Ongelukken en nationaliteit");
            comboBox5.Items.Add("Man/vrouwelijke slachtoffers");
            comboBox5.Items.Add(" Ongeluks hoofdoorzaken");

            comboBox6.Items.Add("Ongelukken en merken");
            comboBox6.Items.Add("Ongelukken en leeftijd");
            comboBox6.Items.Add("Ongelukken en nationaliteit");
            comboBox6.Items.Add("Man/vrouwelijke slachtoffers");
            comboBox6.Items.Add(" Ongeluks hoofdoorzaken");

            comboBox14.Items.Add("Ongelukken en merken");
            comboBox14.Items.Add("Ongelukken en leeftijd");
            comboBox14.Items.Add("Ongelukken en nationaliteit");
            comboBox14.Items.Add("Man/vrouwelijke slachtoffers");
            comboBox14.Items.Add(" Ongeluks hoofdoorzaken");

            comboBox8.Items.Add("Ongelukken en merken");
            comboBox8.Items.Add("Ongelukken en leeftijd");
            comboBox8.Items.Add("Ongelukken en nationaliteit");
            comboBox8.Items.Add("Man/vrouwelijke slachtoffers");
            comboBox8.Items.Add(" Ongeluks hoofdoorzaken");

            comboBox9.Items.Add("Ongelukken en merken");
            comboBox9.Items.Add("Ongelukken en leeftijd");
            comboBox9.Items.Add("Ongelukken en nationaliteit");
            comboBox9.Items.Add("Man/vrouwelijke slachtoffers");
            comboBox9.Items.Add(" Ongeluks hoofdoorzaken");

            comboBox10.Items.Add("Ongelukken en merken");
            comboBox10.Items.Add("Ongelukken en leeftijd");
            comboBox10.Items.Add("Ongelukken en nationaliteit");
            comboBox10.Items.Add("Man/vrouwelijke slachtoffers");
            comboBox10.Items.Add(" Ongeluks hoofdoorzaken");

            comboBox11.Items.Add("Ongelukken en merken");
            comboBox11.Items.Add("Ongelukken en leeftijd");
            comboBox11.Items.Add("Ongelukken en nationaliteit");
            comboBox11.Items.Add("Man/vrouwelijke slachtoffers");
            comboBox11.Items.Add(" Ongeluks hoofdoorzaken");

            comboBox12.Items.Add("Ongelukken en merken");
            comboBox12.Items.Add("Ongelukken en leeftijd");
            comboBox12.Items.Add("Ongelukken en nationaliteit");
            comboBox12.Items.Add("Man/vrouwelijke slachtoffers");
            comboBox12.Items.Add(" Ongeluks hoofdoorzaken");

            comboBox13.Items.Add("Ongelukken en merken");
            comboBox13.Items.Add("Ongelukken en leeftijd");
            comboBox13.Items.Add("Ongelukken en nationaliteit");
            comboBox13.Items.Add("Man/vrouwelijke slachtoffers");
            comboBox13.Items.Add(" Ongeluks hoofdoorzaken");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void opennewform1(object obj)
        {
            Application.Run(new Drenthe());
        }

        private void opennewform2(object obj)
        {
            Application.Run(new Flevoland());
        }

        private void opennewform3(object obj)
        {
            Application.Run(new Friesland());
        }

        private void opennewform4(object obj)
        {
            Application.Run(new Gelderland());
        }

        private void opennewform5(object obj)
        {
            Application.Run(new Groningen());
        }

        private void opennewform6(object obj)
        {
            Application.Run(new Limburg());
        }

        private void opennewform7(object obj)
        {
            Application.Run(new Noord_Brabant());
        }

        private void opennewform8(object obj)
        {
            Application.Run(new Noord_Holland());
        }

        private void opennewform9(object obj)
        {
            Application.Run(new Overijssel());
        }

        private void opennewform10(object obj)
        {
            Application.Run(new Utrecht());
        }

        private void opennewform11(object obj)
        {
            Application.Run(new Zeeland());
        }

        private void opennewform12(object obj)
        {
            Application.Run(new Zuid_Holland());
        }

        private void opennewform13(object obj)
        {
            Application.Run(new Geheel_Nederland());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            newform = new Thread(opennewform1);
            newform.SetApartmentState(ApartmentState.STA);
            newform.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            newform = new Thread(opennewform2);
            newform.SetApartmentState(ApartmentState.STA);
            newform.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            newform = new Thread(opennewform3);
            newform.SetApartmentState(ApartmentState.STA);
            newform.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            newform = new Thread(opennewform4);
            newform.SetApartmentState(ApartmentState.STA);
            newform.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            newform = new Thread(opennewform5);
            newform.SetApartmentState(ApartmentState.STA);
            newform.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            newform = new Thread(opennewform6);
            newform.SetApartmentState(ApartmentState.STA);
            newform.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            newform = new Thread(opennewform7);
            newform.SetApartmentState(ApartmentState.STA);
            newform.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            newform = new Thread(opennewform8);
            newform.SetApartmentState(ApartmentState.STA);
            newform.Start();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            newform = new Thread(opennewform9);
            newform.SetApartmentState(ApartmentState.STA);
            newform.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            newform = new Thread(opennewform10);
            newform.SetApartmentState(ApartmentState.STA);
            newform.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
            newform = new Thread(opennewform11);
            newform.SetApartmentState(ApartmentState.STA);
            newform.Start();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
            newform = new Thread(opennewform12);
            newform.SetApartmentState(ApartmentState.STA);
            newform.Start();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
            newform = new Thread(opennewform13);
            newform.SetApartmentState(ApartmentState.STA);
            newform.Start();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
