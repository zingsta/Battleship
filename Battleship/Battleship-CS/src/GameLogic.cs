using SwinGameSDK;
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
		GameResources.LoadResources();

		SwinGame.PlayMusic(GameResources.GameMusic("Background"));

		//Game Loop
		do {
			GameController.HandleUserInput();
			GameController.DrawScreen();
		} while (!(SwinGame.WindowCloseRequested() == true | GameController.CurrentState == GameState.Quitting));

		SwinGame.StopMusic();

		//Free Resources and Close Audio, to end the program.
		GameResources.FreeResources();
	}
}