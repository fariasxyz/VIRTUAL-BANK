public class CriarConta
{
    private Banco banco;

    public CriarConta(Banco banco)
    {
        this.banco = banco; // Inicializa o banco
    }

    public void MensagemCriarConta()
    {
        Console.Write("Olá, bem-vindo! Digite seu nome: ");
        string nomeClienteNovo = Console.ReadLine();

        Console.Write("Muito bem, agora digite seu CPF: ");
        string cpfClienteNovo = Console.ReadLine();

        Console.Write("Agora crie uma senha: ");
        string senhaClienteNovo = Console.ReadLine();

        Console.Write("Digite o número da conta: ");
        string numeroConta = Console.ReadLine();
        banco.CriarConta(numeroConta); // Cria uma nova conta

        Console.WriteLine("Conta criada com sucesso.");
        Console.WriteLine("-------------------------");
        Console.WriteLine($"Nome: {nomeClienteNovo}");
        Console.WriteLine($"CPF: {cpfClienteNovo}");
        Console.WriteLine($"Senha: {senhaClienteNovo}");
        Console.WriteLine("-------------------------");
    }
}