// Här skriver jag en klass Balance som representerar ett bankkonto med insättningar och uttag. Klassen har metoder för att sätta in och ta ut pengar samt för att visa det aktuella saldot.
public class Balance
{
    private int Deposit;

    private int Withdraw;

    public Balance(int deposit, int withdraw)
    {
        Deposit = deposit;
        Withdraw = withdraw;
    }

    // Kod för att sätta in pengar på kontot. Metoden tar ett belopp som parameter och lägger till det på Deposit. Samt koder för att ta ut pengar från kontot. Metoden tar ett belopp som parameter och lägger till det på Withdraw.
    public int DepositAmount()
    {
        return Deposit;
    }

    public void DepositAmount(int amount)
    {
        Deposit += amount;
    }

    public int WithdrawAmount()
    {
        return Withdraw;
    }

    
    public void WithdrawAmount(int amount)
    {
        Withdraw += amount;
    }

    public int   GetBalance()
    {
        return Deposit - Withdraw;
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Deposit: {Deposit}, Withdraw: {WithdrawAmount()}, Balance: {GetBalance()}");
    }
}
