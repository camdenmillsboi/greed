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
            var squarey = 0;
            var squarex = 400;
            var fallspeed = 3;
            var fallspeed2 = 3;
            var fallspeed3 = 3;
            var fallspeed4 = 3;
            var fallspeed5 = 3;
            var fallspeed6 = 3;
            var fallspeed7 = 3;

            var LimitLine = new Rectangle(0, 480, ScreenWidth, 2);
            //good squares
            var square = new Rectangle (squarex, squarey, RectangleSize, RectangleSize);
            var squarex2 = Raylib.GetRandomValue(50,750);
            var square2 = new Rectangle (squarex2, squarey, RectangleSize, RectangleSize);
            var squarex3 = Raylib.GetRandomValue(50,750);
            var square3 = new Rectangle (squarex3, squarey, RectangleSize, RectangleSize);
            var squarex4 = Raylib.GetRandomValue(50,750);
            var square4 = new Rectangle (squarex4, squarey, RectangleSize, RectangleSize);
            var squarex5 = Raylib.GetRandomValue(50,750);
            var square5 = new Rectangle (squarex5, squarey, RectangleSize, RectangleSize);
            var squarex6 = Raylib.GetRandomValue(50,750);
            var square6 = new Rectangle (squarex6, squarey, RectangleSize, RectangleSize);
            var squarex7 = Raylib.GetRandomValue(50,750);
            var square7 = new Rectangle (squarex7, squarey, RectangleSize, RectangleSize);
            

            // bad squares
            var badx = Raylib.GetRandomValue(50,750);
            var bad = new Rectangle (badx, squarey, RectangleSize, RectangleSize);
            var badx2 = Raylib.GetRandomValue(50,750);
            var bad2 = new Rectangle (badx, squarey, RectangleSize, RectangleSize);
            var badx3 = Raylib.GetRandomValue(50,750);
            var bad3 = new Rectangle (badx, squarey, RectangleSize, RectangleSize);
            var badx4 = Raylib.GetRandomValue(50,750);
            var bad4 = new Rectangle (badx, squarey, RectangleSize, RectangleSize);
            var badx5 = Raylib.GetRandomValue(50,750);
            var bad5 = new Rectangle (badx, squarey, RectangleSize, RectangleSize);
            var badx6 = Raylib.GetRandomValue(50,750);
            var bad6 = new Rectangle (badx, squarey, RectangleSize, RectangleSize);
            var badx7 = Raylib.GetRandomValue(50,750);
            var bad7 = new Rectangle (badx, squarey, RectangleSize, RectangleSize);
            var badx8 = Raylib.GetRandomValue(50,750);
            var bad8 = new Rectangle (badx, squarey, RectangleSize, RectangleSize);


            Raylib.InitWindow(ScreenWidth, ScreenHeight, "GameObject");
            Raylib.SetTargetFPS(60);
            while (!Raylib.WindowShouldClose())
        
            {
                // Add a new random object to the screen every iteration of our game loop
                ///var whichType = Random.Next(8);

                // Generate a random velocity for this object
                var randomY = Random.Next(-2, 2);
                var randomX = Random.Next(-2, 2);

               //setting random positions for both circle and squares
                var position = new Vector2(Random.Next(1, ScreenWidth), 0);
                var position2 = new Vector2(Random.Next(1, ScreenWidth),0 );
                
                // generating new squares
                //squarex = Raylib.GetRandomValue(50, 750);
                

                

                // gnerating new circles
                var circle = new GameCircle(Color.GREEN, 5);
                circle.Position2= position2;
                circle.Velocity = new Vector2(randomX,randomY);
                Objects.Add(circle);
                
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                Raylib.DrawText("Move your red square to the blues to earn points, oranges are minus points!", 12, 24, 20, Color.WHITE);
                

               // foreach (var obj in Objects){
                //    obj.Draw();
               // }

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

                square.y += fallspeed;
                square2.y += fallspeed2;
                square3.y += fallspeed3;
                square4.y += fallspeed4;
                square5.y += fallspeed5;
                square6.y += fallspeed6;
                square7.y += fallspeed7;
                
                bad.y += fallspeed;
                bad2.y += fallspeed2;
                bad3.y += fallspeed3;
                bad4.y += fallspeed4;
                bad5.y += fallspeed5;
                bad6.y += fallspeed6;
                bad7.y += fallspeed7;
                bad8.y += fallspeed;
                


                Raylib.DrawRectangleRec(PlayerRectangle, Color.RED);
                Raylib.DrawRectangleRec(LimitLine, Color.ORANGE);
                Raylib.DrawRectangleRec(square, Color.BLUE);
                Raylib.DrawRectangleRec(square2, Color.BLUE);
                Raylib.DrawRectangleRec(square3, Color.BLUE);
                Raylib.DrawRectangleRec(square4, Color.BLUE);
                Raylib.DrawRectangleRec(square5, Color.BLUE);
                Raylib.DrawRectangleRec(square6, Color.BLUE);
                Raylib.DrawRectangleRec(square7, Color.BLUE);

                Raylib.DrawRectangleRec(bad, Color.ORANGE);
                Raylib.DrawRectangleRec(bad2, Color.ORANGE);
                Raylib.DrawRectangleRec(bad3, Color.ORANGE);
                Raylib.DrawRectangleRec(bad4, Color.ORANGE); 
                Raylib.DrawRectangleRec(bad5, Color.ORANGE);
                Raylib.DrawRectangleRec(bad6, Color.ORANGE);
                Raylib.DrawRectangleRec(bad7, Color.ORANGE);
                Raylib.DrawRectangleRec(bad7, Color.ORANGE);



                // squares meeting fall line
                if (Raylib.CheckCollisionRecs(square, LimitLine)){
                    square.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    square.y = 0;
                    fallspeed = Raylib.GetRandomValue(2,4);
                
                }
                if (Raylib.CheckCollisionRecs(square2, LimitLine)){
                    square2.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    square2.y = 0;
                    fallspeed2 = 4;
                
                }
                if (Raylib.CheckCollisionRecs(square3, LimitLine)){
                    square3.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    square3.y = 0;
                    fallspeed3 = Raylib.GetRandomValue(2,4);
                
                }
                if (Raylib.CheckCollisionRecs(square4, LimitLine)){
                    square4.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    square4.y = 0;
                    fallspeed4 =Raylib.GetRandomValue(2,4);
                
                }
                if (Raylib.CheckCollisionRecs(square5, LimitLine)){
                    square5.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    square5.y = 0;
                    fallspeed5 = Raylib.GetRandomValue(2,4);
                
                }
                if (Raylib.CheckCollisionRecs(square6, LimitLine)){
                    square6.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    square6.y = 0;
                    fallspeed6 = Raylib.GetRandomValue(2,4);
                
                }
                if (Raylib.CheckCollisionRecs(square7, LimitLine)){
                    square7.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    square7.y = 0;
                    fallspeed7 = Raylib.GetRandomValue(2,4);
                
                }
                
                // squares touch player

                if (Raylib.CheckCollisionRecs(square, PlayerRectangle)){
                    square.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    square.y = 0;
                    Score += 1;
                }

                if (Raylib.CheckCollisionRecs(square2, PlayerRectangle )){
                    square2.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    square2.y = 0;
                    Score += 1;
                
                }
                if (Raylib.CheckCollisionRecs(square3, PlayerRectangle)){
                    square3.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    square3.y = 0;
                    Score += 1;
                
                }
                if (Raylib.CheckCollisionRecs(square4, PlayerRectangle)){
                    square4.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    square4.y = 0;
                    Score += 1;
                
                }
                if (Raylib.CheckCollisionRecs(square5, PlayerRectangle)){
                    square5.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    square5.y = 0;
                    Score += 1;
                }
                if (Raylib.CheckCollisionRecs(square6, PlayerRectangle)){
                    square6.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    square6.y = 0;
                    Score += 1;
                
                }
                if (Raylib.CheckCollisionRecs(square7, PlayerRectangle)){
                    square7.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    square7.y = 0;
                    Score += 1;
                
                }

                
                // bad touches floor

                if (Raylib.CheckCollisionRecs(bad, LimitLine)){
                    bad.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    bad.y = 0;
                    fallspeed = Raylib.GetRandomValue(2,4);
                
                }
                if (Raylib.CheckCollisionRecs(bad, LimitLine)){
                    bad2.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    bad2.y = 0;
                    fallspeed2 = 4;
                
                }
                if (Raylib.CheckCollisionRecs(bad3, LimitLine)){
                    bad3.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    bad3.y = 0;
                    fallspeed3 = Raylib.GetRandomValue(2,4);
                
                }
                if (Raylib.CheckCollisionRecs(bad4, LimitLine)){
                    bad4.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    bad4.y = 0;
                    fallspeed4 =Raylib.GetRandomValue(2,4);
                
                }
                if (Raylib.CheckCollisionRecs(bad5, LimitLine)){
                    bad5.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    bad5.y = 0;
                    fallspeed5 = Raylib.GetRandomValue(2,4);
                
                }
                if (Raylib.CheckCollisionRecs(bad6, LimitLine)){
                    bad6.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    bad6.y = 0;
                    fallspeed6 = Raylib.GetRandomValue(2,4);
                
                }
                if (Raylib.CheckCollisionRecs(bad7, LimitLine)){
                    bad7.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    bad7.y = 0;
                    fallspeed7 = Raylib.GetRandomValue(2,4);
                
                }
                if (Raylib.CheckCollisionRecs(bad8, LimitLine)){
                    bad8.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    bad8.y = 0;
                    fallspeed = Raylib.GetRandomValue(2,4);
                
                }
                
                //bad touch player
               
               
                if (Raylib.CheckCollisionRecs(bad, PlayerRectangle)){
                    bad.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    bad.y = 0;
                    Score -= 1;
                
                }
                if (Raylib.CheckCollisionRecs(bad, PlayerRectangle)){
                    bad2.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    bad2.y = 0;
                    Score -= 1;
                
                }
                if (Raylib.CheckCollisionRecs(bad3, PlayerRectangle)){
                    bad3.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    bad3.y = 0;
                    Score -= 1;
                
                }
                if (Raylib.CheckCollisionRecs(bad4, PlayerRectangle)){
                    bad4.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    bad4.y = 0;
                    Score -= 1;
                
                }
                if (Raylib.CheckCollisionRecs(bad5, PlayerRectangle)){
                    bad5.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    bad5.y = 0;
                    Score -= 1;
                
                }
                if (Raylib.CheckCollisionRecs(bad6, PlayerRectangle)){
                    bad6.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    bad6.y = 0;
                    Score -= 1;
                
                }
                if (Raylib.CheckCollisionRecs(bad7, PlayerRectangle)){
                    bad7.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    bad7.y = 0;
                    Score -= 1;
                
                }
                if (Raylib.CheckCollisionRecs(bad8, PlayerRectangle)){
                    bad8.x = Raylib.GetRandomValue(10, ScreenWidth - 10);
                    bad8.y = 0;
                    Score -= 1;
                
                }
               
                
                Raylib.DrawText($"Score: {Score}", 12, 40, 20, Color.WHITE);
                Raylib.EndDrawing();

              
            }
        
            Raylib.CloseWindow();
        }
    }