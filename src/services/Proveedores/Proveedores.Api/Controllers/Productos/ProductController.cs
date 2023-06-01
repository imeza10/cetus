using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cetus.Api.Controllers.Productos
{
    public class ProductController : Controllers
    {
        [HttpGet]
        [Route("Productos")]
        public List<Productos> GetProductos()
        {
            return "";
        }
    }
}
