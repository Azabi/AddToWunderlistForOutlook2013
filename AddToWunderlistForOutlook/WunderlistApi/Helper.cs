using System;
using System.Collections;
using System.Linq;
using AddToWunderlistForOutlook.WunderlistApi.Model;
using Newtonsoft.Json;
using RestSharp;

namespace AddToWunderlistForOutlook.WunderlistApi
{
    /// <summary>
    /// This class is  used communicate with the Wunderlist API.
    /// </summary>
    public static class Helper
    {

        // Wunderlist API URI
        private const string ApiUrl = "https://api.wunderlist.com";
        
        /// <summary>
        /// Call the Wunderlist API method.
        /// </summary>
        /// <param name="token">Authentication Token</param>
        /// <param name="endPoint">Method to pass. <example>me//tasks</example></param>
        /// <param name="parameters">Parameters to pass using Hastable</param>
        /// <param name="method">RestSharp Method. <see cref="RestSharp.Method"/></param>
        /// <returns></returns>
        static internal string DoCall(string token, string endPoint, Hashtable parameters = null, Method method = Method.GET)
        {
            var client = new RestClient(ApiUrl);
            var request = new RestRequest(endPoint)
            {
                Method = method
            };

            if (parameters != null)
            {
                foreach (string key in parameters.Keys)
                {
                    request.AddParameter(key, parameters[key]);
                }
            }

            if (endPoint != "login") request.AddHeader("Authorization", token);

            var response = client.Execute(request);

            //if (response.StatusCode)



            //if (response.Content == typeof(JsonArray))

            //{var jArrayreturn = JsonArray}
            //var jObjectReturn = JObject.Parse(response.Content);
            //return jObjectReturn;
            return response.Content;
        }

        /// <summary>
        /// Authenticate to the Wunderlist API
        /// </summary>
        /// <param name="email">Email address</param>
        /// <param name="password">Password</param>
        /// <returns>WlUser object</returns>
        internal static WlUser Authenticate(string email, string password)
        {
            var param = new Hashtable
                {
                    {"email", email}, 
                    {"password", password}
                };
            var json = DoCall(null, "login", param, Method.POST);

            var user = JsonConvert.DeserializeObject<WlUser>(json);

            return user;
        }

        /// <summary>
        /// Get the users lists
        /// </summary>
        /// <param name="token">Authentication Token</param>
        /// <returns></returns>
        internal static WlListCollection GetLists(string token)
        {
            var json = DoCall(token, "me//lists");
            var collection = JsonConvert.DeserializeObject<WlListCollection>(json);

            return collection;
        }

        /// <summary>
        /// Get the users tasks
        /// </summary>
        /// <param name="token">Authentication Token</param>
        /// <param name="listId">List Id to get tasks from. Default null</param>
        /// <param name="parentId">Parent Id of task to get tasks from. Default null</param>
        /// <returns></returns>
        internal static WlTaskCollection GetTasks(string token, string listId = null, string parentId = null)
        {
            var json = DoCall(token, "me//tasks");
            var collection = JsonConvert.DeserializeObject<WlTaskCollection>(json);
            var returnCollection = new WlTaskCollection();
            if (listId != null)
            {
                returnCollection.AddRange(collection.Where(task => task.List_Id == listId & task.Parent_Id == null));
            }
            else if (parentId != null)
            {
                returnCollection.AddRange(collection.Where(task => task.Parent_Id == parentId));
            }
            return returnCollection;
        }

        /// <summary>
        /// Add a new task
        /// </summary>
        /// <param name="token">Authentication Token</param>
        /// <param name="task">Task to add</param>
        /// <returns></returns>
        internal static WlTask AddTask(string token, WlTask task)
        {
            var param = new Hashtable
                {
                    {"title", task.Title},
                    {"list_id", task.List_Id},
                    {"note",task.Note},
                    {"parent_id", task.Parent_Id},
                    {"due_date", task.Due_Date},
                    {"starred", task.Starred},
                    {"created_at", DateTime.Now},
                    {"type", "Task"},
                };
            var json = DoCall(token, "me//tasks", param, Method.POST);
            var newtask = JsonConvert.DeserializeObject<WlTask>(json);
            return newtask;
        }

        /// <summary>
        /// Add a reminder to a Wunderlist task.
        /// </summary>
        /// <param name="token">Authentication Token</param>
        /// <param name="userId">Id of the authenticated user</param>
        /// <param name="reminder">DateTime of the reminder</param>
        /// <param name="taskId">Id of the task to add reminder to</param>
        internal static void AddReminder(string token, string userId, DateTime reminder, string taskId)
        {
            var param = new Hashtable
                {
                    {"date", reminder},
                    {"user_id", userId},
                    {"task_id", taskId}
                };
            DoCall(token, "me//reminders", param, Method.POST);
        }

        /// <summary>
        /// Star a Wunderlist task.
        /// </summary>
        /// <param name="token">Authentication Token</param>
        /// <param name="taskId">Id of the task</param>
        internal static void StarTask(string token, string taskId)
        {
            var param = new Hashtable
                {
                    {"starred", true},
                    {"task_id", taskId}
                };
            DoCall(token, taskId, param, Method.PUT);
        }

        /// <summary>
        /// Add a new Wunderlist List to Wunderlist
        /// </summary>
        /// <param name="token">Authentication Token</param>
        /// <param name="title">Wunderlist List title</param>
        /// <returns></returns>
        internal static WlList AddList(string token, string title)
        {
            var param = new Hashtable
                {
                    {"title", title},
                };
            var json = DoCall(token, "me//lists", param, Method.POST);
            var newlist = JsonConvert.DeserializeObject<WlList>(json);
            return newlist;
        }
    }
}
