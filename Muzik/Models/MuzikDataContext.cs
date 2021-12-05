using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Muzik.Models
{
    public class MuzikDataContext : DbContext
    {
       
            //Hangi model hangi tabloya denk gelecek ??
            public DbSet<Sarkilar> Muzik { get; set; }
            public MuzikDataContext(DbContextOptions<MuzikDataContext> options) : base(options)
            {


            }

        public MuzikDataContext()
        {
        }

        internal object toListAsync()
            {
                throw new NotImplementedException();
            }
        }
    }
