using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MJ_Rent_Login.Models
{
    public class BorrowRecord
    {
        public int Id { get; set; }

        [Display(Name = "會議室")]
        public int RoomId { get; set; }

        [Display(Name = "使用者")]
        public string UserId { get; set; } = "";

        [Display(Name = "預約日期")]
        public DateTime BorrowDateTime { get; set; }

        [Display(Name = "預約時間長度")]
        //預約時間長度
        public int PreBorrowTimeLength { get; set; }

        [Display(Name = "實際租用長度")]
        //實際借用長度
        public int ActualBorrowTime { get; set; }

    }
}
