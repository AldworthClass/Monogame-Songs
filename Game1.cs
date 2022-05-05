using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Monogame_Songs
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Song tngSong;

        string songStatus;
        int time;
        int songLength;

        Texture2D playButtonTexture;
        Rectangle playButtonRect;
        Texture2D pauseButtonTexture;
        Rectangle pauseButtonRect;
        Texture2D stopButtonTexture;
        Rectangle stopButtonRect;
        Texture2D volumeUpButtonTexture;
        Rectangle volumeUpButtonRect;
        Texture2D volumeDownButtonTexture;
        Rectangle volumeDownButtonRect;
        Texture2D muteButtonTexture;
        Rectangle muteButtonRect;
        Texture2D unMuteButtonTexture;
        Rectangle unMuteButtonRect;

        public Game1()
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

            // TODO: use this.Content to load your game content here
            tngSong = Content.Load<Song>("tng_intro_theme");
            playButtonTexture = Content.Load<Texture2D>("play_button");
            stopButtonTexture = Content.Load<Texture2D>("stop_button");
            muteButtonTexture = Content.Load<Texture2D>("mute_button");
            unMuteButtonTexture = Content.Load<Texture2D>("unmute_button");
            pauseButtonTexture = Content.Load<Texture2D>("pause_button");
            volumeUpButtonTexture = Content.Load<Texture2D>("volume_up_button");
            volumeDownButtonTexture = Content.Load<Texture2D>("volume_down_button");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
