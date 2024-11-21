
using System.ComponentModel.DataAnnotations;

namespace Opti.Models.Pages;

/// <summary>
/// Used for the pages mainly consisting of manually created content such as text, images, and blocks
/// </summary>
[SiteContentType(GUID = "3cb995c3-cf13-4faa-86a8-0fbdada43052")]
[SiteImageUrl(Globals.StaticGraphicsFolderPath + "page-type-thumbnail-standard.png")]
public class TCEPage : PageData
{

}