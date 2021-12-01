
namespace MenuRecursion
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
            this.btnDrawMenu = new System.Windows.Forms.Button();
            this.txtMenu = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDrawMenu
            // 
            this.btnDrawMenu.Location = new System.Drawing.Point(16, 106);
            this.btnDrawMenu.Name = "btnDrawMenu";
            this.btnDrawMenu.Size = new System.Drawing.Size(260, 77);
            this.btnDrawMenu.TabIndex = 0;
            this.btnDrawMenu.Text = "Draw";
            this.btnDrawMenu.UseVisualStyleBackColor = true;
            this.btnDrawMenu.Click += new System.EventHandler(this.btnDrawMenu_Click);
            // 
            // txtMenu
            // 
            this.txtMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtMenu.Location = new System.Drawing.Point(302, 0);
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(854, 588);
            this.txtMenu.TabIndex = 1;
            this.txtMenu.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Draw Multiple Level Recursion Menu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMenu);
            this.Controls.Add(this.btnDrawMenu);
            this.Name = "Form1";
            this.Text = "Draw Menu ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDrawMenu;
        private System.Windows.Forms.RichTextBox txtMenu;
        private System.Windows.Forms.Label label1;
    }
}

