using System;

class Program
{
    static void Main()
    {
      /*  IScannable oldPrinter = new OldPrinter(); не компіл.ється навмисно
        oldPrinter.Print();
        */

        OldPrinter oldPrinter = new OldPrinter();
        oldPrinter.Print();

        ModernAllInOnePrinter modernPrinter = new ModernAllInOnePrinter();
        modernPrinter.Print();
        modernPrinter.Scan();
        modernPrinter.Fax();
    }
}

class ModernAllInOnePrinter : IPrintable, IScannable, IFaxable
{
      
    public void Print()
    {
        Console.WriteLine("Printing from Modern All-in-One Printer");
    }
    public void Scan()
    {
        Console.WriteLine("Scanning from Modern All-in-One Printer");
    }
    public void Fax()
    {
        Console.WriteLine("Faxing from Modern All-in-One Printer"); 
}
}
interface IPrintable
{
   public void Print();
    
   
}
interface IScannable
{
    public void Scan();
    
}
interface IFaxable
{
   public void Fax();
    
}
class OldPrinter : IPrintable
{
     public void Print()
    {
        Console.WriteLine("Printing from Old Printer");
    }
    
}