﻿using System;
using WorldForge.Coordinates;
using WorldForge.NBT;

namespace WorldForge.TileEntities
{
	public class TileEntitySpawner : TileEntity
	{
		[NBTCollection]
		public MobSpawnerData mobSpawnerData = new MobSpawnerData();

		public override GameVersion AddedInVersion => GameVersion.FirstVersion;

		public TileEntitySpawner() : base("mob_spawner")
		{

		}

		public TileEntitySpawner(NBTCompound compound, out BlockCoord blockPos) : base(compound, out blockPos)
		{

		}

		protected override string ResolveTileEntityID(GameVersion version)
		{
			if(version >= GameVersion.Release_1(11))
			{
				return id;
			}
			else
			{
				return "MobSpawner";
			}
		}
	}
}
