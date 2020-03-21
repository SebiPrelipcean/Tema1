using System;

namespace ProiectClase
{
    class Program
    {
        static void Main()
        {
            //	Instantierea unui obiect de tip FiguraGeom utilizand constructorul fara parametri
            //	Tipul variabilei f este 'var' (determinat de compilator)
            var f = new FiguraGeom();
            string s = f.Info();
            Console.WriteLine(s);

            //	Instantierea unui obiect de tip FiguraGeom utilizand constructorul cu parametri
            //	Tipul variabilei f1 este explicit 'FiguraGeom'
            FiguraGeom f1 = new FiguraGeom("Patrat", 4);
            FiguraGeom f2 = new FiguraGeom("Dreprunghi", 4);
            FiguraGeom f3 = new FiguraGeom("Triunghi", 3);
            string s1 = string.Format("{0,0}{1,15}{2,25}", "TipFigura", "NrLaturi", "FiguraDeterminata");
            string s2 = string.Format("{0,0}{1,25}", f1.Info(), f1.TipFigura());
            string s3 = string.Format("{0,0}{1,25}", f2.Info(), f2.TipFigura());
            string s4 = string.Format("{0,0}{1,25}", f3.Info(), f3.TipFigura());
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);



            Console.ReadKey();
        }
    }
}
