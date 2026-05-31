using System.ComponentModel.DataAnnotations;

namespace Loja_Virtual.Models;

public class Produto
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Nome é obrigatório")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Nome deve ter entre 3 e 100 caracteres")]
    public string Nome { get; set; } = string.Empty;
    
    [StringLength(500, ErrorMessage = "Descrição pode ter no máximo 500 caracteres")]
    public string Descricao { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Preço é obrigatório")]
    [Range(0.01, 99999.99, ErrorMessage = "Preço deve estar entre 0,01 e 99.999,99")]
    public decimal Preco { get; set; }
    
    [Required(ErrorMessage = "Quantidade é obrigatória")]
    [Range(0, 9999, ErrorMessage = "Quantidade deve estar entre 0 e 9.999")]
    public int Quantidade { get; set; }
    
    public string? ImagemUrl { get; set; }
    
    public DateTime DataCadastro { get; set; } = DateTime.Now;
    
    public bool Ativo { get; set; } = true;
}