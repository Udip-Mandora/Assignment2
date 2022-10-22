using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        [HttpGet]
        [Route("api/J3/{sms}")]
        public string smsCount(string sms, Break @break)
        {
            List<string> sms2 = new List<string> { "a", "b", "c" };
            List<string> sms3 = new List<string> { "d", "e", "f" };
            List<string> sms4 = new List<string> { "g", "h", "i" };
            List<string> sms5 = new List<string> { "j", "k", "l" };
            List<string> sms6 = new List<string> { "m", "n", "o" };
            List<string> sms7 = new List<string> { "p", "q", "r", "s" };
            List<string> sms8 = new List<string> { "t", "u", "v" };
            List<string> sms9 = new List<string> { "w", "x", "y", "z" };

            string joint = "";
            if (sms == "halt")
            {
                Break break1 = @break;
            }
            else
            {
                for(int i = 0; i < sms.Length; i+=1)
                {
                    if (sms == sms2[i] | sms == sms3[i] | sms == sms4[i] | sms == sms5[i] | sms == sms6[i] | sms == sms7[i] | sms == sms8[i] | sms == sms9[i])
                    { 
                        joint += sms2[i] + sms3[i] + sms4[i] + sms5[i] + sms6[i] + sms7[i] + sms8[i] + sms9[i];
                    }
                }
            }

            return joint;
        }
    }
}
