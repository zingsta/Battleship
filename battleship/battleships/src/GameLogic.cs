using SwinGameSDK;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

/* 
The logic of the game, responsible for loading in the main essence of the
game, loading in resources and other main pieces of information. 
 */
static class GameLogic
{
	//Main file
	public static void Main()
	{
		//Opens a new Graphics Window
		SwinGame.OpenGraphicsWindow("Battle Ships", 800, 600);

		//Load Resources
		LoadResources();

		SwinGame.PlayMusic(GameMusic("Background"));

		//Game Loop
		do {
			HandleUserInput();
			DrawScreen();
		} while (!(SwinGame.WindowCloseRequested() == true | CurrentState == GameState.Quitting));

		SwinGame.StopMusic();

		//Free Resources and Close Audio, to end the program.
		FreeResources();
	}
}