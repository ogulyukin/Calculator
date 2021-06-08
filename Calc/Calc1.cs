using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Calc1
    {
        private Number number01; 
        private Number number02;
        private bool current = true;
        private int operation = -1;
        public Calc1()
        {
            number01 = new Number();
            number02 = new Number();
            current = true;
            operation = -1;
        }
        public void ClearCurrent()
        {
            if (current)
            {
                number01.Clear();
            }
            else
            {
                number02.Clear();
            }
        }
        public void ClearAll()
        {
            number01.Clear();
            number02.Clear();
            current = true;
        }
        public void AddNumber(int number)
        {
            if (current && number01.lenght > 8)
                return;
            if (!current && number02.lenght > 8)
                return;
            if (current)
            {
                number01.AddNumber(number);
            }
            else
            {
                number02.AddNumber(number);
            }
        }
        public void setDot()
        {
                if (current)
                {
                    number01.setDot();
                }else
                {
                    number02.setDot();
                }                   
        }
        public void doOperation(int variant)
        {            
            if (current)
            {
                current = false;
                operation = variant;
                return;
            }
            operation = variant;
        }
        public void doResult()
        {
            switch(operation)
            {
                case 1:
                    number01.setNum(number01.getNum() - number02.getNum());
                    break;
                case 2:
                    number01.setNum(number01.getNum() + number02.getNum());
                        break;
                case 3:
                    number01.setNum(number01.getNum() * number02.getNum());
                    break;
                case 4:
                    number01.setNum(number01.getNum() / number02.getNum());
                    break;
            }
            number02.Clear();
            current = true;
        }
        public bool zeroCheck()
        {
            if (number02.getNum() == 0 && operation == 4)
                return true;
            return false;
        }
        
        public string GetView()
        {
            if (current)
                return Convert.ToString(number01.getNum());
            return Convert.ToString(number02.getNum());
        }
        public string Getsummary()
        {
            if (number02.getNum() == 0)
                return Convert.ToString(number01.getNum());
            return Convert.ToString(number01.getNum()) + GetOperation() + Convert.ToString(number02.getNum());
        }
        private string GetOperation()
        {
            switch(operation)
            {
                case 1:
                    return " - ";
                    break;
                case 2:
                    return " + ";
                    break;
                case 3:
                    return " * ";
                    break;
                case 4:
                    return " / ";
                    break;
            }
            return " ? ";
        }
    }
}
