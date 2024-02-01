using Platformer.Scenes;

namespace Platformer;

public class Game1 : Nez.Core
{
    protected override void Initialize()
    {
        base.Initialize();

        Scene = new Level1Scene();
    }
}
