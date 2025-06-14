using KianaBH.GameServer.Game.Player;

namespace KianaBH.GameServer.Game;

public class BasePlayerManager(PlayerInstance player)
{
    public PlayerInstance Player { get; private set; } = player;
}