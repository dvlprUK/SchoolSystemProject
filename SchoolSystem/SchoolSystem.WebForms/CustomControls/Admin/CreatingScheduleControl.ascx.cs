﻿using SchoolSystem.WebForms.CustomControls.Admin.Models;
using SchoolSystem.WebForms.CustomControls.Admin.Presenters;
using SchoolSystem.WebForms.CustomControls.Admin.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsMvp;
using WebFormsMvp.Web;
using SchoolSystem.WebForms.CustomControls.Admin.Views.EventArguments;
using System.Web.ModelBinding;
using SchoolSystem.Data.Models;
using Ninject;
using SchoolSystem.WebForms.App_Start;
using System.Data.Entity;
using SchoolSystem.Data;
using System.Windows.Forms;
using SchoolSystem.Data.Models.CustomModels;

namespace SchoolSystem.WebForms.CustomControls.Admin
{
    [PresenterBinding(typeof(CreatingSchedulePresenter))]
    public partial class CreateScheduleControl : MvpUserControl<CreatingScheduleModel>, ICreatingScheduleView
    {

        private readonly SchoolSystemDbContext context;
        public event EventHandler<EventArgs> EventBindAllClasses;
        public event EventHandler<CreatingScheduleEventArgs> EventBindScheduleData;
        public event EventHandler<EventArgs> EventBindDaysOfWeek;
        public event EventHandler<AddingSubjectToScheduleEventArgs> EventAddSubjectToSchedule;
        public event EventHandler<BindSubjectsForClassEventArgs> EventBitSubjectForCurrentClass;

        public CreateScheduleControl()
        {
            this.context = NinjectWebCommon.Kernel.Get<SchoolSystemDbContext>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.EventBindAllClasses(this, e);
                this.ClassOfStudentsDropDown.DataSource = this.Model.AllClassOfStudents;
                this.ClassOfStudentsDropDown.DataBind();

                this.EventBindDaysOfWeek(this, e);
                this.DaysOfWeekDropDown.DataSource = this.Model.DaysOfWeek;
                this.DaysOfWeekDropDown.DataBind();

            }

            //this.EventBindScheduleData(this, new CreatingScheduleEventArgs()
            //{
            //    ClassId = this.ClassOfStudentsDropDown.SelectedValue,
            //    DayOfWeekId = this.DaysOfWeekDropDown.SelectedValue
            //});

            //this.ScheduleList.DataSource = this.Model.CurrentSchedule;
            //this.ScheduleList.DataBind();

            //this.EventBitSubjectForCurrentClass(this, new BindSubjectsForClassEventArgs()
            //{
            //    ClassId = int.Parse(this.ClassOfStudentsDropDown.SelectedValue)
            //});

            //this.AddingSubjectDropDown.DataSource = this.Model.SubjectForCurrentClass;
            //this.AddingSubjectDropDown.DataBind();
        }

        public void DaysOfWeekDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.EventBindScheduleData(this, new CreatingScheduleEventArgs()
            {
                ClassId = this.ClassOfStudentsDropDown.SelectedValue,
                DayOfWeekId = this.DaysOfWeekDropDown.SelectedValue
            });

            //this.ScheduleList.DataSource = this.Model.CurrentSchedule;
            //this.ScheduleList.DataBind();
        }




        protected void ScheduleList_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            var subjectDropDown = e.Item.FindControl("AddingSubjectDropDown") as DropDownList;
            var selectedSubjectId = int.Parse(subjectDropDown.SelectedValue);

            var startHourDropDown = e.Item.FindControl("StartHourDropDown") as DropDownList;
            var startHour = int.Parse(startHourDropDown.SelectedValue);
            // public DateTime(int year, int month, int day, int hour, int minute, int second);
            var startHourDateTime = new DateTime(2016, 1, 1, startHour, 0, 0);

            var endHourDropDown = e.Item.FindControl("EndHourDropDown") as DropDownList;
            var endHour = int.Parse(endHourDropDown.SelectedValue);
            var endHourAsDateTime = new DateTime(2016, 1, 1, startHour, 0, 0);

            var dayOfWeekId = int.Parse(this.DaysOfWeekDropDown.SelectedValue);
            var classId = int.Parse(this.ClassOfStudentsDropDown.SelectedValue);

            switch (e.CommandName)
            {
                case ("Edit"):
                    this.Update();
                    break;
                case ("Insert"):
                    this.ScheduleList_InsertItem(classId, dayOfWeekId, selectedSubjectId, startHourDateTime, endHourAsDateTime);
                    break;
            }
        }

        private void ScheduleList_InsertItem(int classId, int dayOfWeekId, int selectedSubjectId, DateTime sartHour, DateTime endHour)
        {
            this.EventAddSubjectToSchedule(this, new AddingSubjectToScheduleEventArgs()
            {
                ClassId = classId,
                DaysOfWeekId = dayOfWeekId,
                StartHour = sartHour,
                EndHour = endHour,
                SubjectId = selectedSubjectId
            });
        }

        private void Update()
        {
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IEnumerable<ManagingScheduleModel> ScheduleList_GetData()
        {
            this.EventBindScheduleData(this, new CreatingScheduleEventArgs()
            {
                ClassId = this.ClassOfStudentsDropDown.SelectedValue,
                DayOfWeekId = this.DaysOfWeekDropDown.SelectedValue
            });

            return this.Model.CurrentSchedule;
        }
        public IEnumerable<Subject> PopulateSubjects()
        {
            this.EventBitSubjectForCurrentClass(this, new BindSubjectsForClassEventArgs()
            {
                ClassId = int.Parse(this.ClassOfStudentsDropDown.SelectedValue)
            });

            return this.Model.SubjectForCurrentClass;
        }
    }
}
