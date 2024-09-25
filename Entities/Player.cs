using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RunnerGame.Graphics;

namespace RunnerGame.Entities;

public class Player(Texture2D spriteSheet, Vector2 position) : IGameEntity
{
    private const int PlayerSpritePositionX = 848;
    private const int PlayerSpritePositionY = 0;
    private const int PlayerSpriteWidth = 44;
    private const int PlayerSpriteHeight = 52;

    public Vector2 Position { get; set; } = position;
    public PlayerState State { get; private set; }
    public bool IsAlive { get; set; }
    public float Speed { get; set; }
    
    public Sprite Sprite { get; private set; } = new(spriteSheet, 
        PlayerSpritePositionX, 
        PlayerSpritePositionY, 
        PlayerSpriteWidth,
        PlayerSpriteHeight);

    public int DrawOrder { get; set; }
    
    public void Update(GameTime gameTime)
    {
        throw new System.NotImplementedException();
    }

    public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
        Sprite.Draw(spriteBatch, Position);
    }
}