using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RunnerGame.Graphics;

public class Sprite(Texture2D texture, int x, int y, int width, int height)
{
    public Texture2D Texture { get; private set; } = texture;
    public int X { get; set; } = x;
    public int Y { get; set; } = y;
    public int Width { get; set; } = width;
    public int Height { get; set; } = height;
    public Color TintColor { get; set; } = Color.White;

    public void Draw(SpriteBatch spriteBatch, Vector2 position)
    {
        spriteBatch.Draw(Texture, position, new Rectangle(X, Y, Width, Height), TintColor);
    }
}