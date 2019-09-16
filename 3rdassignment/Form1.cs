using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3rdassignment
{
    public partial class Form1 : Form
    {
        const int size = 3;
        string[] name = new string[size];
        int[] contact = new int[size];
        string[] address = new string[size];
        string[] order = new string[size];
        int[] quantity = new int[size];
        int index = 0;
        string message = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            for(index=0;index<size;index++)
            {
                if (itemcombobox.SelectedItem.ToString() == "Black")
                {
                    quantity[index] = ((quantity[index]) * 120);
                }
                else if (itemcombobox.SelectedItem.ToString() == "Cold")
                {
                    quantity[index] = ((quantity[index]) * 100);
                }
                else if (itemcombobox.SelectedItem.ToString() == "Hot")
                {
                    quantity[index] = ((quantity[index]) * 90);
                }
                else if (itemcombobox.SelectedItem.ToString() == "Regular")
                {
                    quantity[index] = ((quantity[index]) * 80);
                }
                else
                {
                    MessageBox.Show("Select an item");
                }
                message += "Customer Name: " + name[index] + "\n" + "Customer No: " + contact[index] + "\n"  + "Address: " + address[index] + "\n" + "Order: " + order[index] + "\n" + "Price: " + quantity[index] +"\n"+"\n";

            }
            itemrichtextbox.Text=(message);

        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if(index<=size)
            {
                name[index] = nametextbox.Text;
                contact[index] = Convert.ToInt32(phonenobox.Text);
                address[index] = addresstextbox.Text;
                order[index] = itemcombobox.Text;
                quantity[index] = Convert.ToInt32(quantitytextbox.Text);
                index++;
            }
        }
    }
}
