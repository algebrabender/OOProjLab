using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class Kategorija
    {
        #region Atributes

        private String tip;
        private String datumOd;
        private String datumDo;

        #endregion

        #region Properties

        public String Tip
        {
            get { return this.tip; }
            set { this.tip = value; }
        }

        public String DatumOd
        {
            get { return this.datumOd; }
            set { this.datumOd = value; }
        }

        public String DatumDo
        {
            get { return this.datumDo; }
            set { this.datumDo = value; }
        }

        #endregion

        #region Constrctors

        public Kategorija() { }

        public Kategorija(String kat, String datOd, String datDo)
        {
            this.tip = kat;
            this.datumOd = datOd;
            this.datumDo = datDo;
        }

        #endregion
    }
}
