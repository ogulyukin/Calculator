using System;


namespace Calc
{
    class Calc1
    {
        private Number _number01; 
        private Number _number02;
        private bool _current = true;
        private string _operation = " ? ";
        public Calc1()
        {
            _number01 = new Number();
            _number02 = new Number();
            _current = true;
            _operation = " ? ";
        }
        public void ClearCurrent()
        {
            if (_current)
            {
                _number01.Clear();
            }
            else
            {
                _number02.Clear();
            }
        }
        public void ClearAll()
        {
            _number01.Clear();
            _number02.Clear();
            _current = true;
            _operation = " ? ";
        }
        public void AddNumber(int number)
        {
            if (_current && _number01.lenght > 8)
                return;
            if (!_current && _number02.lenght > 8)
                return;
            if (_current)
            {
                _number01.AddNumber(number);
            }
            else
            {
                _number02.AddNumber(number);
            }
        }
        public void setDot()
        {
                if (_current)
                {
                    _number01.setDot();
                }else
                {
                    _number02.setDot();
                }                   
        }
        public void doOperation(string variant)
        {            
            if (_current)
            {
                _current = false;
                _operation = variant;
                return;
            }
            _operation = variant;
        }
        public void doResult()
        {
            switch(_operation)
            {
                case " - ":
                    _number01.setNum(_number01.getNum() - _number02.getNum());
                    break;
                case " + ":
                    _number01.setNum(_number01.getNum() + _number02.getNum());
                        break;
                case " * ":
                    _number01.setNum(_number01.getNum() * _number02.getNum());
                    break;
                case " / ":
                    _number01.setNum(_number01.getNum() / _number02.getNum());
                    break;
                case " % ":
                    _number01.setNum(_number01.getNum() / 100 * _number02.getNum());
                    break;
                case " ? ":
                    return;
            }
            _number02.Clear();
            _current = true;
            _operation = " ? ";
            _number01.restrictEdit();
        }
        public bool zeroCheck()
        {
            if (_number02.getNum() == 0 && _operation == " / ")
                return true;
            return false;
        }
        
        public string GetView()
        {
            if (_current)
                return Convert.ToString(_number01.getNum());
            return Convert.ToString(_number02.getNum());
        }
        public string Getsummary()
        {
            if (_number02.getNum() == 0)
                return Convert.ToString(_number01.getNum());
            return Convert.ToString(_number01.getNum()) + _operation + Convert.ToString(_number02.getNum());
        }
        public bool validateLeght()
        {
            if (_number01.getNum().ToString().Length > 9)
            {
                return false;
            }
            return true;
        }
    }
}
