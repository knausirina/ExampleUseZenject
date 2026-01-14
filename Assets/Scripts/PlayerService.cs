using UnityEngine;
using Zenject;

//сервис плеера для заполнения начальных данных и логирования их
public class PlayerService
{
    [Inject] private readonly IPlayer _player;
    [Inject] private readonly EquipmentFactory _equipmentFactory;

    public PlayerService(IPlayer player, EquipmentFactory equipmentFactory)
    {
        _player = player;
        _equipmentFactory = equipmentFactory;
    }

    public void Custom()
    {
        _player.Health = 100;
        _player.Lives = 3;
        _player.Nickname = "John";
        _player.Skills = new string[] { "Skill1", "Skill2", "Skill3" };
        _player.Equipment = new Equipment();

        IEquipment equipment = _player.Equipment;
        equipment.AddItem(_equipmentFactory.GetWeapon(WeaponType.Rifle, 50));
        equipment.AddItem(_equipmentFactory.GetParachute());
        equipment.AddItem(_equipmentFactory.GetRocketPack(3));
    }

    public void LogData()
    {
        Debug.Log($"player.Nickname = {_player.Nickname}");
        Debug.Log($"player.Lives = {_player.Lives}");
        Debug.Log($"player.Health = {_player.Health}");
        Debug.Log($"player.Skills = {string.Join(",", _player.Skills)}");
    }
}