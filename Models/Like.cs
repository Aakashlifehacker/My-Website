using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Zachariasz_Jankowski.Models
{
    public class Like
    {
        public string username { get; set; }

        public int post { get; set; }//as I won't go beyond 2,147,483,647 posts
    }



}
