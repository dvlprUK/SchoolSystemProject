﻿using System.Collections.Generic;

using SchoolSystem.Data.Models;
using SchoolSystem.Data.Models.CustomModels;

namespace SchoolSystem.Web.Services.Contracts
{
    public interface ISubjectManagementService
    {
        bool CreateSubject(string subjectName, string subjectPictureUrl);

        IEnumerable<Subject> GetAllSubjects();

        IEnumerable<Subject> GetAllSubjectsAlreadyAssignedToTheClass(int classId);

        /// <summary>
        /// Gets subjects with assigned teachers
        /// </summary>
        /// <returns></returns>
        IEnumerable<SubjectBasicInfoModel> GetAllSubjectsWithTeacher();

        IEnumerable<SubjectBasicInfoModel> GetSubjectsPerTeacher(string teacherName);

        /// <summary>
        /// Gets the subjects with no assigned teacher
        /// </summary>
        /// <returns> IEnumerable<Subject> </returns>
        IEnumerable<SubjectBasicInfoModel> GetAllSubjectsWithoutTeacher();

        /// <summary>
        /// Gets the subjects that are not assigned to the specified class yet.
        /// </summary>
        /// <param name="classId"></param>
        /// <returns></returns>
        IEnumerable<SubjectBasicInfoModel> GetSubjectsNotYetAssignedToTheClass(int classId);

        bool AddSubjectsToTeacher(string teacherId, IEnumerable<int> subjectIds);
    }
}
