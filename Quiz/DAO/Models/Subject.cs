using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DAO.Models
{
    public partial class Subject
    {
        public int SubjectId { get; set; }
        public string NameSubject { get; set; }
        public int? ParentSubjectId { get; set; }
    }
}
