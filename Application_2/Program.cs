internal class Program
{
    private static void Main(string[] args)
    {

        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Criar Conta");
            Console.WriteLine("2. Entrar na Conta");
            Console.WriteLine("3. Sair");

            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                criarConta.MensagemCriarConta(); // Cria uma nova conta
            }
            else if (opcao == "2")
            {
                entrar.EntrarConta(); // Permite que o usuário entre na conta
            }
            else if (opcao == "3")
            {
                Console.WriteLine("Saindo do programa");
            }
        }
    }
}