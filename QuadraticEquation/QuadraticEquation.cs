using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    internal class QuadraticEquation
    {
        private int _decimalNumber = 15;

        private double _zeroEquality = 0.0000000001;

        private Exception NotQuadraticEquation = new Exception("You entered not a quadratic equation");

        private double _a;
        private double _b;
        private double _c;
        private double _d;
        private double _x1;
        private double _x2;

        public QuadraticEquation(double a, double b, double c)
        {
            this._a = a;
            this._b = b;
            this._c = c;
        }

        public void Calculate()
        {
            _d = _b * _b - 4 * _a * _c;
            if (_d >= 0)
            {
                if (_a < _zeroEquality && _a == Math.Abs(_a))
                    throw NotQuadraticEquation;

                _x1 = Math.Round((-_b + Math.Sqrt(_d)) / (2 * _a), _decimalNumber);
                _x2 = Math.Round((-_b - Math.Sqrt(_d)) / (2 * _a), _decimalNumber);
            }
        }

        public double D
        {
            get { return _d; }
        }

        public double X1
        {
            get { return _x1; }
        }
        public double X2
        {
            get { return _x2; }
        }
    }
}
