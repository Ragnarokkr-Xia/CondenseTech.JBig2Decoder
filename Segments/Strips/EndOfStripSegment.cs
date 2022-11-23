namespace CondenseTech.JBig2Decoder.Segments.Strips
{
	public class EndOfStripeSegment : Segment
	{

		public EndOfStripeSegment(JBIG2StreamDecoder streamDecoder) : base(streamDecoder) { }

		public override void ReadSegment()
		{
			for (int i = 0; i < this.GetSegmentHeader().GetSegmentDataLength(); i++)
			{
				decoder.Readbyte();
			}
		}
	}
}
