using Microsoft.AspNetCore.Mvc;

public class FirstController : Controller {
    public IActionResult Index(){
        return View();
    }
    public IActionResult Index2(){
        return View();
    }
}