using System.ComponentModel.DataAnnotations;

namespace introducao.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string PessoaName { get; set; }
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Texto precisa ter no mínimo 5 caractestes")]
        public string Observacoes { get; set; }
        [Range(18,70, ErrorMessage="Idade entre 18 a 70 anos")]
        public int Idade { get; set; }
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "digite um email válido")]
        public string Email { get; set; }
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage="somente letras de 5 a 15 caracteteres")]
        [Required]
        public string Login { get; set; }
        [Required(ErrorMessage = "Senha Obrigatória")]
        public string Senha { get; set; }
        [Compare("Senha", ErrorMessage =" As senhas não são iguais")]
        public string ConfirmarSenha { get; set; }
    }
}