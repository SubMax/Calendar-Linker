using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalendarLinker
{
    public partial class Form1 : Form
    {
        string URL;
        string StatPart = "https://calendar.google.com/calendar/render?action=TEMPLATE";
        string DateDDMMYYYYb = "";
        string DateDDMMYYYYe = "";
        string TimeBeg = "120000";
        string TimeEnd = "140000";
        string LabelEvent = "Название";
        string Details = "";
        string Location = "";

        public string SpaseToPlas(string input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                    output += "+";
                else
                    output += input[i];
            }
            return(output);
        }
        public void Aggregate(ComboBox.ObjectCollection input, int countItems, int step)
        {
            for (int i = 0; i < countItems; i+=step)
                if (i < 10)
                    input.Add("0" + i.ToString());
                else
                    input.Add(i.ToString());
        }

        
        public Form1()
        {
            InitializeComponent();
            DateDDMMYYYYb = dateTimePicker1.Value.Year.ToString() + dateTimePicker1.Value.Month.ToString() + dateTimePicker1.Value.Day.ToString();
            DateDDMMYYYYe = dateTimePicker2.Value.Year.ToString() + dateTimePicker2.Value.Month.ToString() + dateTimePicker2.Value.Day.ToString();
            LabelEvent = SpaseToPlas(textBox1.Text);
            Details = SpaseToPlas(textBox2.Text);
            Location = SpaseToPlas(textBox3.Text);

            Aggregate(EndHour.Items, 24, 1);
            EndHour.SelectedIndex = 12;
            Aggregate(EndMin.Items, 60, 5);
            EndMin.SelectedIndex = 0;

            Aggregate(BegHour.Items, 24, 1);
            BegHour.SelectedIndex = 10;
            Aggregate(BegMin.Items, 60, 5);
            BegMin.SelectedIndex = 0;

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateDDMMYYYYb = dateTimePicker1.Value.Year.ToString() + dateTimePicker1.Value.Month.ToString() + dateTimePicker1.Value.Day.ToString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateDDMMYYYYe = dateTimePicker2.Value.Year.ToString() + dateTimePicker2.Value.Month.ToString() + dateTimePicker2.Value.Day.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date)
                {
                MessageBox.Show("Начало позже окончания!");
                }
                {
                TimeBeg = "T" + BegHour.SelectedItem.ToString() + BegMin.SelectedItem.ToString() + "00";
                TimeEnd = "T" + EndHour.SelectedItem.ToString() + EndMin.SelectedItem.ToString() + "00";
                URL = StatPart + "&text=" + LabelEvent + "&dates=" + DateDDMMYYYYb + TimeBeg + "/" + DateDDMMYYYYe + TimeEnd + "&details=" + Details + "&location=" + Location;
                Clipboard.Clear();
                Clipboard.SetText(URL);
                outputURL.Text = URL;
                MessageBox.Show("Скопираванно в буфер обмена");
                }
            
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LabelEvent = "";
            string LabelEventSp = textBox1.Text;
            LabelEvent = SpaseToPlas(LabelEventSp);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Details = "";
            string DetailsSp = textBox2.Text;
            Details = SpaseToPlas(DetailsSp);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Location = "";
            string LocationSp = textBox3.Text;
            Location = SpaseToPlas(LocationSp);
        }

        private void BegHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BegMin_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void EndHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void EndMin_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
