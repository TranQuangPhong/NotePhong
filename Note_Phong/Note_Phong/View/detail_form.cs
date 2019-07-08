using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using Note_Phong.CommonLibrary;
using Note_Phong.Controllers;
using Note_Phong.Model;
using Note_Phong.Utils;

namespace Note_Phong.View {
    public partial class Detail_form : Form {
        public int Id {
            get;
            set;
        } //id of current detail form form
        CreateNew_form createNew_form;
        Controller controller;
        DBDetailForm dbDetailForm;
        public event EventHandler<MyEventArgs> eDelete_Click; //Send event to main form to remove UI
        public event EventHandler<MyEventArgs> eComplete_Creating_Child; //Send to main to add UI for children
        public event EventHandler eNew_Instance_Created; //Send to main to register event of new Detail_form instance

        public Detail_form () {
            InitializeComponent();
            controller = new Controller();
            dbDetailForm = new DBDetailForm();
            Id = -1;
        }
        public Detail_form (int id) {
            InitializeComponent();
            this.Id = id;
            controller = new Controller();
            dbDetailForm = new DBDetailForm(id);
        }

        private void detail_form_Load (object sender, EventArgs e) {
            //Load DB detail_form
            //Id = ((Detail_form)sender).Id; //Use this to keep data always shows on 1 form
            //dbDetailForm.Id = Id;          //Use this to keep data always shows on 1 form
            dbDetailForm = controller.QueryDataWithId(DBDetailForm.DB_TABLE_NAME, dbDetailForm);
            txtName.Text = dbDetailForm.Name;
            txtId.Text = dbDetailForm.Id.ToString();
            txtLevel.Text = dbDetailForm.Level.ToString();
            txtStatus.Text = dbDetailForm.Status;
            txtDescription.Text = dbDetailForm.Description;
            dtPickerDeadline.Value = dbDetailForm.Deadline;
            txtParent.Tag = dbDetailForm.ParentId; //set Tag (Id) for txtParent
            txtParent.Text = controller.QueryParentName(DBDetailForm.DB_TABLE_NAME, (int)txtParent.Tag); //get parent name

            tasksList.Items.Clear(); //Reset taskList
            string strTaskList = dbDetailForm.TaskList; //Start working on taskList
            if ( dbDetailForm.TaskList != "" ) {
                List<string> list = strTaskList.Split('-').ToList<string>(); //Character '-' devides taskList into single tasks
                foreach ( string item in list ) {
                    if ( item.Contains('+') ) //Character '+' indicates check status = true
                    {
                        string[] subItem = item.Split('+');
                        tasksList.Items.Add(subItem[0], CheckState.Checked);
                    } else {
                        tasksList.Items.Add(item);
                    }
                }
            }//Stop working on taskList

            childrenList.Clear(); //Start working on ChildrenList
            Dictionary<int, string> dictionary = controller.QueryAllChildren(DBDetailForm.DB_TABLE_NAME, Id);
            //Add to ListView
            foreach ( KeyValuePair<int, string> item in dictionary ) {
                ListViewItem childItem = new ListViewItem();
                childItem.Tag = item.Key;
                childItem.Text = item.Value;
                childrenList.Items.Add(childItem);
            } //Stop working on ChildrenList

            this.Text = txtName.Text;
            this.setDisableFields();
        }

        //Add new child for current form (maximum 9 children)
        private void bntNew_Click (object sender, EventArgs e) {
            //TODO: get ID of new child form
            createNew_form = new CreateNew_form();
            createNew_form.eBtnOK_Click += new EventHandler<MyEventArgs>(eCreateNew_BtnOK_Click);
            createNew_form.Show();
        }

        private void btnEdit_Click (object sender, EventArgs e) {
            this.setEnableFields();
        }

        private void btnSave_Click (object sender, EventArgs e) {
            //Get form data
            dbDetailForm.Name = txtName.Text;
            dbDetailForm.Status = txtStatus.Text;
            dbDetailForm.Description = txtDescription.Text;
            dbDetailForm.Deadline = dtPickerDeadline.Value;

            string strTaskList = tasksList.Items[0].ToString(); //Start working on taskList
            if ( tasksList.GetItemCheckState(0) == CheckState.Checked )
                strTaskList += '+'; //Save check state
            for ( int i = 1; i < tasksList.Items.Count; i++ ) {
                strTaskList += '-'; //Character to devide taskList into single tasks
                strTaskList += tasksList.Items[i].ToString();
                if ( tasksList.GetItemCheckState(i) == CheckState.Checked )
                    strTaskList += '+';
            }
            dbDetailForm.TaskList = strTaskList; //Stop working on taskList

            //Update to DB
            if ( controller.UpdateData(DBDetailForm.DB_TABLE_NAME, dbDetailForm) ) {
                detail_form_Load(sender, e);
                this.setDisableFields();
            }

        }

