﻿namespace Chushka.Web.Services.Contracts
{
    using Chushka.Models;
    using ViewModels.Products;
    using Microsoft.AspNetCore.Mvc;

    public interface IProductService
    {
        IActionResult EditProduct(EditDeleteProductViewModel model);

        IActionResult DeleteProduct(string id);

        AllProductsViewModel GetAllProducts(string username);

        IActionResult AddProduct(CreateProductViewModel model);

        Product GetProduct(string id);
    }
}