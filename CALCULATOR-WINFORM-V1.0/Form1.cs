using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR_WINFORM_V1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           // resultTxt.Text = "Hello World";
            this.Font = new Font("Tahoma", 11);  ///this line in the InitializeComponent()
           // this.Controls.Add(resultTxt);
        }

        public static string result = "";

        private void Form1_Load(object sender, EventArgs e)
        {
           /* this.Location = new Point(0, 0);

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           /* result = result + "1";
            MessageBox.Show(result);*/

            //resultTxt.Text = num1.Con;  
/*            this.Controls.Add((resultTxt));
*/
        }

        /* private void button8_Click(object sender, EventArgs e)
         {
             resultTxt.Text += "0";

         }*/

        static double number1 = 0;
        static double number2 = 0;
        static String oper = "";
        private void num0_Click(object sender, EventArgs e)
        {
            result += "0";
            resultTxt.Text = result;

        }
        private void num1_Click(object sender, EventArgs e)
        {
            result += "1";
            resultTxt.Text = result;

        }
        private void num2_Click(object sender, EventArgs e)
        {
            result += "2";
            resultTxt.Text = result;
        }
        private void num3_Click(object sender, EventArgs e)
        {
            result += "3";
            resultTxt.Text = result;

        }
        private void num4_Click(object sender, EventArgs e)
        {
            result += "4";
            resultTxt.Text = result;


        }
        private void num5_Click(object sender, EventArgs e)
        {
            result += "5";
            resultTxt.Text = result;

        }
        private void num6_Click(object sender, EventArgs e)
        {
            result += "6";
            resultTxt.Text = result;

        }
        private void num7_Click(object sender, EventArgs e)
        {
            result += "7";
            resultTxt.Text = result;

        }
        private void num8_Click(object sender, EventArgs e)
        {
            result += "8";
            resultTxt.Text = result;

        }
        private void num9_Click(object sender, EventArgs e)
        {
            result += "9";
            resultTxt.Text = result;

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {

            if (listOper.Count > 0)
            {
                string opr = listOper.ElementAt(0).ToString();
                string[] arrayNumber = result.Split(opr.ElementAt(0));
                float numb1 = float.Parse(arrayNumber[0]);
                float numb2 = float.Parse(arrayNumber[1]);
                double resultNum = cal(numb1, numb2, opr);
                result = "";
                result += resultNum;
                resultTxt.Text = result;
                listOper.RemoveAt(0);
            }
            else
            {
                result += "/";
                resultTxt.Text = result;
                listOper.Add("/");

            }

        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (listOper.Count > 0)
            {
                string opr = listOper.ElementAt(0).ToString();
                string[] arrayNumber = result.Split(opr.ElementAt(0));
                float numb1 = float.Parse(arrayNumber[0]);
                float numb2 = float.Parse(arrayNumber[1]);
                double resultNum = cal(numb1, numb2, opr);
                result = "";
                result += resultNum;
                resultTxt.Text = result;
                listOper.RemoveAt(0);
            }
            else
            {
                result += "x";
                resultTxt.Text = result;
                listOper.Add("x");

            }

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (listOper.Count > 0)
            {
                string opr = listOper.ElementAt(0).ToString();
                string[] arrayNumber = result.Split(opr.ElementAt(0));
                float numb1 = float.Parse(arrayNumber[0]);
                float numb2 = float.Parse(arrayNumber[1]);
                double resultNum = cal(numb1, numb2, opr);
                result = "";
                result += resultNum;
                resultTxt.Text = result;
                listOper.RemoveAt(0);
            }
            else
            {
                result += "-";
                resultTxt.Text = result;
                listOper.Add("-");

            }

        }

        List<string> listNumber = new List<string>();
        // Luu cac phep tinh + - * /
        List<string> listOper = new List<string>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listOper.Count > 0)
            {
                string opr = listOper.ElementAt(0).ToString();
                string[] arrayNumber = result.Split(opr.ElementAt(0));
                float numb1 = float.Parse(arrayNumber[0]);
                float numb2 = float.Parse(arrayNumber[1]);
                double resultNum = cal(numb1, numb2, opr);
                result = "";
                result += resultNum;
                resultTxt.Text = result;
                listOper.RemoveAt(0);
            }
            else
            {
                result += "+";
                resultTxt.Text = result;
                listOper.Add("+");

            }

        }

        double cal(double num1, double num2, string oper)
        {

            switch (oper)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "x":
                    return num1 * num2;
                case "/":
                    return (float)num1 / num2;
            }
            return 0;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (listOper.Count > 0)
            {
                string opr = listOper.ElementAt(0).ToString();
                string[] arrayNumber = result.Split(opr.ElementAt(0));
                float numb1 = float.Parse(arrayNumber[0]);
                float numb2 = float.Parse(arrayNumber[1]);
                double resultNum = cal(numb1, numb2, opr);
                result = "";
                result += resultNum;
                resultTxt.Text = result;
                listOper.RemoveAt(0);
            }
        }
    }
}
