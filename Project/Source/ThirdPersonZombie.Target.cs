

using UnrealBuildTool;
using System.Collections.Generic;

public class ThirdPersonZombieTarget : TargetRules
{
	public ThirdPersonZombieTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "ThirdPersonZombie" } );
	}
}
