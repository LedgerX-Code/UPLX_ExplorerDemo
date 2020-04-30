using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UPLX.Explorer.Models
{
    public class FilterViewModel
    {
        public string Value { get; set; }
        public string Field { get; set; }
        public List<SelectListItem> Fields { get; set; }
    }
}
