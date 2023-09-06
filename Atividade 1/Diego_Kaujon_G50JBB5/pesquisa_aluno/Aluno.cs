// Classe Aluno
class Aluno
{
    public string Nome { get; private set; }
    public string RA { get; private set; }

    public Aluno(string nome, string ra)
    {
        Nome = nome;
        RA = ra;
    }

    public bool VerificarRA(string ra)
    {
        return RA == ra;
    }
}