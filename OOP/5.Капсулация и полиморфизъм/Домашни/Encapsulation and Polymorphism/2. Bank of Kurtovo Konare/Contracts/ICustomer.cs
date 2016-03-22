namespace _02.BankOfKurtovoKonare.Contracts
{
    using _02.BankOfKurtovoKonare.Customers;

    interface ICustomer
    {
        string Name { get; }

        CustomerType CustomerType { get; }
    }
}

