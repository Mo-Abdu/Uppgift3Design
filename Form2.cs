using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InlämningsUppgift3Grafik
{
    public partial class Form2 : Form
    {
        public event Action<List<Person>> UpdatePersons;
        private List<Person> personsInForm2;
        Form1 form1;
        public Form2(List<Person> personsFromForm1, Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            personsInForm2 = personsFromForm1;
            UpdateListBox();
            
        }
       
        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (Person person in personsInForm2)
            {
            listBox1.Items.Add(person.ToString());
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
