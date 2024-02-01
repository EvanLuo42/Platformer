using Nez;
using Nez.Sprites;
using Platformer.Scripts.Creators;

namespace Platformer.Scenes;

public class Level1Scene : Scene
{

    public override void Initialize()
    {
        base.Initialize();

        var playerEntity = AddEntity(PlayerCreator.Create(PlayerCreator.PlayerType.Default, this));
        playerEntity.GetComponent<SpriteAnimator>().Play("Idle");
    }
}