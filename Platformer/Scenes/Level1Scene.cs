using Nez;
using Nez.Sprites;

namespace Platformer.Scenes;

public class Level1Scene : Scene
{

    public override void Initialize()
    {
        base.Initialize();

        var playerTexture = Content.LoadTexture(name: Nez.Content.VirtualGuy.Idle);
        var playerEntity = CreateEntity(name: "player");
        playerEntity.AddComponent<SpriteRenderer>().SetTexture(playerTexture);
    }
}