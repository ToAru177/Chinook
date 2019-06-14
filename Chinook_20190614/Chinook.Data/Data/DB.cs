namespace Chinook.Data
{
    public class DB
    {
        private static GenreData _genre = new GenreData();

        static DB()
        {
            Album = new AlbumData();
        }

        public static GenreData Genre
        {
            get
            {
                return _genre;
            }
        }

        public static TrackData Track { get; } = new TrackData();

        public static AlbumData Album { get; }

        public static CustomerData Customer { get; } = new CustomerData();
        public static InvoiceData Invoice { get; } = new InvoiceData();
        public static ArtistData Artist { get; } = new ArtistData();
    }
}
