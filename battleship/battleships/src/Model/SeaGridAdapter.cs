using System;

/// <summary>
/// The SeaGridAdapter allows for the change in a sea grid view. Whenever a ship is
/// presented it changes the view into a sea tile instead of a ship tile.
/// </summary>
public class SeaGridAdapter: ISeaGrid
{
	private SeaGrid MyGrid;

	public int Width {
		get {
			throw new NotImplementedException ();
		}
	}

	public int Height {
		get {
			throw new NotImplementedException ();
		}
	}

	/// <summary>
	/// Create the SeaGridAdapter, with the grid, and it will allow it to be changed
	/// </summary>
	/// <param name="grid">the grid that needs to be adapted</param>
	public SeaGridAdapter(SeaGrid grid)
	{
		MyGrid = grid;
		MyGrid.Changed += MyGrid_Changed;
	}

	/// <summary>
	/// MyGrid_Changed causes the grid to be redrawn by raising a changed event
	/// </summary>
	/// <param name="sender">the object that caused the change</param>
	/// <param name="e">what needs to be redrawn</param>
	private void MyGrid_Changed(object sender, EventArgs e)
	{
		if (Changed != null) {
			Changed(this, e);
		}
	}

	#region "ISeaGrid Members"

	/// <summary>
	/// Changes the discovery grid. Where there is a ship we will sea water
	/// </summary>
	/// <param name="x">tile x coordinate</param>
	/// <param name="y">tile y coordinate</param>
	/// <returns>a tile, either what it actually is, or if it was a ship then return a sea tile</returns>
	public TileView this[int x, int y] {
		get {
			TileView result = MyGrid[x, y];

			if (result == TileView.Ship) {
				return TileView.Sea;
			} else {
				return result;
			}
		}
	}

	/// <summary>
	/// Indicates that the grid has been changed
	/// </summary>
	public event EventHandler Changed;


	/// <summary>
	/// HitTile calls oppon _MyGrid to hit a tile at the row, col
	/// </summary>
	/// <param name="row">the row its hitting at</param>
	/// <param name="col">the column its hitting at</param>
	/// <returns>The result from hitting that tile</returns>
	public AttackResult HitTile(int row, int col)
	{
		return MyGrid.HitTile(row, col);
	}
	#endregion

}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
