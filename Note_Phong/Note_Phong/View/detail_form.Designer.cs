namespace Note_Phong.View
{
    partial class Detail_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detail_form));
            this.txtAddingTask = new System.Windows.Forms.TextBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.tasksList = new System.Windows.Forms.CheckedListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.bntNew = new System.Windows.Forms.Button();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtPickerDeadline = new System.Windows.Forms.DateTimePicker();
            this.lblId = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.childrenList = new System.Windows.Forms.ListView();
            this.lblParent = new System.Windows.Forms.Label();
            this.btnTree = new System.Windows.Forms.Button();
            this.lblChildren = new System.Windows.Forms.Label();
            this.btnFullTree = new System.Windows.Forms.Button();
            this.txtParent = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAddingTask
            // 
            this.txtAddingTask.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddingTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddingTask.Location = new System.Drawing.Point(20, 361);
            this.txtAddingTask.Multiline = true;
            this.txtAddingTask.Name = "txtAddingTask";
            this.txtAddingTask.Size = new System.Drawing.Size(293, 41);
            this.txtAddingTask.TabIndex = 8;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.Location = new System.Drawing.Point(319, 361);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 41);
            this.btnAddTask.TabIndex = 9;
            this.btnAddTask.Text = "Add";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1044, 178);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 49);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDescription.Location = new System.Drawing.Point(510, 22);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(496, 276);
            this.txtDescription.TabIndex = 10;
            this.txtDescription.Text = "Description";
            // 
            // tasksList
            // 
            this.tasksList.AllowDrop = true;
            this.tasksList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tasksList.CheckOnClick = true;
            this.tasksList.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksList.FormattingEnabled = true;
            this.tasksList.HorizontalScrollbar = true;
            this.tasksList.Items.AddRange(new object[] {
            "taskList"});
            this.tasksList.Location = new System.Drawing.Point(20, 12);
            this.tasksList.Name = "tasksList";
            this.tasksList.Size = new System.Drawing.Size(374, 326);
            this.tasksList.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1044, 249);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 49);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(1044, 104);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 49);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // bntNew
            // 
            this.bntNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntNew.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bntNew.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.bntNew.FlatAppearance.BorderSize = 2;
            this.bntNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.bntNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.bntNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNew.Location = new System.Drawing.Point(1044, 22);
            this.bntNew.Name = "bntNew";
            this.bntNew.Size = new System.Drawing.Size(102, 49);
            this.bntNew.TabIndex = 13;
            this.bntNew.Text = "New";
            this.bntNew.UseVisualStyleBackColor = false;
            this.bntNew.Click += new System.EventHandler(this.bntNew_Click);
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemoveTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTask.Location = new System.Drawing.Point(322, 273);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(75, 49);
            this.btnRemoveTask.TabIndex = 7;
            this.btnRemoveTask.Text = "Remove";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Controls.Add(this.dtPickerDeadline);
            this.panel3.Controls.Add(this.lblId);
            this.panel3.Controls.Add(this.lblLevel);
            this.panel3.Controls.Add(this.lblDeadline);
            this.panel3.Controls.Add(this.lblStatus);
            this.panel3.Controls.Add(this.txtStatus);
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Controls.Add(this.txtLevel);
            this.panel3.Controls.Add(this.txtDescription);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.bntNew);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Location = new System.Drawing.Point(115, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1182, 321);
            this.panel3.TabIndex = 45;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtName.Location = new System.Drawing.Point(20, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(376, 38);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Name";
            // 
            // dtPickerDeadline
            // 
            this.dtPickerDeadline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtPickerDeadline.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerDeadline.CustomFormat = "dd-MM-yyyy";
            this.dtPickerDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerDeadline.Location = new System.Drawing.Point(201, 206);
            this.dtPickerDeadline.Name = "dtPickerDeadline";
            this.dtPickerDeadline.Size = new System.Drawing.Size(195, 32);
            this.dtPickerDeadline.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(15, 93);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 25);
            this.lblId.TabIndex = 44;
            this.lblId.Text = "ID";
            // 
            // lblLevel
            // 
            this.lblLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(15, 146);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(59, 25);
            this.lblLevel.TabIndex = 45;
            this.lblLevel.Text = "Level";
            // 
            // lblDeadline
            // 
            this.lblDeadline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline.Location = new System.Drawing.Point(15, 206);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(89, 25);
            this.lblDeadline.TabIndex = 46;
            this.lblDeadline.Text = "Deadline";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(15, 271);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(68, 25);
            this.lblStatus.TabIndex = 47;
            this.lblStatus.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStatus.BackColor = System.Drawing.SystemColors.Window;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(201, 268);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(195, 30);
            this.txtStatus.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(201, 88);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(195, 30);
            this.txtId.TabIndex = 2;
            // 
            // txtLevel
            // 
            this.txtLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLevel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLevel.Location = new System.Drawing.Point(201, 146);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.ReadOnly = true;
            this.txtLevel.Size = new System.Drawing.Size(195, 30);
            this.txtLevel.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btnAddTask);
            this.panel4.Controls.Add(this.btnRemoveTask);
            this.panel4.Controls.Add(this.txtAddingTask);
            this.panel4.Controls.Add(this.childrenList);
            this.panel4.Controls.Add(this.tasksList);
            this.panel4.Controls.Add(this.lblParent);
            this.panel4.Controls.Add(this.btnTree);
            this.panel4.Controls.Add(this.lblChildren);
            this.panel4.Controls.Add(this.btnFullTree);
            this.panel4.Controls.Add(this.txtParent);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Location = new System.Drawing.Point(115, 408);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1182, 427);
            this.panel4.TabIndex = 46;
            // 
            // childrenList
            // 
            this.childrenList.AccessibleDescription = "";
            this.childrenList.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.childrenList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.childrenList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childrenList.Location = new System.Drawing.Point(510, 90);
            this.childrenList.MultiSelect = false;
            this.childrenList.Name = "childrenList";
            this.childrenList.Size = new System.Drawing.Size(494, 312);
            this.childrenList.TabIndex = 12;
            this.childrenList.UseCompatibleStateImageBehavior = false;
            this.childrenList.View = System.Windows.Forms.View.Tile;
            this.childrenList.ItemActivate += new System.EventHandler(this.childrenList_ItemActivate);
            // 
            // lblParent
            // 
            this.lblParent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblParent.AutoSize = true;
            this.lblParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParent.Location = new System.Drawing.Point(505, 12);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(69, 25);
            this.lblParent.TabIndex = 36;
            this.lblParent.Text = "Parent";
            // 
            // btnTree
            // 
            this.btnTree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTree.Location = new System.Drawing.Point(1044, 90);
            this.btnTree.Name = "btnTree";
            this.btnTree.Size = new System.Drawing.Size(102, 49);
            this.btnTree.TabIndex = 17;
            this.btnTree.Text = "Tree";
            this.btnTree.UseVisualStyleBackColor = true;
            // 
            // lblChildren
            // 
            this.lblChildren.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChildren.AutoSize = true;
            this.lblChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildren.Location = new System.Drawing.Point(505, 56);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(120, 25);
            this.lblChildren.TabIndex = 42;
            this.lblChildren.Text = "Children List";
            // 
            // btnFullTree
            // 
            this.btnFullTree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFullTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullTree.Location = new System.Drawing.Point(1044, 172);
            this.btnFullTree.Name = "btnFullTree";
            this.btnFullTree.Size = new System.Drawing.Size(102, 49);
            this.btnFullTree.TabIndex = 18;
            this.btnFullTree.Text = "Full tree";
            this.btnFullTree.UseVisualStyleBackColor = true;
            // 
            // txtParent
            // 
            this.txtParent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtParent.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParent.Location = new System.Drawing.Point(618, 12);
            this.txtParent.Name = "txtParent";
            this.txtParent.ReadOnly = true;
            this.txtParent.Size = new System.Drawing.Size(386, 30);
            this.txtParent.TabIndex = 11;
            this.txtParent.DoubleClick += new System.EventHandler(this.txtParent_DoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(1044, 344);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 58);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Detail_form
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1382, 903);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Detail_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail";
            this.Load += new System.EventHandler(this.detail_form_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddingTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.CheckedListBox tasksList;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button bntNew;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView childrenList;
        private System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.Button btnTree;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.Button btnFullTree;
        private System.Windows.Forms.TextBox txtParent;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtPickerDeadline;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtLevel;
    }
}