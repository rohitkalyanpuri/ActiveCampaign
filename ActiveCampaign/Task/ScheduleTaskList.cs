using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace ActiveCampaign.Task
{
    public static class ScheduleTaskList
    {
        public static List<ScheduleTask> ScheduleTasks = new List<ScheduleTask>();
        public static int dailyhours = 60 * 60 * 12;
        public static void SetDefaultTask()
        {
            // This is test task we can create number of task as per our requiremnt.          
            //Default interval value for timer
            int seconds = 60*60*12; //60 Sec * 60 Min * 12 =12 hours 
            int dailyhours = 60*60*2;//60 Sec * 60 Min * 2 =2 hours
           
            string timerinterval = ConfigurationManager.AppSettings["NotificationTaskInterval"];
            if (!string.IsNullOrEmpty(timerinterval))
            {
                try
                {
                    seconds = Convert.ToInt32(timerinterval.Trim());
                }
                catch (Exception)
                {
                }
            }

            ScheduleTask task7 = new ScheduleTask();
            task7.Name = "ContactNotesSync";
            task7.Type = (typeof(ContactNotesSync)).ToString();           // change 7
            task7.Seconds = dailyhours;    //change 7
            task7.StopOnError = false;
            task7.Enabled = true;
            ScheduleTaskList.ScheduleTasks.Add(task7);

        }
        public static ScheduleTask GetTaskByType(string TaskType)
        {
            return ScheduleTasks.Where(q => q.Type == TaskType).FirstOrDefault();
        }
       

    }
}
