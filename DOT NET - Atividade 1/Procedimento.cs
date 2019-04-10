using System;

public class Procedimento
{
    public string Nome { get; set; }
    public int Id { get; set; }
    public bool Finalizado { get; set; }

    public Procedimento(string nome, int id)
    {
        this.Nome = nome;
        this.Id = id;
        
    }

    
}