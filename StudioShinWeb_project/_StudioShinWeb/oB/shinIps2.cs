using _DBC;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Net;


namespace _oBjects {
  public class oList {

    [NotMapped] DataBase _DB;
    [NotMapped]
    List<string> ob { get; set; }
    //{



    ////////////////////////////////////var dtm = Database.Mapping;
    //////////////////////////////////foreach (var t in dtm.GetTables())
    //////////////////////////////////{
    //////////////////////////////////    Console.WriteLine(t.TableName);
    //////////////////////////////////}

    //_______________
    //https://stackoverflow.com/questions/3892926/entity-framework-get-list-of-tables
    // We need dbcontext to access the models


    //// Get all the entity types information
    //var entityTypes = models.GetEntityTypes();

    //// T is Name of class
    //var entityTypeOfT = entityTypes.First(t => t.ClrType == typeof(T));

    //var tableNameAnnotation = entityTypeOfT.GetAnnotation("Relational:TableName");
    //var TableName = tableNameAnnotation.Value.ToString();
    //return TableName;
    //_______________





    //_________THE SQL Route of doing this. ________________________________________
    //  SELECT TABLE_NAME FROM _d200.INFORMATION_SCHEMA.TABLES
    //List<string> obList = new List<string>();
    //var connectionString = ConfigurationManager.ConnectionStrings["_d200"].ConnectionString;
    //using (var con = new SqlConnection(connectionString))
    //{
    //    string qry = "SELECT TABLE_NAME FROM _d200.INFORMATION_SCHEMA.TABLES";
    //    var cmd = new SqlCommand(qry, con); cmd.CommandType = CommandType.Text;

    //    con.Open();
    //    using (SqlDataReader objReader = cmd.ExecuteReader())
    //    {
    //        if (objReader.HasRows)
    //        {
    //            while (objReader.Read())
    //            {
    //                //I would also check for DB.Null here before reading the value.
    //                string item = objReader.GetString(objReader.GetOrdinal("Column1"));
    //                obList.Add(item);
    //            }
    //        }

    //    }//endOf    ■    using (SqlDataReader objReader = cmd.ExecuteReader())

    //}//endOf        ■  using (var con = new SqlConnection(connectionString))



    //    return (obList);





    //}; set;
    //}

  }

  [Table("sys")] // These should probally be st8 mapped as the ob Name is...  No need for 3 names for somwething...
  public class shinSystem {
    [Key][DisplayName("Id}")] public Int64 id { get; set; }
    public string sysName { get; set; }
    public string sysDesc { get; set; }
    public string sysCode { get; set; }
    public string sysCategory { get; set; }
    public string opStatus { get; set; }
    public string sysEnvironment { get; set; }
    public string sysConditions { get; set; } //Special Instructions or Notes
    public string sysRecovery { get; set; } //Special Instructions or Notes
    public string sysStorageReqs { get; set; } //Special Instructions or Notes
    public string sysSecConfig { get; set; } //Special Instructions or Notes

    public string sysPOC { get; set; }
    public string sysOwner { get; set; }
    public string sysHardware { get; set; }
    public string sysHardwareConfig { get; set; }
    public string sysSoftware { get; set; }

  }

  public class _shinIps2VM {
    public _shinIps2VM() { }

    [NotMapped] public ICollection<shinIps2> Ips { get; set; }
    //	[NotMapped] public IEnumerable<shinIps2> Ips { get; set; }
    //	[NotMapped] public int ipRowCount { get; set; }
    //	[NotMapped] public int uniqueAddressesCount { get; set; }

  }

  public enum IpTypes {
    [Description("Ipv4")] IP4,
    [Description("Ipv6")] IP6
  }

  //https://docs.microsoft.com/en-us/dotnet/standard/attributes/writing-custom-attributes
  public class shinIps2                //https://ipstack.com/quickstart
  {


    [Key][DisplayName("Id}")] public Int64 id { get; set; }
    public string IP { get; set; }
    public IpTypes? IpType { get; set; }
    
