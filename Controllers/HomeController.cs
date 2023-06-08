using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyValidation.Models;

namespace DojoSurveyValidation.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("addInfo")]
    public IActionResult AddInfo(Survey survey)
    {
        if (ModelState.IsValid)
        {
            Survey newSurvey = new Survey()
            {
                Name = survey.Name,
                Location = survey.Location,
                Language = survey.Language,
                Comment = survey.Comment
            };
            return RedirectToAction("Results", newSurvey);
        }
        return View("Index");
    }

    [HttpGet("results")]
    public ViewResult Results(Survey survey) 
    {
        return View(survey);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
