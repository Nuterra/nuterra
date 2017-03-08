﻿using System;
using System.IO;
using Nuterra.Build;

namespace Nuterra.Installer
{
	public sealed class FixMissingDependencies : ModificationStep
	{
		public static readonly string GalaxyAssemblyFile = "GalaxyCSharp.dll";

		protected override void Perform(ModificationInfo info)
		{
			string source = Path.Combine(info.NuterraData, GalaxyAssemblyFile);
			string target = Path.Combine(info.TerraTechManaged, GalaxyAssemblyFile);
			File.Copy(source, target, overwrite: true);
		}
	}
}