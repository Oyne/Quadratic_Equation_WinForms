using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    internal class QuadraticEquation
    {
        // Number of digits after decimal point
        private int _decimalNumber = 15;

        // Value for checking double zero
        private double _zeroEquality = 0.0000000001;

        // Exception for calculating non quadratic equation
        private Exception NotQuadraticEquation = new Exception("You entered not a quadratic equation");

        private double _a; // a
        private double _b; // b
        private double _c; // c
        private double _d; // D
        private double _x1; // x1
        private double _x2; // x2

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="a">a value</param>
        /// <param name="b">b value</param>
        /// <param name="c">c value</param>
        public QuadraticEquation(double a, double b, double c)
        {
            this._a = a;
            this._b = b;
            this._c = c;
        }

        /// <summary>
        /// Calculates D and x1/x2
        /// </summary>
        public void Calculate()
        {
            _d = _b * _b - 4 * _a * _c;

            // Checking for roots
            if (_d >= 0)
            {
                // Checking for non quadratic equation
                if (_a < _zeroEquality && _a == Math.Abs(_a))
                    throw NotQuadraticEquation;

                _x1 = Math.Round((-_b + Math.Sqrt(_d)) / (2 * _a), _decimalNumber);
                _x2 = Math.Round((-_b - Math.Sqrt(_d)) / (2 * _a), _decimalNumber);
            }
        }

        /// <summary>
        /// A Property
        /// </summary>
        public double A { get => _a; set => _a = value; }

        /// <summary>
        /// B Property
        /// </summary>
        public double B { get => _b; set => _b = value; }

        /// <summary>
        /// C Property
        /// </summary>
        public double C { get => _c; set => _c = value; }


        /// <summary>
        /// D Property
        /// </summary>
        public double D { get => _d; }

        /// <summary>
        /// x1 Property
        /// </summary>11
        public double X1 { get => _x1; }
    
        /// <summary>
        /// x2 Property
        /// </summary>
        public double X2 { get => _x2; }
    }
}
