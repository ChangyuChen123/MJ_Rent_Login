using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MJ_Rent_Login.Models
{
    public class MeetRoom
    {
        [Display(Name = "會議室編號")]
        public int Id { get; set; }

        [Display(Name = "會議室名稱")]
        public string Name { get; set; }

        [Display(Name = "描述")]
        public string Description { get; set; }
        
        [Display(Name = "類型")]
        public string Type { get; set; }

        [Display(Name = "容納人數")]
        public int Capacity { get; set; }

        [Display(Name = "投影機")]
        public Boolean HaveProjector { get; set; }

        [Display(Name = "白板")]
        public Boolean HaveWhiteBoard { get; set; }

        [Display(Name = "使用狀態")]
        public Boolean IsActive { get; set; }


        public MeetRoom() { }
    }
}
