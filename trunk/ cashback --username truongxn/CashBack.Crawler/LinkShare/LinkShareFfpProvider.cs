﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CashBack.Data;
using CashBack.Services;

namespace CashBack.Crawler
{
    public class LinkShareFfpProvider : Provider
    {
        public LinkShareFfpProvider(ICatalogService service)
            : base(service)
        { }

        public LinkShareFfpProvider()
            : base(new CatalogService())
        { }

        protected override IList<Product> MakeProducts()
        {
            IList<Product> products = new List<Product>();

            return products;
        }
        public override void Execute()
        {
        }
    }
}