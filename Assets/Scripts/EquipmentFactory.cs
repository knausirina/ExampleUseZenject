using Zenject;

//фабрика экипировки
public class EquipmentFactory
{
    [Inject] private readonly Weapon.Factory _weaponFactory;
    [Inject] private readonly RocketPack.Factory _rocketPackFactoru;

    public Parachute GetParachute()
    {
        return new Parachute();
    }

    public RocketPack GetRocketPack(int charges)
    {
        return _rocketPackFactoru.Create(charges);
    }

    public Weapon GetWeapon(WeaponType weaponType, int charges)
    {
        return _weaponFactory.Create(weaponType, charges);
    }
}