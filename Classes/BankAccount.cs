public class Balance
{
    private int Deposit;

    private int Withdraw;

    public Balance(int deposit, int withdraw)
    {
        Deposit = deposit;
        Withdraw = withdraw;
    }

    // Getter: returns current deposit amount
    public int DepositAmount()
    {
        return Deposit;
    }

    // Overload: deposit an amount
    public void DepositAmount(int amount)
    {
        Deposit += amount;
    }

    // Getter: returns current withdraw amount
    public int WithdrawAmount()
    {
        return Withdraw;
    }

    // Overload: withdraw an amount
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
