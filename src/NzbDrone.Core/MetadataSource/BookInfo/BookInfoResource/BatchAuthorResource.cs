using System.Collections.Generic;

namespace NzbDrone.Core.MetadataSource.BookInfo
{
    public class BatchAuthorResource
    {
        public Dictionary<string, AuthorResource> Results { get; set; }
    }
}
