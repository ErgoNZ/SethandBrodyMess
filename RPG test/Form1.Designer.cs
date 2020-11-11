namespace RPG_test
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
            this.components = new System.ComponentModel.Container();
            this.lblTarget = new System.Windows.Forms.Label();
            this.tmrTarget = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblEnemy2 = new System.Windows.Forms.Label();
            this.lblEnemy3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(157, 199);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(0, 17);
            this.lblTarget.TabIndex = 0;
            // 
            // tmrTarget
            // 
            this.tmrTarget.Enabled = true;
            this.tmrTarget.Tick += new System.EventHandler(this.tmrTarget_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // lblEnemy2
            // 
            this.lblEnemy2.AutoSize = true;
            this.lblEnemy2.Location = new System.Drawing.Point(284, 199);
            this.lblEnemy2.Name = "lblEnemy2";
            this.lblEnemy2.Size = new System.Drawing.Size(0, 17);
            this.lblEnemy2.TabIndex = 2;
            // 
            // lblEnemy3
            // 
            this.lblEnemy3.AutoSize = true;
            this.lblEnemy3.Location = new System.Drawing.Point(349, 199);
            this.lblEnemy3.Name = "lblEnemy3";
            this.lblEnemy3.Size = new System.Drawing.Size(0, 17);
            this.lblEnemy3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEnemy3);
            this.Controls.Add(this.lblEnemy2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTarget);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Timer tmrTarget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEnemy2;
        private System.Windows.Forms.Label lblEnemy3;
    }
}

