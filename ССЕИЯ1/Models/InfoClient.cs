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
    
    public partial class InfoClient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InfoClient()
        {
            this.Obshii = new HashSet<Obshii>();
        }
    
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int IdOrganization { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> DataBirthday { get; set; }
        public Nullable<int> SeriyaPasport { get; set; }
        public Nullable<int> numberPasport { get; set; }
        public byte[] Photo { get; set; }
    
        public virtual Organization Organization { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Obshii> Obshii { get; set; }
    }
}
