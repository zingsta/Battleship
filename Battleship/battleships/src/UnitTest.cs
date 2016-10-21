using NUnit.Framework;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using SwinGameSDK;

namespace MyGame
{
	[TestFixture]
	public class TestDeploymentController
	{
		const int SHIPS_TOP = 98;
		const int SHIPS_LEFT = 20;
		const int SHIPS_HEIGHT = 90;
		const int SHIPS_WIDTH = 300;
		const int TOP_BUTTONS_TOP = 72;
		const int TOP_BUTTONS_HEIGHT = 46;
		const int PLAY_BUTTON_LEFT = 693;
		const int PLAY_BUTTON_WIDTH = 80;
		const int UP_DOWN_BUTTON_LEFT = 410;
		const int LEFT_RIGHT_BUTTON_LEFT = 350;
		const int RANDOM_BUTTON_LEFT = 547;
		const int RANDOM_BUTTON_WIDTH = 51;
		const int DIR_BUTTONS_WIDTH = 47;

		const int TEXT_OFFSET = 5;

		[Test]
		public void DirectionTest ()
		{
			Direction _UpDirection = Direction.UpDown;
			Direction _LeftDirection = Direction.LeftRight;

			Assert.IsTrue(_UpDirection == Direction.UpDown);
			Assert.IsTrue(_LeftDirection == Direction.LeftRight);
			Assert.IsFalse(_UpDirection == _LeftDirection);
		}

		[Test]
		public void SetDirectionTest()
		{
			Direction _direction;
			_direction = Direction.UpDown;

			Assert.IsTrue(_direction == Direction.UpDown);

			_direction = Direction.LeftRight;
			Assert.IsTrue(_direction == Direction.LeftRight);
		}

		[Test]
		public void MousePositionsTest ()
		{
			Assert.IsFalse(UP_DOWN_BUTTON_LEFT == LEFT_RIGHT_BUTTON_LEFT);
		}
	}
}