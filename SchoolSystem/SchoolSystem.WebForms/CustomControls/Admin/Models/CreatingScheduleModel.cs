﻿using SchoolSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolSystem.WebForms.CustomControls.Admin.Models
{
    public class CreatingScheduleModel
    {
        public IEnumerable<ClassOfStudents> AllClassOfStudents { get; set; }

        public IEnumerable<Test> CurrentSchedule { get; set; } = new List<Test>                 {
                    new Test() {ClassName="12a",StartHour = 11, EndHour = 12, SubjName = "matem", DayOfWeek = "Monday" },
                    new Test() {ClassName="11a",StartHour = 11, EndHour = 12, SubjName = "bg", DayOfWeek = "Tuesday" },
                    new Test() {ClassName="11a",StartHour = 11, EndHour = 12, SubjName = "lit", DayOfWeek = "Thursday" },
                    new Test() {ClassName="12a",StartHour = 11, EndHour = 12, SubjName = "fvs", DayOfWeek = "Thursday" },
                    new Test() {ClassName="12a",StartHour = 11, EndHour = 12, SubjName = "neshto", DayOfWeek = "Thursday" },
                    new Test() {ClassName="12a",StartHour = 11, EndHour = 12, SubjName = "drugo", DayOfWeek = "Thursday" },
                    new Test() {ClassName="11a",StartHour = 11, EndHour = 12, SubjName = "ala", DayOfWeek = "Thursday" },
                    new Test() {ClassName="11a",StartHour = 11, EndHour = 12, SubjName = "bala", DayOfWeek = "Thursday" },
                    new Test() {ClassName="11a",StartHour = 11, EndHour = 12, SubjName = "matem", DayOfWeek = "Monday" },
                    new Test() {ClassName="11a",StartHour = 11, EndHour = 12, SubjName = "makro", DayOfWeek = "Monday" },
                    new Test() {ClassName="12a",StartHour = 11, EndHour = 12, SubjName = "matem", DayOfWeek = "Monday" },
                    new Test() {ClassName="12a",StartHour = 11, EndHour = 12, SubjName = "finansi", DayOfWeek = "Monday" },
                    new Test() {ClassName="11a",StartHour = 11, EndHour = 12, SubjName = "matem", DayOfWeek = "Monday" },
                    new Test() {ClassName="11a",StartHour = 11, EndHour = 12, SubjName = "ssss", DayOfWeek = "Monday" },
                    new Test() {ClassName="11a",StartHour = 11, EndHour = 12, SubjName = "schetovodstvo", DayOfWeek = "Monday" },
                    new Test() {ClassName="11a",StartHour = 11, EndHour = 12, SubjName = "matem", DayOfWeek = "Monday" },
                    new Test() {ClassName="11a",StartHour = 11, EndHour = 12, SubjName = "matem", DayOfWeek = "Monday" },
                    new Test() {ClassName="12a",StartHour = 11, EndHour = 12, SubjName = "matem", DayOfWeek = "Monday" },
                    new Test() {ClassName="12a",StartHour = 11, EndHour = 12, SubjName = "pc", DayOfWeek = "Monday" },
                    new Test() {ClassName="12а",StartHour = 11, EndHour = 12, SubjName = "petak12", DayOfWeek = "Friday" },
                    new Test() {ClassName="12а",StartHour = 11, EndHour = 12, SubjName = "petak12", DayOfWeek = "Friday" },
                    new Test() {ClassName="11a",StartHour = 11, EndHour = 12, SubjName = "petak11", DayOfWeek = "Friday" },
                };
    }

    public class Test
    {
        public int StartHour { get; set; }
        public int EndHour { get; set; }

        public string SubjName { get; set; }

        public string DayOfWeek { get; set; }

        public string ClassName { get; set; }
    }
}