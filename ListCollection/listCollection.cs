using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{

	public static void Main()
	{
		Customer customer1 = new Customer()
		{
			ID = 101,
			Name = "Nirav",
			Salary = 5000
		};

        Customer customer2 = new Customer()
        {
            ID = 102,
            Name = "Meet",
            Salary = 5000
        };

        Customer customer3 = new Customer()
        {
            ID = 103,
            Name = "Deep",
            Salary = 5000
        };

        Customer[] customer = new Customer[2];
        customer[0] = customer1;
        customer[1] = customer2;
        customer[2] = customer3;

    }

    public Class1()
	{


	}

}
