using Raylib_cs;
using System.Numerics;
using System.Security.Cryptography;

public class Program
{
    // code for window
    static string title = "Asad-Muhammad-a3-game"; // Window title
    static int screenWidth = 800; // Screen width
    static int screenHeight = 600; // Screen height
    static int targetFps = 60; // Target frames-per-second

    static Player player;

    static void Main()
    {
        // Create a window to draw to. The arguments define width and height
        Raylib.InitWindow(screenWidth, screenHeight, title);
        // Set the target frames-per-second (FPS)
        Raylib.SetTargetFPS(targetFps);
        // Setup your game. This is a function YOU define.
        Setup();
        // Loop so long as window should not close
        while (!Raylib.WindowShouldClose())
        {
            // Enable drawing to the canvas (window)
            Raylib.BeginDrawing();
            // Clear the canvas with one color
            Raylib.ClearBackground(Color.RayWhite);
            // game code
            Update();
            // Stop drawing to the canvas, begin displaying the frame
            Raylib.EndDrawing();
        }
        // Close the window
        Raylib.CloseWindow();
    }

    static void Setup()
    {
        // code for player
        player = new Player();
    }

    static void Update()
    {
        // code for original game
        player.Move();
        player.Draw();
    }
}

public class player
{
    public Vector2 position;

    public player()
    {
        position = new Vector2(300, 200); //position
    }

    public void Move()
    {
        // movement 
        if (!Raylib.IsKeyDown(KeyboardKey.Right))
        {
            position.X += 2.0f;
        }

        if (Raylib.IsKeyDown(KeyboardKey.Left))
        {
            position.X += 2.0f;
        }

        if (Raylib.IsKeyDown(KeyboardKey.Up))
        {
            position.X += 2.0f;
        }

        if (Raylib.IsKeyDown(KeyboardKey.Down))
        {
            position.X += 2.0f;
        }
    }

    public void Draw()
    {
        Raylib.DrawCircleV(position, 18, Color.Brown);
    }
}

