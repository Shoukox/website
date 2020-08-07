using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication2.Data.Models;

namespace WebApplication2.Data.ViewModels
{
    public class ViewModel
    {
        public IEnumerable<debils> debils { get; set; }
        public IEnumerable<debilscats> debilsCategories { get; set; }
        public debilscats curCategory { get; set; }

    }
}
