using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || comstatus.Text == "")
            {
                MessageBox.Show("enter anythink");
                
                return;
            }

            //switch (comstatus.SelectedItem)
            //{
            //    case "Finished":
            //        if (list1.Items.Contains(txtname.Text))
            //        {
            //            MessageBox.Show("Already entered");
            //            return;
            //        }
            //        list1.Items.Add(txtname.Text);
            //        list2.Items.Remove(txtname.Text);
            //        list3.Items.Remove(txtname.Text);
            //        break;
            //    case "Pending":
            //        if (list2.Items.Contains(txtname.Text))
            //        {
            //            MessageBox.Show("Already entered");
            //            return;
            //        }
            //        list2.Items.Add(txtname.Text);
            //        list1.Items.Remove(txtname.Text);
            //        list3.Items.Remove(txtname.Text);
            //        break;
            //    case "In Progress":
            //        if (list3.Items.Contains(txtname.Text))
            //        {
            //            MessageBox.Show("Already entered");
            //            return;
            //        }
            //        list3.Items.Add(txtname.Text);
            //        list2.Items.Remove(txtname.Text);
            //        list1.Items.Remove(txtname.Text);
            //        break;
            //    case "select one":
            //        MessageBox.Show("select one");
            //        break;

            //}

            string taskname = txtname.Text;
            string taskstatus = comstatus.SelectedItem.ToString();

            if (taskstatus == "Finished")
            {
                if (list1.Items.Contains(txtname.Text))
                {
                    MessageBox.Show("Already entered");
                    return;
                }
                list1.Items.Add(taskname);
                list2.Items.Remove(txtname.Text);
                list3.Items.Remove(txtname.Text);
            }
            else if (taskstatus == "Pending")
            {
                if (list2.Items.Contains(txtname.Text))
                {
                    MessageBox.Show("Already entered");
                    return;
                }
                list2.Items.Add(taskname);
                list1.Items.Remove(txtname.Text);
                list3.Items.Remove(txtname.Text);
            }
            else if (taskstatus == "In Progress")
            {
                if (list3.Items.Contains(txtname.Text))
                {
                    MessageBox.Show("Already entered");
                    return;
                }
                list3.Items.Add(taskname);
                list2.Items.Remove(txtname.Text);
                list1.Items.Remove(txtname.Text);
            }
            else
            {
                MessageBox.Show("invalid task status");
            }

        }

            private void clearbtn_Click(object sender, EventArgs e)
            {
                txtname.Text = "";
                list1.Items.Clear();
                list2.Items.Clear();
                list3.Items.Clear();
                
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                //MessageBox.Show("welcome xariif");
                comstatus.Items.Add("select one");
                comstatus.SelectedItem = "select one";
            }
        }
    }
