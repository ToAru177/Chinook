using System.Collections.Generic;
using System.Linq;

namespace Chinook.Data
{
    public class GenreData : EntityData<Genre>
    {
        private static GenreData _instance;

        public static GenreData Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GenreData();

                return _instance;
            }

        }
        
    }
}