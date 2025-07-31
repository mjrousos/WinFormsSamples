using System;
using System.Data;
using System.Windows.Forms;

namespace SimpleSample
{
    partial class Form1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.toolBar = new System.Windows.Forms.ToolBar();
            this.tbtnCat = new System.Windows.Forms.ToolBarButton();
            this.tbtnDog = new System.Windows.Forms.ToolBarButton();
            this.tbtnExit = new System.Windows.Forms.ToolBarButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdateUserName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGrid();
            this.tbtnOcelot = new System.Windows.Forms.ToolBarButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(802, 519);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 29);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolBar
            // 
            this.toolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbtnCat,
            this.tbtnDog,
            this.tbtnOcelot,
            this.tbtnExit});
            this.toolBar.DropDownArrows = true;
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolBar.Name = "toolBar";
            this.toolBar.ShowToolTips = true;
            this.toolBar.Size = new System.Drawing.Size(900, 49);
            this.toolBar.TabIndex = 1;
            this.toolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar_ButtonClick);
            // 
            // tbtnCat
            // 
            this.tbtnCat.Name = "tbtnCat";
            this.tbtnCat.Text = "Cat";
            // 
            // tbtnDog
            // 
            this.tbtnDog.Name = "tbtnDog";
            this.tbtnDog.Text = "Dog";
            // 
            // tbtnExit
            // 
            this.tbtnExit.Name = "tbtnExit";
            this.tbtnExit.Text = "Exit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 469);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpdateUserName
            // 
            this.btnUpdateUserName.Location = new System.Drawing.Point(802, 122);
            this.btnUpdateUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateUserName.Name = "btnUpdateUserName";
            this.btnUpdateUserName.Size = new System.Drawing.Size(84, 35);
            this.btnUpdateUserName.TabIndex = 3;
            this.btnUpdateUserName.Text = "Update";
            this.btnUpdateUserName.UseVisualStyleBackColor = true;
            this.btnUpdateUserName.Click += new System.EventHandler(this.btnUpdateUserName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(804, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "User name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(802, 88);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(84, 26);
            this.txtUserName.TabIndex = 5;
            // 
            // dataGrid
            // 
            this.dataGrid.CaptionText = "DataGrid Example";
            this.dataGrid.DataMember = "";
            this.dataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid.Location = new System.Drawing.Point(475, 216);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(414, 272);
            this.dataGrid.TabIndex = 6;
            // 
            // tbtnOcelot
            // 
            this.tbtnOcelot.Name = "tbtnOcelot";
            this.tbtnOcelot.Text = "Ocelot";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateUserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.dataGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolBar toolBar;
        private System.Windows.Forms.ToolBarButton tbtnCat;
        private System.Windows.Forms.ToolBarButton tbtnDog;
        private System.Windows.Forms.ToolBarButton tbtnExit;
        private PictureBox pictureBox1;
        private Button btnUpdateUserName;
        private Label label1;
        private TextBox txtUserName;
        private DataGrid dataGrid;
        private string imagePath;
        private ToolBarButton tbtnOcelot;
    }
}
