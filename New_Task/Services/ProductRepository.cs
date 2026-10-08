using System;
using New_Task.Interface;

namespace New_Task.Services
{
	public class ProductRepository : IProductRepository
    {
		public ProductRepository()
		{
		}

        public void GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

