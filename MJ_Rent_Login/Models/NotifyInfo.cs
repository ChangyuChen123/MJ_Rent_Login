using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MJ_Rent_Login.Models
{
    public class NotifyInfo
    {
        public int Id { get; set; }

        [Display(Name = "使用者")]
        public string UserId { get; set; } = "";

        [Display(Name = "通知內容")]
        public string InfoContext { get; set; } = string.Empty;

        [Display(Name = "已通知")]
        //是否已經通知
        public Boolean HaveNotify { get; set; }
        
    }
}
