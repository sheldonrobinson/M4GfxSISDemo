// Copyright 2019 Sheldon Robinson. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class M4GfxSISDemoEditorTarget : TargetRules
{
	public M4GfxSISDemoEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "M4GfxSISDemo" } );
	}
}
