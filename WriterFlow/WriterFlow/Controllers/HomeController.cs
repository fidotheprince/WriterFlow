using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using WriterFlow.Models;

namespace WriterFlow.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        //looks into View folder auto
        //looks for view of same name 

            [HttpGet]
        public JsonResult ShowPrompt()
        {
            /*var prompt1 = new WriterPrompt();
            prompt1.Prompt = "prompt1";
            var prompt2 = new WriterPrompt();
            prompt2.Prompt = "prompt2";
            var prompt3 = new WriterPrompt();
            prompt3.Prompt = "prompt3";
            var prompt4 = new WriterPrompt();
            prompt4.Prompt = "prompt4";
            var prompt5 = new WriterPrompt();
            prompt5.Prompt = "prompt5";


            //create array items - instantiate items 

            WriterPrompt[] PromptCatalog = new WriterPrompt[5];
            PromptCatalog[0] = prompt1;
            PromptCatalog[1] = prompt2;
            PromptCatalog[2] = prompt3;
            PromptCatalog[3] = prompt4;
            PromptCatalog[4] = prompt5;

            //random method

            Random rnd = new Random();

            //tie random method to array - returns random number (prompt object)
            //min - index - max index 

            var model = PromptCatalog[rnd.Next(0, 4)];*/

            //makes avaiable to view file - ShowPrompt.cshtml

            var testprompt = new WriterPrompt();
            testprompt.Prompt = "test prompt";

            var model = testprompt;

            return Json(model, JsonRequestBehavior.AllowGet);
        }


    }
}
