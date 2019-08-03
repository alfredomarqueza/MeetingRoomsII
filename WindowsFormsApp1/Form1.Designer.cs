namespace WindowsFormsApp1
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
            this.btn_Allocate = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listViewIntervals = new System.Windows.Forms.ListView();
            this.columnHeaderStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.numericUpDownStart = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEnd = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Allocate
            // 
            this.btn_Allocate.Location = new System.Drawing.Point(164, 245);
            this.btn_Allocate.Name = "btn_Allocate";
            this.btn_Allocate.Size = new System.Drawing.Size(75, 23);
            this.btn_Allocate.TabIndex = 0;
            this.btn_Allocate.Text = "Allocate";
            this.btn_Allocate.UseVisualStyleBackColor = true;
            this.btn_Allocate.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 274);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 70);
            this.textBox2.TabIndex = 2;
            // 
            // listViewIntervals
            // 
            this.listViewIntervals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderStart,
            this.columnHeaderEnd});
            this.listViewIntervals.FullRowSelect = true;
            this.listViewIntervals.GridLines = true;
            this.listViewIntervals.Location = new System.Drawing.Point(83, 91);
            this.listViewIntervals.MultiSelect = false;
            this.listViewIntervals.Name = "listViewIntervals";
            this.listViewIntervals.Size = new System.Drawing.Size(156, 148);
            this.listViewIntervals.TabIndex = 3;
            this.listViewIntervals.UseCompatibleStateImageBehavior = false;
            this.listViewIntervals.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderStart
            // 
            this.columnHeaderStart.Tag = "";
            this.columnHeaderStart.Text = "Start";
            this.columnHeaderStart.Width = 74;
            // 
            // columnHeaderEnd
            // 
            this.columnHeaderEnd.Tag = "";
            this.columnHeaderEnd.Text = "End";
            this.columnHeaderEnd.Width = 74;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(83, 34);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(164, 34);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 5;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // numericUpDownStart
            // 
            this.numericUpDownStart.Location = new System.Drawing.Point(84, 64);
            this.numericUpDownStart.Name = "numericUpDownStart";
            this.numericUpDownStart.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownStart.TabIndex = 6;
            // 
            // numericUpDownEnd
            // 
            this.numericUpDownEnd.Location = new System.Drawing.Point(164, 64);
            this.numericUpDownEnd.Name = "numericUpDownEnd";
            this.numericUpDownEnd.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownEnd.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 435);
            this.Controls.Add(this.numericUpDownEnd);
            this.Controls.Add(this.numericUpDownStart);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.listViewIntervals);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_Allocate);
            this.Name = "Form1";
            this.Text = "Meeting Rooms II";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Allocate;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView listViewIntervals;
        private System.Windows.Forms.ColumnHeader columnHeaderStart;
        private System.Windows.Forms.ColumnHeader columnHeaderEnd;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.NumericUpDown numericUpDownStart;
        private System.Windows.Forms.NumericUpDown numericUpDownEnd;
    }
}

