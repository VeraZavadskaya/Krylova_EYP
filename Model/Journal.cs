//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Krylova_EYP.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Journal
    {
        public int Id { get; set; }
        public System.DateTime DateTest { get; set; }
        public int IdStudent { get; set; }
        public int IdTest { get; set; }
        public int Mark { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Test Test { get; set; }
    }
}
