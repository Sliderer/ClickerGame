
namespace Clicker
{
    partial class ShopForm
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
            this.Bonus10 = new System.Windows.Forms.Button();
            this.Bonus20 = new System.Windows.Forms.Button();
            this.Bonus30 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bonus10
            // 
            this.Bonus10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bonus10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bonus10.Location = new System.Drawing.Point(170, 60);
            this.Bonus10.Name = "Bonus10";
            this.Bonus10.Padding = new System.Windows.Forms.Padding(10);
            this.Bonus10.Size = new System.Drawing.Size(463, 72);
            this.Bonus10.TabIndex = 0;
            this.Bonus10.Text = "+10 к зарплате за 1000 нажатий";
            this.Bonus10.UseVisualStyleBackColor = true;
            this.Bonus10.Click += new System.EventHandler(this.Bonus10_Click);
            // 
            // Bonus20
            // 
            this.Bonus20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bonus20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bonus20.Location = new System.Drawing.Point(170, 180);
            this.Bonus20.Name = "Bonus20";
            this.Bonus20.Padding = new System.Windows.Forms.Padding(10);
            this.Bonus20.Size = new System.Drawing.Size(463, 72);
            this.Bonus20.TabIndex = 1;
            this.Bonus20.Text = "+20 к зарплате за 2000 нажатий";
            this.Bonus20.UseVisualStyleBackColor = true;
            this.Bonus20.Click += new System.EventHandler(this.Bonus20_Click);
            // 
            // Bonus30
            // 
            this.Bonus30.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bonus30.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bonus30.Location = new System.Drawing.Point(170, 300);
            this.Bonus30.Name = "Bonus30";
            this.Bonus30.Padding = new System.Windows.Forms.Padding(10);
            this.Bonus30.Size = new System.Drawing.Size(463, 72);
            this.Bonus30.TabIndex = 2;
            this.Bonus30.Text = "+30 к зарплате за 3000 нажатий";
            this.Bonus30.UseVisualStyleBackColor = true;
            this.Bonus30.Click += new System.EventHandler(this.Bonus30_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bonus30);
            this.Controls.Add(this.Bonus20);
            this.Controls.Add(this.Bonus10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ShopForm";
            this.Text = "ShopForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bonus10;
        private System.Windows.Forms.Button Bonus20;
        private System.Windows.Forms.Button Bonus30;
    }
}