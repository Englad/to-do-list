using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ToDoList
{

    public partial class startForm : Form
    {
        string loc1path = @"D:\Coding Projects 2\Chashtag\ToDoList\ToDoList\loc1.txt";
        string loc2path = @"D:\Coding Projects 2\Chashtag\ToDoList\ToDoList\loc2.txt";
        string path = @"D:\Coding Projects 2\Chashtag\ToDoList\ToDoList\";
        int loc1 = 29;
        int loc2 = 85;
        string loc2original = "85";
        public static int ButtonClicked = 1;


        public startForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void firstNote_Click(object sender, EventArgs e)
        {
            //this.Hide();
            secondForm secondF = new secondForm("note1");
            secondF.ShowDialog();
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ButtonClicked < 6)
            {
                ButtonClicked++;
                generateButton();
            }
            else
            {
                DialogResult noMoreButtons = MessageBox.Show("Sorry, you cannot create more than 6 notes");
            }
        }

        void newButton_Click(object sender, System.EventArgs e)
        {
            var butText = (sender as Button).Text;
            secondForm secondF = new secondForm(butText);
            secondF.ShowDialog();
        }

        private void startForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ButtonClicked == 1)
                {
                    File.WriteAllText(loc2path, loc2original);
                }
            else
                {
                    File.WriteAllText(loc2path, loc2original);
                }
        }

        private void startForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(path + "Note 2.txt"))
            {
                ButtonClicked = 2;
                generateButton();
            }
            if (File.Exists(path + "Note 3.txt"))
            {
                ButtonClicked = 3;
                generateButton();
            }
            if (File.Exists(path + "Note 4.txt"))
            {
                ButtonClicked = 4;
                generateButton();
            }
            if (File.Exists(path + "Note 5.txt"))
            {
                ButtonClicked = 5;
                generateButton();
            }
            if (File.Exists(path + "Note 6.txt"))
            {
                ButtonClicked = 6;
                generateButton();
            }
        }

        public void generateButton()
         {
            loc1 = Int32.Parse(File.ReadAllText(loc1path));
            loc2 = Int32.Parse(File.ReadAllText(loc2path));
            Button newButton = new Button();
            newButton.Location = new Point(loc1, loc2 + 40);
            newButton.Size = new Size(413, 23);
            newButton.Text = string.Format("Note {0}", ButtonClicked);
            newButton.Click += new EventHandler(this.newButton_Click);
            this.Controls.Add(newButton);
            loc2 = loc2 + 40;
            File.WriteAllText(loc1path, loc1.ToString());
            File.WriteAllText(loc2path, loc2.ToString());
        }
    }
}
