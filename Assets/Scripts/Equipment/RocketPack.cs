using Zenject;

public class RocketPack : Item
{
    public int Charges { get; private set; }
    public RocketPack(int charges) : base("RocketPack")
    {
        this.Charges = charges;
    }

    //фабрика рюкзаков позволяет скрывать зависимости которые могут появится в будущем
    public class Factory : PlaceholderFactory<int, RocketPack> { }
}