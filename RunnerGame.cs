using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using RunnerGame.Entities;
using RunnerGame.Graphics;

namespace RunnerGame;

public class RunnerGame : Game
{
    private const string AssetNameSpritesheet = "TrexSpritesheet";
    private const string AssetNameSoundEffectHit = "hit";
    private const string AssetNameSoundEffectScoreReached = "score-reached";
    private const string AssetNameSoundEffectButtonPress = "button-press";
    
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    
    private Texture2D _textureSpriteSheet;
    
    private SoundEffect _soundEffectHit;
    private SoundEffect _soundEffectScoreReached;
    private SoundEffect _soundEffectButtonPress;
    
    private Player _player;

    public RunnerGame()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        
        _textureSpriteSheet = Content.Load<Texture2D>(AssetNameSpritesheet);
        
        _soundEffectHit = Content.Load<SoundEffect>(AssetNameSoundEffectHit);
        _soundEffectScoreReached = Content.Load<SoundEffect>(AssetNameSoundEffectScoreReached);
        _soundEffectButtonPress = Content.Load<SoundEffect>(AssetNameSoundEffectButtonPress);

        //TODO: Remove after testing
        _player = new Player(_textureSpriteSheet, Vector2.Zero);
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
            Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        _spriteBatch.Begin();
        
        _player.Draw(gameTime, _spriteBatch);
        
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}