using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MJ_Rent_Login.Models
{
    public class MeetRoom
    {
        public int Id { get; set; }

        [Display(Name = "會議室")]
        public string Name { get; set; }

        [Display(Name = "簡介")]
        public string Description { get; set; }
        
        [Display(Name = "類型")]
        public string Type { get; set; }

        [Display(Name = "會議室大小")]
        public int Capacity { get; set; }

        [Display(Name = "視訊")]
        public Boolean HaveProjector { get; set; }

        [Display(Name = "白板")]
        public Boolean HaveWhiteBoard { get; set; }

        [Display(Name = "狀態")]
        public Boolean IsActive { get; set; }


        public MeetRoom() { }
    }
}
