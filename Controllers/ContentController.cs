using CorporateWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace CorporateWebsite.Controllers
{
    public class ContentController : Controller
    {
        public IActionResult Index()
        {
            return View(ContentModel.GetModules());
        }

        #region 
        //todo здесь должнны быть методы POST или DELETE, но ради экономии времени я временно сделал GET
        public IActionResult RemoveModule(string id)
        {
            bool isSucces = ContentModel.RemoveModule(int.Parse(id));
            if (isSucces)
                return RedirectToAction("Index");
            else
                return NotFound();
        }

        public IActionResult RemoveSection(string id)
        {
            bool isSucces = ContentModel.RemoveSection(int.Parse(id));
            if (isSucces)
                return RedirectToAction("Index");
            else
                return NotFound();
        }
        #endregion 
    }
}