using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Clicker
{
    class GameController
    {
        private int money { get; set; }
        private int coinsPerClick { get; set; }

        private string defaultParametrs = "0 100";
        private string dataPath = "data.txt";

        public delegate void ParametrsChange();
        public event ParametrsChange parametrsChange;


        public GameController()  
        {
            ShopForm.coinsPerClickUpdate += UpdateCoinsPerClick;
            GetSaveData();
        }


        private void GetSaveData()
        {
            FileStream data = new FileStream(dataPath, FileMode.OpenOrCreate);
            byte[] byteArray = new byte[data.Length];
            data.Read(byteArray, 0, byteArray.Length);
            string text = Encoding.Default.GetString(byteArray);

            if (text == "")
            {
                byte[] buffer = Encoding.Default.GetBytes(defaultParametrs);
                data.Write(buffer, 0, buffer.Length);
                text = defaultParametrs;
            }

            string[] textArray = text.Split();
            money = int.Parse(textArray[0]);
            coinsPerClick = int.Parse(textArray[1]);  

            data.Close();
        }

        public void SaveData()
        {
            FileStream data = new FileStream(dataPath, FileMode.OpenOrCreate);
            byte[] byteArray = Encoding.Default.GetBytes($"{money} {coinsPerClick}");
            data.Write(byteArray, 0, byteArray.Length);
            data.Close();
        }

        public void Click()
        {
            money += coinsPerClick;
            SaveData();
        }

        public void UpdateCoinsPerClick(int cost, int value)
        {
            if (money >= cost)
            {
                money -= cost;
                coinsPerClick += value;
                parametrsChange?.Invoke();
                SaveData();
            }
        }

        public int GetMoney
        {
            get
            {
                return money;
            }
        }

        public int GetCoinsPerClick
        {
            get
            {
                return coinsPerClick;
            }
        }
    }
}
