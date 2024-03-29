public class ConcreteComponent : IComponent<string>
{
    public string GetText()
    {
        return "How are you doing?";
    }
}
