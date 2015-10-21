using System;
using Microsoft.Build.Utilities;
using Microsoft.Build.Framework;
using System.Diagnostics;


namespace Test
{
    class PublishVersionTask : Task
    {
        //static int rev = 1;
        //static DateTime currentdate = DateTime.Now;

        public int Revision
        {
            get
            {
                //if (DateTime.Now.Date == currentdate.Date)
                //    rev++;
                //else
                //    rev = 1;
                //return rev;
                return 1;
            }
        }

        [Output]
        public string PublishVersion
        {
            get
            {
                return DateTime.Now.ToString("yyyy.MM.dd.") + Revision.ToString();

            }
        }

        public override bool Execute()
        {
            Debug.WriteLine("PublishVersion = " + PublishVersion);
            return true;
        }



    }
}
