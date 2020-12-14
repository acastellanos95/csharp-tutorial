using System;
using System.Collections.Generic;

namespace Exercise_WE
{
    class Program
    {
        static void Main(string[] args)
        {
            UploadVideoToCloudStorage uploadVideoToCloudStorage = new UploadVideoToCloudStorage();
            CallThirdPartyVideoEncoder callThirdPartyVideoEncoder = new CallThirdPartyVideoEncoder();
            SendNotificationEmail sendNotificationEmail = new SendNotificationEmail();
            ChangeStatusDBToProcessing changeStatusDBToProcessing = new ChangeStatusDBToProcessing();

            Workflow workflow = new Workflow(new List<IActivity> { uploadVideoToCloudStorage, callThirdPartyVideoEncoder, sendNotificationEmail, changeStatusDBToProcessing });

            workflow.Run();
        }
    }
}
