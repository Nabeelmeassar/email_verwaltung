using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EUIE_Mail
{
    public partial class Form1 : Form 
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void einfügen_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student();

                student.NameStudent = txtNameStudent.Text;
                student.MatriNr = int.Parse(txtMatriNrStudent.Text);
                foreach (Student item in listBox1.Items)
                {
                    if (item.ToString() == student.ToString())
                    {
                        MessageBox.Show("Alder!");
                        return;
                    }
                }
                listBox1.Items.Add(student);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Es ist ein Fehler aufgetreten !");

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Prof prof = new Prof();

                prof.Name = txtNameProf.Text;
                prof.RoomNr = int.Parse(txtRoomNr.Text);

                foreach (var item in listBox2.Items)
                {
                    if (item.ToString() == prof.ToString())
                    {
                        MessageBox.Show("Alder du hast schon diese Element breit eingefügt!");
                        return;
                    }
                }

                listBox2.Items.Add(prof);
            }
            catch (Exception)
            {

                MessageBox.Show("Es ist ein Fehler aufgetreten !");

            }

        }

        private void btnlöschen_Click(object sender, EventArgs e)
        {
            //foreach ( Control c in Controls)
            //{
            //    //((ListBox)c).Items.Remove();
            //}
            try
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch (Exception)
            {

                MessageBox.Show("Wählen Sie bitte die Element aus der Student list !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
            catch (Exception)
            {

                MessageBox.Show("Wählen Sie bitte die Elemant aus der  Profiessorn List ");
            }
          
        }
    }
}
