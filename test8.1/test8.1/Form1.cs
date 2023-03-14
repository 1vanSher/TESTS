using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalcClass;

namespace test8._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text += $"Test Case 1 {Environment.NewLine}";
                textBox1.Text += $"Входные данные: a = 150, b = 150{Environment.NewLine}";
                textBox1.Text += $"Ожидаемый результат: res = 300{Environment.NewLine}";
                long res = CalcClass.CalcClass.Add(150, 150);
                string error = CalcClass.CalcClass.lastError;
                if (res == 300)
                {
                    textBox1.Text += $"Тест пройден{Environment.NewLine}{Environment.NewLine}";
                }
            }
            catch (Exception ex)
            {
                textBox1.Text += "Перехвачено исключение: " + ex.Message + $"{Environment.NewLine}Тест не пройден.{Environment.NewLine}";
            }
            try
            {
                textBox1.Text += $"Test Case 2{Environment.NewLine}";
                textBox1.Text += $"Входные данные: a = 150000000000000000, b = 150{Environment.NewLine}";
                long res = CalcClass.CalcClass.Add(-150000000000000000, 150);
                string error = CalcClass.CalcClass.lastError;
                textBox1.Text += $"Ожидаемый результат: Error = {error + Environment.NewLine}";
                textBox1.Text += "Получившийся результат: error = " + error + Environment.NewLine;
                if (error == "ERROR 06: Very big for INT" || error == "ERROR 06: Very small for INT")
                {
                    textBox1.Text += $"Тест пройден{Environment.NewLine}{Environment.NewLine}";
                }
                else
                {
                    textBox1.Text += $"Тест не пройден{Environment.NewLine}{Environment.NewLine}";
                }
            }
            catch (Exception ex)
            {
                textBox1.Text += "Перехвачено исключение: " +
                ex.ToString() + $"{Environment.NewLine}Тест не пройден.{Environment.NewLine}";
            }

            try
            {
                textBox1.Text += $"Test Case 3{Environment.NewLine}";
                textBox1.Text += $"Входные данные: a = 150, b = 150000000000000000{Environment.NewLine}";
                long res = CalcClass.CalcClass.Add(150, 150000000000000000);
                string error = CalcClass.CalcClass.lastError;
                textBox1.Text += $"Ожидаемый результат:  Error = {error + Environment.NewLine}";
                textBox1.Text += "Получившийся результат: error = " + error + Environment.NewLine;
                if (error == "ERROR 06: Very big for INT" || error == "ERROR 06: Very small for INT")
                {
                    textBox1.Text += $"Тест пройден{Environment.NewLine}{Environment.NewLine}";
                }
                else
                {
                    textBox1.Text += $"Тест не пройден{Environment.NewLine}{Environment.NewLine}";
                }
            }
            catch (Exception ex)
            {
                textBox1.Text += "Перехвачено исключение: " +
                ex.ToString() + $"{Environment.NewLine}Тест не пройден.{Environment.NewLine}";
            }
            try
            {
                textBox1.Text += $"Test Case 4{Environment.NewLine}";
                textBox1.Text += $"Входные данные: a = 2147483647, b = 2147483647{Environment.NewLine}";
                long res = CalcClass.CalcClass.Add(2147483647, 2147483647);
                string error = CalcClass.CalcClass.lastError;
                textBox1.Text += $"Ожидаемый результат:  Error = {error + Environment.NewLine}";
                textBox1.Text += "Получившийся результат: error = " + error + Environment.NewLine;
                if (error == "ERROR 06: Very big for INT" || error == "ERROR 06: Very small for INT")
                {
                    textBox1.Text += $"Тест пройден{Environment.NewLine}{Environment.NewLine}";
                }
                else
                {
                    textBox1.Text += $"Тест не пройден{Environment.NewLine}{Environment.NewLine}";
                }
            }
            catch (Exception ex)
            {
                textBox1.Text += "Перехвачено исключение: " +
                ex.ToString() + $"{Environment.NewLine}Тест не пройден.{Environment.NewLine}";
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text += $"Test Case 1 {Environment.NewLine}";
                textBox2.Text += $"Входные данные: a = 150, b = 150{Environment.NewLine}";
                textBox2.Text += $"Ожидаемый результат: res = 0{Environment.NewLine}";
                long res = CalcClass.CalcClass.Sub(150, 150);
                string error = CalcClass.CalcClass.lastError;
                if (res == 0)
                {
                    textBox2.Text += $"Тест пройден{Environment.NewLine}{Environment.NewLine}";
                }
            }
            catch (Exception ex)
            {
                textBox2.Text += "Перехвачено исключение: " + ex.Message + $"{Environment.NewLine}Тест не пройден.{Environment.NewLine}";
            }
            try
            {
                textBox2.Text += $"Test Case 2{Environment.NewLine}";
                textBox2.Text += $"Входные данные: a = 150000000000000000, b = 150{Environment.NewLine}";
                long res = CalcClass.CalcClass.Sub(-150000000000000000, 150);
                string error = CalcClass.CalcClass.lastError;
                textBox2.Text += $"Ожидаемый результат: Error = {error + Environment.NewLine}";
                textBox2.Text += "Получившийся результат: error = " + error + Environment.NewLine;
                if (error == "ERROR 06: Very big for INT" || error == "ERROR 06: Very small for INT")
                {
                    textBox2.Text += $"Тест пройден{Environment.NewLine}{Environment.NewLine}";
                }
                else
                {
                    textBox2.Text += $"Тест не пройден{Environment.NewLine}{Environment.NewLine}";
                }
            }
            catch (Exception ex)
            {
                textBox2.Text += "Перехвачено исключение: " +
                ex.ToString() + $"{Environment.NewLine}Тест не пройден.{Environment.NewLine}";
            }

            try
            {
                textBox2.Text += $"Test Case 3{Environment.NewLine}";
                textBox2.Text += $"Входные данные: a = 150, b = 150000000000000000{Environment.NewLine}";
                long res = CalcClass.CalcClass.Sub(150, 150000000000000000);
                string error = CalcClass.CalcClass.lastError;
                textBox2.Text += $"Ожидаемый результат:  Error = {error + Environment.NewLine}";
                textBox2.Text += "Получившийся результат: error = " + error + Environment.NewLine;
                if (error == "ERROR 06: Very big for INT" || error == "ERROR 06: Very small for INT")
                {
                    textBox2.Text += $"Тест пройден{Environment.NewLine}{Environment.NewLine}";
                }
                else
                {
                    textBox2.Text += $"Тест не пройден{Environment.NewLine}{Environment.NewLine}";
                }
            }
            catch (Exception ex)
            {
                textBox2.Text += "Перехвачено исключение: " +
                ex.ToString() + $"{Environment.NewLine}Тест не пройден.{Environment.NewLine}";
            }
            try
            {
                textBox2.Text += $"Test Case 4{Environment.NewLine}";
                textBox2.Text += $"Входные данные: a = 2147483647, b = 2147483647{Environment.NewLine}";
                long res = CalcClass.CalcClass.Sub(-2147483647, -2147483647);
                string error = CalcClass.CalcClass.lastError;
                textBox2.Text += $"Ожидаемый результат:  Error = {error + Environment.NewLine}";
                textBox2.Text += "Получившийся результат: error = " + error + Environment.NewLine;
                if (error == "ERROR 06: Very big for INT" || error == "ERROR 06: Very small for INT")
                {
                    textBox2.Text += $"Тест пройден{Environment.NewLine}{Environment.NewLine}";
                }
                else
                {
                    textBox2.Text += $"Тест не пройден{Environment.NewLine}{Environment.NewLine}";
                }
            }
            catch (Exception ex)
            {
                textBox2.Text += "Перехвачено исключение: " +
                ex.ToString() + $"{Environment.NewLine}Тест не пройден.{Environment.NewLine}";
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text += $"Test Case 1 {Environment.NewLine}";
                textBox3.Text += $"Входные данные: a = 10, b = 10{Environment.NewLine}";
                textBox3.Text += $"Ожидаемый результат: res = 100{Environment.NewLine}";
                long res = CalcClass.CalcClass.Mult(10, 10);
                string error = CalcClass.CalcClass.lastError;
                if (res == 100)
                {
                    textBox3.Text += $"Тест пройден{Environment.NewLine}{Environment.NewLine}";
                }
            }
            catch (Exception ex)
            {
                textBox3.Text += "Перехвачено исключение: " + ex.Message + $"{Environment.NewLine}Тест не пройден.{Environment.NewLine}";
            }
            try
            {
                textBox3.Text += $"Test Case 2{Environment.NewLine}";
                textBox3.Text += $"Входные данные: a = 150000000000000000, b = 150{Environment.NewLine}";
                long res = CalcClass.CalcClass.Mult(-150000000000000000, 150);
                string error = CalcClass.CalcClass.lastError;
                textBox3.Text += $"Ожидаемый результат: Error = {error + Environment.NewLine}";
                textBox3.Text += "Получившийся результат: error = " + error + Environment.NewLine;
                if (error == "ERROR 06: Very big for INT" || error == "ERROR 06: Very small for INT")
                {
                    textBox3.Text += $"Тест пройден{Environment.NewLine}{Environment.NewLine}";
                }
                else
                {
                    textBox3.Text += $"Тест не пройден{Environment.NewLine}{Environment.NewLine}";
                }
            }
            catch (Exception ex)
            {
                textBox3.Text += "Перехвачено исключение: " +
                ex.ToString() + $"{Environment.NewLine}Тест не пройден.{Environment.NewLine}";
            }

            try
            {
                textBox3.Text += $"Test Case 3{Environment.NewLine}";
                textBox3.Text += $"Входные данные: a = 150, b = 150000000000000000{Environment.NewLine}";
                long res = CalcClass.CalcClass.Mult(150, 150000000000000000);
                string error = CalcClass.CalcClass.lastError;
                textBox3.Text += $"Ожидаемый результат:  Error = {error + Environment.NewLine}";
                textBox3.Text += "Получившийся результат: error = " + error + Environment.NewLine;
                if (error == "ERROR 06: Very big for INT" || error == "ERROR 06: Very small for INT")
                {
                    textBox3.Text += $"Тест пройден{Environment.NewLine}{Environment.NewLine}";
                }
                else
                {
                    textBox3.Text += $"Тест не пройден{Environment.NewLine}{Environment.NewLine}";
                }
            }
            catch (Exception ex)
            {
                textBox3.Text += "Перехвачено исключение: " +
                ex.ToString() + $"{Environment.NewLine}Тест не пройден.{Environment.NewLine}";
            }
            try
            {
                textBox3.Text += $"Test Case 4{Environment.NewLine}";
                textBox3.Text += $"Входные данные: a = 2147483647, b = 2147483647{Environment.NewLine}";
                long res = CalcClass.CalcClass.Mult(2147483647, 2147483647);
                string error = CalcClass.CalcClass.lastError;
                textBox3.Text += $"Ожидаемый результат:  Error = {error + Environment.NewLine}";
                textBox3.Text += "Получившийся результат: error = " + error + Environment.NewLine;
                if (error == "ERROR 06: Very big for INT" || error == "ERROR 06: Very small for INT")
                {
                    textBox3.Text += $"Тест пройден{Environment.NewLine}{Environment.NewLine}";
                }
                else
                {
                    textBox3.Text += $"Тест не пройден{Environment.NewLine}{Environment.NewLine}";
                }
            }
            catch (Exception ex)
            {
                textBox3.Text += "Перехвачено исключение: " +
                ex.ToString() + $"{Environment.NewLine}Тест не пройден.{Environment.NewLine}";
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text += $"Test Case 1 {Environment.NewLine}";
                textBox4.Text += $"Входные данные: a = 150, b = 150{Environment.NewLine}";
                textBox4.Text += $"Ожидаемый результат: res = 1{Environment.NewLine}";
                long res = CalcClass.CalcClass.Div(150, 150);
                string error = CalcClass.CalcClass.lastError;
                if (res == 1)
                {
                    textBox4.Text += $"Тест пройден{Environment.NewLine}{Environment.NewLine}";
                }
            }
            catch (Exception ex)
            {
                textBox4.Text += "Перехвачено исключение: " + ex.Message + $"{Environment.NewLine}Тест не пройден.{Environment.NewLine}";
            }
            try
            {
                textBox4.Text += $"Test Case 2{Environment.NewLine}";
                textBox4.Text += $"Входные данные: a = 150000000000000000, b = 150{Environment.NewLine}";
                long res = CalcClass.CalcClass.Div(-150000000000000000, 150);
                string error = CalcClass.CalcClass.lastError;
                textBox4.Text += $"Ожидаемый результат: Error = {error + Environment.NewLine}";
                if (error == "ERROR 06: Very big for INT" || error == "ERROR 06: Very small for INT")
                {
                    textBox4.Text += "Получившийся результат: error = " + error + Environment.NewLine;
                    textBox4.Text += $"Тест пройден{Environment.NewLine}{Environment.NewLine}";
                }
                else
                {
                    textBox4.Text += $"Тест не пройден{Environment.NewLine}{Environment.NewLine}";
                }
            }
            catch (Exception ex)
            {
                textBox4.Text += "Перехвачено исключение: " +
                ex.ToString() + $"{Environment.NewLine}Тест не пройден.{Environment.NewLine}";
            }

            try
            {
                textBox4.Text += $"Test Case 3{Environment.NewLine}";
                textBox4.Text += $"Входные данные: a = 150, b = 150000000000000000{Environment.NewLine}";
                long res = CalcClass.CalcClass.Div(150, 150000000000000000);
                string error = CalcClass.CalcClass.lastError;
                textBox4.Text += $"Ожидаемый результат:  Error = {error + Environment.NewLine}";

                if (error == "ERROR 06: Very big for INT" || error == "ERROR 06: Very small for INT")
                {
                    textBox4.Text += "Получившийся результат: error = " + error + Environment.NewLine;
                    textBox4.Text += $"Тест пройден{Environment.NewLine}{Environment.NewLine}";
                }
                else
                {
                    textBox4.Text += $"Тест не пройден{Environment.NewLine}{Environment.NewLine}";
                }
            }
            catch (Exception ex)
            {
                textBox4.Text += "Перехвачено исключение: " +
                ex.ToString() + $"{Environment.NewLine}Тест не пройден.{Environment.NewLine}";
            }
            try
            {
                textBox4.Text += $"Test Case 4{Environment.NewLine}";
                textBox4.Text += $"Входные данные: a = 2147483647, b = 2147483647{Environment.NewLine}";
                long res = CalcClass.CalcClass.Div(2147483647, 2147483647);
                string error = CalcClass.CalcClass.lastError;
                textBox4.Text += $"Ожидаемый результат:  Error = {error + Environment.NewLine}";
                if (error == "ERROR 06: Very big for INT" || error == "ERROR 06: Very small for INT")
                {
                    textBox4.Text += "Получившийся результат: error = " + error + Environment.NewLine;
                    textBox4.Text += $"Тест пройден{Environment.NewLine}{Environment.NewLine}";
                }
                else
                {
                    textBox4.Text += $"Тест не пройден{Environment.NewLine}{Environment.NewLine}";
                }
            }
            catch (Exception ex)
            {
                textBox4.Text += "Перехвачено исключение: " +
                ex.ToString() + $"{Environment.NewLine}Тест не пройден.{Environment.NewLine}";
            }
            try
            {
                textBox4.Text += $"Test Case 4{Environment.NewLine}";
                textBox4.Text += $"Входные данные: a = 100, b = 0{Environment.NewLine}";
                string error = CalcClass.CalcClass.lastError;
                textBox4.Text += $"Ожидаемый результат:  Error = {error + Environment.NewLine}";
                long res = CalcClass.CalcClass.Div(100, 0);
            }
            catch (Exception ex)
            {
                if (ex.Message == "Error 09: Division by zero")
                {
                    string error = CalcClass.CalcClass.lastError;
                    textBox4.Text += "Получившийся результат: error = " + error + Environment.NewLine;
                    textBox4.Text += $"Тест пройден{Environment.NewLine}{Environment.NewLine}";
                }
                else
                {
                    textBox4.Text += "Перехвачено исключение: " +
                    ex.Message + $"{Environment.NewLine}Тест не пройден.{Environment.NewLine}";
                }

            }
        }
    }
}
