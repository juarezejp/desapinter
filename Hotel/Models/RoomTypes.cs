using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models{
    public class RoomTypes{
        [Key]
        [Display(Name="ID")]
        public int RoomTypeID {get;set;}

        [Display(Name="RoomType",Prompt="RoomType")]
        [Required(ErrorMessage="El RoomType es obligatorio")]
        [StringLength(50)]
        public string RoomType {get;set;}

    }
}