using Raylib_cs;
using System.Numerics;

public class Player
{
    Vector2 position;

    public Player()
    {
        // Place player in center of screen
        position.X = Raylib.GetScreenWidth() / 2;
        position.Y = Raylib.GetScreenHeight() / 2;
    }

    public void Draw()
    {
        float headRadius = 22.5f;
        float width = 40;
        float height = 100;
        Vector2 legbase = position + new Vector2(0, -30);
        Vector2 footleft = position + new Vector2(-width / 2, 0);
        Vector2 footRight = position + new Vector2(+width / 2, 0);
        Vector2 armBase = position + new Vector2(0, -40);
        Vector2 handleft = armBase + new Vector2(-width / 2, +5);
        Vector2 handright = armBase + new Vector2(+width / 2, +5);
        Vector2 headBase = position + new Vector2(0, -height + headRadius);

        // Torso
        Raylib.DrawLineV(legbase, headBase, Color.Black);
        // Legs
        Raylib.DrawLineV(legbase, footleft, Color.Black);
        Raylib.DrawLineV(legbase, footRight, Color.Black);
        // Arms
        Raylib.DrawLineV(armBase, handleft, Color.Black);
        Raylib.DrawLineV(armBase, handright, Color.Black);
        // Head
        Raylib.DrawCircleV(headBase, headRadius, Color.Black);

        // Refrence base position
        Raylib.DrawCircleV(position, 2, Color.White);
         
    {
        
    }
}

    public void Move()
    {
        position = Raylib.GetMousePosition();
    }
}
