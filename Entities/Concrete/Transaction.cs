using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Transaction : IEntity
    {
        [Key]
        public int IslemNO { get; set; }
        public int IslemTipi { get; set; }
        public string IslemAciklamasi { get; set; }
        public int IslemTutari { get; set; }
        public int AlacakHesapNO { get; set; }
        public int BorcluHesapNO { get; set; }
        public DateTime IslemTarihi { get; set; }
        public int IslemiYapan { get; set; }
        public int KayitDurumu { get; set; }
    }
}
