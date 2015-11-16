﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SPDS.Models;
using SPDS.Models.DbModels;

namespace SPDS.Controllers
{
    public class DataController : Controller
    {

        // GET: Data
        public ActionResult Data()
        {
            return View();
        }
        [HttpGet]
        public ActionResult View_Data()
        {
            return View();
        }
        [HttpPost]
        public ActionResult View_Data(ViewDataViewModel model)
        {
            if(ModelState.IsValid)
            {
                //if both target material and projectile are invalid
                if((model._targetMaterial == null || model._targetMaterial == "") &&
                       (model._projectile == null || model._projectile == ""))
                {
                    //invalid search - error
                }
                //invalid projectile entered - valid target material
                else if ((!(model._targetMaterial == null) || !(model._targetMaterial == "")) &&
                                (model._projectile == null || model._projectile == ""))
                {
                    //search for target material
                    model.Search(model._targetMaterial);
                }
                //invalid targetmaterial - valid projectile
                else if ((model._targetMaterial == null || model._targetMaterial == "") &&
                               (!(model._projectile == null) || !(model._projectile == "")))
                {
                    //search for projectile
                    model.Search(model._projectile,0);
                }
                //both targetmaterial and projectile are valid
                else if((!(model._targetMaterial == null) || !(model._targetMaterial == "")) &&
                      (!(model._projectile == null) || !(model._projectile == "")))
                {
                    //search for both target material and projectile
                    model.Search(model._projectile, model._targetMaterial);
                }

            }

            return View(model);
        }

        [Authorize(Roles = "3")]
        public ActionResult Review_Data()
        {
            return View();
        }

        //[Authorize(Roles = "3,1")]
        public ActionResult Submit_Data()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Submit_Data(Submitmodel model)
        {
            if(ModelState.IsValid)
            {

                TempData["notice"] = "Data was successfully Submitted";

                var Datacollection = new DatasetQuery();
                Datacollection.comment = model._comment;
                Datacollection.doiNumber = model._doiNumber;
                Datacollection.method = model._method;
                Datacollection.projectile = model._projectile;
                Datacollection.stateOfAggregation = model._stateOfAggregation;
                Datacollection.targetMaterial = model._targetMaterial;
                Datacollection.email = model._author;
                //Datacollection.datapoints =;



                return RedirectToAction("View_Data", "Data");
                
            }
            
       

            return View();  
        }
    }
}