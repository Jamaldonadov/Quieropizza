﻿using QuieroPizza.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizza.Web.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.Id = 1;
            producto1.Descripcion = "Pizza 6 quesos";

            var producto2 = new ProductoModel();
            producto2.Id = 1;
            producto2.Descripcion = "Pizza 4 estaciones";

            var producto3 = new ProductoModel();
            producto3.Id = 1;
            producto3.Descripcion = "Pizza Jamon y queso ";

            var listadeproductos = new List<ProductoModel>();
            listadeproductos.Add(producto1);
            listadeproductos.Add(producto2);
            listadeproductos.Add(producto3);


            return View(listadeproductos);
        }
    }
}