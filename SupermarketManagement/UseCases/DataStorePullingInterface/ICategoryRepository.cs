using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBusines;

namespace UseCases.DataStorePullingInterface
{
   public interface ICategoryRepository
   {
       public IEnumerable<Category> GetCategories();
   }
}
