using ClassLibrary;

string employee_phno;
string ph;
while (true)
{
    try
    {
        Console.WriteLine("Enter Phone Numnber:");
        employee_phno = Console.ReadLine();

        ph = Validate.Val(employee_phno);

        Console.WriteLine("Employee Phone Number:" + ph);

    }
    catch (InvalidMobileNumberException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
