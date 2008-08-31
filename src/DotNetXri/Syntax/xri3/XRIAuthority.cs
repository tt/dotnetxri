namespace DotNetXri.Syntax.Xri3 {

	public interface XRIAuthority : XRISyntaxComponent {

		public List getSubSegments();
		public int getNumSubSegments();
		public XRISubSegment getSubSegment(int i);
		public XRISubSegment getFirstSubSegment();
		public XRISubSegment getLastSubSegment();
		public bool startsWith(XRISubSegment[] subSegments);
	}
}