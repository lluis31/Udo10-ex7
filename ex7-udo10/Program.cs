using System;

namespace ex7_udo10
{
    class Raiz
    {
        private int a;
        public int _a { get { return a; } set { a = value; } }

        private int b;
        public int _b { get { return b; } set { b = value; } }

        private int c;
        public int _c { get { return c; } set { c = value; } }

        private double Discriminante;
        public double _Discriminante { get { return Discriminante; } set { Discriminante = value; } }
        private double r1;
        public double _r1 { get { return r1; } set { r1 = value; } }
        private double r2;
        public double _r2 { get { return r2; } set { r2 = value; } }

        public Raiz()
        {
            _a = 0;
            _b = 0;
            _c = 0;
            _Discriminante = 0;
        }

        public Raiz(int a, int b, int c)
        {
            _a = a;
            _b = b;
            _c = c;
            _Discriminante = Math.Pow(b, 2) - 4 * a * c;

        }

        public override string ToString()
        {
            string p = Convert.ToString(_a) + "x^2+" + Convert.ToString(_b) + "x+" + Convert.ToString(_c);
            Console.WriteLine(p);
            return p;
        }
        public double ObtenDiscriminante()
        {
            //this._Discriminante= Math.Pow(this._b, 2) - 4 * this._a * this._c;
            return _Discriminante;
        }
        public bool Tiene2raices()
        {
            return _Discriminante > 0;
        }
        public bool Tiene1raiz()
        {
            return _Discriminante == 0;
        }
        public void ObtenerResultados()
        {
            this._r1 = (-_b + (Math.Sqrt(Math.Pow(_b, 2) - 4 * _a * _c))) / (2 * _a);
            this._r2 = (-_b - (Math.Sqrt(Math.Pow(_b, 2) - 4 * _a * _c))) / (2 * _a);
            Console.WriteLine("{0}  {1}", this._r1, this._r2);
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("Inserta el valor a:");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Inserta el valor b:");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Inserta el valor c:");
                int c = Convert.ToInt32(Console.ReadLine());

                Raiz abc = new Raiz(a, b, c);
                abc.ToString();

                Console.WriteLine(abc.Tiene1raiz());
                Console.WriteLine(abc.Tiene2raices());

                abc.ObtenerResultados();
            }
        }
    }
}
