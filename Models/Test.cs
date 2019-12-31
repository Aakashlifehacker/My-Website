using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Zachariasz_Jankowski.Models
{
    public class Test
    {

        public string username { get; set; }

        public int post { get; set; }
    }
}
