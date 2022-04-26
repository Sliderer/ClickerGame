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
    public partial class ShopForm : Form
    {
        private int[] prices = { 1000, 2000, 3000 };
        private int[] values = { 10, 20, 30 };

        public delegate void CoinsPerClickUpdate(int cost, int value);
        public static event CoinsPerClickUpdate coinsPerClickUpdate;

        public ShopForm()
        {
            InitializeComponent();
        }

        private void Bonus10_Click(object sender, EventArgs e)
        {
            AddCoinsPerClick(prices[0], values[0]);
        }

        private void Bonus20_Click(object sender, EventArgs e)
        {
            AddCoinsPerClick(prices[1], values[1]);
        }
        
        private void Bonus30_Click(object sender, EventArgs e)
        {
            AddCoinsPerClick(prices[2], values[2]);
        }

        private void AddCoinsPerClick(int cost, int value)
        {
            coinsPerClickUpdate?.Invoke(cost, value);
        }

    }
}
