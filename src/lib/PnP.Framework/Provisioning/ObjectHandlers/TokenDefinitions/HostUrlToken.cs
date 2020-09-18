﻿using Microsoft.SharePoint.Client;
using PnP.Framework.Attributes;
using System;

namespace PnP.Framework.Provisioning.ObjectHandlers.TokenDefinitions
{
    [TokenDefinitionDescription(
     Token = "{hosturl}",
     Description = "Returns a full url of the current host",
     Example = "{hosturl}",
     Returns = "https://mycompany.sharepoint.com")]
    public class HostUrlToken : TokenDefinition
    {
        public HostUrlToken(Web web) : base(web, "{hosturl}")
        {
        }

        public override string GetReplaceValue()
        {
            if (CacheValue == null)
            {
                TokenContext.Web.EnsureProperty(w => w.Url);
                var uri = new Uri(TokenContext.Web.Url);
                CacheValue = $"{uri.Scheme}://{uri.DnsSafeHost.ToLower().Replace("-admin", "")}";
            }
            return CacheValue;
        }
    }
}
