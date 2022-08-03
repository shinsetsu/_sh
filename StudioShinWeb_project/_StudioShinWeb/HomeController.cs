using _DBC;
using _oBjects;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;
using _StudioShinWeb.oB;

namespace _StudioShinWeb {
  public class HomeController : Controller {
    private readonly ILogger<HomeController> _logger;
    private readonly DataBase _DB;
    private readonly IWebHostEnvironment _ENV;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private shinEmail _shinEmail;
    // private _shIP_M _shIP_M;

    public HomeController(DataBase _DB, IWebHostEnvironment env, IHttpContextAccessor httpContextAccessor) {

      this._DB = _DB; _ENV = env;
      _httpContextAccessor = httpContextAccessor;
      _shinEmail = new shinEmail();


    }

    ///■■■■  O v e r R i d e s ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■

    public override void OnActionExecuted(ActionExecutedContext context) {




      ViewBag.baseUrl = $"{this.Request.Scheme}://{this.Request.Host.Value.ToString()}{this.Request.PathBase.Value.ToString()}";

      ViewBag.urlPath = HttpContext.Request.Path;


      _DBInitalize.Init(_DB); // Checking if database tables are empty. Adds intial value if so.

      //base.OnActionExecuted(context);  // Not sure what this was from

      shinSiteMetrics siteMetrics = _DB.shinSiteMetrics.FirstOrDefault();


      ViewBag.IsDebug = false;


      ViewBag.IpCount = "-";
      ViewBag.pageViewsDebug = "-";
      ViewBag.pageViewsRelease = "-";
      ViewBag.ClientIP = "-";
      ViewBag.IsDebug = true;
      ViewBag.EventsFiredRelease = "-";
      ViewBag.EventsFiredDebug = "-";

      siteMetrics.PageEventsIncrement(_DB);
      if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development") {
        ViewBag.IsDebug = true;
      } else {
        ViewBag.IsDebug = false;


      }

      if (true || Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") != "Development")//ToggleThisOffIfYouNeedAFasterReloadDuringDevelopment___SometimesIUseThisInDebug_and_sometimesInRelease
      {

        shinIps2 ip = new shinIps2();

        if ((ViewBag.ClientIP = HttpContext.Connection.RemoteIpAddress.ToString()) != null) {

          ip.upsertIP(Request.HttpContext.Connection.RemoteIpAddress.ToString(), _DB, "url");
          ViewBag.IpCount = ip.GetIpRowCount(_DB);
        } else { ViewBag.IpCount = 0; }


        if ((HttpContext.Connection.RemoteIpAddress.ToString()) != null) {
          ViewBag.ClientIP = HttpContext.Connection.RemoteIpAddress.ToString();
        }


        ViewBag.Mac = siteMetrics.GetMacAddress();


        ViewBag.EventsFiredRelease = siteMetrics.EventsFiredRelease;
        ViewBag.EventsFiredDebug = siteMetrics.EventsFiredDebug;



      }
    }

    [Route("")]
    [Route("Wardrobe")]
    public IActionResult Index() {
      return View("z___Wardrobe_____.cshtml");
    }


    
    [Route("GuestBook")]
    public IActionResult GuestBook() {
      return View("z___GuestBook____.cshtml");
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


    [Route("ContactMe")] public IActionResult _contact() { return View("z_ContactMe.cshtml"); }
    [Route("sendEmail")]
    public JsonResult SendEmail([FromBody] shinEmail email) {

      //https://github.com/jstedfast/MailKit

      string FromEmail = email.FromEmail;
      string FromName = email.FromName;
      string Subject = email.Subject;
      string MessageBody = email.MessageBody;


      string ToEmail = "shinsetsu@protonmail.com";

      bool emailSentSuccess = false;


      try {



        var message = new MimeMessage();
        message.From.Add(new MailboxAddress(FromName, FromEmail));
        message.To.Add(new MailboxAddress("■■■", ToEmail));
        message.Subject = Subject;

        message.Body = new TextPart("plain") {
          Text = MessageBody
        };

        using (var client = new SmtpClient()) {
          // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
          client.ServerCertificateValidationCallback = (s, c, h, e) => true;

          client.Connect("smtp.gmail.com", 587, false);

          // Note: only needed if the SMTP server requires authentication
          client.Authenticate("shindevasp@gmail.com", "shinDev123");

          client.Send(message);
          emailSentSuccess = true;
          client.Disconnect(true);
        }

        

        _shinEmail.AddEmailToDB(_DB, email);
      } catch (Exception) {
        return Json(emailSentSuccess.ToString());

      }

      return Json(emailSentSuccess.ToString());

    }


  }











}
