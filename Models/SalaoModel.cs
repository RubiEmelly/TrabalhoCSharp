using System.ComponentModel.DataAnnotations;

namespace Salao_De_Cabeleireiro.Models
{
    public class SalaoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o campo do Nome Cliente")]
        public string NomeCliente { get; set; }

        [Required(ErrorMessage = "Digite o campo do Nome Funcionário")]
        public string NomeFuncionario { get; set; }

        [Required(ErrorMessage = "Digite o campo do Tipo de Serviço")]
        public string Servico { get; set; }

        public DateTime Horario { get; set; } = DateTime.Now;
    }
}
