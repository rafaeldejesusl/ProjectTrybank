namespace trybank;

public class Trybank
{
    public bool Logged;
    public int loggedUser;
    
    //0 -> Número da conta
    //1 -> Agência
    //2 -> Senha
    //3 -> Saldo
    public int[,] Bank;
    public int registeredAccounts;
    private int maxAccounts = 50;
    public Trybank()
    {
        loggedUser = -99;
        registeredAccounts = 0;
        Logged = false;
        Bank = new int[maxAccounts, 4];
    }

    public void RegisterAccount(int number, int agency, int pass)
    {
        try
        {
            if (Bank.Length > 0)
            {
                for (int i = 0; i < registeredAccounts; i++)
                {
                    if (Bank[i, 0] == number && Bank[i, 1] == agency)
                    {
                        throw new ArgumentException("A conta já está sendo usada!");
                    }
                }
            }
            Bank[registeredAccounts, 0] = number;
            Bank[registeredAccounts, 1] = agency;
            Bank[registeredAccounts, 2] = pass;
            Bank[registeredAccounts, 3] = 0;
            registeredAccounts++;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }

    public void Login(int number, int agency, int pass)
    {
        try
        {
            if (Logged)
            {
                throw new AccessViolationException("Usuário já está logado");
            }
            for (int i = 0; i < registeredAccounts; i++)
            {
                if (Bank[i, 0] == number && Bank[i, 1] == agency)
                {
                    if (Bank[i, 2] == pass)
                    {
                        Logged = true;
                        loggedUser = i;
                    }
                    else
                    {
                        throw new ArgumentException("Senha incorreta");
                    }
                }
            }
            if (!Logged)
            {
                throw new ArgumentException("Agência + Conta não encontrada");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }

    public void Logout()
    {
        try
        {
            if (!Logged)
            {
                throw new AccessViolationException("Usuário não está logado");
            }
            else
            {
                Logged = false;
                loggedUser = -99;
            }
        }
        catch (AccessViolationException ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }

    public int CheckBalance()
    {
        try
        {
            if (!Logged)
            {
                throw new AccessViolationException("Usuário já está logado");
            }
            int balance = Bank[loggedUser, 3];
            return balance;
        }
        catch (AccessViolationException ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }  
    }

    public void Transfer(int destinationNumber, int destinationAgency, int value)
    {
        try
        {
            if (!Logged)
            {
                throw new AccessViolationException("Usuário já está logado");
            }
            if (Bank[loggedUser, 3] < value)
            {
                throw new InvalidOperationException("Saldo insuficiente");
            }
            Bank[loggedUser, 3] -= value;
            for (int i = 0; i < registeredAccounts; i++)
            {
                if (Bank[i, 0] == destinationNumber && Bank[i, 1] == destinationAgency)
                {
                    Bank[i, 3] += value;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }

    public void Deposit(int value)
    {
        try
        {
            if (!Logged)
            {
                throw new AccessViolationException("Usuário já está logado");
            }
            Bank[loggedUser, 3] += value;
        }
        catch (AccessViolationException ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }

    public void Withdraw(int value)
    {
        try
        {
            if (!Logged)
            {
                throw new AccessViolationException("Usuário já está logado");
            }
            if (Bank[loggedUser, 3] < value)
            {
                throw new InvalidOperationException("Saldo insuficiente");
            }
            Bank[loggedUser, 3] -= value;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }
}
