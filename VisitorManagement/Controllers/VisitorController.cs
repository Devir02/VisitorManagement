using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VisitorManagement.Models;
using VisitorManagement.Models.DAL;

namespace VisitorManagement.Controllers
{
    public class VisitorController : Controller
    {
        // GET: Visitor

        private IGenericRepository<tbl_UK_Visitors> _visitorRepository;
        private tbl_UK_Visitors _visitor;
        private static readonly ILog Log = LogManager.GetLogger(typeof(VisitorController));
        public VisitorController()
        {
            this._visitorRepository = new GenericRepository<tbl_UK_Visitors>();
            this._visitor = new tbl_UK_Visitors();
        }
        public ActionResult Index()
        {
            return View(_visitorRepository.GetModel());
        }
        [HttpPost]
        public ActionResult CreateEU(FormCollection collection)
        {
            try
            {
               

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult CreateNonEU(FormCollection collection)
        {
            try
            {


                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                Log.Error(ex.InnerException.ToString());
                return View();
            }
        }
        [HttpGet]
        public ActionResult CreateEU()
        {
            try
            {

                return View(_visitor);
            }
            catch (Exception ex)
            {
                Log.Error(ex.InnerException.ToString());
                return View(_visitor);
            }
        }
        [HttpGet]
        public ActionResult CreateNonEU()
        {
            try
            {

                return View(_visitor);
            }
            catch (Exception ex)
            {
                Log.Error(ex.InnerException.ToString());
                return View(_visitor);
            }
        }

    }
}