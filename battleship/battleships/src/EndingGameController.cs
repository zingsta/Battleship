using SwinGameSDK;

//The EndingGameController is responsible for managing the interactions at the end of a game.
static class EndingGameController
{
	/// <summary>
	/// Draw the end of the game screen, shows the win/lose state
	/// </summary>
	public static void DrawEndOfGame ()
	{
		UtilityFunctions.DrawField ((ISeaGrid)GameController.ComputerPlayer.PlayerGrid, GameController.ComputerPlayer, true);
		UtilityFunctions.DrawSmallField ((ISeaGrid)GameController.HumanPlayer.PlayerGrid, GameController.HumanPlayer);

		if (GameController.HumanPlayer.IsDestroyed) {
			SwinGame.DrawTextLines ("YOU LOSE!", Color.White, Color.Transparent, GameResources.GameFont ("ArialLarge"), FontAlignment.AlignCenter, 0, 200, SwinGame.ScreenWidth (), SwinGame.ScreenHeight ());
		} else {
			SwinGame.DrawTextLines ("-- WINNER --", Color.White, Color.Transparent, GameResources.GameFont ("ArialLarge"), FontAlignment.AlignCenter, 0, 200, SwinGame.ScreenWidth (), SwinGame.ScreenHeight ());
		}
	}
	/* 
	Handle the input during the end of the game.
	Any interaction will result in it reading in the highsSwinGame. 
	*/
	public static void HandleEndOfGameInput()
	{
		if (SwinGame.MouseClicked (MouseButton.LeftButton) || SwinGame.KeyTyped (KeyCode.vk_RETURN) || SwinGame.KeyTyped (KeyCode.vk_ESCAPE)) {
			HighScoreController.ReadHighScore (GameController.HumanPlayer.Score);
			GameController.EndCurrentState ();
		}
	}

}



//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================


