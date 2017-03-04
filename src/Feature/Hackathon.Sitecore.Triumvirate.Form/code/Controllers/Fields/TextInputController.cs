﻿using System.Web.Mvc;
using Hackathon.Sitecore.Triumvirate.Feature.Form.Controllers.Fields.Base;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using Sitecore.XA.Foundation.RenderingVariants.Repositories;

namespace Hackathon.Sitecore.Triumvirate.Feature.Form.Controllers.Fields
{
    /// <summary>
    /// Text Input Controller
    /// </summary>
    /// <author>
    /// Christian Hahn, Mrz-2017
    /// </author>
    public class TextInputController : FieldBaseController
    {
        /// <summary>
        /// c'tor
        /// </summary>
        public TextInputController(IVariantsRepository variantsRepository) : base(variantsRepository)
        {
        }
    }
}