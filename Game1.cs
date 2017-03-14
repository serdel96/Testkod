using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace testkod
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Rectangle but1, but2, but3, but4, grat;
        Texture2D texBut1, texBut2, texBut3, texBut4, texGrat;

        MouseState mouse;

        bool chose;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        
        protected override void Initialize()
        {
            IsMouseVisible = true;
            base.Initialize();
        }

        public void CheckTile(int x, int y, Rectangle rect)
        {
            if (rect.Contains(x, y))
            {
                chose = true;
            }
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            chose = false;

            texBut1 = Content.Load<Texture2D>("C1");
            texBut2 = Content.Load<Texture2D>("C2");
            texBut3 = Content.Load<Texture2D>("C3");
            texBut4 = Content.Load<Texture2D>("C4");
            texGrat = Content.Load<Texture2D>("grattis");

            but1 = new Rectangle(200, 100, 100, 60);
            but2 = new Rectangle(350, 100, 100, 60);
            but3 = new Rectangle(200, 200, 100, 60);
            but4 = new Rectangle(350, 200, 100, 60);
            grat = new Rectangle(250, 150, 300, 300);


        }
        
        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            mouse = Mouse.GetState();

            if(but1.Contains(mouse.X, mouse.Y))
            {
                if(mouse.LeftButton == ButtonState.Pressed)
                chose = true;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();

            if(chose == false)
            {
                spriteBatch.Draw(texBut1, but1, Color.White);
                spriteBatch.Draw(texBut2, but2, Color.White);
                spriteBatch.Draw(texBut3, but3, Color.White);
                spriteBatch.Draw(texBut4, but4, Color.White);
            }
            else if(chose == true)
            {
                spriteBatch.Draw(texGrat, grat, Color.White);
            }

            spriteBatch.End();
            

            base.Draw(gameTime);
        }
    }
}
