using System;
using Nez;
using Nez.Sprites;
using Nez.Textures;

namespace Platformer.Scripts.Creators;

public class PlayerCreator
{
    public static Entity Create(Enum type, Scene scene)
    {
        var entity = new Entity();
        entity = AddAnimation(entity, scene);
        switch (type)
        {
            case PlayerType.Default:
                break;
            default:
                break;
        }

        return entity;
    }

    private static Entity AddAnimation(Entity entity, Scene scene)
    {
        var doubleJumpTexture = scene.Content.LoadTexture(name: Content.VirtualGuy.DoubleJump);
        var doubleJumpSprites =
            Sprite.SpritesFromAtlas(texture: doubleJumpTexture, cellWidth: 16, cellHeight: 16).ToArray();

        var fallTexture = scene.Content.LoadTexture(name: Content.VirtualGuy.Fall);
        var fallSprites =
            Sprite.SpritesFromAtlas(texture: fallTexture, cellWidth: 16, cellHeight: 16).ToArray();

        var hitTexture = scene.Content.LoadTexture(name: Content.VirtualGuy.Hit);
        var hitSprites =
            Sprite.SpritesFromAtlas(texture: hitTexture, cellWidth: 16, cellHeight: 16).ToArray();

        var idleTexture = scene.Content.LoadTexture(name: Content.VirtualGuy.Idle);
        var idleSprites =
            Sprite.SpritesFromAtlas(texture: idleTexture, cellWidth: 16, cellHeight: 16).ToArray();

        var jumpTexture = scene.Content.LoadTexture(name: Content.VirtualGuy.Jump);
        var jumpSprites =
            Sprite.SpritesFromAtlas(texture: jumpTexture, cellWidth: 16, cellHeight: 16).ToArray();

        var runTexture = scene.Content.LoadTexture(name: Content.VirtualGuy.Run);
        var runSprites =
            Sprite.SpritesFromAtlas(texture: runTexture, cellWidth: 16, cellHeight: 16).ToArray();

        var wallJumpTexture = scene.Content.LoadTexture(name: Content.VirtualGuy.WallJump);
        var wallJumpSprites =
            Sprite.SpritesFromAtlas(texture: wallJumpTexture, cellWidth: 16, cellHeight: 16).ToArray();

        entity.AddComponent<SpriteAnimator>()
            .AddAnimation("Double Jump", doubleJumpSprites)
            .AddAnimation("Fall", fallSprites)
            .AddAnimation("Hit", hitSprites)
            .AddAnimation("Idle", idleSprites)
            .AddAnimation("Jump", jumpSprites)
            .AddAnimation("Run", runSprites)
            .AddAnimation("Wall Jump", wallJumpSprites);

        return entity;
    }

    public enum PlayerType
    {
        Default
    }
}