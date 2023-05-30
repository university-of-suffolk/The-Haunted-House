using UnrealBuildTool;

public class TheHauntedHouseTarget : TargetRules
{
	public TheHauntedHouseTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("TheHauntedHouse");
	}
}
