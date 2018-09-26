using MathCheatSheet.Models;
using System.Linq;
using System.Web.Mvc;

namespace Math_Cheat_Sheet.Controllers
{
    public class CheatSheetController : Controller
    {
        private MathCheatSheetModel Entities = new MathCheatSheetModel();

        // GET: CheatSheet
        public ActionResult Index()
        {
            return View(Entities.CheatSheets.ToList());
        }

        // GET: CheatSheet/Details/5
        public ActionResult Print(int id)
        {
            var sheet = Entities.CheatSheets.SingleOrDefault(s => s.Id == id);

            return View(sheet);
        }

        // GET: CheatSheet/Create
        public ActionResult Create()
        {
            return View(new CheatSheet());
        }

        // POST: CheatSheet/Create
        [HttpPost]
        public ActionResult Create(CheatSheet model)
        {
            try
            {
                Entities.CheatSheets.Add(model);
                Entities.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        // GET: CheatSheet/Edit/5
        public ActionResult Edit(int id)
        {
            var sheet = Entities.CheatSheets.SingleOrDefault(s => s.Id == id);

            return View(sheet);
        }

        // POST: CheatSheet/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CheatSheet model)
        {
            try
            {
                var sheet = Entities.CheatSheets.SingleOrDefault(s => s.Id == id);
                sheet.Name = model.Name;

                Entities.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CheatSheet/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                var sheet = Entities.CheatSheets.SingleOrDefault(s => s.Id == id);
                Entities.CheatSheets.Remove(sheet);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
