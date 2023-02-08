using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using RVAProdavnica.Services;

namespace RVAProdavnica.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    [Route("Administration/[controller]/[action]/{id?}")]
    public class ProductController : Controller
    {
        #region Dependecy injection

        private readonly IProductService productService;

        #endregion

        #region Constructors
        /// <summary>
        ///     Default constructor
        /// </summary>
        /// <param name="productService"></param>
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        #endregion

        #region Function
        /// <summary>
        ///     Get All Products
        /// </summary>
        /// <returns></returns>
        public IActionResult Products()
        {
            return View();
        }
        #endregion


        /// <summary>
        ///     Rows for products
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="rowsPerPage"></param>
        /// <returns></returns>
        public IActionResult Rows(int pageNumber, int rowsPerPage)
        {
            var products = productService.TableSearch(pageNumber, rowsPerPage);
            return View(products);
        }
    }
}
