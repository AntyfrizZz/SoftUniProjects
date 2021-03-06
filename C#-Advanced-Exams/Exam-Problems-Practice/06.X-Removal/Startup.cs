﻿using System;
using System.Collections.Generic;

class Startup
{
    static List<char[]> board = new List<char[]>();
    static List<bool[]> toRemove = new List<bool[]>();

    static void Main()
    {
        ReadBoard();

        MarkCellsForRemoving();

        PrintBoard();

    }

    private static void MarkCellsForRemoving()
    {
        for (int row = 1; row < board.Count - 1; row++)
        {
            for (int col = board[row].Length - 1; col >= 1; col--)
            {
                if (board[row - 1].Length < col + 2 ||
                    board[row + 1].Length < col + 2)
                {
                    continue;
                }

                var current = board[row][col].ToString().ToLower();

                if (board[row - 1][col - 1].ToString().ToLower() == current &&
                    board[row - 1][col + 1].ToString().ToLower() == current &&
                    board[row + 1][col - 1].ToString().ToLower() == current &&
                    board[row + 1][col + 1].ToString().ToLower() == current)
                {
                    toRemove[row - 1][col - 1] = true;
                    toRemove[row - 1][col + 1] = true;
                    toRemove[row + 1][col - 1] = true;
                    toRemove[row + 1][col + 1] = true;
                    toRemove[row][col] = true;
                }
            }
        }
    }

    private static string ReadBoard()
    {
        var inputLine = Console.ReadLine();

        while (inputLine != "END")
        {
            board.Add(inputLine.ToCharArray());
            toRemove.Add(new bool[inputLine.Length]);

            inputLine = Console.ReadLine();
        }

        return inputLine;
    }

    private static void PrintBoard()
    {
        for (int row = 0; row < board.Count; row++)
        {
            for (int col = 0; col < board[row].Length; col++)
            {
                if (!toRemove[row][col])
                {
                    Console.Write(board[row][col]);
                }
            }
            Console.WriteLine();
        }
    }
}