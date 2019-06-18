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

        string path;

        public secondForm(string butText, string path)
        {
            InitializeComponent();
            this.path = Path.Combine(path, butText + ".txt");
            

             if (File.Exists(Path.Combine(path, butText + ".txt")))
            {
                userTextBox.Text = File.ReadAllText(Path.Combine(path, butText + ".txt"));
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
            DialogResult saveFile = MessageBox.Show("File saved! " + path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();

        }
    }
}
