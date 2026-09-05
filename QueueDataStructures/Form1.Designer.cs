namespace QueueDataStructures
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstQueue;
        private System.Windows.Forms.Button btnServe;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblCounts;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstQueue = new System.Windows.Forms.ListBox();
            this.btnServe = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblService = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblCounts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbService
            // 
            this.cmbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbService.Items.AddRange(new object[] {
            "Express",
            "Premium",
            "Standard",
            "Same day delivery"});
            this.cmbService.SelectedIndex = 0;
            this.cmbService.Location = new System.Drawing.Point(24, 48);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(220, 23);
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(24, 110);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.PlaceholderText = "Enter customer / order";
            this.txtCustomer.Size = new System.Drawing.Size(220, 23);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.Text = "Add to Queue";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnServe
            // 
            this.btnServe.Location = new System.Drawing.Point(144, 150);
            this.btnServe.Name = "btnServe";
            this.btnServe.Size = new System.Drawing.Size(100, 30);
            this.btnServe.Text = "Serve Next";
            this.btnServe.UseVisualStyleBackColor = true;
            this.btnServe.Click += new System.EventHandler(this.btnServe_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(24, 200);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(220, 30);
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstQueue
            // 
            this.lstQueue.FormattingEnabled = true;
            this.lstQueue.ItemHeight = 15;
            this.lstQueue.Location = new System.Drawing.Point(280, 24);
            this.lstQueue.Name = "lstQueue";
            this.lstQueue.Size = new System.Drawing.Size(480, 364);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(24, 24);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(79, 15);
            this.lblService.Text = "Choose Service";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(24, 88);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(93, 15);
            this.lblCustomer.Text = "Customer / Order";
            // 
            // lblCounts
            // 
            this.lblCounts.AutoSize = true;
            this.lblCounts.Location = new System.Drawing.Point(24, 250);
            this.lblCounts.Name = "lblCounts";
            this.lblCounts.Size = new System.Drawing.Size(100, 15);
            this.lblCounts.Text = "Counts: E:0 P:0 S:0 SD:0";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.lblCounts);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnServe);
            this.Controls.Add(this.lstQueue);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.cmbService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Delivery Queue Manager";
            this.BackColor = System.Drawing.Color.FromArgb(255, 230, 235); // soft pink
            // Theme: set controls background where appropriate
            this.cmbService.BackColor = System.Drawing.Color.White;
            this.txtCustomer.BackColor = System.Drawing.Color.White;
            this.lstQueue.BackColor = System.Drawing.Color.FromArgb(255, 255, 240); // light yellow
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(255, 250, 240);
            this.btnServe.BackColor = System.Drawing.Color.FromArgb(255, 250, 240);
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(255, 250, 240);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
