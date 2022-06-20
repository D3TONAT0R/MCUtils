﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MCUtils.Coordinates
{
	public struct RegionLocation
	{
		public int x;
		public int z;

		public RegionLocation(int regionX, int regionZ)
		{
			x = regionX;
			z = regionZ;
		}

		public static RegionLocation FromRegionFileName(string regionFileName)
		{
			regionFileName = Path.GetFileName(regionFileName);
			var split = regionFileName.Split('.');
			return new RegionLocation(int.Parse(split[split.Length - 3]), int.Parse(split[split.Length - 2]));
		}

		public ChunkCoord GetChunkCoord(int chunkOffsetX = 0, int chunkOffsetZ = 0)
		{
			return new ChunkCoord(x * 32 + chunkOffsetX, z * 32 + chunkOffsetZ);
		}

		public string ToFileName() => $"r.{x}.{z}.mca";

		public string ToFileNameMCR() => $"r.{x}.{z}.mcr";
	}
}