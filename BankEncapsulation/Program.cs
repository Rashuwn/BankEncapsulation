namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var interaction = new UserInteraction();
            var rashuwnsAccount = new BankAccount();
            interaction.ATM(rashuwnsAccount);
        }
    }
}
