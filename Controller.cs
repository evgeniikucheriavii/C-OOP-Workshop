using System;
using System.Collections.Generic;

namespace OOPGame
{
	public static class Controller
	{
		public static void Controll(ConsoleKeyInfo e)
		{
			Direction d = Direction.None;

			switch(e.Key)
			{
				case ConsoleKey.UpArrow:
					d = Direction.Up;
					break;

				case ConsoleKey.DownArrow:
					d = Direction.Down;
					break;

				case ConsoleKey.LeftArrow:
					d = Direction.Left;
					break;

				case ConsoleKey.RightArrow:
					d = Direction.Right;
					break;				
			}

			if(d != Direction.None)
			{
				Game.Objects[0].Position.Move(d);
			}
		}

	}
}