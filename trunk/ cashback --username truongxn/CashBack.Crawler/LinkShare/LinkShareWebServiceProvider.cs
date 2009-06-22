﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CashBack.Data;
using CashBack.Services;

namespace CashBack.Crawler
{
    public class LinkShareWebServiceProvider : Provider
    {
        public LinkShareWebServiceProvider(ICatalogService service)
            : base(service)
        { }

        public LinkShareWebServiceProvider()
            : base(new CatalogService())
        { }

        public override void UpdateProvider()
        {
            throw new NotImplementedException();
        }

        public override void Execute()
        {
        }
    }
}
