using System.Collections.Generic;

namespace CoreBackend.Api.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public ICollection<MaterialDto> Materials { get; set; }
    }
}
