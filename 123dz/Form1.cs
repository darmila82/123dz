using _123dz.Skald;
using _123dz.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _123dz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void check_create_Click(object sender, EventArgs e)
        {
            Soap_text.Text = $"{Soap.soap_on_sklad} Мила - {Soap.soap_price}$";
            Shampoo_text.Text = $"{Shampoo.shampoo_on_sklad} Шампуня - {Shampoo.shampoo_price}$";
            Teeth_pasta_text.Text = $"{Teeth_pasta.teeth_pasta_on_sklad} Пасти - {Teeth_pasta.teeth_pasta_price}$";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void balance_check_Click(object sender, EventArgs e)
        {
            Balance_text.Text = $"{Balance.user_balance}$";
        }

        private void hide_balance_Click(object sender, EventArgs e)
        {
            Balance_text.Text = $"*********************";
        }

        private void balance_input_button_Click(object sender, EventArgs e)
        {
            Balance_input.Visible = true;
            input_your_balance.Visible = true;
            Enter.Visible = true;
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            //Тут був ввід балансу але трайпарс не працює
            //Balance.user_balance = Int32.Parse(Balance_input.Text);
            Balance_input.Visible = false;
            input_your_balance.Visible = false;
            Enter.Visible = false;
        }

        private void But_button_Click(object sender, EventArgs e)
        {
            Product_buy.Visible = true;
            Product_buy_input.Visible = true;
            Product_buy.Text = $"Введіть який проудкт ви хочете купити               (1 - мило,2 - Шампунь,3 - Зубна паста)";
            switch (Product_buy_input.Text)
            {
                case "1": // якщо купити мило
                    Product_buy.Text = $"{Soap.soap_on_sklad} Мила - {Soap.soap_price}$";
                    Thread.Sleep(5000);
                    Product_buy.Text = $"Скільки бажаєте купити, наразі у вас є {User.Balance.user_balance}$";
                    //якщо невистачає балансу або продукту на складі
                    if(Int32.Parse(Product_buy_input.Text) > Soap.soap_on_sklad || User.Balance.user_balance > Int32.Parse(Product_buy_input.Text)* Soap.soap_price)
                    {
                        Product_buy.Text = $"Нажаль наразі ми не можемо провести таку операцію,перевірте чи в вас вистачає коштів на цю покупку і чи є на складі така кількість проудку)";
                    }
                    //провелення покупки
                    else
                    {
                        Product_buy.Text = $"{Int32.Parse(Product_buy_input.Text)} мила це {Int32.Parse(Product_buy_input.Text)} по {Soap.soap_price},що = {Int32.Parse(Product_buy_input.Text)* Soap.soap_price}";
                        User.Balance.user_balance = User.Balance.user_balance - (Int32.Parse(Product_buy_input.Text) * Soap.soap_price);
                        User.Inventory.Soap_inventory += Int32.Parse(Product_buy_input.Text);
                        Product_buy.Text = $"Дякуємо за покупку";
                        Thread.Sleep(5000);
                        Product_buy.Text = $"Наразі у вас на балансі {User.Balance.user_balance}$";
                        Thread.Sleep(5000);
                        Product_buy.Text = $"У вас є {User.Inventory.Soap_inventory} мила";
                    }

                    break;
                case "2":

                    break;
                case "3":

                    break;
                default: 
                    break;
            }
        }
    }
}
