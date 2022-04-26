
namespace Clicker
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MoneyText = new System.Windows.Forms.Label();
            this.CoinsPerClick = new System.Windows.Forms.Label();
            this.OpenShopButton = new System.Windows.Forms.Button();
            this.ClickButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // MoneyText
            // 
            this.MoneyText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MoneyText.AutoSize = true;
            this.MoneyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoneyText.Location = new System.Drawing.Point(25, 227);
            this.MoneyText.Name = "MoneyText";
            this.MoneyText.Size = new System.Drawing.Size(168, 39);
            this.MoneyText.TabIndex = 1;
            this.MoneyText.Text = "Деньги: 0";
            this.MoneyText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CoinsPerClick
            // 
            this.CoinsPerClick.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CoinsPerClick.AutoSize = true;
            this.CoinsPerClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoinsPerClick.Location = new System.Drawing.Point(25, 301);
            this.CoinsPerClick.Name = "CoinsPerClick";
            this.CoinsPerClick.Size = new System.Drawing.Size(261, 39);
            this.CoinsPerClick.TabIndex = 2;
            this.CoinsPerClick.Text = "Заработок: 100";
            this.CoinsPerClick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpenShopButton
            // 
            this.OpenShopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenShopButton.Location = new System.Drawing.Point(32, 369);
            this.OpenShopButton.Name = "OpenShopButton";
            this.OpenShopButton.Size = new System.Drawing.Size(211, 50);
            this.OpenShopButton.TabIndex = 3;
            this.OpenShopButton.Text = "Магазин";
            this.OpenShopButton.UseVisualStyleBackColor = true;
            this.OpenShopButton.Click += new System.EventHandler(this.OpenShopButton_Click);
            // 
            // ClickButton
            // 
            this.ClickButton.BackgroundImage = global::Clicker.Properties.Resources.kisspng_money_bag_coin_gold_gold_bag_5a9761402667f5_5555762815198702721573;
            this.ClickButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClickButton.FlatAppearance.BorderSize = 0;
            this.ClickButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClickButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClickButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClickButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClickButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ClickButton.Location = new System.Drawing.Point(357, 12);
            this.ClickButton.Name = "ClickButton";
            this.ClickButton.Size = new System.Drawing.Size(522, 611);
            this.ClickButton.TabIndex = 0;
            this.ClickButton.UseVisualStyleBackColor = true;
            this.ClickButton.Click += new System.EventHandler(this.ClickButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(891, 648);
            this.Controls.Add(this.OpenShopButton);
            this.Controls.Add(this.CoinsPerClick);
            this.Controls.Add(this.MoneyText);
            this.Controls.Add(this.ClickButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClickButton;
        private System.Windows.Forms.Label MoneyText;
        private System.Windows.Forms.Label CoinsPerClick;
        private System.Windows.Forms.Button OpenShopButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

