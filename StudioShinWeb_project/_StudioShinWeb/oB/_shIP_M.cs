//using _DBC;
//using System;
//using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;


//namespace _oBjects {



//  //public enum IpTypes {
//  //  [Description("Ipv4")] IP4,
//  //  [Description("Ipv6")] IP6
//  //}

//  //https://docs.microsoft.com/en-us/dotnet/standard/attributes/writing-custom-attributes

//  public class _shIP_M                //https://ipstack.com/quickstart
//    {


//    [Key] [DisplayName("Id}")] public Int64 id { get; set; }


//    public string IP { get; set; }
//    public IpTypes? IpType { get; set; }
//    //public List<DateTime>? seenDateList { get; set; }
//    public DateTime? lastSeenDate { get; set; }
//    public DateTime? firstSeenDate { get; set; }


//    public int? timesSeenInDay { get; set; }
//    public Int64? timesSeenCount { get; set; }

//    public Int64? totalIpsSeen { get; set; }
//    public string countCode { get; set; }
//    public string countName { get; set; }

//    public string stateABR { get; set; }
//    public string state { get; set; }
//    public string city { get; set; }
//    public string zip { get; set; }

//    public string latitude { get; set; }
//    public string longitude { get; set; }


//    [NotMapped] public DataBase _DB;

//    public _shIP_M() {

//      IP = "_"; ;
//      IpType = null;
//      //this.seenDateList = new List<DateTime>() { DateTime.UtcNow };

//      this.lastSeenDate = DateTime.UtcNow;
//      this.firstSeenDate = DateTime.UtcNow;
//      this.timesSeenInDay = 1;
//      this.timesSeenCount = 1;
//      this.totalIpsSeen = 0;      //FIX THIS  ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
//      this.countCode = "_";
//      this.countName = "_";
//      this.stateABR = "_";
//      this.state = "_";
//      this.city = "_";
//      this.zip = "_";
//      this.latitude = "_";
//      this.longitude = "_";
//      DataBase _DB;
//    }




//    public int GetIpRowCount() { return _DB._shIP_M.Select(x => x.IP).Count(); }
//    public _shIP_M GetIp(int id) { return _DB._shIP_M.FirstOrDefault(x => x.id == id); }
//    //public  List<_shIP_M> GetIps() {  return  Database._shIP_M.Select(); }

//    public int GetIpCount() {
//      int rowCount;
//      var connectionString = ConfigurationManager.ConnectionStrings["_d200"].ConnectionString;
//      string queryString = "SELECT COUNT(*)FROM [_d200].[dbo].[_shIP_M]WHERE 1=1;";
//      using (var connection = new SqlConnection(connectionString)) {
//        var command = new SqlCommand(queryString, connection);
//        connection.Open();
//        rowCount = (int)command.ExecuteScalar();
//      }
//      return rowCount;
//    }




//    public bool Upsert(string ip, DataBase _DB) { //Returns True if added, False if not;


//      _shIP_M shinIP = new _shIP_M() { };

//      //try {

//      //  if (ip != "::/" && ip != "::1") { //https://ipstack.com/quickstart
//      //    using (WebClient client = new WebClient()) {
//      //      string s = client.DownloadString("http://api.ipstack.com/" + shinIP.IP + "?access_key=3c04ccc15d0b1d91a38baf224bf80dd4");
//      //      //string s = client.DownloadString("http://api.ipstack.com/24.12.63.159?access_key=3c04ccc15d0b1d91a38baf224bf80dd4");

//      //      JObject jO = JObject.Parse(s);

//      //      if (jO["type"].ToString() == "ipv4") { shinIP.IpType = IpTypes.IP4; }
//      //      if (jO["type"].ToString() == "ipv6") { shinIP.IpType = IpTypes.IP6; }

//      //      shinIP.countCode = jO["country_code"].ToString();
//      //      shinIP.countName = jO["country_name"].ToString();
//      //      shinIP.stateABR = jO["region_code"].ToString();
//      //      shinIP.state = jO["region_name"].ToString();
//      //      shinIP.city = jO["city"].ToString();
//      //      shinIP.zip = jO["zip"].ToString();
//      //      shinIP.latitude = jO["latitude"].ToString();
//      //      shinIP.longitude = jO["longitude"].ToString();
//      //    }
//      //  }





//      //  _DB.Add(shinIP);
//      //  _DB.SaveChanges();
//      return true;
//      //} catch (Exception e) { var a = e; return false; }

//    }
//  }
//}