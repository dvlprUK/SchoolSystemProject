﻿using SchoolSystem.Data.Models.CustomModels;
using System.Collections.Generic;

namespace SchoolSystem.MVP.Admin.Models
{
    public class CreatingClassOfStudentsModel
    {
        public IEnumerable<SubjectBasicInfo> Subjects { get; set; }

        public bool IsSuccesfull { get; set; }
    }
}