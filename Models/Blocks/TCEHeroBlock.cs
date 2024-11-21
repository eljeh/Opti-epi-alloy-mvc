using System.ComponentModel.DataAnnotations;
using EPiServer.Web;

namespace Opti.Models.Blocks;

/// <summary>
/// Used for a primary message on a page, commonly used on start pages and landing pages
/// </summary>
[SiteContentType(
    GroupName = Globals.GroupNames.Specialized,
    GUID = "0ccbb58c-b633-4c00-8a18-8f18d5b8a5ad")]
[SiteImageUrl]
public class TCEHeroBlock : SiteBlockData
{}
