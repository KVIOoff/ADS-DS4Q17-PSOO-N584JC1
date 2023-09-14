using System;
using System.Collections.Generic;

public class Aluno : Pessoa
{
    private string ra;

    public Aluno(string nome, int idade, string ra) : base(nome, idade)
    {
        this.ra = ra;
    }

    public string RA
    {
        get { return ra; }
    }
}