using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    abstract class AbstractOperations
    {
        public abstract int Add(int a, int b);
        public abstract double Add(double a, double b);
        public abstract float Add(float a, float b);

        public abstract int Subtract(int a, int b);
        public abstract double Subtract(double a, double b);
        public abstract float Subtract(float a, float b);

        public abstract int Multiply(int a, int b);
        public abstract double Multiply(double a, double b);
        public abstract float Multiply(float a, float b);

        public abstract int Divide(int a, int b);
        public abstract double Divide(double a, double b);
        public abstract float Divide(float a, float b);
    }
}
