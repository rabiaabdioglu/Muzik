using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Muzik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Muzik.Component
{
    public class SarkilarList:ViewComponent
    {

           
        private MuzikDataContext database;
        public SarkilarList(MuzikDataContext _context)
        {

            database = _context;

        }
        public async Task<IViewComponentResult> InvokeAsync(int SarkiID)
        {
            var sarkilar = database.Muzik.ToListAsync(); ;
            //Details htmlden bu fonksiyon çağrısı yapılınca  liste geri döndürülüyor
             
            return View(await sarkilar);
        }

    }

}
