﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheSnackHole.Data;
using TheSnackHole.Models;
using System.Web.Mvc;

namespace TheSnackHole.ViewModels
{
    public abstract class ProductsBaseViewModel
    {
        public Product Product { get; set; } = new Product();

        public SelectList BrandsSelectListItems { get; set; }

        public virtual void Init(Context context)
        {
            BrandsSelectListItems = new SelectList(
                context.Brands.OrderBy(b => b.Name)
                .ToList(), "BrandId", "Name");
        }
    }
}