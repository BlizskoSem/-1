//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ССЕИЯ1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReceivingParty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReceivingParty()
        {
            this.Obshii = new HashSet<Obshii>();
        }
    
        public int Id { get; set; }
        public int IdDivision { get; set; }
        public string Fcs { get; set; }
        public byte[] Photo { get; set; }
    
        public virtual Divisions Divisions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Obshii> Obshii { get; set; }
    }
}
