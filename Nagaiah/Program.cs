class Program
{
    static void Main(string[] args)
    {
        var component = new ConcreteComponent();
        Console.WriteLine(component.GetText());

        var plainDecorator = new PlainDecorator(component);
        Console.WriteLine(plainDecorator.GetText());

        var upperCaseDecorator = new UpperCaseDecorator(component);
        Console.WriteLine(upperCaseDecorator.GetText());

        var colorDecorator = new ColorDecorator(component);
        Console.WriteLine(colorDecorator.GetText());
    }
}
