using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Account : IEntity
    {
        [Key]
        public int HesapNO { get; set; }
        public int MusteriNO { get; set; }
        public int SubeNO { get; set; }
        public int EkNO { get; set; }
        public int Bakiye { get; set; }
        public int HesapTuru { get; set; }
        public string HesapAciklamasi { get; set; }
    }
}
