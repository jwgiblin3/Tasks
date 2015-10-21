using System;
using Microsoft.Build.Utilities;
using Microsoft.Build.Framework;
using System.Diagnostics;

namespace RevisionTask
{       
    public class RevisionTask :Task
    {
        public static DateTime currentdate = DateTime.Now;

        public int Revision
        {
            get
            {
                //if (DateTime.Now.Date == currentdate.Date)
                //    rev++;
                //else
                //    rev = 1;
                //return rev;

                return DateTime.Now.Hour + (DateTime.Now.Minute * 60);
            }
        }

        [Output]
        public string PublishVersion
        {
            get; set;

        }





 


        public override bool Execute()
        {
            PublishVersion = DateTime.Now.ToString("yyyy.MM.dd.") + Revision.ToString();
 	        Debug.WriteLine("PublishVersion = " + PublishVersion);
            Log.LogMessage(MessageImportance.High, "PublishVersion = " + PublishVersion);

            return true;
   

        }
    }
}
