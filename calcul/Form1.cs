using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace calcul
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            int intDay, intMonth, intYear;
           
            intMonth = StringToIntMonth(comboBoxMonth.Text); 
            intYear = int.Parse(textBoxYear.Text);
            intDay = int.Parse(comboBoxDay.Text);
            DaysOfTheWeek OUT = new DaysOfTheWeek(intDay, intMonth, intYear);
            textBoxYear.Clear();
            labelOut.Text = OUT.DayOfWeek();
            ButtonRun.Enabled = false;
            comboBoxDay.Enabled = false;
        }

        
      
        //валидация введенного года
        private List<string> IntToMasString(int intNum)
        {
           // string[] tmp = new string[intNum];
           List <string>  tmp = new List<string>();
              for ( int i= 1;i <= intNum; i++)
              {
                  tmp.Add(i.ToString());
              }
            
            return tmp;
        }
        private void TextBoxValidatedYear(object sender, EventArgs e)
        {
            if (isNum(textBoxYear.Text))
            {
                labelValidYear.Text = "Коректно";
                labelValidYear.ForeColor = Color.Green;

                ValidMonthYear();

            }
            else
            {
                labelValidYear.Text = "ТОЛЬКО ЛЮБОЕ НАТУРАЛЬНОЕ ЧИСЛО";
                labelValidYear.ForeColor = Color.Red;
            }
        }

        //изменение поля текст бокс
        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //
        //Вспомогательные методы
        //
        //состоит ли строка из цыфр
        private bool isNum(string strNum)
        {
            int n;
            return int.TryParse(strNum, out n);
        }
        //функция проверки високосного года
        private bool isLeapYear(int intYear)
        {
            return intYear % 4 == 0 && (intYear % 100 != 0 || intYear % 400 == 0);
        }

        //функция определения кол-во дней в месяце
        private int CountDay(int intMonth,int intYear)
        {
            //если месяц февраль
            if (intMonth == 2)
            {//если год високосный
                if (isLeapYear(intYear))
                {

                    return 29;
                }
                //если год НЕ високосный
                else
                {
                    return 28;
                }
            }
            //если в месяце 31 день
            else if ((new List<int>() { 1, 3, 5, 7, 8, 10, 12 }).Contains(intMonth))
            {
                return  31;
            }
            //если в месяце 30 дней
            else
            {
                return 30;
            }

        }
        //
        private int StringToIntMonth(string strMonth)
        {
            string[] mon = new string[] {"Январь","Февраль","Март","Апрель","Май","Июнь","Июль","Август","Сентябрь",
                "Октябрь","Ноябрь","Декабрь"};
            return 1+(new List<string>(mon)).IndexOf(strMonth);

        }

        private void ValidMonthYear()
        {
           if ((!String.IsNullOrEmpty(comboBoxMonth.Text)&&!String.IsNullOrEmpty(textBoxYear.Text))
                &&isNum(textBoxYear.Text))
            {
                int intDay, intMonth, intYear;
                intMonth = StringToIntMonth(comboBoxMonth.Text);
              
                intYear = int.Parse(textBoxYear.Text);
                intDay = CountDay(intMonth, intYear);

                comboBoxDay.Items.Clear();
                comboBoxDay.Items.AddRange(IntToMasString(intDay).ToArray());
                comboBoxDay.Enabled = true;
                ButtonRun.Enabled = true;
            }
            
              
            
        }

       /* private void comboBoxMonth_Validated(object sender, EventArgs e)
        {
          //  ValidMonthYear();
        }*/

        private void comboBoxMonth_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ValidMonthYear();
        }
    }
}
