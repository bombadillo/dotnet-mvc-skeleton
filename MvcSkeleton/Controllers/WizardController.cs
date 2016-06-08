namespace MvcSkeleton.Controllers
{
    using System.Web.Mvc;

    using Domain;

    public class WizardController : Controller
    {
        private readonly IRetrieveWizards WizardRetriever;

        public WizardController(IRetrieveWizards wizardRetriever)
        {
            WizardRetriever = wizardRetriever;
        }

        // GET: Wizard
        public ActionResult Index()
        {            
            return View(WizardRetriever.Retrieve());
        }
    }
}