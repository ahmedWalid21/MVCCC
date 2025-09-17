using Microsoft.AspNetCore.Mvc;

namespace MVCCC.Controllers
{
    public class MovieController:Controller
    {
        //Action: public non-static method in a controller class    
        //Action: has a spacific return type
        //ActionResult
        //public string GetMovie(int id)
        //{
        //    return $"Get Movie With Id: {id}";
        //}
        //public string AddMovie(int id)
        //{
        //    return $"Add Movie With Id: {id}";
        //}

        //public ContentResult GetMovie(int id)
        //{
        //    var contentResult = new ContentResult()
        //    {
        //        Content = $"Get Movie With Id: {id}",
        //        ContentType = "text/html",
        //        StatusCode = 200

        //    };
        //    return contentResult;
        //}
        //public ContentResult GetMovie(int id)
        //{
        //    var contentResult = new ContentResult()
        //    {
        //        Content = $"Get Movie With Id: {id}",
        //        ContentType = "object/pdf",
        //        StatusCode = 200

        //    };
        //    return contentResult;
        //}
        //public RedirectResult GetMovie(int id)
        //{
        //   var redirectResult = new RedirectResult("https://www.google.com");
        //    return redirectResult;
        //}
        //public RedirectToActionResult GetMovie(int id)
        //{
        //    var redirectResult = new RedirectToActionResult("AddMovie", "Movie", new { id = 133 });
        //    return redirectResult;
        //}
        //[ActionName("GetMovie")]
        //public IActionResult GetMovieByCategory(int id)
        //{
        //    if (id == 1)
        //    {
        //        //return new ContentResult(){Content = $"Get Movie With Id: {id}",ContentType = "text/html"  };
        //        return Content($"Get Movie With Id: {id}", "text/html");
        //    }
        //    else if(id==2)
        //    {
        //        return new ContentResult()
        //        {
        //            Content = $"Get Movie With Id: {id}",
        //            ContentType = "object/pdf"
        //        };
        //    }
        //    else
        //    {
        //        return new RedirectResult("https://www.google.com");    
        //    }
        //}

        //Action Paraneter Binding
        //1.Form
        //2.Segment
        //3.Query params
        //4.Files

        //public IActionResult GetMovie(int id)
        //{
        //         return Content($"Get Movie With Id: {id}", "text/html");
        //}


    }
}
