using System.Collections.Generic;

namespace NzbDrone.Core.MetadataSource.BookInfo
{
    public class BatchSearchResource
    {
        public Dictionary<string, List<BatchSearchResultResource>> Results { get; set; }
    }

    public class BatchSearchResultResource
    {
        public int BookId { get; set; }
        public int WorkId { get; set; }
        public BatchSearchAuthorResource Author { get; set; }
    }

    public class BatchSearchAuthorResource
    {
        public int Id { get; set; }
    }
}
