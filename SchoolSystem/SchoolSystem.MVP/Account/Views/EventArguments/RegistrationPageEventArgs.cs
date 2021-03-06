﻿using System;
using System.Collections.Generic;

using Microsoft.Owin;

namespace SchoolSystem.MVP.Account.Views.EventArguments
{
    public class RegistrationPageEventArgs : EventArgs
    {
        public string Email { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserType { get; set; }

        public IOwinContext OwinCtx { get; set; }

        public IEnumerable<int> SubjectIds { get; set; }

        public int ClassOfSudentsId { get; set; }
    }
}