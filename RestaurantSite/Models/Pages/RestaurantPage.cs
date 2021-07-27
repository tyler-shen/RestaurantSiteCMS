using EPiServer.Cms.Shell.UI.ObjectEditing.EditorDescriptors;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.PlugIn;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestaurantSite.Models.Pages
{
    [ContentType(DisplayName = "RestaurantPage", GUID = "88f7b177-cf18-4b03-a05e-05c13afb2428", Description = "")]

    public class RestaurantPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "The heading will be shown at top of the page",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Image",
            Description = "Main Image",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual XhtmlString MainBody { get; set; }

        [PropertyDefinitionTypePlugIn]
        public class ItemProperty : PropertyList<Menu> { }

        [CultureSpecific]
        [Display(
            Name = "List",
            Description = "Dataprovider List",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        [EditorDescriptor(EditorDescriptorType = typeof(CollectionEditorDescriptor<Menu>))]
        public virtual IList<Menu> List { get; set; }
    }

    public class Menu
    {
        public virtual string Item { get; set; }
        public virtual double Price { get; set; }
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }
    }
}