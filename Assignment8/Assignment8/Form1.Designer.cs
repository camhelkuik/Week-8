namespace Assignment8
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
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnIntegers = new System.Windows.Forms.Button();
            this.btnDoubles = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtList = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(53, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "lblName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 506);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Search Key";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(55, 580);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(118, 25);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "resultLabel";
            // 
            // btnIntegers
            // 
            this.btnIntegers.Location = new System.Drawing.Point(59, 86);
            this.btnIntegers.Name = "btnIntegers";
            this.btnIntegers.Size = new System.Drawing.Size(208, 56);
            this.btnIntegers.TabIndex = 3;
            this.btnIntegers.Text = "Create &Integers";
            this.btnIntegers.UseVisualStyleBackColor = true;
            this.btnIntegers.Click += new System.EventHandler(this.btnIntegers_Click);
            // 
            // btnDoubles
            // 
            this.btnDoubles.Location = new System.Drawing.Point(336, 86);
            this.btnDoubles.Name = "btnDoubles";
            this.btnDoubles.Size = new System.Drawing.Size(208, 56);
            this.btnDoubles.TabIndex = 4;
            this.btnDoubles.Text = "Create &Doubles";
            this.btnDoubles.UseVisualStyleBackColor = true;
            this.btnDoubles.Click += new System.EventHandler(this.btnDoubles_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(59, 638);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(485, 42);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(59, 717);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(485, 42);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(59, 787);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(485, 42);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(59, 174);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtList.Size = new System.Drawing.Size(485, 278);
            this.txtList.TabIndex = 8;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(300, 500);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(244, 31);
            this.txtSearch.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 891);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDoubles);
            this.Controls.Add(this.btnIntegers);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnIntegers;
        private System.Windows.Forms.Button btnDoubles;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

