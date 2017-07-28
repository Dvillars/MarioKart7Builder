using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MarioKart7Builder.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MarioKart7Builder.ViewModels
{
    public class CreateKartViewModel
    {
        public Kart kart { get; set; }
        public IEnumerable<SelectListItem> Characters { get; set; }
    }
}
