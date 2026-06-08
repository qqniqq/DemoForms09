using DemoLib.Repositories;

namespace DemoLib.Data
{
    public class UnitOfWork
    {
        public UserRepository Users
        {
            get;
        }

        public ProductRepository Products
        {
            get;
        }

        public OrderRepository Orders
        {
            get;
        }

        public CategoryRepository Categories
        {
            get;
        }

        public SupplierRepository Suppliers
        {
            get;
        }

        public ManufacturerRepository Manufacturers
        {
            get;
        }

        public UnitOfWork()
        {
            Users =
                new UserRepository();

            Products =
                new ProductRepository();

            Orders =
                new OrderRepository();

            Categories =
                new CategoryRepository();

            Suppliers =
                new SupplierRepository();

            Manufacturers =
                new ManufacturerRepository();
        }
    }
}