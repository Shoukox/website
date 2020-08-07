using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication2.Data.Models;

namespace WebApplication2.Data.ViewModels
{
    public class ViewModel
    {
        public IEnumerable<person> persons { get; set; }
        public IEnumerable<personcats> personCats { get; set; }
        public personcats curCategory { get; set; }

    }
}
