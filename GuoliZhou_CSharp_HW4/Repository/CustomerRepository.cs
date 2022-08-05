using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuoliZhou_CSharp_HW4.DataModel;

namespace GuoliZhou_CSharp_HW4.Repository
{
    public class CustomerRepository:IRepository<Product>
    {
        private List<Product> listProduct = new List<Product>();

        public void Add(Product obj)
        {
            listProduct.Add(obj);
        }

        public void Remove(Product obj)
        {

            listProduct.Remove(obj);
        }

        public void Save(Product obj)
        {
            Product product1 = GetById(obj.Id);
            if(product1 != null)
            {
                product1.Id = obj.Id;
                product1.Name = obj.Name;
                product1.Description = obj.Description;
                
            }
        }

        public IEnumerable<Product> GetAll()
        {
            return listProduct;
        }

        public Product GetById(int id)
        {
            for(int i = 0; i < listProduct.Count; i++)
            {
                if(listProduct[i] == listProduct[id])
                {
                    return listProduct[i];
                }
            }
            return null;
        }


    }
}
