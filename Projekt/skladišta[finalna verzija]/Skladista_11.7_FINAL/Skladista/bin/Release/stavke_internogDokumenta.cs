//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Skladista
{
    using System;
    using System.Collections.Generic;
    
    public partial class stavke_internogDokumenta
    {
        public int id_dokumenta { get; set; }
        public int id_artikla { get; set; }
        public Nullable<int> kolicina { get; set; }
        public Nullable<decimal> cijena_artikla { get; set; }
    
        public virtual Artikl Artikl { get; set; }
        public virtual interniDokument interniDokument { get; set; }
        public virtual Artikl Artikl1 { get; set; }
        public float UkupnaCijena
        {
            get
            {
                if(kolicina!=null && cijena_artikla!=null)
                return (float)kolicina * (float)cijena_artikla;
                return 0;
            }
        }
    }
}
