// Fill out your copyright notice in the Description page of Project Settings.

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
