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
    
    public partial class Staffs
    {
        public int id { get; set; }
        public string name { get; set; }
        public string login { get; set; }
        public string passoword { get; set; }
        public int role_id { get; set; }
    
        public virtual Roles Roles { get; set; }
    }
}
