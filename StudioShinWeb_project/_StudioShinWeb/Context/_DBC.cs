//using System.Linq;
//using Microsoft.EntityFrameworkCore;
//using _oBjects;

//namespace _DBC {
//  //https://docs.microsoft.com/en-us/ef/core/managing-schemas/scaffolding?tabs=dotnet-core-cli

//  //dotnet ef dbcontext scaffold ... --context-dir Data --output-dir Models    
//  //dotnet ef dbcontext scaffold ... --namespace Your.Namespace --context-namespace Your.DbContext.Namespace

//  //https://docs.microsoft.com/en-us/ef/core/managing-schemas/ensure-created
//  //context.Database.EnsureDeleted();
//  // context.Database.EnsureCreated();

//  //https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-3.1
//  public class DataBase : DbContext {
//    public DataBase() {
//    }

//    public DataBase(DbContextOptions<DataBase> options) : base(options) { }






//    public DbSet<_oBjects._shIP_M> _shIP_M { get; set; }
//    public DbSet<_oBjects.shinIps2> shinIps2 { get; set; }
//    public DbSet<_oBjects.shinSiteMetrics> shinSiteMetrics { get; set; }
//    public DbSet<_oBjects.shinJWys> shinJWys { get; set; }




//    public DbSet<_oBjects.RefEmpAp_M> RefEmpAp_M { get; set; }



//  }


//  public static class notesRegionEF {

//    public static void EF_Notes(DataBase _DB) {
//      // Drop the database if it exists
//      //_DB.Database.EnsureDeleted();
//      //_DB.Database.EnsureCreated();


//      //_DB.Database.ExecuteSqlCommand(){ };
//      //_DB.Database.Migrate();




//    }
//  }






//  //■■■■■■■■■■  ■  initEvery table  inSQL.
//  //■■■■■■■■■■    shouldGet HardCoded InitEntry totables,
//  //                & perhapsHere canFeeeed  --->  T e s tCases| Unit| Boundaries.

//  public static class _DBInitalize {
//    //ThisInitalize function has been verified firing|PopulatingDBTables
//    public static void Init(DataBase _DB) {



//      //if (!_DB.shinSiteMetrics.Any()) { _DB.Add(new shinSiteMetrics { pageViewsDebug = 1, pageViewsRelease = 1, EventsFiredDebug = 1 }); }   // Looking if DB has been seeded


//      //if (!_DB._shIP_M.Any()) { _DB.Add(new _shIP_M { IP = "Init" }); }   // Looking if DB has been seeded



//      //_DB.SaveChanges();
//    }
//  }
//}