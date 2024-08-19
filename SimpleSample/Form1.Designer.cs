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
            // TODO ToolBar is no longer supported. Use ToolStrip instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
            this.toolBar = new System.Windows.Forms.ToolBar();
            // TODO ToolBarButton is no longer supported. Use ToolStripButton instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
            this.tbtnCat = new System.Windows.Forms.ToolBarButton();
            // TODO ToolBarButton is no longer supported. Use ToolStripButton instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
            this.tbtnDog = new System.Windows.Forms.ToolBarButton();
            // TODO ToolBarButton is no longer supported. Use ToolStripButton instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
            this.tbtnExit = new System.Windows.Forms.ToolBarButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdateUserName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            // TODO DataGrid is no longer supported. Use DataGridView instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
            this.dataGrid = new System.Windows.Forms.DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(713, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolBar
            // 
            // TODO ToolBarButton is no longer supported. Use ToolStripButton instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
                                                this.toolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbtnCat,
            this.tbtnDog,
            this.tbtnExit});
            this.toolBar.DropDownArrows = true;
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.ShowToolTips = true;
            this.toolBar.Size = new System.Drawing.Size(800, 45);
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
            this.pictureBox1.Location = new System.Drawing.Point(12, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 375);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpdateUserName
            // 
            this.btnUpdateUserName.Location = new System.Drawing.Point(713, 98);
            this.btnUpdateUserName.Name = "btnUpdateUserName";
            this.btnUpdateUserName.Size = new System.Drawing.Size(75, 28);
            this.btnUpdateUserName.TabIndex = 3;
            this.btnUpdateUserName.Text = "Update";
            this.btnUpdateUserName.UseVisualStyleBackColor = true;
            this.btnUpdateUserName.Click += new System.EventHandler(this.btnUpdateUserName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(715, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "User name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(713, 70);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(75, 22);
            this.txtUserName.TabIndex = 5;
            // 
            // dataGrid
            // 
            this.dataGrid.CaptionText = "DataGrid Example";
            this.dataGrid.DataMember = "";
            this.dataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid.Location = new System.Drawing.Point(422, 173);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(368, 218);
            this.dataGrid.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateUserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.dataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        // TODO ToolBar is no longer supported. Use ToolStrip instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
        private System.Windows.Forms.ToolBar toolBar;
        // TODO ToolBarButton is no longer supported. Use ToolStripButton instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
        private System.Windows.Forms.ToolBarButton tbtnCat;
        // TODO ToolBarButton is no longer supported. Use ToolStripButton instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
        private System.Windows.Forms.ToolBarButton tbtnDog;
        // TODO ToolBarButton is no longer supported. Use ToolStripButton instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
        private System.Windows.Forms.ToolBarButton tbtnExit;
        private PictureBox pictureBox1;
        private Button btnUpdateUserName;
        private Label label1;
        private TextBox txtUserName;
        // TODO DataGrid is no longer supported. Use DataGridView instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
        private DataGrid dataGrid;
        private string imagePath;
    }
}
