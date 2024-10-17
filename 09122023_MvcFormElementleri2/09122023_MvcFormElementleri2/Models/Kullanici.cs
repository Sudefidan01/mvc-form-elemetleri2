using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _09122023_MvcFormElementleri2.Models
{
    public class Kullanici
    {
        [Display(Name ="Adınız")]
        [Required(ErrorMessage ="Ad bilgisi boş bırakılamaz")]
        public string Ad { get; set; }

        //------------------------------------
        [Display(Name ="Soyadınız")]
        [Required(ErrorMessage ="Soyad Bilgisi Boş bırakılamaz")]
        public string Soyad { get; set; }

        //--------------------------------
        [Display(Name ="E-Mail Adresiniz")]
        [Required(ErrorMessage ="E-mail bilgisi boş bırakılamaz")]
        //https://regexr.com
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$",ErrorMessage ="Girilen bilgi e-mail formatında olmalıdır")]
        public string Email { get; set; }

        //------------------------
        [Display(Name ="Parolanız")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Parola bilgisi boş bırakılamaz")]
        [StringLength(16,MinimumLength =6,ErrorMessage ="Parolanız en az 6 en fazla 16 karakter uzunluğunda olabilir")]
        public string Parola { get; set; }

        //----------------------
        [Display(Name ="Parola(Tekrar)")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Parola bilgisi boş bırakılamaz")]
        [StringLength(16, MinimumLength = 6, ErrorMessage = "Parolanız en az 6 en fazla 16 karakter uzunluğunda olabilir")]
        [Compare("Parola",ErrorMessage ="Parola bilgileri uyuşmuyor")]
        public string ParolaTekrar { get; set; }
    }
}