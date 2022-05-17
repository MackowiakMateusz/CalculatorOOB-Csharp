using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Operations : AbstractOperations
    {
        public override int Add(int a, int b)//polymorphism, bo deklaruje kilka method o tej samej nazwie ktore moga robic i zwracaja inny typ
        {
            try// try catcha chcialem pokazac ze tez wiem xd
            {//dalej nie robilem bo w sumie po co, ale moznaby
                return a + b;
            }
            catch//wywoluje sie jakby blok wyzej sie wywalil
            {
                throw new Exception("Operations Class Instance threw Exception at Add method");
            }
            finally//wywoluje sie jakby catche sie skoncza/wywala
            {

            }
        }
        public override double Add(double a, double b)
        {
            return a + b;
        }

        public override float Add(float a, float b)
        {
            return a + b;
        }

        public override int Divide(int a, int b)
        {
            return a / b;
        }

        public override double Divide(double a, double b)
        {
            return a / b;
        }

        public override float Divide(float a, float b)
        {
            return a / b;
        }

        public override int Multiply(int a, int b)
        {
            return a * b;
        }

        public override double Multiply(double a, double b)
        {
            return a * b;
        }

        public override float Multiply(float a, float b)
        {
            return a * b;
        }

        public override int Subtract(int a, int b)
        {
            return a - b;
        }

        public override double Subtract(double a, double b)
        {
            return a - b;
        }

        public override float Subtract(float a, float b)
        {
            return a - b;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
