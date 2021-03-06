using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Number
    {
        private decimal _num;
        private int _digit;
        private bool _dot = false;
        public int lenght { get; set; }

        public void setDot()
        {
            if (_dot)
                return;
            _dot = true;
        }

        public void Clear()
        {
            _num = 0;
            _digit = 10;
            _dot = false;
            lenght = 0;
        }

        public Number()
        {
            Clear();
        }

        public bool getDot()
        {
            return _dot;
        }

        public void AddNumber(int number) 
        {
            if (number == 0 && _dot == false)
                return;
            if(!_dot)
            {
                _num *= 10;
                _num += number;
                lenght++;
            }
            else
            {
                decimal temp = Convert.ToDecimal(number);
                temp /= _digit;
                _num += temp;
                _digit *= 10;
                lenght++;
            }    
        }

        public decimal getNum()
        {
            return _num;
        }
        
        public void setNum(decimal number)
        {
            _num = number;
        }
    }
}
