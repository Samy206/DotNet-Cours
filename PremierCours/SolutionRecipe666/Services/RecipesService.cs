using DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RecipesService
    {
        public List<Recipe> GetAll()
        {
            return new List<Recipe>()
            {
                new Recipe() { Id = Guid.NewGuid(), Title = "Recipe 01" },
                new Recipe() { Id = Guid.NewGuid(), Title = "Recipe 02" },
                new Recipe() { Id = Guid.NewGuid(), Title = "Recipe 03" },
            };
        }
    }
}
