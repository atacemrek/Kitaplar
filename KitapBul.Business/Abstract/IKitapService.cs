using KitapBul.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapBul.Business.Abstract
{
    public interface IKitapService 
    {
        List<Kitap> GetAllKitap();
        Kitap GetKitapById (int id);
        Kitap CreateKitap (Kitap kitap);
        Kitap UpdateKitap (Kitap kitap);
        void DeleteKitap(int id);
    
    }
}
