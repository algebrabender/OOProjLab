using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Podaci
{
    public class ListaVozaca
    {
        public delegate void SortDelegate(List<Vozac> lista);
        public SortDelegate SortListDelegate { get; set; }

        #region Atributes

        private List<Vozac> listaVozaca;

        #endregion

        #region Properties

        public List<Vozac> ListaVozacaValues
        {
            get { return this.listaVozaca; }
        }

        #endregion

        #region Constructors

        private ListaVozaca()
        {
            this.listaVozaca = new List<Vozac>();
        }

        #endregion

        #region Methodes

        public bool dodavanjeVozaca(Vozac vozac)
        {
            if (vozacUListi(vozac))
                return false;

            this.listaVozaca.Add(vozac);
            return true;
        }

        public bool brisanjeVozaca(Vozac vozac)
        {
            if (!vozacUListi(vozac))
                return false;

            this.listaVozaca.Remove(vozac);
            return true;
        }

        public bool brisanjeVozaca(String dozvola)
        {
            Vozac temp = null;

            foreach (var v in this.listaVozaca)
            {
                if (v.BrojVozackeDozvole == dozvola)
                {
                    temp = v;
                    break;
                }
            }

            if (temp == null)
                return false;

            this.listaVozaca.Remove(temp);
            return true;
        }

        public bool menjanjeVozaca(Vozac vozac)
        {
            Vozac v = GetVozac(vozac.BrojVozackeDozvole);

            if (v == null)
                return false;

            v.Ime = vozac.Ime;
            v.Prezime = vozac.Prezime;
            v.BrojVozackeDozvole = vozac.BrojVozackeDozvole;
            v.DatumRodjenja = vozac.DatumRodjenja;
            v.DozvolaOd = vozac.DozvolaOd;
            v.DozvolaDo = vozac.DozvolaDo;
            v.MestoIzdavanja = vozac.MestoIzdavanja;
            v.Pol = vozac.Pol;
            return true;
        }

        public bool vozacUListi(Vozac vozac)
        {
            foreach (var v in this.listaVozaca)
            {
                if (v.BrojVozackeDozvole == vozac.BrojVozackeDozvole)
                    return true;
            }

            return false;
        }

        public bool vozacUListi(String dozvola)
        {
            foreach (var v in this.listaVozaca)
            {
                if (v.BrojVozackeDozvole == dozvola)
                    return true;
            }

            return false;
        }

        public Vozac GetVozac(String dozvola)
        {
            foreach (var v in this.listaVozaca)
            {
                if (v.BrojVozackeDozvole == dozvola)
                    return v;
            }

            return null;
        }

        public void sortiranje()
        {
            if (SortListDelegate != null)
                SortListDelegate(listaVozaca);
        }

        public void izFajla(String putanja)
        {
            using (StreamReader sr = new StreamReader(putanja))
            {
                int brojVozaca = int.Parse(sr.ReadLine());
                for (int i = 0; i< brojVozaca; i++)
                {
                    Vozac v = new Vozac();
                    v.Ime = sr.ReadLine();
                    v.Prezime = sr.ReadLine();
                    v.BrojVozackeDozvole = sr.ReadLine();
                    v.DatumRodjenja = sr.ReadLine();
                    v.DozvolaOd = sr.ReadLine();
                    v.DozvolaDo = sr.ReadLine();
                    v.MestoIzdavanja = sr.ReadLine();
                    v.Pol = sr.ReadLine();
                    v.PutanjaDoSlike = sr.ReadLine();

                    String linija = sr.ReadLine();
                    String dtOd, dtDo;
                    if (linija == "Kategorije")
                    {
                        linija = sr.ReadLine();
                        while (linija != "Zabrane")
                        {
                            dtOd = sr.ReadLine();
                            dtDo = sr.ReadLine();
                            Kategorija k = new Kategorija(linija, dtOd, dtDo);
                            v.Liste.dodavanjeKategorije(k);

                            linija = sr.ReadLine();
                        }
                        if (linija == "Zabrane")
                        {
                            linija = sr.ReadLine();
                            while (linija != "" && linija != null)
                            {
                                dtOd = sr.ReadLine();
                                dtDo = sr.ReadLine();
                                Kategorija k = new Kategorija(linija, dtOd, dtDo);
                                v.Liste.dodavanjeZabrane(k);

                                linija = sr.ReadLine();
                            }
                        }
                    }
                    listaVozaca.Add(v);
                }
            }
        }

        public void uFajl(String putanja)
        {
            using (StreamWriter sw = new StreamWriter(putanja))
            {
                sw.WriteLine(listaVozaca.Count);
                foreach (Vozac v in listaVozaca)
                {
                    sw.WriteLine(v.Ime);
                    sw.WriteLine(v.Prezime);
                    sw.WriteLine(v.BrojVozackeDozvole);
                    sw.WriteLine(v.DatumRodjenja);
                    sw.WriteLine(v.DozvolaOd);
                    sw.WriteLine(v.DozvolaDo);
                    sw.WriteLine(v.MestoIzdavanja);
                    sw.WriteLine(v.Pol);
                    sw.WriteLine(v.PutanjaDoSlike);

                    sw.WriteLine("Kategorije");
                    foreach (Kategorija k in v.Liste.ListaKategorijaValues)
                    {
                        sw.WriteLine(k.Tip);
                        sw.WriteLine(k.DatumOd);
                        sw.WriteLine(k.DatumDo);
                    }
                    
                    sw.WriteLine("Zabrane");
                    foreach (Kategorija k in v.Liste.ListaZabranaValues)
                    {
                        sw.WriteLine(k.Tip);
                        sw.WriteLine(k.DatumOd);
                        sw.WriteLine(k.DatumDo);
                    }
                    

                    sw.WriteLine();
                }
            }
        }

        #endregion

        private static ListaVozaca instance = null;

        public static ListaVozaca Instance
        {
            get
            {
                if (instance == null)
                    instance = new ListaVozaca();

                return instance;
            }
        }
    }
}
