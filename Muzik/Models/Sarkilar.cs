using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Muzik.Models
{
    public class Sarkilar
    {

        [Key]
        public int SarkiId { get; set; }

        [Required(ErrorMessage = "Lütfen boş bırakmayınız..")]
        [StringLength(50)]
        [Display(Name = "Şarkı İsmi")]
        public string SarkiAd { get; set; }

        [StringLength(50)]
        [Display(Name = "Album İsmi")]
        public string AlbumAd { get; set; }

        [Display(Name = "Çıkış Yılı")]
        public int CikisYili { get; set; }

        [Required(ErrorMessage = "Lütfen boş bırakmayınız..")]
        [StringLength(50)]
        [Display(Name = "Şarkıcı İsmi")]
        public string Artist { get; set; }


        [Display(Name = "Tür")]
        public string Tur { get; set; }


        [Display(Name = "Şarkı Süresi")]
        public string SarkiSuresi { get; set; }

       

    }
}
