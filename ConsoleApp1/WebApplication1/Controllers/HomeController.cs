using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult About()
    {
        ViewData["Title"] = "About Me";

        ViewData["Paragraph1"] = "I am a forward-thinking student and developer based in Muntinlupa, currently pursuing a Bachelor of Science in Information Technology at Lyceum of Alabang. My technical milestones include building full-stack web applications and deploying scalable APIs.";

        ViewData["Paragraph2"] = "I aim to become a Lead Software Engineer, specializing in full-stack cloud development and machine learning integration. Outside of coding, I am an avid trail runner and amateur landscape photographer. These creative, active hobbies keep me grounded and energized, preventing burnout and fueling my problem-solving skills when tackling complex software architecture.";

        return View();
    }
    public IActionResult Skills()
    {
        ViewData["Title"] = "Skills";

        ViewData["Category1"] = "Languages";
        ViewData["Description1"] = "Java, C++, C#, Python, VBA";

        ViewData["Category2"] = "Web Tech";
        ViewData["Description2"] = "HTML, CSS, ASP.NET Core MVC";

        ViewData["Category3"] = "Databases";
        ViewData["Description3"] = "Microsoft Access";

        ViewData["Category4"] = "Tools";
        ViewData["Description4"] = "Visual Studio, Git/GitHub, Figma, Cisco Packet Tracer, Adobe Photoshop, Blender";

        return View();
    }
    public IActionResult Projects()
    {
        ViewData["Title"] = "Projects";

        // Project 1
        ViewData["ProjectTitle1"] = "Student Management System – Procedural Core";
        ViewData["ProjectDesc1"] = "A procedural programming-based console application developed to organize student records, compute grade averages, and assess overall academic performance.";
        ViewData["ProjectTech1"] = "C#";
        ViewData["ProjectLink1"] = "https://github.com/kykie-hub/BSIT31E1_PRELIM_H1_Ocampo_Kylie.git";

        // Project 2
        ViewData["ProjectTitle2"] = "File Ingestion Engine";
        ViewData["ProjectDesc2"] = "A backend processing tool built with the Strategy and Factory design patterns to handle different file formats, process text streams, and validate structured data.";
        ViewData["ProjectTech2"] = "C#";
        ViewData["ProjectLink2"] = "https://github.com/kykie-hub/BSIT31E1_PRELIM_H2_Ocampo_Kylie-.git";

        // Project 3
        ViewData["ProjectTitle3"] = "FizzBuzz Logic Evaluation";
        ViewData["ProjectDesc3"] = "An algorithmic console application demonstrating control flow architecture, nested conditional branching, and modulo arithmetic evaluations to track sequential numeric outputs.";
        ViewData["ProjectTech3"] = "C#";
        ViewData["ProjectLink3"] = "https://github.com/kykie-hub/BSIT31E1_PRELIM_A1_Ocampo_Kylie.git";

        // Project 4
        ViewData["ProjectTitle4"] = "Console Calculator Engine";
        ViewData["ProjectDesc4"] = "An interactive console application implementing an event-driven loop, robust type-conversion validation, exception handling for mathematical boundary conditions, and conditional arithmetic evaluation.";
        ViewData["ProjectTech4"] = "C#";
        ViewData["ProjectLink4"] = "https://github.com/kykie-hub/BSIT31E1_PRELIM_A2_Ocampo_Kylie.git";

        // Project 5
        ViewData["ProjectTitle5"] = "Http Client Starter";
        ViewData["ProjectDesc5"] = "An ASP.NET Core Web API initialization script that configures dependency injection, core services, request routing, and secure API controllers.";
        ViewData["ProjectTech5"] = "C#, JSON";
        ViewData["ProjectLink5"] = "https://github.com/kykie-hub/HttpClientStarter-1-.git";

        // Project 6
        ViewData["ProjectTitle6"] = "Transport Polymorphism Challenge";
        ViewData["ProjectDesc6"] = "A test application built using object-oriented programming to demonstrate inheritance, interface implementation, factory pattern usage, and polymorphic behavior among different classes.";
        ViewData["ProjectTech6"] = "C#";
        ViewData["ProjectLink6"] = "https://github.com/kykie-hub/BSIT_31E1_PRELIM_Q1_Ocampo_Kylie.git";

        return View();
    }
    public IActionResult Contact()
    {
        ViewData["Title"] = "Contact Information";

        ViewData["Email"] = "kykie1008@gmail.com";
        ViewData["Mobile"] = "+63 993 080 9143";

        ViewData["GitHubUrl"] = "https://github.com/kykie-hub";
        ViewData["GitHubText"] = "github.com/kykie-hub";

        ViewData["FacebookUrl"] = "https://www.facebook.com/kylie.l.ocampo";
        ViewData["FacebookText"] = "facebook.com/kylie.l.ocampo";

        ViewData["Resume"] = "~/OCAMPO-KYLIE-RESUME-2025 (1).pdf";

        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}