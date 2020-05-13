namespace Zadanie16_Listy
{
    partial class MainForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lblSelectionMode = new System.Windows.Forms.Label();
            this.comboSelectionMode = new System.Windows.Forms.ComboBox();
            this.btnLB1ToLB2 = new System.Windows.Forms.Button();
            this.btnLB2ToLB1 = new System.Windows.Forms.Button();
            this.btnClearChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(259, 407);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(442, 23);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox2.Size = new System.Drawing.Size(259, 407);
            this.listBox2.TabIndex = 3;
            // 
            // lblSelectionMode
            // 
            this.lblSelectionMode.AutoSize = true;
            this.lblSelectionMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSelectionMode.Location = new System.Drawing.Point(288, 26);
            this.lblSelectionMode.Name = "lblSelectionMode";
            this.lblSelectionMode.Size = new System.Drawing.Size(147, 24);
            this.lblSelectionMode.TabIndex = 4;
            this.lblSelectionMode.Text = "Selection Mode:";
            // 
            // comboSelectionMode
            // 
            this.comboSelectionMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboSelectionMode.FormattingEnabled = true;
            this.comboSelectionMode.Items.AddRange(new object[] {
            "One",
            "Multi Simple",
            "Multi Extended"});
            this.comboSelectionMode.Location = new System.Drawing.Point(293, 66);
            this.comboSelectionMode.Name = "comboSelectionMode";
            this.comboSelectionMode.Size = new System.Drawing.Size(134, 24);
            this.comboSelectionMode.TabIndex = 5;
            this.comboSelectionMode.SelectedIndexChanged += new System.EventHandler(this.comboSelectionMode_SelectedIndexChanged);
            // 
            // btnLB1ToLB2
            // 
            this.btnLB1ToLB2.Location = new System.Drawing.Point(308, 120);
            this.btnLB1ToLB2.Name = "btnLB1ToLB2";
            this.btnLB1ToLB2.Size = new System.Drawing.Size(107, 101);
            this.btnLB1ToLB2.TabIndex = 6;
            this.btnLB1ToLB2.Text = ">>>";
            this.btnLB1ToLB2.UseVisualStyleBackColor = true;
            this.btnLB1ToLB2.Click += new System.EventHandler(this.btnLB1ToLB2_Click);
            // 
            // btnLB2ToLB1
            // 
            this.btnLB2ToLB1.Location = new System.Drawing.Point(308, 237);
            this.btnLB2ToLB1.Name = "btnLB2ToLB1";
            this.btnLB2ToLB1.Size = new System.Drawing.Size(107, 101);
            this.btnLB2ToLB1.TabIndex = 7;
            this.btnLB2ToLB1.Text = "<<<";
            this.btnLB2ToLB1.UseVisualStyleBackColor = true;
            this.btnLB2ToLB1.Click += new System.EventHandler(this.btnLB2ToLB1_Click);
            // 
            // btnClearChanges
            // 
            this.btnClearChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClearChanges.Location = new System.Drawing.Point(308, 369);
            this.btnClearChanges.Name = "btnClearChanges";
            this.btnClearChanges.Size = new System.Drawing.Size(107, 51);
            this.btnClearChanges.TabIndex = 8;
            this.btnClearChanges.Text = "Clear Changes";
            this.btnClearChanges.UseVisualStyleBackColor = true;
            this.btnClearChanges.Click += new System.EventHandler(this.btnClearChanges_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 455);
            this.Controls.Add(this.btnClearChanges);
            this.Controls.Add(this.btnLB2ToLB1);
            this.Controls.Add(this.btnLB1ToLB2);
            this.Controls.Add(this.comboSelectionMode);
            this.Controls.Add(this.lblSelectionMode);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(744, 493);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List to List Transfer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lblSelectionMode;
        private System.Windows.Forms.ComboBox comboSelectionMode;
        private System.Windows.Forms.Button btnLB1ToLB2;
        private System.Windows.Forms.Button btnLB2ToLB1;
        private System.Windows.Forms.Button btnClearChanges;
    }
}

