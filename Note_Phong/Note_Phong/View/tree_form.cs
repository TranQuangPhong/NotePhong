using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Note_Phong.Controllers;
using Note_Phong.Model;

namespace Note_Phong.View {
    public partial class Tree_form : Form {
        public event EventHandler eNew_Instance_Created; //Send to main to register event of new Detail_form instance

        Controller controller;

        public Tree_form () {
            InitializeComponent();
            controller = new Controller();
        }

        private void tree_form_Load (object sender, EventArgs e) {
            Dictionary<int, string> dictionary = controller.QueryAllRoot(DBDetailForm.DB_TABLE_NAME);
            foreach ( KeyValuePair<int, string> item in dictionary ) {
                TreeNode root = new TreeNode(item.Value);
                root.Tag = item.Key;
                treeView.Nodes.Add(root);

                load_nodes_recursive(root);
            }
        }

        private void treeView_MouseDoubleClick (object sender, MouseEventArgs e) {
            //treeView.SelectedNode.Tag = 5; TODO: remove this code
            Detail_form df = new Detail_form(( int )treeView.SelectedNode.Tag);
            if ( eNew_Instance_Created != null )
                eNew_Instance_Created.Invoke(df, e);

            df.Show();
        }

        private void load_nodes_recursive (TreeNode parentNode) {
            try {
                Dictionary<int, string> dictionaryChild = controller.QueryAllChildren(DBDetailForm.DB_TABLE_NAME, (int)parentNode.Tag);
                if ( dictionaryChild.Count <= 0 ) {
                    return;
                }
                foreach ( KeyValuePair<int, string> item in dictionaryChild ) {
                    TreeNode node = new TreeNode(item.Value);
                    node.Tag = item.Key;
                    parentNode.Nodes.Add(node);

                    load_nodes_recursive(node);
                }
            } catch(Exception e) {
                MessageBox.Show(e.Message);
                return;
            }
        }

    }
}
