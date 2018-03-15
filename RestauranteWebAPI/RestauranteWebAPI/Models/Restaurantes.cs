using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

// classe referente a entidade restaurante
namespace RestauranteWebAPI.Models
{
    public class Restaurantes
    {
        //colunas da tabela restaurante
        [Required(ErrorMessage = "O nome do Restaurante é obrigatório.")]
        [Key]// chave primaria
        public String NomeRestauranteID { get; set; }

    }
}