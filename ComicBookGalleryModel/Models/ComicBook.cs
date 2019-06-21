using System;

namespace ComicBookGalleryModel.Models
{
    public class ComicBook
    {
        // Id, ID, ComicBookId, ComicBookID - proper names for the primary key column
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string Description { get; set; }
        public DateTime PublishedOn { get; set; }
    }
}
