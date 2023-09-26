using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExePedroIV.Models
{
    public class Cliente
    {
        [DisplayName("Código do Cliente")]
        [Range(1,500,ErrorMessage ="Codigo somente entre 1 a 500")]
        [Required(ErrorMessage ="O código é obrigatorio!")]
        public int idCli { get; set; }

        [DisplayName("Nome do Cliente")]
        [StringLength(150,MinimumLength =5,ErrorMessage = "O campo deve conter no mínimo 5 a 150 caracteres!")]
        [Required(ErrorMessage = "O nome é obrigatorio!")]
        public string nomeCli { get; set; }

        [DisplayName("CPF")]
        [Required(ErrorMessage = "Informe o CPF")]
        [System.Web.Mvc.Remote("SelectCpf", "Home", ErrorMessage = "CPF já esta cadastrado!")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve ter exatamente 11 caracteres")]
        //[RegularExpression(@"[0-9]{3}\.[0-9]{3}\.[0-9]{3}\-[0-9]{2}", ErrorMessage = "O CPF deve conter exatamente 11 dígitos numéricos")]
        public string cpf { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "O e-mail é obrigatorio!")]
        [RegularExpression(@"^(([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5}){1,25})+([;.](([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5}){1,25})+)*$",
            ErrorMessage = "Digite um e-mail valido!")]
        public string email { get; set; }

        [DisplayName("Login")]
        [System.Web.Mvc.Remote("SelectLogin","Home",ErrorMessage ="Este login já existe!")]
        [RegularExpression(@"[a-zA-ZçÇ0-9]{5,15}", ErrorMessage = "O campo deve conter no mínimo 5 a 15 caracteres!")]
        [Required(ErrorMessage = "O login é obrigatorio!")]
        public string login { get; set; }

        [DisplayName("Senha")]
        [DataType(DataType.Password)]
        [RegularExpression(@"[a-zA-ZçÇ0-9]{5,15}", ErrorMessage = "O campo deve conter no mínimo 5 a 15 caracteres!")]
        [Required(ErrorMessage = "O senha é obrigatorio!")]
        public string senha { get; set; }

        [DisplayName("Confirme a Senha")]
        [DataType(DataType.Password)]
        [Compare("senha",ErrorMessage ="As senhas são diferentes!")]
        public string confirmaSenha { get; set; }

        [DisplayName("Data do Cadastro")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "O data é obrigatorio!")]
        [DataType(DataType.Date)]
        [System.Web.Mvc.Remote("SelectData", "Home", ErrorMessage = "A data deve ser igual a hoje ou maior.")]
        public System.DateTime? dataCadastro { get; set; } 
    }
}