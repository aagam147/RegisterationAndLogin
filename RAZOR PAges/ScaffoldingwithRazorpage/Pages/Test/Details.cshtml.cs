﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUDOPERATION.Model;
using ScaffoldingwithRazorpage.Data;

namespace ScaffoldingwithRazorpage.Pages.Test
{
    public class DetailsModel : PageModel
    {
        private readonly ScaffoldingwithRazorpage.Data.ScaffoldingwithRazorpageContext _context;

        public DetailsModel(ScaffoldingwithRazorpage.Data.ScaffoldingwithRazorpageContext context)
        {
            _context = context;
        }

        public Registration Registration { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Registration = await _context.Registration.FirstOrDefaultAsync(m => m.Id == id);

            if (Registration == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
