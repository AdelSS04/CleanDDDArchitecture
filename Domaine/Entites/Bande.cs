using Domaine.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine.Entites
{
    public class Bande
    {
        public int Id { get; set; }
        public DateTime? DateEntre { get; set; }
        public DateTime? DateSortie { get; set; }
        public BandeType BandeType { get; set; }
        public int Quantity { get; set; }
    }
}
