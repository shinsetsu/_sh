
//using _oBjects;

//using System;
//using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Net.NetworkInformation;
//using _DBC;

//namespace _oBjects {
//  public class shinLink {
//    public shinLink() { }
//    public shinLink(string aHref, string aId, string aDisplayText, bool debug) {
//      this.aHref = aHref;
//      this.aId = aId;
//      this.aDisplayText = aDisplayText;
//      this.aTarget = "_self";
//      this.aDownload = "";
//      this.aFilename = "";
//      this.debugBool = debug;
//    }
//    public shinLink(string aHref, string aId, string aDisplayText) {
//      this.aHref = aHref;
//      this.aId = aId;
//      this.aDisplayText = aDisplayText;
//      this.aTarget = "_self";
//      this.aDownload = "";
//      this.aFilename = "";
//      this.debugBool = false;
//    }
//    public shinLink(string aHref, string aId, string aDisplayText, string aTarget, string aDownload, string aFilename) {
//      this.aHref = aHref;
//      this.aId = aId;
//      this.aDisplayText = aDisplayText;
//      this.aTarget = aTarget;
//      this.aDownload = aDownload;
//      this.aFilename = aFilename;
//      this.debugBool = false;
//    }

//    public string aHref { get; set; }
//    public string aId { get; set; }
//    public string aDisplayText { get; set; }
//    public string aTarget { get; set; }
//    public string aDownload { get; set; }
//    public string aFilename { get; set; }
//    public bool debugBool { get; set; }
//    [NotMapped] DataBase _DB;
//  }




//  public class shinSiteMetrics {


//    [Key][DisplayName("Id}")] public int id { get; set; }


//    [DisplayName("PageViewsDebug")] public int pageViewsDebug { get; set; }
//    [DisplayName("PageViewsRelease")] public int pageViewsRelease { get; set; }

//    [DisplayName("EventsFiredRelease")] public int EventsFiredRelease { get; set; }
//    [DisplayName("EventsFiredDebug")] public int EventsFiredDebug { get; set; }
//    //[DisplayName("Ips")] public virtual ICollection<shinIps2> Ips { get; set; }
//    [NotMapped] DataBase _DB;

//    internal string GetMacAddress() {
//      const int MIN_MAC_ADDR_LENGTH = 12;
//      string macAddress = string.Empty;
//      long maxSpeed = -1;

//      foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces()) {
//        //log.Debug(
//        //    "Found MAC Address: "+nic.GetPhysicalAddress()+
//        //    " Type: "+nic.NetworkInterfaceType);

//        string tempMac = nic.GetPhysicalAddress().ToString();
//        if (nic.Speed > maxSpeed &&
//            !string.IsNullOrEmpty(tempMac) &&
//            tempMac.Length >= MIN_MAC_ADDR_LENGTH) {
//          //log.Debug("New Max Speed = "+nic.Speed+", MAC: "+tempMac);
//          maxSpeed = nic.Speed;
//          macAddress = tempMac;
//        }
//      }

//      return macAddress;
//    }





//    internal void PageEventsIncrement(DataBase _DB) {
//      try {

//        shinSiteMetrics siteMetrics = _DB.shinSiteMetrics.FirstOrDefault();
//        if (siteMetrics == null) { _DB.Add(new shinSiteMetrics() { }); }

//        if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development") {
//          siteMetrics.pageViewsDebug++; _DB.Update(siteMetrics);
//        } else { siteMetrics.pageViewsRelease++; _DB.Update(siteMetrics); }

//        _DB.SaveChanges();

//      } catch (Exception e) { var a = e; }
//    }

//    internal dynamic GetReleaseCount(DataBase _DB) {
//      try {
//        shinSiteMetrics siteMetrics = _DB.shinSiteMetrics.FirstOrDefault();
//        if (siteMetrics == null) {
//          siteMetrics = new shinSiteMetrics() { };

//        }
//        return siteMetrics.pageViewsRelease;
//      } catch (Exception) {
//        return 0;
//      }

//    }

//    internal dynamic GetDebugCount(DataBase Databaseontext) {
//      try {
//        shinSiteMetrics siteMetrics = Databaseontext.shinSiteMetrics.FirstOrDefault();
//        if (siteMetrics == null) {
//          siteMetrics = new shinSiteMetrics() { };

//        }
//        return siteMetrics.pageViewsDebug;
//      } catch (Exception) {
//        return 0;
//      }



//    }
//  }



//}
