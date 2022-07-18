using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _oBjects {





  //■■ sysProj_Tickets  |  TicketTitle Attachments ActiveFolkId TimeDays
  public class sysProj_Tickets        {    [Key] [DisplayName("Id}")] public int id { get; set; }    public string TicketTitle { get; set; }    public List<string> Attachments { get; set; }    public List<int> ActiveFolkId { get; set; }    public string TargetDate { get; set; }    public int TimeDays { get; set; }  }
  //■■   Folk           |  Name Email Email2 Phone DiscordIP
  public class Folk                  {                [Key] [DisplayName("Id}")] public int id { get; set; }        public string Name { get; set; }    public string Email { get; set; }    public string Email2 { get; set; }    public string Phone { get; set; }    public string DiscordIP { get; set; }  }
  //■■  workLogItem     |  logTitle folkId workType randomMouseDragDistanceGuessAmountOfTimeSpent
  public class workLogItem          {    [Key] [DisplayName("Id}")] public int id { get; set; }    public string logTitle { get; set; }    [ForeignKey("Folk")] public int folkId { get; set; }    public string workType { get; set; }    public int randomMouseDragDistanceGuessAmountOfTimeSpent { get; set; }  }


}
