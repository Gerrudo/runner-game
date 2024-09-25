using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RunnerGame.Entities;

public interface IGameEntity
{
    int DrawOrder { get; }
    
    void Update(GameTime gameTime);
    
    void Draw(GameTime gameTime, SpriteBatch spriteBatch);
}