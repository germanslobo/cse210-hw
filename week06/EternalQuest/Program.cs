// EXCEEDING REQUIREMENTS DESCRIPTION:
// 1. Added a leveling/ranking mechanism in GoalManager.DisplayPlayerInfo() based on current points (every 500 points grants a new level).
// 2. Added special celebration feedback messages when a checklist goal achieves its full target count and grants a bonus.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}