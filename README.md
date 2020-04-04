ActiveCampaign API Integration with Dot Net. 

Want to integrate ActiveCampaign's  account in the project?

Not getting any library or package of ActiveCampaign?

Don't know how to achieve it?

In this blog I would answer all of this questions with help of Github repository and learn to schedule it using System.Threading’s TimerCallback. 

ActiveCampaign is a cloud software platform for small-to-mid-sized business. 

The company offers software for customer experience automation, which combines the email marketing, marketing automation, sales automation, and CRM categories. 

For API documentation please follow the below link:-
https://www.activecampaign.com/api/overview.php 

In repository, you could see APIResult.cs file which is has models which would help to bind results of ActiveCampaign API.

ActiveCampaign API needs api_action and api_key as a mandate parameters to execute API. 

ActiveCampaignClient.cs file has few functions which would help to execute ActiveCampaign API.

With help of  documentation you could call API  with few filters also. For example: - Getting contacts based on attached tag.

For reference you could check "GetContactList" function.

Now, what if I want to sync contacts or notes on daily basis.

We have to create Time scheduler on server. But, we could also achieve this by TimerCallback . 

We will make Task which will run after some amount of intervals. For reference you could see the Task.cs file in the repository.

Now questions come how to execute these Tasks. For that we would require Global.asax file. Where we could write some code to set tasks, initialize and execute it. For reference you could check “Global.asax”.

Few basic settings on IIS after deploying.

 1. IIS Manager -> Application pools -> DefaultAppPool->Right Click->Advance Settings

2. Set Idle Time-out Action to zero. Zero means infinite. Site will never go in idle mode.

3. Set Regular Time interval(minutes) to Zero under Recycle section. Zero means infinite. Site will never recycle. 

If you are creating separate site to execute this Tasks then you may also need to create time scheduler which will trigger your site daily once in a day only If your server restart daily.

Because, to initialize all the Task you need to at least call Applicaton_start function in Global.asax which is called on very first request of site. And, if your server is been schedule to restart than your Tasks will not be continued to execute.

Follow the below steps to set Time scheduler:

1. Search for Task Scheduler in the start menu and open it.

2. In the Task Scheduler, click on "Create basic task".

3. Name the task and click on the "Next" button.

4. Select when do you want the task to start and click "Next". In my case, I want to run the task daily, so I've selected "Daily". If you want to start the task as soon as you start the computer then select either "When I log on" or "When the computer starts".

5. Choose the schedule and recurring behavior. If you want to run the schedule every day, make sure that the "Recur every day" field is set to "1".

6. Select "Start a program" and click "Next".

7. Click on the "Browse" button and select your browser. In my case, I'm selecting Chrome.

8. Add webpage address in the "Add arguments" field and click "Next"

9. Verify your configuration and click "Finish".

That is it. You've successfully scheduled a web page to launch at the time you need with Task Scheduler. To verify if the scheduled task is working properly, right-click on the schedule and select "Run". Task Scheduler will automatically open the target webpage in the browser of your choice.

Suggestions:- 

Try to keep log of every executions of task and sync process. So, that It would be helpful for you to track the error if occurs.
 
