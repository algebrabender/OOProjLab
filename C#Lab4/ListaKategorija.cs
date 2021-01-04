using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class ListaKategorija
    {
        #region Atributes

        private List<Kategorija> listaKategorija;
        private List<Kategorija> listaZabrana;

        #endregion

        #region Properties

        public List<Kategorija> ListaKategorijaValues
        {
            get { return this.listaKategorija; }
        }

        public List<Kategorija> ListaZabranaValues
        {
            get { return this.listaZabrana; }
        }

        #endregion

        #region Constructors

        public ListaKategorija()
        {
            this.listaKategorija = new List<Kategorija>();
            this.listaZabrana = new List<Kategorija>();
        }

        #endregion

        #region Methodes

        public bool dodavanjeKategorije(Kategorija kat)
        {
            if (kategorijaUListi(kat))
                return false;

            this.listaKategorija.Add(kat);
            return true;
        }

        public bool brisanjeKategorije(String tip)
        {
            Kategorija temp = null;

            foreach (var k in this.listaKategorija)
            {
                if (k.Tip == tip)
                {
                    temp = k;
                    break;
                }
            }

            if (temp == null)
                return false;

            this.listaKategorija.Remove(temp);
            return true;
        }

        public bool kategorijaUListi(Kategorija kat)
        {
            foreach (var k in this.listaKategorija)
            {
                if (k.Tip == kat.Tip)
                    return true;
            }

            return false;
        }

        public bool dodavanjeZabrane(Kategorija kat)
        {
            if (zabranaUListi(kat))
                return false;

            this.listaZabrana.Add(kat);
            return true;
        }

        public bool brisanjeZabrane(String tip)
        {
            Kategorija temp = null;

            foreach (var k in this.listaZabrana)
            {
                if (k.Tip == tip)
                {
                    temp = k;
                    break;
                }
            }

            if (temp == null)
                return false;

            this.listaZabrana.Remove(temp);
            return true;
        }

        public bool zabranaUListi(Kategorija kat)
        {
            foreach (var k in this.listaZabrana)
            {
                if (k.Tip == kat.Tip)
                    return true;
            }

            return false;
        }

        #endregion

    }
}
