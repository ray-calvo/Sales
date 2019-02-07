namespace Sales.API.Controllers
{
    using Common.Models;
    using Domain.Models;
    using System;
    using System.Linq;
    using System.Web.Http;

    [Authorize]
    public class CategoriesController : ApiController
    {
        private DataContext db = new DataContext();

        public IQueryable<Category> GetCategories()
        {
            return db.Categories.OrderBy(c => c.Description);
        }
    }



}
