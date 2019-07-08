namespace Note_Phong.View
{
    partial class CreateNew_form
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
            this.lblNewGoalName = new System.Windows.Forms.Label();
            this.lblNewGoalId = new System.Windows.Forms.Label();
            this.txtNewGoalName = new System.Windows.Forms.TextBox();
            this.txtNewGoalId = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewGoalName
            // 
            this.lblNewGoalName.AutoSize = true;
            this.lblNewGoalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewGoalName.Location = new System.Drawing.Point(61, 40);
            this.lblNewGoalName.Name = "lblNewGoalName";
            this.lblNewGoalName.Size = new System.Drawing.Size(64, 25);
            this.lblNewGoalName.TabIndex = 0;
            this.lblNewGoalName.Text = "Name";
            // 
            // lblNewGoalId
            // 
            this.lblNewGoalId.AutoSize = true;
            this.lblNewGoalId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewGoalId.Location = new System.Drawing.Point(61, 98);
            this.lblNewGoalId.Name = "lblNewGoalId";
            this.lblNewGoalId.Size = new System.Drawing.Size(31, 25);
            this.lblNewGoalId.TabIndex = 1;
            this.lblNewGoalId.Text = "ID";
            // 
            // txtNewGoalName
            // 
            this.txtNewGoalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewGoalName.Location = new System.Drawing.Point(154, 35);
            this.txtNewGoalName.Multiline = true;
            this.txtNewGoalName.Name = "txtNewGoalName";
            this.txtNewGoalName.Size = new System.Drawing.Size(342, 30);
            this.txtNewGoalName.TabIndex = 2;
            // 
            // txtNewGoalId
            // 
            this.txtNewGoalId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewGoalId.Location = new System.Drawing.Point(154, 93);
            this.txtNewGoalId.Multiline = true;
            this.txtNewGoalId.Name = "txtNewGoalId";
            this.txtNewGoalId.Size = new System.Drawing.Size(342, 30);
            this.txtNewGoalId.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(120, 198);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(103, 48);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(333, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 48);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CreateNew_form
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(576, 331);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNewGoalId);
            this.Controls.Add(this.txtNewGoalName);
            this.Controls.Add(this.lblNewGoalId);
            this.Controls.Add(this.lblNewGoalName);
            this.Name = "CreateNew_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create a new goal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewGoalName;
        private System.Windows.Forms.Label lblNewGoalId;
        private System.Windows.Forms.TextBox txtNewGoalName;
        private System.Windows.Forms.TextBox txtNewGoalId;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}