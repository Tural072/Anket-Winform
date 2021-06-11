using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anket_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            Human human = new Human();
            human.Adress = adressTxtbx.Text;
            human.Age = ageTxtbx.Text;
            human.Birthdate = dateTimePicker1.Value;
            human.FatherName = fatherNameTxtbx.Text;
            human.Name = nameTxtbx.Text;
            human.Surename = surenameTxtbx.Text;
            foreach (RadioButton c in genderGrpbx.Controls.OfType<RadioButton>())
            {
                if (c.Checked)
                {
                    human.Gender = c.Text;
                }
            }
            foreach (RadioButton c in maritalStatusGrpbx.Controls.OfType<RadioButton>())
            {
                if (c.Checked)
                {
                    human.MartialStatus = c.Text;
                }
            }
            foreach (CheckBox c in foreginLanguageGrpbx.Controls.OfType<CheckBox>())
            {
                if (c.Checked)
                {
                    human.Language += c.Text;
                    human.Language += ",";
                }
            }
            jsonTxtbx.Text = $"{human.Name}.Json";
            HelperJson.JSONSerialization(human, jsonTxtbx.Text);
        }
    }
}
