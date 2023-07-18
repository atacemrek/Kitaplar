using KitapBul.DataAccess.Abstract;
using KitapBul.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapBul.DataAccess.Concrete
{
    public class KitapRepository : IKitapRepository
    {
        public Kitap CreateKitap(Kitap kitap)
        {
            using (var kitapDbContext = new KitapDbContext())
            {
                kitapDbContext.Kitaps.Add(kitap);
                kitapDbContext.SaveChanges();
                return kitap;
            }
        }

        public void DeleteKitap(int id)
        {
            using (var kitapDbContext = new KitapDbContext())
            {
                var deletedKitap=GetKitapById(id);
                kitapDbContext.Kitaps.Remove(deletedKitap);
                kitapDbContext.SaveChanges();
            }
        }

        public List<Kitap> GetAllKitaps()
        {
            using (var kitapDbContext = new KitapDbContext())
            {
                return kitapDbContext.Kitaps.ToList();
            }
        }

        public Kitap GetKitapById(int id)
        {
            using (var kitapDbContext = new KitapDbContext())
            {
                return kitapDbContext.Kitaps.Find(id);
            }
        }

        public Kitap UpdateKitap(Kitap kitap)
        {
            using (var kitapDbContext = new KitapDbContext())
            {
                kitapDbContext.Kitaps.Update(kitap);
                return kitap;
            }
        }
    }
}
