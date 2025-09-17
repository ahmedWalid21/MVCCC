using Microsoft.AspNetCore.Mvc;

namespace MVCCC.Controllers
{
    public class MovieController:Controller
    {
        //Action: public non-static method in a controller class    
        public string GetMovie(int id)
        {
            return $"Get Movie With Id: {id}";
        }
        public string AddMovie(int id)
        {
            return $"Add Movie With Id: {id}";
        }
    }
}
