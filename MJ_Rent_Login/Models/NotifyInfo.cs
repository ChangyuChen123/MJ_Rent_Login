using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MJ_Rent_Login.Models
{
    public class NotifyInfo
    {
        public int Id { get; set; }

        public string UserId { get; set; } = "";

        public string InfoContext { get; set; } = string.Empty;

        //是否已經通知
        public Boolean HaveNotify { get; set; }
        
    }
}
