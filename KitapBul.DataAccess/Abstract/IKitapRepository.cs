using KitapBul.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapBul.DataAccess.Abstract
{
    internal interface IKitapRepository
    {
        List<Kitap> GetAllKitaps();

        Kitap GetKitapById(int id);

        Kitap CreateKitap(Kitap kitap);

        Kitap UpdateKitap(Kitap Kitap);

        void DeleteKitap(int id);

    }
}
