using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        ///<summary>
        ///Gives total calories consumed by user depending on the input they give
        ///</summary>
        ///<param name="burger"> The input of food item 1 we are supposed to take from the user</param>
        ///<param name="drink"> The input of food item 2 we are supposed to take from the user</param>
        ///<param name="side"> The input of food item 3 we are supposed to take from the user</param>
        ///<param name="dessert"> The input of food item 4 we are supposed to take from the user</param>
        ///<example>
        ///     GET : /api/J1/4/4/4/4   
        ///         Your total calorie count is 0
        ///         
        ///     GET : /api/J1/1/2/3/4
        ///         Your total calorie count is 691
        ///         
        ///     GET : /api/J1/1/1/1/1
        ///         Your total calorie count is 858
        ///</example>
        [HttpGet]
        [Route("api/J1/{burger}/{drink}/{side}/{dessert}")]
        public string Calcount(int burger, int drink, int side, int dessert)
        {
            List<int> burgercal = new List<int> { 461, 431, 420, 0 };
            List<int> drinkcal = new List<int> { 130, 160, 118, 0 };
            List<int> sidecal = new List<int> { 100, 57, 70, 0 };
            List<int> dessertcal = new List<int> { 167, 265, 75, 0 };
            
            int burg = 0;
            for (int i = 0; i < burgercal.Count; i+=1)
            {
                if ((i + 1) == burger)
                {
                    burg += burgercal[i]; 
                }
               
            }
            int burg1 = burg;

            int drink1 = 0;
            for (int i = 0; i < drinkcal.Count; i+=1)
            {
                if ((i + 1) == drink)
                {
                    drink1 += drinkcal[i];
                }
                 
            }
            int drk = drink1;

            int sid = 0;
            for (int i = 0; i < sidecal.Count; i+=1)
            {
                if ((i + 1) == side)
                {
                    sid += sidecal[i];
                }
                
            }
            int sidn = sid;

            int des = 0;
            for (int i = 0; i < dessertcal.Count; i+=1)
            {
                if ((i + 1) == dessert)
                {
                    des += dessertcal[i];
                }
                
            }
            int dess = des;

            int total = burg1 + drk + sidn + dess; 

            return "Your total calorie count is " + total.ToString();
        }

    }
}
