// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GPE230Project : ModuleRules
{
	public GPE230Project(ReadOnlyTargetRules Target) : base(Target)
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
			"GPE230Project",
			"GPE230Project/Variant_Platforming",
			"GPE230Project/Variant_Platforming/Animation",
			"GPE230Project/Variant_Combat",
			"GPE230Project/Variant_Combat/AI",
			"GPE230Project/Variant_Combat/Animation",
			"GPE230Project/Variant_Combat/Gameplay",
			"GPE230Project/Variant_Combat/Interfaces",
			"GPE230Project/Variant_Combat/UI",
			"GPE230Project/Variant_SideScrolling",
			"GPE230Project/Variant_SideScrolling/AI",
			"GPE230Project/Variant_SideScrolling/Gameplay",
			"GPE230Project/Variant_SideScrolling/Interfaces",
			"GPE230Project/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
