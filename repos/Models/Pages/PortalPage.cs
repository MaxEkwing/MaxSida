﻿using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System.ComponentModel.DataAnnotations;

namespace repos.Models.Pages
{
    [ContentType(
        DisplayName = "Portal page",
        GUID = "8d843e6f-f56d-494d-b527-964ae3e1b2bb",
        Description = "The portal page.",
        AvailableInEditMode = true)]
    [ImageUrl("~/styles/images/page_type.png")]
    public class PortalPage : SitePageData
    {

    }
}
