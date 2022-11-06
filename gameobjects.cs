using Raylib_cs;
using System.Numerics;

class GameObject {
    public Vector2 Position { get; set; } = new Vector2(0, 0);
    public Vector2 Position2 { get; set; } = new Vector2(0, 0);
    public Vector2 Velocity { get; set; } = new Vector2(0, 0);

    virtual public void Draw() {
        // Base game objects do not have anything to draw
    }

    public void Move() {
        // making it so when the player moves, everything else moves too
        Vector2 NewPosition = Position;
        Vector2 NewPosition2 = Position2;

        // no matter what key is pressed, both circle and square move down
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
            NewPosition.Y += Velocity.Y;
            NewPosition2.Y += Velocity.Y;
            Position = NewPosition;
            Position2 = NewPosition2;
            }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
            NewPosition.Y += Velocity.Y;
            NewPosition2.Y += Velocity.Y;
            Position = NewPosition;
            Position2 = NewPosition2;
            }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)) {
            NewPosition.Y += Velocity.Y;
            NewPosition2.Y += Velocity.Y;
            Position = NewPosition;
            Position2 = NewPosition2;
            }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) {
            NewPosition.Y += Velocity.Y;
            NewPosition2.Y += Velocity.Y;
            Position = NewPosition;
            Position2 = NewPosition2;
    }
    }
}

class ColoredObject: GameObject {
    // setting up color specification
    public Color Color { get; set; }

    public ColoredObject(Color color) {
        Color = color;
    }
}

class GameSquare: ColoredObject {
    //generating squares
    public int Size { get; set; }

    public GameSquare(Color color, int size): base(color) {
        Size = size;
    }

    override public void Draw() {
        Raylib.DrawRectangle((int)Position.X, (int)Position.Y, Size, Size, Color);
    }
}

class GameCircle: ColoredObject {
    //generating circles
    public float Radius { get; set; }

    public GameCircle(Color color, float radius): base(color) {
        Radius = radius;
    }
    public override void Draw()
    {
        Raylib.DrawCircle((int)Position2.X, (int)Position2.Y, Radius, Color);
    }
}

class GameText: ColoredObject {

    public GameText(Color color): base(color) {
        
    }
}

