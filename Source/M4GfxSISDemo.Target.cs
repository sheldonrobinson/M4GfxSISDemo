// Copyright 2019 Sheldon Robinson. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class M4GfxSISDemoTarget : TargetRules
{
	public M4GfxSISDemoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "M4GfxSISDemo" } );
	}
}
