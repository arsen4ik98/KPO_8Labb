using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_CPO8
{
    public partial class Form1 : Form
    {
        //public CoffeeMachine coffee_machine;
        public Form1()
        {
            InitializeComponent();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            CoffeeMachine coffee_machine = null;

            if (CoffeeCheckBox.Checked == true)
            {
                coffee_machine = new Coffee();
            }
            if (CocoaCheckBox.Checked == true)
            {
                coffee_machine = new Cocoa();
            }
            if (ChocolateCheckBox.Checked == true)
            {
                coffee_machine = new Chocolate();
            }
            if (SugarCheckBox.Checked == true)
            {
                coffee_machine = new Sugar(coffee_machine); 
            }
            if (MilkCheckBox.Checked == true)
            {
                coffee_machine = new Milk(coffee_machine); 
            }
            if (CreamCheckBox.Checked == true)
            {
                coffee_machine = new Cream(coffee_machine); 
            }
            if (CoffeeCheckBox.Checked == true && CocoaCheckBox.Checked == true ||
                CoffeeCheckBox.Checked == true && ChocolateCheckBox.Checked == true ||
                CocoaCheckBox.Checked == true && ChocolateCheckBox.Checked == true ||
                CoffeeCheckBox.Checked == true && CocoaCheckBox.Checked == true && ChocolateCheckBox.Checked == true ||
                coffee_machine == null)
            {
                throw new
                ArgumentException("Ошибка (выбрано больше одного напитка)");
            }
            if (coffee_machine == null)
            {
                throw new
                ArgumentException("Ошибка (в метод передана пустая строка)");
            }
            TotalTextBox.Text += "Название: " + coffee_machine.Name + Environment.NewLine + "Цена: " + coffee_machine.GetCost() + " руб." + Environment.NewLine;

        }

    }
}
