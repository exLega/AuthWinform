//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp8
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pasport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pasport()
        {
            this.Pacient = new HashSet<Pacient>();
        }
    
        public int id { get; set; }
        public Nullable<int> number { get; set; }
        public Nullable<int> seria { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string father_name { get; set; }
        public Nullable<System.DateTime> date_birth { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pacient> Pacient { get; set; }
    }
}
