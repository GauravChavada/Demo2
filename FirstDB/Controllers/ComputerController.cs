using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstDB.Models;
namespace FirstDB.Controllers
{
    public class ComputerController : Controller
    {
        readonly DatabaseConn databaseConn = new DatabaseConn();
        // GET: Computer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewAll()
        {
            DateTime dt = new DateTime(2023, 01, 01);

            return View(databaseConn.Computers.ToList().Where(m => m.Prize >= 20000 && m.Document_Date <= dt).ToList());
            //return View(databaseConn.Database.SqlQuery<ComputerModel>("select * from Computers where Prize >= 20000 AND Document_Date <= '20230101'").ToList());
        }
        public ActionResult SummaryResult()
        {

             ViewBag.ViewModelCom = databaseConn.Database.SqlQuery<ComputerViewModel>("select Company_Name,count(Company_Name) as 'Total_No_Computers',SUM(Prize) as 'Total_Prize' from Computers group by Company_Name").ToList();

            return View(databaseConn.Computers.ToList());
            //return View(databaseConn.Database.SqlQuery<ComputerModel>("select * from Computers where Prize >= 20000 AND Document_Date <= '20230101'").ToList());
        }
    }
}