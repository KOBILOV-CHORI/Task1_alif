void CalculatePayment(string product, double amount, string phoneNumber, int installmentRange)
{
    int maxInstallment = 24;
    double commission = 0;
    int standardInstallment = 0;
    bool test;
    double endCommission = 0;
    if (product.ToLower().Contains("smartphone"))
    {
        commission = 0.03;
        standardInstallment = 9;
        test = true;
    }

    else if (product.ToLower().Contains("computer"))
    {
        commission = 0.04;
        standardInstallment = 12;
        test = true;
    }

    else if (product.ToLower().Contains("tv"))
    {
        commission = 0.05;
        standardInstallment = 18;
        test = true;
    }
    else
    {
        Console.WriteLine("Unknown product");
        test = false;
    }

    if (test)
    {
        for (int i = 0; i < installmentRange && i < maxInstallment; i += standardInstallment)
        {
            endCommission += commission;
        }
        amount += endCommission * amount;
        Console.WriteLine($"Детали покупки: {product}, общая сумма платежа: {amount}.");
    }
}
CalculatePayment("Smartphone Samsung Galaxy A50", 1000, "+99290000xxxx", 18);