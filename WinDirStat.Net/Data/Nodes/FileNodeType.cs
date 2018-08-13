﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinDirStat.Net.Data.Nodes {
	[Serializable]
	public enum FileNodeType : byte {
		Root = 0,
		Directory = 1,
		File = 2,
		FileCollection = 3,
		FreeSpace = 4,
		Unknown = 5,
	}
}