        private void btnCancle_Click (object sender, EventArgs e) {
            detail_form_Load(sender, e);
            this.setDisableFields();
        }

        private void btnTree_Click (object sender, EventArgs e) {
            //Show tree_form
            //Root of the tree is this form id
            //Load DB (get only 'Name')
        }

        private void btnFullTree_Click (object sender, EventArgs e) {
            //Show tree_form
            //Root is form level 0)
            //Load DB (only 'Name')
        }

        private void btnDelete_Click (object sender, EventArgs e) {
            if ( MessageBox.Show("Delete this form & all children! Are you sure?", "Delete form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes ) {
                if ( controller.DeleteData(DBDetailForm.DB_TABLE_NAME, Id) ) {
                    if ( eDelete_Click != null ) {
                        MyEventArgs myEvent = new MyEventArgs();
                        myEvent.Id = Id;
                        eDelete_Click.Invoke(sender, myEvent);
                    }
                    this.Close();
                }
            } else {
                //Do nothing
            }
        }

        //Add an item to taskList
        private void btnAddTask_Click (object sender, EventArgs e) {
 
            if ( (txtAddingTask.Text.ToString() != "") && (!txtAddingTask.Text.ToString().Contains("  "))
                && !txtAddingTask.Text.ToString().Contains('-') && !txtAddingTask.Text.ToString().Contains('+') )
                tasksList.Items.Add(txtAddingTask.Text);
            else
                MessageBox.Show("The task contains invalid characters(+, -, 2 spaces, or empty)");

            txtAddingTask.Clear();
            txtAddingTask.Focus();
        }

        //Remove a task from taskList
        private void btnRemoveTask_Click (object sender, EventArgs e) {
            tasksList.Items.Remove(tasksList.SelectedItem);
        }

        //Open parent form (keep current form)
        private void txtParent_DoubleClick (object sender, EventArgs e) {
            //Load DB detail_form with parent id (open parent in another form)
            Detail_form parent_form = new Detail_form((int)txtParent.Tag);
            if(eNew_Instance_Created != null){
                eNew_Instance_Created.Invoke(parent_form, e); //Fire event to main to register handlers for new parent_form
            }
            parent_form.Show();
        }

        private void childrenList_ItemActivate (object sender, EventArgs e) {
            Detail_form child_form = new Detail_form((int)childrenList.FocusedItem.Tag);
            if ( eNew_Instance_Created != null ) {
                eNew_Instance_Created.Invoke(child_form, e); //Fire event to main to register handlers for new child_form
            }
            child_form.Show();
        }

        /// <summary>
        /// Handle events from CreateNew_form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>MyEventArgs object contains Name & Id of new child form
        /// <returns></returns>
        private void eCreateNew_BtnOK_Click (object sender, MyEventArgs e) {
            //Insert DB
            DBDetailForm dbDetailForm = new DBDetailForm(e.Id);
            dbDetailForm.Name = e.Name;
            dbDetailForm.ParentId = this.Id;
            if ( controller.InsertData(DBDetailForm.DB_TABLE_NAME, dbDetailForm) ) {
                //Update List View for children
                detail_form_Load(sender, null);
                createNew_form.Close();
                //send event to main form
                if ( eComplete_Creating_Child != null ) {
                    eComplete_Creating_Child.Invoke(this, e);
                }
            }
        }

        /// <sumary>
        /// Utilities functions
        /// </sumary>
        private void setDisableFields () { //while not editing
            txtName.ReadOnly = true;
            txtStatus.ReadOnly = true;
            txtDescription.ReadOnly = true;
            txtAddingTask.ReadOnly = true;
            txtAddingTask.Clear();

            dtPickerDeadline.Enabled = false;
            tasksList.Enabled = false;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnAddTask.Enabled = false;
            btnRemoveTask.Enabled = false;

            btnTree.Enabled = true;
            btnFullTree.Enabled = true;

        }

        private void setEnableFields () { //While editing
            txtName.ReadOnly = false;
            txtStatus.ReadOnly = false;
            txtDescription.ReadOnly = false;
            txtAddingTask.ReadOnly = false;

            dtPickerDeadline.Enabled = true;
            tasksList.Enabled = true;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAddTask.Enabled = true;
            btnRemoveTask.Enabled = true;

            btnTree.Enabled = false;
            btnFullTree.Enabled = false;
        }

    }
}
