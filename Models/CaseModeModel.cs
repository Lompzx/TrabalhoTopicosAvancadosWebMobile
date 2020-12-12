using System.ComponentModel.DataAnnotations;
namespace Trabalho.Models
{
    public class CaseModeModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Nome é obrigatório")]
        public string Name { get; set; }
        [Required(ErrorMessage="Descrição é obrigatório")]
        public string Description { get; set; }    
        [Required(ErrorMessage="Preço é obrigatório")]

        [DataType(DataType.Currency)]
        [DisplayFormat(ApplyFormatInEditMode = true,DataFormatString ="{0:F2}")]
        public decimal Price { get; set; }
        [Url(ErrorMessage="URL não esta no formato correto")]
        [Required(ErrorMessage="URL é obrigatório")]
        public string ImageUrl { get; set; }

    }
}

