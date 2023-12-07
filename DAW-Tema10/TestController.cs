using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class SampleController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Get()
    {
        var htmlContent = "<html><body><h1>Hello, World!</h1></body></html>";
        return Content(htmlContent, "text/html");
    }
}
