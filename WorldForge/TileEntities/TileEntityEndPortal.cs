﻿using WorldForge.Coordinates;
using WorldForge.NBT;

namespace WorldForge.TileEntities
{
	public class TileEntityEndPortal : TileEntity
	{
		public override GameVersion AddedInVersion => GameVersion.Release_1(0);

		public TileEntityEndPortal() : base("end_portal")
		{

		}

		public TileEntityEndPortal(NBTCompound compound, out BlockCoord blockPos) : base(compound, out blockPos)
		{

		}

		protected override string ResolveTileEntityID(GameVersion version)
		{
			return version >= GameVersion.Release_1(11) ? id : "AirPortal";
		}
	}
}
