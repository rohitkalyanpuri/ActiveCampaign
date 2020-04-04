using ActiveCampaignNet;
using System;

namespace ActiveCampaign.Task
{
   
    public class ContactNotesSync : ITask
    {
        public static bool IsExecuting = false;
        public void Execute()
        {
            try
            {
                
                if (IsExecuting)
                    return;

                TimeSpan start = new TimeSpan(7, 0, 0); //7 o'clock
                TimeSpan end = new TimeSpan(23, 59, 0); //23:59 o'clock
                TimeSpan now = DateTime.Now.TimeOfDay;

                if ((now > start) && (now < end))
                {
                    IsExecuting = true;
                    ActiveCampaignClient activeCampaignClient = new ActiveCampaignClient();
                    activeCampaignClient.SyncActiveCampaignContactNotes();
                    IsExecuting = false;
                }
              
            }
            catch (Exception ex)
            {
                IsExecuting = false;
                
            }
        }

        
    }
}