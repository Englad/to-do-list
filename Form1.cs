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
        public string path = "";
        string loc1path = "loc1.txt";
        string loc2path = "loc2.txt";
        string theFile;
        int loc1 = 29;
        int loc2 = 85;
        string loc2original = "85";
        string thePath = "";
        public static int ButtonClicked = 1;



        public startForm()
        {


            InitializeComponent();
                if (!File.Exists(".//theFile.txt"))
                {
                    FolderBrowserDialog fbd = new FolderBrowserDialog();
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        path = fbd.SelectedPath;
                        loc1path = Path.Combine(path, "loc1.txt");
                        loc2path = Path.Combine(path, "loc2.txt");
                        theFile = Path.Combine("./", "theFile.txt");
                        File.WriteAllText(loc1path, loc1.ToString());
                        File.WriteAllText(loc2path, loc2.ToString());
                        File.WriteAllText(theFile, "something");
                    }
                }
                else
                {
                    loc1path = Path.Combine(path, "loc1.txt");
                    loc2path = Path.Combine(path, "loc2.txt");
                 theFile = Path.Combine("./", "theFile.txt");
                 File.WriteAllText(loc1path, loc1.ToString());
                 File.WriteAllText(loc2path, loc2.ToString());
                 File.WriteAllText(theFile, "something");
            }
            }
            

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void firstNote_Click(object sender, EventArgs e)
        {
            secondForm secondF = new secondForm("note1", path);
            secondF.ShowDialog();
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
            secondForm secondF = new secondForm(butText, path);
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
            if (File.Exists(Path.Combine(path, "Note 2.txt")))
            {
                ButtonClicked = 2;
                generateButton();
            }
            if (File.Exists(Path.Combine(path, "Note 3.txt")))
            {
                ButtonClicked = 3;
                generateButton();
            }
            if (File.Exists(Path.Combine(path, "Note 4.txt")))
            {
                ButtonClicked = 4;
                generateButton();
            }
            if (File.Exists(Path.Combine(path, "Note 5.txt")))
            {
                ButtonClicked = 5;
                generateButton();
            }
            if (File.Exists(Path.Combine(path, "Note 6.txt")))
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
