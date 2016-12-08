using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Raven.Client;
using Raven.Client.Document;
using RavenDbDemo.Models;

namespace RavenDbDemo.Controllers
{
    public class RavenDbController : Controller
    {
        readonly IDocumentStore _documentStore ;

        public RavenDbController(IDocumentStore documentStore)
        {
            _documentStore = documentStore;
        }

        public ActionResult Index()
        {
            using (var session = _documentStore.OpenSession())
            {
                
            }
            return View() ;
        }
        public ActionResult Create()
        {
            using (var session = _documentStore.OpenSession())
            {
                session.Store(new User
                {
                    Name = "Vishal",
                    Address = "Mumbai",
                    PhoneNumber = "8899778855",


                });
                session.SaveChanges();

            }
             return View();
        }
    }
}