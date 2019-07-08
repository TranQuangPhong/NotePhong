using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Note_Phong.Utils;

namespace Note_Phong.View
{
    public partial class CreateNew_form : Form
    {
        private static CreateNew_form createNew_form;
        public event EventHandler<MyEventArgs> eBtnOK_Click; //Send to main form  & detail form to add UI

        public CreateNew_form()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// Get Name & Id from user
        /// Fire an event containing Name & Id to Main_form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            int parseId = 0;
            MyEventArgs myEvent = new MyEventArgs();
            if (int.TryParse(txtNewGoalId.Text, out parseId))
            {
                myEvent.Name = txtNewGoalName.Text;
                myEvent.Id = parseId;

                //Fire event, sent to Main_form
                if (eBtnOK_Click != null)
                    eBtnOK_Click.Invoke(sender, myEvent);
            }
            else
            {
                MessageBox.Show("Wrong Id format, re-type Id as a number!");
                txtNewGoalId.Clear();
                txtNewGoalName.Clear();
            }
            //this.Close(); //Keep showing this form to handle exceptions
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
