using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Game1
{
    class ScreenManager
    {
        LabScreen labScreen;
        Vector2 resolution;


        public ScreenManager(GraphicsDeviceManager graphics)
        {
            labScreen = new LabScreen();

            //resolution.X = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            //resolution.Y = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
            resolution.Y = 160;
            resolution.X = 90;
            graphics.PreferredBackBufferHeight = (int)resolution.Y;
            graphics.PreferredBackBufferWidth = (int)resolution.X;
            //graphics.IsFullScreen = true;
        }

        public void LoadContent(ContentManager Content)
        {
            labScreen.LoadContent(Content);
        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
