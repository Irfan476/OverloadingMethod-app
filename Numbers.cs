using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {
        private int _c, _d;
        public int FindMinimum(int a, int b)
        {
            return a < b ? a : b;
        }

        public int FindMinimum(int a, int b, float c)
        {
            _c = a < c ? a : (int)c;
            _d = b < c ? b : (int)c;
            return _c < _d ? _c : _d;
        }

        public int FindMaximum(int a, int b)
        {
            return a > b ? a : b;
        }

        public int FindMaximum(int a, int b, float c)
        {
            _c = a > c ? a : (int)c;
            _d = b > c ? b : (int)c;
            return _c > _d ? _c : _d;
        }
    }
}
