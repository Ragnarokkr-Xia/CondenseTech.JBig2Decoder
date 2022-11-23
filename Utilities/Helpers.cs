﻿namespace CondenseTech.JBig2Decoder.Utilities
{
  public class Helpers
  {
    private long[][] ConvertToJaggedArray(long[,] multiArray, int numOfColumns, int numOfRows)
    {
      long[][] jaggedArray = new long[numOfColumns][];

      for (int c = 0; c < numOfColumns; c++)
      {
        jaggedArray[c] = new long[numOfRows];
        for (int r = 0; r < numOfRows; r++)
        {
          jaggedArray[c][r] = multiArray[c, r];
        }
      }

      return jaggedArray;
    }

  }
}
