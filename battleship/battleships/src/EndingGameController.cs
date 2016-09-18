using SwinGameSDK;

//The EndingGameController is responsible for managing the interactions at the end of a game.
static class EndingGameController
{
<<<<<<< HEAD

	/// <summary>
	/// Draw the end of the game screen, shows the win/lose state
	/// </summary>
	public static void DrawEndOfGame ()
=======
	//Draw the end of the game screen, shows the win/lose state
	public static void DrawEndOfGame()
>>>>>>> 4786b05667642f844fba717f659639d28e87a8f1
	{
		UtilityFunctions.DrawField ((ISeaGrid)GameController.ComputerPlayer.PlayerGrid, GameController.ComputerPlayer, true);
		UtilityFunctions.DrawSmallField ((ISeaGrid)GameController.HumanPlayer.PlayerGrid, GameController.HumanPlayer);

		if (GameController.HumanPlayer.IsDestroyed) {
			SwinGame.DrawTextLines ("YOU LOSE!", Color.White, Color.Transparent, GameResources.GameFont ("ArialLarge"), FontAlignment.AlignCenter, 0, 250, SwinGame.ScreenWidth (), SwinGame.ScreenHeight ());
		} else {
			SwinGame.DrawTextLines ("-- WINNER --", Color.White, Color.Transparent, GameResources.GameFont ("ArialLarge"), FontAlignment.AlignCenter, 0, 250, SwinGame.ScreenWidth (), SwinGame.ScreenHeight ());
		}
	}

<<<<<<< HEAD
	/// <summary>
	/// Handle the input during the end of the game. Any interaction
	/// will result in it reading in the highsSwinGame.
	/// </summary>
	public static void HandleEndOfGameInput ()
=======
	/* 
	Handle the input during the end of the game.
	Any interaction will result in it reading in the highsSwinGame. 
	*/
	public static void HandleEndOfGameInput()
>>>>>>> 4786b05667642f844fba717f659639d28e87a8f1
	{
		if (SwinGame.MouseClicked (MouseButton.LeftButton) || SwinGame.KeyTyped (KeyCode.vk_RETURN) || SwinGame.KeyTyped (KeyCode.vk_ESCAPE)) {
			HighScoreController.ReadHighScore (GameController.HumanPlayer.Score);
			GameController.EndCurrentState ();
		}
	}

<<<<<<< HEAD
}



//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
=======
}
>>>>>>> 4786b05667642f844fba717f659639d28e87a8f1
