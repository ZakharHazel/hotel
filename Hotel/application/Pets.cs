//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel.application
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pets
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pets()
        {
            this.Maintenance = new HashSet<Maintenance>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Type_animal { get; set; }
        public string Passport { get; set; }
        public int Age { get; set; }
        public string Note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Maintenance> Maintenance { get; set; }
        public virtual Type_of_animal Type_of_animal { get; set; }
    }
}