using KitapBul.Business.Abstract;
using KitapBul.Business.Concrate;
using KitapBul.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KitapBul.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KitapController : ControllerBase
    {
        private IKitapService _kitapService;

        public KitapController()
        {
            _kitapService = new KitapManager();
        }

        [HttpGet]
        public List<Kitap> Get()
        {
            return _kitapService.GetAllKitap();
        }

        [HttpGet("{id}")]
        public Kitap Get(int id)
        {
            return _kitapService.GetKitapById(id);
        }
        [HttpPost]
        public Kitap Post([FromBody] Kitap kitap)
        {
            return _kitapService.CreateKitap(kitap);

        }

        [HttpPut]
        public Kitap Put([FromBody] Kitap kitap)
        {
            return _kitapService.UpdateKitap(kitap);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _kitapService.DeleteKitap(id);
        }
    }
}
