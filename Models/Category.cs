using System.ComponentModel.DataAnnotations;

namespace CategoryApi.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Название обязательно")]
        public string ?Name { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Порядок отображения должен быть больше 0")]
        public int DisplayOrder { get; set; }
    }
}
