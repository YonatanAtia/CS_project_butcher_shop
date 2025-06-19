using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;



namespace Butcher_Shop
{
    using System;
    using System.Collections;
    using static Program;
    public partial class Form1 : Form
    {
        CartList Cart_List = new CartList();

        

        string receipt = "-----------------------------------------------\n" +
                         "           JONATHAN'S & YAHEL'S BUTCHER        \n" +
                         "-----------------------------------------------\n" +
                         "Product                            Price           Code";
        
        public void updateReceipt()
        {
            richTextBox1.Text = receipt+"\n\n";
            for (int i = 0; i < 18; i++)
            {
                if (CartList._prdDtlArr[i].amount > 0)
                {
                    richTextBox1.Text += CartList._prdDtlArr[i].name + "  " + "X" + CartList._prdDtlArr[i].amount + "               " +
                        (double)System.Math.Round(CartList._prdDtlArr[i].price, 2) + "        " + CartList._prdDtlArr[i].serialNum;
                    richTextBox1.Text += "\n";
                }
                
            }
            CartList.totalAmount = (double)System.Math.Round(CartList.totalAmount, 2);
            richTextBox1.Text += "\n\n\n\n"+"          TOTAL PRICE: "+ CartList.totalAmount;
            richTextBox1.Text += "\n-----------------------------------------------";
        }
        public Form1()
        {
            CartList.zeroPrice();
            InitializeComponent();
            richTextBox1.Text += receipt;
            richTextBox1.Text += "\n\n\n\n" + "          TOTAL PRICE: " + CartList.totalAmount;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //*********************ORDERRING BUTTONS*************************//
        private void button1_Click(object sender, EventArgs e)//Hot dog Buton; Count 0;
        {
            Cart_List.Add(new cattle(0, false, 20, "Italy", "425372", "Hot Dog      ", 4.55));//Whole Chicken
            CartList.add(0, 4.55);
            CartList.totalAmount += 4.55;
            updateReceipt();
            Btn_P_0.Visible = true;
        }
        private void Btn_P_HOTDOG_Click(object sender, EventArgs e) // remove product 0
        {
            if (CartList._prdDtlArr[0].amount > 0)
            {
                CartList.sub(0, 4.55);
                CartList.totalAmount -= 4.55;
                updateReceipt();
            }
            
            if (CartList._prdDtlArr[0].amount == 0)
                Btn_P_0.Visible = false;
        }
        private void BtnSinta_Click(object sender, EventArgs e)//Count 1
        {
            Cart_List.Add(new cattle(11, false, 8, "Argentina", "397271", "Sinta        ", 11));
            CartList.add(1, 11);
            CartList.totalAmount += 11;
            updateReceipt();
            Btn_P_1.Visible = true;
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            if (CartList._prdDtlArr[1].amount > 0)
            {
                CartList.sub(1, 11);
                CartList.totalAmount -= 11;
                updateReceipt();
            }

            if (CartList._prdDtlArr[1].amount == 0)
                Btn_P_1.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)//steak //Count 2
        {
            Cart_List.Add(new cattle(1, true, 25, "Argentina", "666666", "Steak        ", 16));
            //if (CartList._prdDtlArr[2].amount > 0){ Btn_P_0.Visible = true;}
            CartList.add(2, 16);
            CartList.totalAmount += 16;
            updateReceipt();
            Btn_P_2.Visible = true;

        }
        private void BtnWings_Click(object sender, EventArgs e)//Count 3
        {
            Cart_List.Add(new Chicken("Wings", false, 8.5, "Israel", "665588", "Chicken Wings", 2));
            CartList.add(3, 2);
            CartList.totalAmount += 2;
            updateReceipt();
            Btn_P_3.Visible = true;
        }
        private void BtnWholeChicken_Click(object sender, EventArgs e)//Count 4
        {
            Cart_List.Add(new Chicken("Whole Chicken", false, 5.5, "Israel",
                "796366", "whole Chicken", 2.5));
            CartList.add(4, 2.5);
            CartList.totalAmount += 2.5;
            updateReceipt();
            Btn_P_4.Visible = true;
        }
        private void BtnLegs_Click(object sender, EventArgs e)//Count 5
        {
            Cart_List.Add(new Chicken("Legs", true, 5.5, "Israel", "549131", "Chicken legs ", 2.6));
            CartList.add(5, 2.6);
            CartList.totalAmount += 2.6;
            updateReceipt();
            Btn_P_5.Visible = true;
        }
        private void BtnTuna_Click(object sender, EventArgs e)//Count 6
        {
            Cart_List.Add(new Fish(true, true, 6.5, "Japan", "357148", "Tuna         ", 7.5));
            CartList.add(6, 7.5);
            CartList.totalAmount += 7.5;
            updateReceipt();
            Btn_P_6.Visible = true;
        }
        private void BtnAmnom_Click(object sender, EventArgs e)//Count 7
        {
            Cart_List.Add(new Fish(false, false, 10, "Israel", "235777", "Amnon        ", 3.7));
            CartList.add(7, 3.7);
            CartList.totalAmount += 3.7;
            updateReceipt();
            Btn_P_7.Visible = true;
        }
        private void BtnSalmon_Click(object sender, EventArgs e)//Count 8
        {
            Cart_List.Add(new Fish(true, false, 10, "Norway", "996378", "Salmon       ", 12.5));
            CartList.add(8, 12.5);
            CartList.totalAmount += 12.5;
            updateReceipt();
            Btn_P_8.Visible = true;
        }
        //******************drinks butons*********************//
        private void BtnTaquila_Click(object sender, EventArgs e)//Count 9
        {
            Cart_List.Add(new other_Alchohol_Drink(40, "Mexico", "548941", "Taquila      ", 80));
            CartList.add(9, 80);
            CartList.totalAmount += 80;
            updateReceipt();
            Btn_P_9.Visible = true;
        }
        private void BtnJin_Click(object sender, EventArgs e)//Count 10
        {
            Cart_List.Add(new other_Alchohol_Drink(47.3, "France", "116633", "Jin          ", 99));
            CartList.add(10, 99);
            CartList.totalAmount += 99;
            updateReceipt();
            Btn_P_10.Visible = true;
        }
        private void BtnVodka_Click(object sender, EventArgs e)//Count 11
        {
            Cart_List.Add(new other_Alchohol_Drink(40, "Russia", "479966", "Vodka        ", 75));
            CartList.add(11, 75);
            CartList.totalAmount += 75;
            updateReceipt();
            Btn_P_11.Visible = true;
        }
        private void BtnRedWine1_Click(object sender, EventArgs e)//Count 12
        {
            Cart_List.Add(new Wine("Cabernet Sauvignon", 10, true, true, false,
                14.5, "Spain", "568648", "Rioja        ", 75));
            CartList.add(12, 75);
            CartList.totalAmount += 75;
            updateReceipt();
            Btn_P_12.Visible = true;
        }
        private void BtnRedWine2_Click(object sender, EventArgs e)//Count 13
        {
            Cart_List.Add(new Wine("Marlo", 12, true, true, false, 13.2, "Israel",
                "684662", "Bazelet      ", 149));
            CartList.add(13, 149);
            CartList.totalAmount += 149;
            updateReceipt();
            Btn_P_13.Visible = true;
        }
        private void BtnChampagne_Click(object sender, EventArgs e)//Count 14
        {
            Cart_List.Add(new Wine("Chardonnay", 8, false, false, true, 9.5, "France",
                "467855", "Champagne    ", 199));
            CartList.add(14, 199);
            CartList.totalAmount += 199;
            updateReceipt();
            Btn_P_14.Visible = true;
        }
        private void BtnCorona_Click(object sender, EventArgs e)//Count 15
        {
            Cart_List.Add(new Beer(false, true, 4.5, "Mexico", "857433", "Corona       ", 9.9));
            CartList.add(15, 9.9);
            CartList.totalAmount += 9.9;
            updateReceipt();
            Btn_P_15.Visible = true;
        }
        private void BtnPaulaner_Click(object sender, EventArgs e)//Count 16
        {
            Cart_List.Add(new Beer(false, false, 5.2, "Germany", "152485", "Paulaner     ", 11));
            CartList.add(16, 11);
            CartList.totalAmount += 11;
            updateReceipt();
            Btn_P_16.Visible = true;
        }
        private void Btnheineken_Click(object sender, EventArgs e)//Count 17
        {
            Cart_List.Add(new Beer(false, false, 4.5, "Mexico", "534813", "heineken     ", 10.5));
            CartList.add(17, 10.5);
            CartList.totalAmount += 10.5;
            updateReceipt();
            Btn_P_17.Visible = true;
        }
        //****************END OF ORDERRING BUTTONS**********************///

        //****************SAVE, LOAD, CLEAR BUTTONS*********************///
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Cart_List.copyStruct();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            saveFileDialog1.Filter = "model files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    //!!!!
                    formatter.Serialize(stream, Cart_List);
                }
            }
        }
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            openFileDialog1.Filter = "model files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                //!!!!
                Cart_List = (CartList)binaryFormatter.Deserialize(stream);
                Cart_List.reversCopyStruct();
                updateReceipt();
            }
        }
        //**********************END********************************//
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)//CLEAR BUTTON
        {
            //Cart_List.clearlist();
            CartList.clear();
            richTextBox1.Text = "";
            richTextBox1.Text += receipt;
            richTextBox1.Text += "\n\n\n\n" + "          TOTAL PRICE: " + CartList.totalAmount;
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            if (CartList._prdDtlArr[2].amount > 0)
            {
                CartList.sub(0, 16);
                CartList.totalAmount -= 16;
                updateReceipt();
            }
            if (CartList._prdDtlArr[2].amount == 0)
                Btn_P_2.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (CartList._prdDtlArr[3].amount > 0)
            {
                CartList.sub(0, 2);
                CartList.totalAmount -= 2;
                updateReceipt();
            }
            if (CartList._prdDtlArr[3].amount == 0)
                Btn_P_3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CartList._prdDtlArr[4].amount > 0)
            {
                CartList.sub(0, 2.5);
                CartList.totalAmount -= 2.5;
                updateReceipt();
            }
            if (CartList._prdDtlArr[4].amount == 0)
                Btn_P_4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CartList._prdDtlArr[5].amount > 0)
            {
                CartList.sub(0, 2.6);
                CartList.totalAmount -= 2.5;
                updateReceipt();
            }
            if (CartList._prdDtlArr[5].amount == 0)
                Btn_P_5.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (CartList._prdDtlArr[6].amount > 0)
            {
                CartList.sub(0, 7.5);
                CartList.totalAmount -= 7.5;
                updateReceipt();
            }
            if (CartList._prdDtlArr[6].amount == 0)
                Btn_P_6.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (CartList._prdDtlArr[7].amount > 0)
            {
                CartList.sub(0, 3.7);
                CartList.totalAmount -= 3.7;
                updateReceipt();
            }
            if (CartList._prdDtlArr[7].amount == 0)
                Btn_P_7.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (CartList._prdDtlArr[8].amount > 0)
            {
                CartList.sub(0, 12.5);
                CartList.totalAmount -= 12.5;
                updateReceipt();
            }
            if (CartList._prdDtlArr[8].amount == 0)
                Btn_P_8.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (CartList._prdDtlArr[9].amount > 0)
            {
                CartList.sub(0, 80);
                CartList.totalAmount -= 80;
                updateReceipt();
            }
            if (CartList._prdDtlArr[9].amount == 0)
                Btn_P_9.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (CartList._prdDtlArr[10].amount > 0)
            {
                CartList.sub(0, 99);
                CartList.totalAmount -= 99;
                updateReceipt();
            }
            if (CartList._prdDtlArr[10].amount == 0)
                Btn_P_10.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (CartList._prdDtlArr[11].amount > 0)
            {
                CartList.sub(0, 75);
                CartList.totalAmount -= 75;
                updateReceipt();
            }
            if (CartList._prdDtlArr[11].amount == 0)
                Btn_P_11.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (CartList._prdDtlArr[12].amount > 0)
            {
                CartList.sub(0, 75);
                CartList.totalAmount -= 75;
                updateReceipt();
            }
            if (CartList._prdDtlArr[12].amount == 0)
                Btn_P_12.Visible = false;
        }

            private void button12_Click(object sender, EventArgs e)
        {
            if (CartList._prdDtlArr[13].amount > 0)
            {
                CartList.sub(0, 149);
                CartList.totalAmount -= 149;
                updateReceipt();
            }
            if (CartList._prdDtlArr[13].amount == 0)
                Btn_P_13.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (CartList._prdDtlArr[14].amount > 0)
            {
                CartList.sub(0, 199);
                CartList.totalAmount -= 199;
                updateReceipt();
            }
            if (CartList._prdDtlArr[14].amount == 0)
                Btn_P_14.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (CartList._prdDtlArr[15].amount > 0)
            {
                CartList.sub(0, 9.9);
                CartList.totalAmount -= 9.9;
                updateReceipt();
            }
            if (CartList._prdDtlArr[15].amount == 0)
                Btn_P_15.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (CartList._prdDtlArr[16].amount > 0)
            {
                CartList.sub(0, 11);
                CartList.totalAmount -= 11;
                updateReceipt();
            }
            if (CartList._prdDtlArr[16].amount == 0)
                Btn_P_16.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (CartList._prdDtlArr[17].amount > 0)
            {
                CartList.sub(0, 10.5);
                CartList.totalAmount -= 10.5;
                updateReceipt();
            }
            if (CartList._prdDtlArr[17].amount == 0)
                Btn_P_17.Visible = false;
        }
    }
}
