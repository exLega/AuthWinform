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
    
    public partial class Visit
    {
        public int id { get; set; }
        public Nullable<int> pacient_id { get; set; }
        public Nullable<int> doctor_id { get; set; }
    
        public virtual WindowsFormsApp8.Models.Doctor Doctor { get; set; }
        public virtual Pacient Pacient { get; set; }
    }
}
