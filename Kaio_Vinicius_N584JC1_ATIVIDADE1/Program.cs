using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Professor fernando = new Professor("Fernando", 40, "APSOO");
  
        Aluno kaio = new Aluno("Kaio Vinicius", 21, "N584JC1");
        Console.WriteLine("Objeto do tipo professor");
        Console.WriteLine("Nome: {0} Disciplina: {1} idade: {2}",fernando.Nome, fernando.Disciplina, fernando.Idade);
        Console.WriteLine("Objeto do tipo aluno");  
        Console.WriteLine("Nome: {0} Ra: {1} idade: {2}",kaio.Nome, kaio.RA, kaio.Idade);
    }

}