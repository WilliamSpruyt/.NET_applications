using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WIlliGram.Models;

namespace WIlliGram.Models
{
    public class WIlliGramContext : DbContext
    {
        public WIlliGramContext (DbContextOptions<WIlliGramContext> options)
            : base(options)
        {
        }

        public DbSet<WIlliGram.Models.Witter> Witter { get; set; }

        public DbSet<WIlliGram.Models.Friend> Friend { get; set; }
    }
}
