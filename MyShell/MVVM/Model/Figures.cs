using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShell.MVVM.Model
{
    class Figures
    {
        [Table("FigureData")]
        public class Figure
        {
            [PrimaryKey, AutoIncrement] public int Id { get; set; }

            [Column("figurename"), Indexed, NotNull, Unique] public string? Name { get; set; } 

            [Column("price"), Indexed, NotNull] public int? Price { get; set; }

            [Column("brand"), Indexed, NotNull] public string? Brand { get; set; }

            [Column("releasedate"), Indexed, NotNull] public string? ReleaseDate { get; set; }

            [Column("series"), Indexed, NotNull] public string? Series { get; set; }

            [Column("specifications"), Indexed, NotNull] public string? Specificiations { get; set; }

            [Column("sculptor"), Indexed, NotNull] public string? Sculptor { get; set; }

            

            
        };
    }
}
