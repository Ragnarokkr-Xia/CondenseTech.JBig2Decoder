﻿namespace CondenseTech.JBig2Decoder.Decoders
{
  public class DecodeIntResult
  {

    private long _intResult;
    private bool _booleanResult;

    public DecodeIntResult(long intResult, bool booleanResult)
    {
      this._intResult = intResult;
      this._booleanResult = booleanResult;
    }

    public long IntResult()
    {
      return _intResult;
    }

    public bool BooleanResult()
    {
      return _booleanResult;
    }
  }
}
