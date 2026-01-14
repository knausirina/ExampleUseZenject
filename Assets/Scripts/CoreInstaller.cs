using Zenject;

public class CoreInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        //регистрация фабрики экипировки - чтобы ее можно было получить эту в зависимость в другом классе автоматически (создана будет в
        //одном экземпляре)
        Container.Bind<EquipmentFactory>().AsSingle();

        //регистрация класса Player по интерфейсу IPlayer = зависимость IPlayer будет создана в одном экземпляре при получении ее в другом классе
        Container.Bind<IPlayer>().To<Player>().AsSingle();

        //регистрация фабрик оружия и рюкзаков
        Container.BindFactory<WeaponType, int, Weapon, Weapon.Factory>();
        Container.BindFactory<int, RocketPack, RocketPack.Factory>();

        //регистрация сервиса настройки player (создана будет в одном экземпляре)
        Container.Bind<PlayerService>().AsSingle();
        //регистрая точки входа в игру (создана будет в одном экземпляре)
        Container.BindInterfacesTo<EntryPoint>().AsSingle();
    }
}