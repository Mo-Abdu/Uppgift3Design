using System.IO;

namespace InlämningsUppgift3Grafik
{
    public partial class Form1 : Form
    {
        List<Person> persons = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

    

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string living = livingBox.Text;
            string school = schoolBox.Text;
            string job = jobBox.Text;

            Person person = new Person(name, living, school, job);
            persons.Add(person);
            personList.Items.Add(person.Name);


        }

        string folderPath = "SavedHere";
        string path = "persons.csv";

        private void saveButton_Click(object sender, EventArgs e)
        {

            StreamWriter writer = new StreamWriter(path);
            foreach (Person person in persons)
            {
                writer.WriteLine(person.GetCSV());
            }
            writer.Close();

        }

        private void loadButton_Click(object sender, EventArgs e)
        {

            persons.Clear();
            personList.Items.Clear();

            FileInfo file = new FileInfo(path);
            if (file.Exists)
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        string[] strings = line.Split(",");
                        string name = strings[0];
                        var living = strings[1];
                        string school = strings[2];
                        string jobb = strings[3];

                        Person person = new Person(name, living, school, jobb);
                        persons.Add(person);
                        personList.Items.Add(person.Name);
                        personList.Items.Add(person.Living);
                        personList.Items.Add(person.School);
                        personList.Items.Add(person.Job);


                        line = sr.ReadLine();
                    }



                }
            }

        }


        private void removeButton_Click(object sender, EventArgs e)
        {

            int index = personList.SelectedIndex;
            if (index > -1)
            {
                Person person = persons[index];
                persons.RemoveAt(index);
                personList.Items.RemoveAt(index);
            }

        }




    }
}