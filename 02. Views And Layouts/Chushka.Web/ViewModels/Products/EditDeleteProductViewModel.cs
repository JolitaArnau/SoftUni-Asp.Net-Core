namespace Chushka.Web.ViewModels.Products
{
    public class EditDeleteProductViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public string ShortDescription => this.Description + "...";

        public string LongDescription
        {
            get
            {
                if (this.Description == null) return null;
                if (this.Description.Length > 50)
                {
                    return this.Description.Substring(0, 50) + "...";
                }

                return null;
            }
        }

        public string ProductType { get; set; }
    }
}