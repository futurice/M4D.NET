namespace Console1App
{
    public class Animal
    {

        public string Name { get; internal set; }

        static class Props
        {
            class Name : ComputedProperty<Animal, Name, string>
            {
                static Name() => Expr = e => e.Name;
            }
        }
    }
}