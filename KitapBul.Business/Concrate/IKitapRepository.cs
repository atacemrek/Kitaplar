using KitapBul.Entities;

namespace KitapBul.Business.Concrate
{
    internal interface IKitapRepository
    {
        Kitap CreateKitap(Kitap kitap);
        void DeleteKitap(object kitap);
        Kitap GetAllKitaps();
        Kitap UpdateKitap(Kitap kitap);
    }
}