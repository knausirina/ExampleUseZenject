using UnityEngine;
using Zenject;

//точка в входа в игру, метод Initialize будет вызвон когда все зависимости будут созданы и внедрены
public class EntryPoint : IInitializable
{
    [Inject] private readonly PlayerService _playerService;
    [Inject] private readonly IPlayer _player;

    public EntryPoint(PlayerService customPlayer, IPlayer player)
    {
        _playerService = customPlayer;
        _player = player;
    }

    public void Initialize()
    {
        _playerService.Custom();

        _playerService.LogData();
    }
}