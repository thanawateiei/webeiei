using Microsoft.AspNetCore.Mvc;
using WebVanProject.Models;

namespace WebVanProject.Controllers
{
    public class DetailController : Controller
    {
        private readonly webContext _db;

        public DetailController(webContext db)
        { _db = db; }
        public IActionResult Index()
        {
            List<Detail> Details = new List<Detail>();
            var pd = from p in _db.Details
                     //join pt1 in _db.Provinces on p.OriginProvince equals pt.IdProvince into join_p_pt
                     //join pt2 in _db.Provinces on p.OriginProvince equals pt.IdProvince into join_p_pt
                     select p;
            Details.AddRange(pd);
            if(Details == null) return NotFound();
            
            return View(Details);
        }
    }
}
