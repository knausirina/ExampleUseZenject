using Zenject;

public class Weapon : Item
{
    public int Ammo { get; private set; }

    public Weapon(WeaponType weaponType, int ammo) : base(weaponType.ToString())
    {
        this.Ammo = ammo;
    }

    //фабрика оружия позволяет скрывать зависимости которые могут появится в будущем
    public class Factory : PlaceholderFactory<WeaponType, int, Weapon> { }
}