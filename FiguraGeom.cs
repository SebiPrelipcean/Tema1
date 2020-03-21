namespace ProiectClase
{
    //	Clasa FiguraGeom 
    public class FiguraGeom
    {
        string denumire;
        int nrLaturi;

        //	Constructor fara parametri
        public FiguraGeom()
        {
            denumire = string.Empty;
            nrLaturi = 0;
        }

        //	Constructor cu parametri
        public FiguraGeom(string _denumire, int _nrLaturi)
        {
            denumire = _denumire;
            nrLaturi = _nrLaturi;
        }

        public string TipFigura()
        {
            if (nrLaturi == 3)
                return string.Format("TRIUNGHI ");
            else if (nrLaturi == 4)
                return string.Format("PATRULATER ");
            else if (nrLaturi > 4)
                return string.Format("POLIGON ");
            else
                return string.Format("NU ESTE O FIGURA ");

        }

        //	Metoda care returneaza informatiile despre figura geometrica 
        //	sub forma unui sir de caractere
        public string Info()
        {
            //Verificam daca este setata vreo denumire
            if (denumire == string.Empty)
                return string.Format("FIGURA NESETATA!");
            return string.Format("{0,0}{1,15}", denumire, nrLaturi);
        }
    }
}
