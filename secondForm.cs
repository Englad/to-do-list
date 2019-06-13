using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{

    public partial class secondForm : Form
    {
        private string path;

        public secondForm(string butText)
        {
            InitializeComponent();
            this.path = @"D:\Coding Projects 2\Chashtag\ToDoList\ToDoList\" + butText + ".txt";
            //startForm.ButtonClicked;
            //startForm.ButtonClicked;

            if (File.Exists(path))
            {
                userTextBox.Text = File.ReadAllText((path));
            }
            else
            {

            }
        }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(path, userTextBox.Text);
            DialogResult noMoreButtons = MessageBox.Show("File saved!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();

        }
    }
}
