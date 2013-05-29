using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventsWebSite.Models
{
    public enum EventType
    {
        Defaut = 0,

        TaskUpdated,

        AddedPicture,

        SignTask,

        AddComment,

        TaskCanceled,

        TaskStateChanged
    }
}