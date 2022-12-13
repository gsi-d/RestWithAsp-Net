using ResWithASP_Net.Model.Base;

namespace ResWithASP_Net.Model
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
    }
}
