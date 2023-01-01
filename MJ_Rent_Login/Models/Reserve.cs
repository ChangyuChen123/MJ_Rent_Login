using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MJ_Rent_Login.Models
{
    public class Reserve
    {
        public int Id { get; set; }

        [Display(Name = "會議室")]
        public int RoomId { get; set; }

        [Display(Name = "使用者")]
        public string UserId { get; set; } = "";
        
        //預約時間
        [Display(Name = "預約日期時間")]
        public DateTime ResDateTime { get; set; }

        //預約時間長度
        [Display(Name = "預約時間長度")]
        public int ResTimeLength { get; set; }


    }
}
