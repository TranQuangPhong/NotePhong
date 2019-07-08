using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using Note_Phong.Controllers;
using Note_Phong.Model;
using Note_Phong.Utils;

namespace Note_Phong.View {
    public partial class Main_form : Form {
        CreateNew_form createNew_form;
        //Detail_form detail_form;
        Controller controller;
        DBDetailForm dbDetailForm;

        private const string TABLE_LAYOUT_PANEL_TAG_ROOT = "rootForms"; //determine root table panel will contain new created form
        private const string TABLE_LAYOUT_PANEL_TAG_CHILD = "childForms"; //determine child table panel will contain new created form

        public Main_form () {
            InitializeComponent();
            controller = new Controller();
            dbDetailForm = new DBDetailForm();
        }

        private void Main_form_Load (object sender, EventArgs e) {
            //TODO: Load DB to show UI
        }

        private void btnNew_Click (object sender, EventArgs e) {
            createNew_form = new CreateNew_form();
            //Subcribe event from CreateNew_form
            createNew_form.eBtnOK_Click += new EventHandler<MyEventArgs>(eCreateNew_BtnOK_Click);
            createNew_form.Show();
        }//End btnNew_Click()

        public void btnForm_Click (object sender, EventArgs e) { //Enter detail_form

            Detail_form detail_form = new Detail_form(( int )(( Button )sender).Tag);
            detail_form.eNew_Instance_Created += new EventHandler(eDetail_New_Instance_Created);
            detail_form.eDelete_Click += new EventHandler<MyEventArgs>(eDetail_BtnDelete_Click);
            detail_form.eComplete_Creating_Child += new EventHandler<MyEventArgs>(eDetail_Complete_Creating_Child);
            detail_form.Show();
        }//End btnForm_Click()

        public void btnDelete_Click (object sender, EventArgs e) { //Delete this form & its children

            if ( MessageBox.Show("Delete this form & all children! Are you sure?", "Delete form",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes ) {
                Button thisButton = sender as Button;
                //Delete this form & all children id in DB
                if ( controller.DeleteData(DBDetailForm.DB_TABLE_NAME, ( int )thisButton.Tag) ) {
                    RemoveUI(( int )thisButton.Tag);
                }
            } else {
                //Do nothing
            }
        }//End btnDelete_Click()


        /// <summary>
        /// Handle events from Detail_form when a new instance of Detail_form is created
        /// Register handlers for events of the new instance
        /// </summary>
        /// <param name="sender"></param>the Detail_form object need to be registered event
        /// <param name="e"></param>
        private void eDetail_New_Instance_Created (object sender, EventArgs e) {
            (( Detail_form )sender).eNew_Instance_Created += new EventHandler(eDetail_New_Instance_Created);
            (( Detail_form )sender).eDelete_Click += new EventHandler<MyEventArgs>(eDetail_BtnDelete_Click);
            (( Detail_form )sender).eComplete_Creating_Child += new EventHandler<MyEventArgs>(eDetail_Complete_Creating_Child);

        }

        /// <summary>
        /// Handle events from CreateNew_form
        /// Insert DB and update UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>MyEventArgs object contains Name & Id to set to the form
        /// <returns></returns>
        private void eCreateNew_BtnOK_Click (object sender, MyEventArgs e) {
            //Set id & name for input arg 'dbDetailForm'
            dbDetailForm.Id = e.Id;
            dbDetailForm.Name = e.Name;

            //Insert DB & add UI
            if ( controller.InsertData(DBDetailForm.DB_TABLE_NAME, dbDetailForm) ) {
                AddUI(TABLE_LAYOUT_PANEL_TAG_ROOT);
                createNew_form.eBtnOK_Click -= new EventHandler<MyEventArgs>(eCreateNew_BtnOK_Click);
                createNew_form.Close(); //Only close when there's no exception
            }
        }//End eBtnOK_Click()

        /// <summary>
        /// Handle events from Detail_form
        /// Update UI after Detail_form completed creating new child
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eDetail_Complete_Creating_Child (object sender, MyEventArgs e) {
            //((Detail_form)sender).eDelete_Click += new EventHandler<MyEventArgs>(eDetail_BtnDelete_Click);
            //Set id & name for input arg 'dbDetailForm'
            dbDetailForm.Id = e.Id;
            dbDetailForm.Name = e.Name;

            AddUI(TABLE_LAYOUT_PANEL_TAG_CHILD);
        }

        /// <summary>
        /// Handle events from Detail_form
        /// Remove UI after Detail_form.bntDelete is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>MyEventArgs object contains Id to RemoveUI
        /// <returns></returns>
        private void eDetail_BtnDelete_Click (object sender, MyEventArgs e) {
            RemoveUI(e.Id);
        }

        /// <sumary>
        /// Utilities functions
        /// </sumary>

        /// <summary>
        /// Remove UI which has deleted DB
        /// </summary>
        /// <param name="tag"></param>Tag of the object need to be deleted
        /// <returns></returns>
        private void AddUI (string tag) {
            Panel panel = new Panel();
            panel.Dock = DockStyle.Fill;
            //Create 2 buttons to add to Panel
            Button btnForm = new Button();
            Button btnDelete = new Button();

            //Set Tag value as id
            panel.Tag = dbDetailForm.Id;
            btnForm.Tag = dbDetailForm.Id;
            btnDelete.Tag = dbDetailForm.Id;

            //Query 'Name' to update UI
            dbDetailForm = controller.QueryDataWithId(DBDetailForm.DB_TABLE_NAME, dbDetailForm);
            btnForm.Text = dbDetailForm.Name;
            btnDelete.Text = "X";

            btnForm.Dock = DockStyle.Fill;
            btnDelete.ForeColor = Color.White;
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            btnDelete.Size = new System.Drawing.Size(40, 35);

            btnForm.Click += new EventHandler(btnForm_Click);
            btnDelete.Click += new EventHandler(btnDelete_Click);

            //Main_form currentMain = (Main_form)Application.OpenForms["main_form"];
            foreach ( Control item in this.Controls ) {
                if ( item is TableLayoutPanel && item.Tag == tag ) {
                    item.Controls.Add(panel);
                    panel.Controls.Add(btnDelete); //btnDelete is over btnForm
                    panel.Controls.Add(btnForm);
                    break;
                }
            }
        }//End AddUI()


        /// <summary>
        /// Remove UI which has deleted DB
        /// </summary>
        /// <param name="tag"></param>Tag of the object need to be deleted
        /// <returns></returns>
        private void RemoveUI (int tag) {
            //Remove the panel containing btnForm & btnDelete
            foreach ( Control tbLayoutP in this.Controls.OfType<TableLayoutPanel>() ) {
                foreach ( Control item in tbLayoutP.Controls ) {
                    if ( item is Panel ) {
                        foreach ( Button subItem in item.Controls ) {
                            if ( subItem.Tag.ToString().StartsWith(tag.ToString()) /*( int )subItem.Tag == tag*/ ) {
                                tbLayoutP.Controls.Remove(item);
                            }
                        }
                    }
                }
            }
        }//End RemoveUI()
    }
}
