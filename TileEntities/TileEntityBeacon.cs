﻿using MCUtils.Coordinates;
using MCUtils.NBT;
using System;
using System.Collections.Generic;
using System.Text;

namespace MCUtils.TileEntities
{
	public class TileEntityBeacon : TileEntity
	{
		public TileEntityBeacon(BlockCoord blockPos) : base("beacon", blockPos)
		{
		}

		public TileEntityBeacon(NBTCompound compound) : base(compound)
		{
		}

		protected override void Serialize(NBTCompound nbt, Version version)
		{
			throw new NotImplementedException();
		}
	}
}
