using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MJ_Rent_Login.Models
{
    public class Reserve
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public string UserId { get; set; } = "";

        //預約時間
        public DateTime ResDateTime { get; set; }

        //預約時間長度
        public int ResTimeLength { get; set; }


    }
}
