using System.Collections.Generic;

public class Paciente
{
    public string Nome { get; set; }
    public int Id { get; set; }
    public List<Procedimento> Procedimentos { get; set; }

    public Paciente(string nome, int id)
    {
        this.Nome = nome;
        this.Id = id;
        this.Procedimentos = new List<Procedimento>();
    }

    

}