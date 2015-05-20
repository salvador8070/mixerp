﻿/********************************************************************************
Copyright (C) Binod Nepal, Mix Open Foundation (http://mixof.org).

This file is part of MixERP.

MixERP is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

MixERP is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with MixERP.  If not, see <http://www.gnu.org/licenses/>.
***********************************************************************************/

using System.Web.Mvc;
using MixERP.Net.UI.ScrudFactory;
using MixERP.Net.Web.UI.BackOffice.Resources;
using MixERP.Net.Web.UI.Providers;
using System.Reflection;

namespace MixERP.Net.Web.UI.BackOffice.Controllers.Tax
{
    [RouteArea("BackOffice", AreaPrefix = "back-office")]
    [RoutePrefix("tax/sales-tax-types")]
    [Route("{action=index}")]

    public class SalesTaxTypesController : ScrudController
    {
        public ActionResult Index()
        {
            const string view = "~/Areas/BackOffice/Views/Tax/SalesTaxTypes.cshtml";
            return View(view, this.GetConfig());
        }
        public override Config GetConfig()
        {
            Config config = ScrudProvider.GetScrudConfig();
            {
                config.KeyColumn = "sales_tax_type_id";

                config.TableSchema = "core";
                config.Table = "sales_tax_types";

                config.ViewSchema = "core";
                config.View = "sales_tax_type_scrud_view";

                config.Text = Titles.SalesTaxTypes;

                config.ResourceAssembly = Assembly.GetAssembly(typeof(SalesTaxTypesController));
                return config;
            }
        }

    }
}