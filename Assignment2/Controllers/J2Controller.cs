using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        ///<summary>
        ///Gives total ways to get a sum of 10 by rolling two dices
        ///</summary>
        ///<param name="m">positive integer representing the number of sides on the first die</param>
        ///<param name="n">positive integer representing the number of sides on the second die</param>
        ///<example>
        ///     GET : /api/J2/6/8   
        ///         There are 5 total ways to get the sum 10.
        ///         
        ///     GET : /api/J2/12/4
        ///         There are 4 total ways to get the sum 10.
        ///         
        ///     GET : /api/J2/3/3
        ///         There are 0 total ways to get the sum 10.
        ///</example>
        [HttpGet]
        [Route("api/J2/{m}/{n}")]
        public string DiceGame(int m, int n)
        {

            int dice = 0;
            for (int i = 0; i <= m; i+=1)
            {
                for(int j = 0; j <= n; j += 1) 
                {
                    if ((i + j) == 10)
                    {
                        dice++;
                    }
                }
            }
            return "There are " + dice.ToString() + " ways to get sum 10";
        }
    }
}
