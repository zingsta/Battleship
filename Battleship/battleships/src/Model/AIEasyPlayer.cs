using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;


public class AIEasyPlayer : AIPlayer
{
	private enum AIStates
	{
		Searching
	}

	private AIStates _CurrentState = AIStates.Searching;

	private Stack<Location> _Targets = new Stack<Location>();
	public AIEasyPlayer(BattleShipsGame controller) : base(controller)
	{
	}

	protected override void GenerateCoords(ref int row, ref int column)
	{
		do {
			switch (_CurrentState) {
			case AIStates.Searching:
				SearchCoords(ref row, ref column);
				break;
			default:
				throw new ApplicationException("AI has gone in an invalid state");
			}
		} while ((row < 0 || column < 0 || row >= EnemyGrid.Height || column >= EnemyGrid.Width || EnemyGrid[row, column] != TileView.Sea));
		//while inside the grid and not a sea tile do the search
	}
		
	private void TargetCoords(ref int row, ref int column)
	{
		Location l = _Targets.Pop();

		if ((_Targets.Count == 0))
			_CurrentState = AIStates.Searching;
		row = l.Row;
		column = l.Column;
	}
		
	private void SearchCoords(ref int row, ref int column)
	{
		row = _Random.Next(0, EnemyGrid.Height);
		column = _Random.Next(0, EnemyGrid.Width);
	}
		
	protected override void ProcessShot(int row, int col, AttackResult result)
	{
		if (result.Value == ResultOfAttack.Hit) {
			_CurrentState = AIStates.Searching;
			AddTarget(row - 1, col);
			AddTarget(row, col - 1);
			AddTarget(row + 1, col);
			AddTarget(row, col + 1);
		} else if (result.Value == ResultOfAttack.ShotAlready) {
			throw new ApplicationException("Error in AI");
		}
	}

	/// <summary>
	/// AddTarget will add the targets it will shoot onto a stack
	/// </summary>
	/// <param name="row">the row of the targets location</param>
	/// <param name="column">the column of the targets location</param>
	private void AddTarget(int row, int column)
	{

		if (row >= 0 && column >= 0 && row < EnemyGrid.Height && column < EnemyGrid.Width && EnemyGrid[row, column] == TileView.Sea) {
			_Targets.Push(new Location(row, column));
		}
	}
}


