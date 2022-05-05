﻿using Microsoft.Xna.Framework;
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
        Texture2D restartButtonTexture;
        Rectangle restartButtonRect;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 265;
            _graphics.PreferredBackBufferHeight = 300;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            tngSong = Content.Load<Song>("tng_intro_theme");
            playButtonTexture = Content.Load<Texture2D>("play_button");
            playButtonRect = new Rectangle(140, 40, 50, 50);
            stopButtonTexture = Content.Load<Texture2D>("stop_button");
            stopButtonRect = new Rectangle(75, 40, 50, 50);
            muteButtonTexture = Content.Load<Texture2D>("mute_button");
            muteButtonRect = new Rectangle(10, 105, 50, 50);
            unMuteButtonTexture = Content.Load<Texture2D>("unmute_button");
            unMuteButtonRect = new Rectangle(205, 105, 50, 50);
            pauseButtonTexture = Content.Load<Texture2D>("pause_button");
            pauseButtonRect = new Rectangle(205, 40, 50, 50);
            volumeUpButtonTexture = Content.Load<Texture2D>("volume_up_button");
            volumeUpButtonRect = new Rectangle(140, 105, 50, 50);
            volumeDownButtonTexture = Content.Load<Texture2D>("volume_down_button");
            volumeDownButtonRect = new Rectangle(75, 105, 50, 50);
            restartButtonTexture = Content.Load<Texture2D>("restart_button");
            restartButtonRect = new Rectangle(10, 40, 50, 50);
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
            _spriteBatch.Begin();
            _spriteBatch.Draw(restartButtonTexture, restartButtonRect, Color.White);
            _spriteBatch.Draw(stopButtonTexture, stopButtonRect, Color.White);
            _spriteBatch.Draw(playButtonTexture, playButtonRect, Color.White);
            _spriteBatch.Draw(pauseButtonTexture, pauseButtonRect, Color.White);

            _spriteBatch.Draw(muteButtonTexture, muteButtonRect, Color.White);
            _spriteBatch.Draw(unMuteButtonTexture, unMuteButtonRect, Color.White);
            _spriteBatch.Draw(volumeUpButtonTexture, volumeUpButtonRect, Color.White);
            _spriteBatch.Draw(volumeDownButtonTexture, volumeDownButtonRect, Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
