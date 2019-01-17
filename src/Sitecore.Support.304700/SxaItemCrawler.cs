using Sitecore.ContentSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.XA.Foundation.Multisite.Extensions;
using Sitecore.Data;
using Sitecore.Data.Items;

namespace Sitecore.Support.XA.Foundation.VersionSpecific.Search
{
  public class SxaItemCrawler: Sitecore.XA.Foundation.VersionSpecific.Search.SxaItemCrawler
  {   

    protected override bool IsExcludedFromIndex(IIndexableUniqueId indexableUniqueId, IndexEntryOperationContext operationContext, bool checkLocation)
    {
      try
      {
        return base.IsExcludedFromIndex(indexableUniqueId, operationContext, checkLocation);
      }
      catch
      {
        return false;
      }
    }
  }
}