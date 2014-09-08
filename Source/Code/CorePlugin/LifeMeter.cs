﻿using System;
using Duality;
using Duality.Components.Renderers;

namespace Breakout
{
	[Serializable]
	public class LifeMeter : Component, ICmpUpdatable
	{
		public int Lives { get; set; }

		public void OnUpdate()
		{
			GameObj.GetComponent<TextRenderer>().Text.SourceText = "Lives: " + Lives;
		}
	}
}