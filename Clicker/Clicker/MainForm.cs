using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    public partial class MainForm : Form
    {
        internal GameController controller;
        private ShopForm shopForm;

        public MainForm()
        {
            InitializeComponent();
            controller = new GameController();
            controller.parametrsChange += UpdateTextinfo;
            UpdateTextinfo();
        }

        private void ClickButton_Click(object sender, EventArgs e)
        {
            controller.Click();
            UpdateTextinfo();
        }

        private void UpdateTextinfo()
        {
            MoneyText.Text = $"Деньги: {controller.GetMoney}";
            CoinsPerClick.Text = $"Заработок: {controller.GetCoinsPerClick}";
        }

        private void OpenShopButton_Click(object sender, EventArgs e)
        {
            shopForm = new ShopForm();
            shopForm.Show();
        }

    }
}
