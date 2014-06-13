using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AddToWunderlistForOutlook.WunderlistApi.Model;
using RestSharp;

namespace AddToWunderlistForOutlook.WunderlistApi
{
    /// <summary>
    /// This State class holds the current Authentications of the Wunderlist API. This class is also used communicate with the Helper class.
    /// </summary>
    public class State
    {

        /// <summary>
        /// Is the user authenticated.
        /// </summary>
        public bool Authenticated { get; private set; }

        /// <summary>
        /// Get the current authenticated user.
        /// </summary>
        public WlUser User { get; private set; }

        /// <summary>
        /// Get the Wunderlist lists from the current User.
        /// </summary>
        public WlListCollection WlListCollection { get; private set; }

        /// <summary>
        /// Authenticate to the Wunderlist API
        /// </summary>
        /// <param name="email">Email address</param>
        /// <param name="password">Password</param>
        /// <returns></returns>
        public bool Authenticate(string email, string password)
        {
            User = Helper.Authenticate(email, password);
            if (User != null & User.Token != null)
            {
                Authenticated = true;

                GetLists();
            }

            return Authenticated;
        }

        /// <summary>
        /// Retrieve the Wunderlist lists from the Wunderlist Api.
        /// </summary>
        /// <returns></returns>
        public bool GetLists()
        {
            if (User != null)
            {
                WlListCollection = Helper.GetLists(User.Token);
            }

            return (WlListCollection != null);
        }

        /// <summary>
        /// Add a new Wunderlist Task to Wunderlist.
        /// </summary>
        /// <param name="task">Wunderlist Task to add</param>
        /// <returns></returns>
        public WlTask AddTask(WlTask task)
        {
            return Helper.AddTask(User.Token, task);
        }

        /// <summary>
        /// Add a reminder to a Wunderlist task.
        /// </summary>
        /// <param name="reminderdate">Reminder date</param>
        /// <param name="taskId">Id of the Task</param>
        public void AddReminder(DateTime reminderdate, string taskId)
        {
            Helper.AddReminder(User.Token, User.Id, reminderdate, taskId);
        }

        /// <summary>
        /// Star a Wunderlist task.
        /// </summary>
        /// <param name="taskId">Id of the Task</param>
        public void StarTask(string taskId)
        {
            Helper.StarTask(User.Token, taskId);
        }

        /// <summary>
        /// Add a new Wunderlist List to Wunderlist
        /// </summary>
        /// <param name="title">Wunderlist List title</param>
        /// <returns></returns>
        public WlList AddList(string title)
        {
            return Helper.AddList(User.Token, title);
        }

    }
}
