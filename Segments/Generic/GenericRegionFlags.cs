﻿using System;

namespace CondenseTech.JBig2Decoder.Segments.Generic
{
	public class GenericRegionFlags : Flags
	{

		public const string MMR = "MMR";
		public const string GB_TEMPLATE = "GB_TEMPLATE";
		public const string TPGDON = "TPGDON";

		public override void SetFlags(int flagsAsInt)
		{
			this.flagsAsInt = flagsAsInt;

			/** extract MMR */
			flags[MMR] = flagsAsInt & 1;

			/** extract GB_TEMPLATE */
			flags[GB_TEMPLATE] = (flagsAsInt >> 1) & 3;

			/** extract TPGDON */
			flags[TPGDON] = (flagsAsInt >> 3) & 1;


			if (JBIG2StreamDecoder.debug)
				Console.WriteLine(flags);
		}
	}
}
