namespace Northwind.Dto.Category
{
    public class CreateCategoryDto
    {
      
        public string CategoryName { get; set; } = null!;

        public string? Description { get; set; }

        public byte[]? Picture { get; set; }
    }
}
