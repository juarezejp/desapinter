using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models{
    public class PaymentMethods{
        [Key]
        [Display(Name="ID")]
        public int PaymentMethodID {get;set;}

        [Display(Name="PaymentMethod",Prompt="RoomType")]
        [Required(ErrorMessage="El PaymentMethod es obligatorio")]
        [StringLength(50)]
        public string PaymentMethod {get;set;}
    }
}