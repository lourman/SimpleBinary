using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace SimpleBinary
{
    public partial class Form1 : Form
    {

        private Person person;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinaryWriter bw;

            //create the file
            try
            {
                bw = new BinaryWriter(new FileStream("mydata.dat", FileMode.Append));
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Cannot create file.");
                return;
            }

            try
            {
                bw.Write(person.Name);
                bw.Write(person.Age);
                bw.Write(person.Balance);
                bw.Write(person.Famous);
                bw.Write(((int)person.GetQuotes().Count));
                foreach (String s in person.GetQuotes())
                {
                    bw.Write(s);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Cannot write to file.");
                return;
            }
            bw.Close();

            uName.Clear();
            uiAge.Clear();
            uiBalance.Clear();
            uiFamous.Checked = false;
            uName.Focus();
        }

        private void uiCreateButton_Click(object sender, EventArgs e)
        {
            Int16 age;
            string name;

            name = uName.Text;
            try
            {
                age = Int16.Parse(uiAge.Text);
            }
            catch (Exception ex)
            { age = 0; }

            person = new Person(name, age);

            try
            { person.Balance = Decimal.Parse(uiBalance.Text); }
            catch (Exception ex)
            { person.Balance = 0.0M; }

            if (uiFamous.Checked)
                person.Famous = true;
        }

        private void uiQuoteButton_Click(object sender, EventArgs e)
        {
            if (person != null)
            {
                person.AddQuote(uiQuote.Text);
            }
            uiQuote.Clear();
            uiQuote.Focus();
        }

        private void uiLoadButon_Click(object sender, EventArgs e)
        {
            //declare a Binary Reader
            BinaryReader br;

            //Clear the text box
            uiShowTextBox.Clear();


            //reading from the file

            //try to open the filestream 
            //catch and report any errors
            

            //try to read in the data
            // while there is still data in the stream to read..
            //   can use BinaryReader Method PeekChar that returns a number >=0 if more data in the file.
            
            // Read in a record from the file using appropriate types (info on this in the powerpoint!)
            // or infer from the write above!
            // create a Person using the data given and mutate attributes appropriately
            // you will need to get a count of the quotes and read in each in turn.

            // Use DisplayPerson(person); to display the person in the UI


            // end of while loop

            //catch reading exceptions and display them

            uiShowTextBox.AppendText("Done");

            // Close the Binary Reader
            



        }

        private void DisplayPerson(Person p)
        {
            uiShowTextBox.AppendText(p.Name + "(" + p.Age.ToString() + ")");
            uiShowTextBox.AppendText(" - £" + p.Balance.ToString() + "\n");
            if (p.Famous)
            {
                uiShowTextBox.AppendText("FAMOUS\n");
            }
            foreach (String s in p.GetQuotes())
            {
                uiShowTextBox.AppendText("\t" + s + "\n");
            }
            uiShowTextBox.AppendText("\n\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BinaryWriter bw;

            //create the file
            try
            {
                bw = new BinaryWriter(new FileStream("mydata.dat", FileMode.Create));
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Cannot create file.");
                return;
            }

            try
            {
                bw.Write("Fred");
                bw.Write((Int16)21);
                bw.Write(10.01M);
                bw.Write(false);
                bw.Write(0);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Cannot write to file.");
                return;
            }
            bw.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BinaryReader br;
            
            try
            {
                br = new BinaryReader(new FileStream("mydata.dat", FileMode.Open));
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Cannot open file.");
                return;
            }

            try
            {
                String name;
                Int16 age;
                Decimal balance;
                bool famous;
                int quoteCount;

                name = br.ReadString();
                age = br.ReadInt16();
                balance = br.ReadDecimal();
                famous = br.ReadBoolean();
                quoteCount = br.ReadInt32();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Cannot read from file.");
                return;
            }
            br.Close();

        }

    }

    public class Person
    {
        String mName;
        Int16 mAge;
        Decimal mBalance;
        bool mFamous;
        List<string> mQuotes;

        public Person(String Name, Int16 Age)
        {
            mQuotes = new List<string>();

            mName = Name;
            mAge = Age;
            mFamous = false;
        }

        public Decimal Balance
        {
            get { return mBalance; }
            set { mBalance = value; }
        }

        public bool Famous
        {
            get { return mFamous; }
            set { mFamous = value; }
        }


        public String Name
        {
            get { return mName; }
        }
        public Int16 Age
        {
            get { return mAge; }
        }

        public void AddQuote(String Quote)
        {
            mQuotes.Add(Quote);
        }

        public List<String> GetQuotes()
        {
            return mQuotes;
        }
    }
}
