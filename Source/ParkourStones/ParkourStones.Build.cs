// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ParkourStones : ModuleRules
{
	public ParkourStones(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
