using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Podaci
{
    public class Vozac : Object
    {
        #region Atributes

        private String ime;
        private String prezime;
        private String brojVozackeDozvole;
        private String datumRodjenja;
        private String dozvolaOd;
        private String dozvolaDo;
        private String mestoIzdavanja;
        private String pol;
        private String putanjaDoSlike;
        private ListaKategorija liste;

        #endregion

        #region Properties

        public String Ime
        {
            get { return this.ime; }
            set { this.ime = value; }
        }

        public String Prezime
        {
            get { return this.prezime; }
            set { this.prezime = value; }
        }

        public String BrojVozackeDozvole
        {
            get { return this.brojVozackeDozvole; }
            set { this.brojVozackeDozvole = value; }
        }

        public String DatumRodjenja
        {
            get { return this.datumRodjenja; }
            set { this.datumRodjenja = value; }
        }

        public String DozvolaOd
        {
            get { return this.dozvolaOd; }
            set { this.dozvolaOd = value; }
        }

        public String DozvolaDo
        {
            get { return this.dozvolaDo; }
            set { this.dozvolaDo = value; }
        }

        public String MestoIzdavanja
        {
            get { return this.mestoIzdavanja; }
            set { this.mestoIzdavanja = value; }
        }

        public String Pol
        {
            get { return this.pol; }
            set { this.pol = value; }
        }

        public String PutanjaDoSlike
        {
            get { return this.putanjaDoSlike; }
            set { this.putanjaDoSlike = value; }
        }

        public ListaKategorija Liste
        {
            get { return this.liste; }
            set { this.liste = value; }
        }

        /*public ListaZabrana Zabrane
        {
            get { return this.zabrane; }
            set { this.zabrane = value; }
        }*/


        #endregion

        #region Constrctors

        public Vozac() 
        {
            this.Liste = new ListaKategorija();
        }

        public Vozac(String ime, String prezime, String brVoz, String datumRodj, String dozOd, String dozDo, String mesto, String pol, String putanja)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.brojVozackeDozvole = brVoz;
            this.datumRodjenja = datumRodj;
            this.dozvolaOd = dozOd;
            this.dozvolaDo = dozDo;
            this.mestoIzdavanja = mesto;
            this.pol = pol;
            this.putanjaDoSlike = putanja;
        }

        #endregion
    }
}
