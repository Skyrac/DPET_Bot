
namespace DPET_Bot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.cursor_label = new System.Windows.Forms.Label();
            this.cursor_x = new System.Windows.Forms.Label();
            this.cursor_y = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cursor_label
            // 
            this.cursor_label.AutoSize = true;
            this.cursor_label.Location = new System.Drawing.Point(12, 9);
            this.cursor_label.Name = "cursor_label";
            this.cursor_label.Size = new System.Drawing.Size(42, 15);
            this.cursor_label.TabIndex = 0;
            this.cursor_label.Text = "Cursor";
            // 
            // cursor_x
            // 
            this.cursor_x.AccessibleName = "cursor_x";
            this.cursor_x.AutoSize = true;
            this.cursor_x.Location = new System.Drawing.Point(56, 9);
            this.cursor_x.Name = "cursor_x";
            this.cursor_x.Size = new System.Drawing.Size(13, 15);
            this.cursor_x.TabIndex = 1;
            this.cursor_x.Text = "0";
            // 
            // cursor_y
            // 
            this.cursor_y.AutoSize = true;
            this.cursor_y.Location = new System.Drawing.Point(89, 9);
            this.cursor_y.Name = "cursor_y";
            this.cursor_y.Size = new System.Drawing.Size(13, 15);
            this.cursor_y.TabIndex = 2;
            this.cursor_y.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cursor_y);
            this.Controls.Add(this.cursor_x);
            this.Controls.Add(this.cursor_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cursor_label;
        private System.Windows.Forms.Label cursor_x;
        private System.Windows.Forms.Label cursor_y;
    }
}

