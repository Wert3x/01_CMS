namespace CMS.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.Description = "Yellow flowers";
                product.CurrentPrice = 15.99M;
            }
            return product;
        }

        public bool Save(Product product)
        {
            if (product.Validate())
            {
                return true;
            }
            return false;
        }
    }
}