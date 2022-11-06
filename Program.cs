using Raylib_cs;
using System.Numerics;

static class Program
    {
        public static void Main()
        {

            var ScreenHeight = 480;
            var ScreenWidth = 800;
            var Objects = new List<GameObject>();
            var Random = new Random();
            var RectangleSize = 10;
            var PlayerRectangle = new Rectangle(ScreenWidth - (RectangleSize * 2), ScreenHeight - (RectangleSize * 2), RectangleSize, RectangleSize);
            var MovementSpeed = 4;
            var Score = 0;


            Raylib.InitWindow(ScreenWidth, ScreenHeight, "GameObject");
            Raylib.SetTargetFPS(60);
            while (!Raylib.WindowShouldClose())
        
            {
                // Add a new random object to the screen every iteration of our game loop
                var whichType = Random.Next(80);

                // Generate a random velocity for this object
                var randomY = Random.Next(-2, 2);
                var randomX = Random.Next(-2, 2);

               //setting random positions for both circle and squares
                var position = new Vector2(Random.Next(1, ScreenWidth), 0);
                var position2 = new Vector2(Random.Next(1, ScreenWidth),0 );
                
                // generating new squares
                var square = new GameSquare(Color.BLUE, 10);
                square.Position = position;
                square.Velocity = new Vector2(randomX,randomY);
                Objects.Add(square);

                // gnerating new circles
                var circle = new GameCircle(Color.GREEN, 5);
                circle.Position2= position2;
                circle.Velocity = new Vector2(randomX,randomY);
                Objects.Add(circle);
                
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                Raylib.DrawText("Move your red square to the other squares to get points avoid circles!", 12, 24, 20, Color.WHITE);
                

                foreach (var obj in Objects){
                    obj.Draw();
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
                    PlayerRectangle.x += MovementSpeed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
                    PlayerRectangle.x -= MovementSpeed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)) {
                    PlayerRectangle.y -= MovementSpeed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) {
                    PlayerRectangle.y += MovementSpeed;
                    position2.Y +=1;
                }
                Raylib.DrawRectangleRec(PlayerRectangle, Color.RED);

                foreach (var obj in Objects) {
                    obj.Move();
                }
               
               //checking for collisions between player and circles
               // so far only is able to find colisions when the circles 
               // first generate though.
                if (Raylib.CheckCollisionCircleRec(position2, 5, PlayerRectangle)) {
                    Score += 1;
                }
               
                
                Raylib.DrawText($"Score: {Score}", 12, 40, 20, Color.WHITE);
                Raylib.EndDrawing();

              
            }
        
            Raylib.CloseWindow();
        }
    }