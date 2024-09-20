namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
             var michealsAccount = new BankAccount();
            
            Console.WriteLine("How much would you like to deposit?");
           
            var amountToDeposit = double.Parse(Console.ReadLine());

            michealsAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you! Your balance is now {michealsAccount.GetBalance()}");
        }
    }
}
