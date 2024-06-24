using Microsoft.AspNetCore.Mvc;
using WebAPI1.Models;
using System.Collections.Generic;

namespace WebAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public object GetProducts(string searchText)
        {
            List<Category> final = new List<Category>();
            List<Category> categories = new List<Category>()
            {
                new Category() { Id = 1, Name = "Pencil" },
                new Category() { Id = 2, Name = "Eraser" },
                new Category() { Id = 3, Name = "Pen" },
                new Category() { Id = 4, Name = "Marker" },
                new Category() { Id = 5, Name = "Crayon" },
                new Category() { Id = 6, Name = "Paintbrush" },
                new Category() { Id = 7, Name = "Chalk" },
                new Category() { Id = 8, Name = "Highlighter" },
                new Category() { Id = 9, Name = "Charcoal" },
                new Category() { Id = 10, Name = "Pastel" },
                new Category() { Id = 11, Name = "Fountain Pen" },
                new Category() { Id = 12, Name = "Ballpoint Pen" },
                new Category() { Id = 13, Name = "Rollerball Pen" },
                new Category() { Id = 14, Name = "Gel Pen" },
                new Category() { Id = 15, Name = "Stylus" }
            };
            for (int i = 0; i < categories.Count; i++)
            {
                if(categories[i].Name.ToLower().Contains(searchText.ToLower()))
                {
                    final.Add(categories[i]);
                }
            }
            return final;
        }
    }
}