﻿using _oBjects;
using _StudioShinWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _StudioShinWeb {
  public class HomeController : Controller {
    //private readonly ILogger<HomeController> _logger;
    //private readonly DataBase _DB;
    //private readonly IWebHostEnvironment _ENV;
   // private _shIP_M _shIP_M;

    //public HomeController(DataBase _DB, IWebHostEnvironment env) {
    public HomeController() {
      //this._DB = _DB; _ENV = env;

    }

    private void initVariables() {
      //var shinIP2 = new _shIP_M(); shinIP2.init();
      //var metrics = new shinSiteMetrics(); metrics.init();


    }

    ///■■■■  O v e r R i d e s ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■

    public override void OnActionExecuted(ActionExecutedContext context) {
      ////siteMetrics.PageEventsIncrement(_DB);





      ////_DBInitalize.Init(_DB);

      ////base.OnActionExecuted(context);  // Not sure what this was from

      ////shinSiteMetrics siteMetrics = _DB.shinSiteMetrics.FirstOrDefault();
      //shinSiteMetrics siteMetrics = new shinSiteMetrics();

      //ViewBag.IsDebug = false;


      //ViewBag.IpCount = "-";
      //ViewBag.pageViewsDebug = "-";
      //ViewBag.pageViewsRelease = "-";
      //ViewBag.ClientIP = "-";
      //ViewBag.IsDebug = true;
      //ViewBag.EventsFiredRelease = "-";
      //ViewBag.EventsFiredDebug = "-";


      //if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development") {
      //  ViewBag.IsDebug = true;
      //} else {
      //  ViewBag.IsDebug = false;


      //}

      ////if (true || Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") != "Development")//ToggleThisOffIfYouNeedAFasterReloadDuringDevelopment___SometimesIUseThisInDebug_and_sometimesInRelease
      ////{

      ////  _shIP_M = new _shIP_M();

      ////  if ((ViewBag.ClientIP = HttpContext.Connection.RemoteIpAddress.ToString()) != null) {

      ////    _shIP_M.Upsert(Request.HttpContext.Connection.RemoteIpAddress.ToString(), _DB);
      ////    //ViewBag.IpCount = _shIP_M.CountIpsSeen();
      ////  } else { ViewBag.IpCount = 0; }


      //if ((HttpContext.Connection.RemoteIpAddress.ToString()) != null) {
      //  ViewBag.ClientIP = HttpContext.Connection.RemoteIpAddress.ToString();
      //}


      ////ViewBag.pageViewsDebug = siteMetrics.GetDebugCount(_DB);
      ////ViewBag.pageViewsRelease = siteMetrics.GetReleaseCount(_DB);
      //ViewBag.Mac = siteMetrics.GetMacAddress();


      ////ViewBag.EventsFiredRelease = siteMetrics.EventsFiredRelease;
      ////ViewBag.EventsFiredDebug = siteMetrics.EventsFiredDebug;



      ////}
    }

    [Route("")]
    [Route("Wardrobe")]
    public IActionResult Index() {      return View("z___Wardrobe____________________.cshtml");
    }

    //  [Route("_shIP_M")] public IActionResult _shIP_M() { return View("_shIP_M.cshtml"); }


    //  public async Task<ActionResult<IEnumerable<_shIP_M>> Get_shIP_M {
    //    return await _DB._shIP_M.ToListAsync();
    //}


    [Route("AboutZJ")] public IActionResult AboutZJ() { return View("z___AboutZJ____________________.cshtml"); }
    [Route("Resume")] public IActionResult Resume() { return View("z__Resume_________________________.cshtml"); }

    [Route("StyleTooling")] public IActionResult z_StyleTooling_Firm() { return View("z_StyleTooling_Firm.cshtml"); }
    [Route("RefList")] public IActionResult RefList() { return View("RefList.cshtml"); }


    //[Route("FilUpload")]
    //[HttpGet]
    //public IActionResult FileUpload() {


    //  return View("");
    //}

    //[Route("FilUpload")]
    //[HttpPost]
    //public IActionResult FilUpload(List<IFormFile> files) {

    //  int i = 0;
    //  //long size = files.Sum(f => f.Length);

    //  //foreach (var formFile in files) {
    //  //  if (formFile.Length > 0) {
    //  //    var filePath = Path.GetTempFileName();

    //  //    using (var stream = System.IO.File.Create(filePath)) {
    //  //      await formFile.CopyToAsync(stream);
    //  //    }
    //  //  }
    //  //}

    //  //// Process uploaded files
    //  //// Don't rely on or trust the FileName property without validation.

    //  //return Ok(new { count = files.Count, size });
    //  return View("FileUpload.cshtml");
    //}

    //[Route("shinJWys")]
    //public async Task<IActionResult> shinJWys() {

    //  int i = 0;
    //  IEnumerable<shinJWys> mL = await _DB.shinJWys.ToListAsync();


    //  return View("shinJWys.cshtml", mL);
    //}





    //[Route("_shIP_M")]
    //public async Task<IActionResult> _shIP_M() {
    //  return View("Ips.cshtml", _DB._shIP_M.ToImmutableList());

    //  //return Json(_DB._shIP_M.ToImmutableList());
    //}




    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

    public IActionResult Error() {
      return View("ErrorV.cshtml", new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }















    public class ErrorViewModel {
      public string RequestId { get; set; }

      public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }



    //public List<string> FindRoutes() {
      //var LStrings = new List<string>();



      //var fullText = System.IO.File.ReadAllText("HomeController.cs");


      //var LRoutes = System.IO.File.ReadAllText("HomeController.cs");

      //List<string> files = new List<string>() { "" };
      //var myRegex = new Regex(@"[A-Za-z0-9_]");



      //\s* Look for zero or more occurrences of a white - space character.
      //List<string> resultList = files.Where(myRegex.IsMatch).ToList();

      //foreach (string word in fullText) {

      //}


      //foreach ((string)" " in File.ReadAllText("words.txt")) {



      //  string input = File.ReadAllText("file.txt");

      //  foreach (string word in File.ReadLines("words.txt")) {
      //    var regex = new Regex(word, RegexOptions.IgnoreCase);
      //    int startat = 0;
      //    int count = 0;

      //    Match match = regex.Match(input, startat);
      //    while (match.Success) {
      //      count++;
      //      startat = match.Index + 1;
      //      match = regex.Match(input, startat);
      //    }

      //    Console.WriteLine(word + "\t" + count);
      //  }

      //  //Match match;
      //  while ((match = regex.Match(input, startat)).Success) {
      //    count++;
      //    startat = match.Index + 1;
      //  }


      //}


    //  return LStrings;
    //}




  }
}