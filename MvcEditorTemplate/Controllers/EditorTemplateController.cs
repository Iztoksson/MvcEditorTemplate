namespace MvcEditorTemplate.Controllers
{
    using MvcEditorTemplate.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class EditorTemplateController : Controller
    {
        public ActionResult Index()
        {
            var vm = new MainVm();
            var pList = new List<PersonVm>();

            // Mock our person list - KISS :)
            for (int i = 1; i <= 5; i++)
            {
                var p = new PersonVm();

                p.PersonId = i;
                p.FirstName = "Person " + i;
                p.LastName = "Surname " + i;
                p.DateOfBirth = new DateTime(1980, 5, 3).AddYears(i);

                pList.Add(p);
            }
            vm.PersonsList = pList;

            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(MainVm vm, string btnSubmitPerson)
        {
            // Verify which button was pressed and act accordingly.
            if(!string.IsNullOrEmpty(btnSubmitPerson))
            {
                // Do something with data that was posted back.
            }
            return View(vm);
        }
    }
}