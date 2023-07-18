using KitapBul.Business.Abstract;
using KitapBul.DataAccess.Concrete;
using KitapBul.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapBul.Business.Concrate
{
    public class KitapManager : IKitapService
    {
        private IKitapRepository _kitaprepository;

        public KitapManager()
        {
            _kitaprepository = new KitapRepository();
        }

        public Kitap CreateKitap(Kitap kitap)
        {
            return _kitaprepository.CreateKitap(kitap);
        }

        public void DeleteKitap(int id)
        {
            _kitaprepository.DeleteKitap(id);
        }

        public List<Kitap> GetAllKitap()
        {
            throw new NotImplementedException();
        }

        public Kitap GetKitapById(int id)
        {
            if (id > 0)
            {
                return _kitaprepository.GetAllKitaps();
            }
            throw new Exception("id 1'den küçük olamaz.")
        }

        public Kitap UpdateKitap(Kitap kitap)
        {
            return _kitaprepository.UpdateKitap(kitap);
        }
    }
}
