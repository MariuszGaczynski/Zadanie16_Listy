using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie16_Listy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 25; i++)
            {
                listBox1.Items.Add(String.Format("Opcja {0}", i +1));
                listBox2.Items.Add(String.Format("Opcja {0}", (char)(i + (int)'A')));
            }
        }

        

        private void comboSelectionMode_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboSelectionMode.SelectedIndex == 0)
            {
                listBox1.SelectionMode = SelectionMode.One;
                listBox2.SelectionMode = SelectionMode.One;

                MessageBox.Show("You can choose one item in a time", "Selection Mode - ONE");
            }
            if (comboSelectionMode.SelectedIndex == 1)
            {
                listBox1.SelectionMode = SelectionMode.MultiSimple;
                listBox2.SelectionMode = SelectionMode.MultiSimple;

                MessageBox.Show("You can choose one item and then another ones, one by one",
                    "Selection Mode - MULTI SIMPLE");
            }
            if (comboSelectionMode.SelectedIndex == 2)
            {
                listBox1.SelectionMode = SelectionMode.MultiExtended;
                listBox2.SelectionMode = SelectionMode.MultiExtended;

                MessageBox.Show("You can choose one item and then pressing Ctrl key add another one" +
                    " or you can select whole range by clicking on first and last element" +
                    " while pressing Shift key" ,
                    "Selection Mode - MULTI EXTENDED");
            }


        }


        private void btnLB1ToLB2_Click(object sender, EventArgs e)
        {
            foreach (string item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(item);
                
            }

            while (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
            
        }


        private void btnLB2ToLB1_Click(object sender, EventArgs e)
        {

            foreach (string item in listBox2.SelectedItems)
            {
                listBox1.Items.Add(item);
                
            }

            while (listBox2.SelectedItems.Count > 0)
            {
                listBox2.Items.Remove(listBox2.SelectedItems[0]);
            }

        }

        private void btnClearChanges_Click(object sender, EventArgs e)
        {
            while (listBox1.Items.Count > 0)
            {
                listBox1.Items.Remove(listBox1.Items[0]);
            }

            while (listBox2.Items.Count > 0)
            {
                listBox2.Items.Remove(listBox2.Items[0]);
            }

            MainForm_Load(sender, e);
        }
    }
}
