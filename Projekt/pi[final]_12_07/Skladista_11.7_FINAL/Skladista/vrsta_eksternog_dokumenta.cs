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
    
    public partial class vrsta_eksternog_dokumenta
    {
        public vrsta_eksternog_dokumenta()
        {
            this.eksterniDokument = new HashSet<eksterniDokument>();
        }
    
        public int sifra { get; set; }
        public string naziv { get; set; }
    
        public virtual ICollection<eksterniDokument> eksterniDokument { get; set; }
    }
}
