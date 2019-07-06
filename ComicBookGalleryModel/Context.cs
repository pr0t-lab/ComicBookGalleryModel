using ComicBookGalleryModel.Models;
using System.Data.Entity;

namespace ComicBookGalleryModel
{
    public class Context : DbContext
    {
        // connectionString: Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ComicBookGallery;Integrated Security=True;MultipleActiveResultSets=True
        //public Context() : base("ComicBookGallery") or : base("<connectionString>")
        //{

        //}

        public Context()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
            //Database.SetInitializer(new CreateDatabaseIfNotExists<Context>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<Context>());
        }

        public DbSet<ComicBook> ComicBooks { get; set; }
    }
}
