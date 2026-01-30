// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Parkour : ModuleRules
{
	public Parkour(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Parkour",
			"Parkour/Variant_Platforming",
			"Parkour/Variant_Platforming/Animation",
			"Parkour/Variant_Combat",
			"Parkour/Variant_Combat/AI",
			"Parkour/Variant_Combat/Animation",
			"Parkour/Variant_Combat/Gameplay",
			"Parkour/Variant_Combat/Interfaces",
			"Parkour/Variant_Combat/UI",
			"Parkour/Variant_SideScrolling",
			"Parkour/Variant_SideScrolling/AI",
			"Parkour/Variant_SideScrolling/Gameplay",
			"Parkour/Variant_SideScrolling/Interfaces",
			"Parkour/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
