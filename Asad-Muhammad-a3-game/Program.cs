using Raylib_cs;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;

public class Program
{
    Player player;
    Obstacle obstacle;
    TextReader timesUpText;

    public Program()
    {
        Raylib.InitWindow(800, 600, "Assignment 3 - 2D Game Project");
        Raylib.SetTargetFPS(60);

        player = new Player();
        obstacle = new Obstacle();
        timesUpText = new Text("Times Up, Raylib.GetScreenWidth() /")
