using NoteProject.Common;
using NoteProject.Entities;
using NoteProject.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoteProject.WebUI.Init
{
    public class WebCommon : ICommon
    {
        public string GetUsername()
        {
            EvernoteUser user = CurrentSession.User;

            if(user != null)
            {
                return user.Username;
            }

            return "system";
        }
    }
}