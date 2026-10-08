using System;
namespace New_Task.Interface
{
	public interface IProductRepository
	{
		public void GetByIdAsync(int id);
	}
}

