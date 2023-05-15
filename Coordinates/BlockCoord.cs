﻿using System;

namespace MCUtils.Coordinates
{
	public struct BlockCoord
	{
		public int x;
		public int y;
		public int z;

		public RegionLocation Region => new RegionLocation((int)Math.Floor(x / 512f), (int)Math.Floor(z / 512f));

		public ChunkCoord Chunk => new ChunkCoord((int)Math.Floor(x / 16f), (int)Math.Floor(z / 16f));

		public BlockCoord LocalRegionCoords => new BlockCoord(x.Mod(512), y, z.Mod(512));

		public BlockCoord LocalChunkCoords => new BlockCoord(x.Mod(16), y, z.Mod(16));

		public BlockCoord(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public override string ToString()
		{
			return $"[{x},{y},{z}]";
		}

		public static BlockCoord operator +(BlockCoord l, BlockCoord r)
		{
			return new BlockCoord(l.x + r.x, l.y + r.y, l.z + r.z);
		}

		public static BlockCoord operator -(BlockCoord l, BlockCoord r)
		{
			return new BlockCoord(l.x - r.x, l.y - r.y, l.z - r.z);
		}

		public BlockCoord ChunkToRegionSpace(ChunkCoord localChunk)
		{
			if(localChunk.x > 31 || localChunk.z > 31 || localChunk.x < 0 || localChunk.z < 0)
			{
				throw new ArgumentException("Chunk coordinate was not in region space: "+localChunk);
			}
			return this + localChunk.BlockCoord;
		}

		public BlockCoord RegionToWorldSpace(RegionLocation localRegion)
		{
			return this + localRegion.GetBlockCoord(0, 0, 0);
		}

		public BlockCoord ChunkToWorldSpace(ChunkCoord localChunk, RegionLocation localRegion)
		{
			return ChunkToRegionSpace(localChunk).RegionToWorldSpace(localRegion);
		}

		public BlockCoord ChunkToWorldSpace(ChunkData chunk)
		{
			return this + chunk.worldSpaceCoord.BlockCoord;
		}
	}
}
