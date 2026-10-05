class costumer
{
    public string name;
    public int id;
    public double balance;

    public costumer(string name_value, int id_value)
    {
        id = id_value;
        name = name_value;
        balance = 0;
    }

    public costumer(string name_value, int id_value, double balance_value) 
    {
        this.name = name_value;
        this.id = id_value;
        this.balance = balance_value;
    }
    public void deposit(double amount)
    {
        balance += amount;   
    }

    public void withdraw(double amount)
    {
        if (balance >= amount)
        {
        balance -= amount;
        }
    }
    public double getbalance()
    {
        return balance;
    }
}