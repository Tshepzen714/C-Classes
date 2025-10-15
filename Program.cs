using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Writing_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }//End Main
    }//End Program
    public class Phone
    {
        private string phoneNumber;
        private int airTime;
        private int sms;

        public void SetPhone(string nPhoneNumber,int nAirTime,int nSms)
        {
            phoneNumber = nPhoneNumber;
            airTime = nAirTime >= 0 ? nAirTime : 0;
            sms = nSms >= 0 ? nSms : 0;
        }
        public string GetPhoneDetails()
        {
            return phoneNumber + "\tAir Time: " + airTime + "\tSms: " + sms;
        }
        public int Call(int callDuration)
        {
            return airTime - callDuration;
        }
        public bool SendSms()
        {
            
                bool flag = false;
            {
                if (sms >= 1)
                    sms--;
                flag = true;
            }
                return flag;
             
        }
    }//End Phone




}


