using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
 * We will need to create the following methods to satisfy our application needs:
 * Name | URL | HTTPMethod
 * List products and categories (api/v1/Catalog) GET,
 * Get product by Id (api/v1/Catalog/{id}) GET,
 * Get products by Category (api/v1/Catalog/GetProductByCategory/{category}) GET,
 * Create a product (api/v1/Catalog) POST,
 * Update a product (api/v1/Catalog) PUT,
 * Delete a product (api/v1/Catalog/{id}) DEL
 */

namespace Catalog.API.Controllers
{
    public class CatalogController : ControllerBase
    {

    }
}
