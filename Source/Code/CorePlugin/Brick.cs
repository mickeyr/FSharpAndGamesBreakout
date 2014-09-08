﻿using System;
using Breakout.FSharp;
using Duality;
using Duality.Resources;

namespace Breakout
{
	[Serializable]
	public class Brick : Component, ICmpCollisionListener
	{
		public void OnCollisionBegin(Component sender, CollisionEventArgs args)
		{
			var scoreComponent = Scene.Current.FindComponent<ScoreComponentF>();
			if (scoreComponent != null)
				scoreComponent.IncreaseScore(1);
			GameObj.DisposeLater();
		}

		public void OnCollisionEnd(Component sender, CollisionEventArgs args)
		{
			
		}

		public void OnCollisionSolve(Component sender, CollisionEventArgs args)
		{
			
		}
	}
}
