using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP2_Triangulo__FI13005258_.Models; 

namespace TP2_Triangulo__FI13005258_.Controllers
{
    public class TriangleController : Controller
    {
        public ActionResult Index()
        {
            return View(new TriangleModel());
        }

        [HttpPost]
        public ActionResult Index(TriangleModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            double[] sides = { model.A, model.B, model.C };
            Array.Sort(sides);

            if (sides[0] + sides[1] <= sides[2])
            {
                ModelState.AddModelError("", "La suma de los dos lados menores debe ser mayor que el mayor.");
                return View(model);
            }

            model.Perimeter = model.A + model.B + model.C;
            model.SemiPerimeter = model.Perimeter / 2;
            double s = model.SemiPerimeter;
            model.Area = Math.Sqrt(s * (s - model.A) * (s - model.B) * (s - model.C));

            if (model.A == model.B && model.B == model.C)
                model.TriangleType = "Equilátero";
            else if (model.A == model.B || model.A == model.C || model.B == model.C)
                model.TriangleType = "Isósceles";
            else
                model.TriangleType = "Escaleno";

            model.Alpha = Math.Acos((Math.Pow(model.B, 2) + Math.Pow(model.C, 2) - Math.Pow(model.A, 2)) / (2 * model.B * model.C)) * (180 / Math.PI);
            model.Beta = Math.Acos((Math.Pow(model.A, 2) + Math.Pow(model.C, 2) - Math.Pow(model.B, 2)) / (2 * model.A * model.C)) * (180 / Math.PI);
            model.Gamma = Math.Acos((Math.Pow(model.A, 2) + Math.Pow(model.B, 2) - Math.Pow(model.C, 2)) / (2 * model.A * model.B)) * (180 / Math.PI);

            return View(model);
        }
    }
}