    public DateTime dateSeen { get; set; }
    
    public string countCode { get; set; }
    public string countName { get; set; }
    public string stateABR { get; set; }
    public string state { get; set; }
    public string city { get; set; }
    public string zip { get; set; }
    public string latitude { get; set; }
    public string longitude { get; set; }


    [NotMapped] public DataBase _DB;


    public shinIps2() {
      IP = "_";
      this.IpType = null;
      this.dateSeen = DateTime.UtcNow;
      

      
      this.countCode = "_";
      this.countName = "_";
      this.stateABR = "_";
      this.state = "_";
      this.city = "_";
      this.zip = "_";
      this.latitude = "_";
      this.longitude = "_";

    }

    public int GetYourVisits(DataBase _DB, string ClientIP) {

      //var customers = context.Customers.Where(x => customerIds.Contains(x.CustomerID)).ToList();

      //return _DB.shinIps2.Where(x => x.IP == ClientIP).ToList();
      int return 0;
    }
    public int GetDistinctIpRowCount(DataBase _DB) {

      return _DB.shinIps2.Select(x => x.IP).Distinct().Count();
    }
    public  int GetUniqueIpRowCount(DataBase _DB) {

      return _DB.shinIps2.Select(x => x.IP).Count();
    }


    //public int GetUniqueIpRowCount(DataBase _DB) {


    //  (from o in context.MyContainer
    //   where o.ID == '1'
    //   from t in o.MyTable
    //   select t).Count();

    //  return _DB.shinIps2.Select(x => x.IP).Count();
    //}

    //public shinIps2 GetIp(int id) { return _DB.shinIps2.FirstOrDefault(x => x.id == id); }
    ////public  List<shinIps2> GetIps() {  return  Database.shinIps2.Select(); }

    //public int GetIpCount()
    //{
    //    int rowCount;
    //    var connectionString = ConfigurationManager.ConnectionStrings["_d200"].ConnectionString;
    //    string queryString = "SELECT COUNT(*)FROM [_d200].[dbo].[shinIps2]WHERE 1=1;";
    //    using (var connection = new SqlConnection(connectionString))
    //    {
    //        var command = new SqlCommand(queryString, connection);
    //        connection.Open();
    //        rowCount = (int)command.ExecuteScalar();
    //    }
    //    return rowCount;
    //}




    public bool upsertIP(string ip, DataBase _DB) { //Returns True if added, False if not;



      try {
        shinIps2 ipUpsert = _DB.shinIps2.FirstOrDefault(x => x.id == id);

        if (ipUpsert == null) { ipUpsert = new shinIps2(); }




        if (ip != "::/" && ip != "::1") { //https://ipstack.com/quickstart
          using (WebClient client = new WebClient()) {
            string s = client.DownloadString("http://api.ipstack.com/" + ipUpsert.IP + "?access_key=3c04ccc15d0b1d91a38baf224bf80dd4");
            //string s = client.DownloadString("http://api.ipstack.com/24.12.63.159?access_key=3c04ccc15d0b1d91a38baf224bf80dd4");

            JObject jO = JObject.Parse(s);

            if (jO["type"].ToString() == "ipv4") { ipUpsert.IpType = IpTypes.IP4; }
            if (jO["type"].ToString() == "ipv6") { ipUpsert.IpType = IpTypes.IP6; }

            ipUpsert.countCode = jO["country_code"].ToString();
            ipUpsert.countName = jO["country_name"].ToString();
            ipUpsert.stateABR = jO["region_code"].ToString();
            ipUpsert.state = jO["region_name"].ToString();
            ipUpsert.city = jO["city"].ToString();
            ipUpsert.zip = jO["zip"].ToString();
            ipUpsert.latitude = jO["latitude"].ToString();
            ipUpsert.longitude = jO["longitude"].ToString();
          }
        }





        _DB.Add(ipUpsert);
        _DB.SaveChanges();
        return true;
      } catch (Exception e) { var a = e; return false; }

    }
  }
}