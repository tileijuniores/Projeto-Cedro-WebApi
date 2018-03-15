using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RestauranteWebAPI.Models
{
    public class Pratos
    {
        //colunas da tabela restaurante
        [Required(ErrorMessage = "O nome do Prato é obrigatório.")]
        [Key]// chave primaria
        public String NomePrato { get; set; }

        public String NomeRestauranteID { get; set; }
        [Required(ErrorMessage = "O nome do restaurante é obrigatório.")]
        [ForeignKey("NomeRestauranteID")] // chave estrangeira x;
        public virtual Restaurantes Restaurante { get; set; }

        [Required(ErrorMessage = "O preço do Prato é obrigatório.")]
        public float PrecoPrato { get; set; }

    }
}