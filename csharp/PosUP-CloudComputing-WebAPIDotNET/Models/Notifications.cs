using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Microsoft.Azure.NotificationHubs;

namespace PosUP_CloudComputing_WebAPIDotNET.Models
{
    public class Notifications
    {
        public static Notifications Instance = new Notifications();

        public NotificationHubClient Hub { get; set; }

        private Notifications()
        {
            Hub = NotificationHubClient.CreateClientFromConnectionString("Endpoint=sb://posup-cloudcomputing-namespace.servicebus.windows.net/;SharedAccessKeyName=DefaultFullSharedAccessSignature;SharedAccessKey=6Ve3WikmVFgu/qh3mTyw5LHQDtx77NYCSa/RKtI82yY=", "posup-cloudcomputing-nh");
        }
    }
}