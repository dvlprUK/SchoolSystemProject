﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminArea.aspx.cs" Inherits="SchoolSystem.WebForms.Admin.AdminArea" %>

<%@ Register Src="~/CustomControls/Admin/CreatingSubjectControl.ascx" TagPrefix="custom" TagName="CreatingSubjectControl" %>
<%@ Register Src="~/CustomControls/Admin/CreatingClassOfStudentsControl.ascx" TagPrefix="custom" TagName="CreatingClassOfStudentsControl" %>
<%@ Register Src="~/CustomControls/Admin/ManagingScheduleControl.ascx" TagPrefix="custom" TagName="ManagingScheduleControl" %>

<%@ Register Assembly="AjaxControlToolkit"
    Namespace="AjaxControlToolkit"
    TagPrefix="ajaxtoolkit" %>
<%@ Register Src="~/CustomControls/Admin/AssignSubjectsToClassOfStudentsControl.ascx" TagPrefix="custom" TagName="AssignSubjectsToClassOfStudentsControl" %>
<%@ Register Src="~/CustomControls/Admin/AssignSubjectToTeacherControl.ascx" TagPrefix="custom" TagName="AssignSubjectToTeacherControl" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:Label runat="server" ID="Tabs" CssClass="tabs">
                <asp:Button Text="Създаване на предмет" BorderStyle="None" ID="Tab1" CssClass="btn btn-default tab" runat="server"
                    OnClick="Tab1_Click" />

                <asp:Button Text="Създаване на клас" BorderStyle="None" ID="Tab2" CssClass="btn btn-default tab" runat="server"
                    OnClick="Tab2_Click" />

                <asp:Button Text="Менажиране на програма" BorderStyle="None" ID="Tab3" CssClass="btn btn-default tab" runat="server"
                    OnClick="Tab3_Click" />

                <asp:Button Text="Добавяне на предмет към клас" BorderStyle="None" ID="Tab4" CssClass="btn btn-default tab" runat="server"
                    OnClick="Tab4_Click" />

                 <asp:Button Text="Добавяне на предмет към учител" BorderStyle="None" ID="Tab5" CssClass="btn btn-default tab" runat="server"
                    OnClick="Tab5_Click" />

            </asp:Label>

            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View runat="server" ID="CreatingSubjectTab">
                    <custom:CreatingSubjectControl runat="server" />
                </asp:View>
                <asp:View runat="server" ID="CreatingClassOfStudentsTab">
                    <custom:CreatingClassOfStudentsControl runat="server" />
                </asp:View>
                <asp:View runat="server" ID="ManagingScheduleTab">
                    <custom:ManagingScheduleControl runat="server" />
                </asp:View>
                <asp:View runat="server" ID="AssigningSubjectsToClass">
                    <custom:AssignSubjectsToClassOfStudentsControl runat="server" id="AssignSubjectsToClassOfStudentsControl" />
                </asp:View>
                  <asp:View runat="server" ID="AssignSubjectsToTeacher">
                      <custom:AssignSubjectToTeacherControl runat="server" ID="AssignSubjectToTeacherControl" />
                </asp:View>
            </asp:MultiView>
        </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="Tab1" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
