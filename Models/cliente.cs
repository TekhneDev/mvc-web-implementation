namespace LHPet.Models;
public class Cliente
{
    public int Id { get; set;}

    // A interrogação (?) é um açucar sintático para declarar que um tipo primitivo pode ter o valor nulo, já que o null por padrão não é um valor válido para um tipo primitivo
    public string? Nome { get; set; }
    public string? Cpf { get; set; }
    public string? Email { get; set; }
    public string? Paciente { get; set; }

    public Cliente(int id, string nome, string cpf, string email, string paciente)
    {
        this.Id  = id;
        this.Nome = nome;
        this.Cpf = cpf;
        this.Email = email;
        this.Paciente = paciente;
    }
}