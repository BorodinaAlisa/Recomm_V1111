using DB_993;
using Microsoft.EntityFrameworkCore;

namespace design
{
    public partial class Favorite : Form
    {
        public Favorite()
        {
            InitializeComponent();
        }
        private void LoadFavorites()
        {
            using (var context = new ApplicationContex())
            {
                var favorites = context.Favourites.Include(f => f.Realty_id).ToList();
                // Здесь вы можете отобразить объекты из favorites в пользовательском интерфейсе
            }
        }
    }
}
