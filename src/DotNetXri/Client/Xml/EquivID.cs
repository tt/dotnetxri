package org.openxri.xml;

using java.net.URISyntaxException;

using org.w3c.dom.Element;

public class EquivID :SimpleXMLElement {

	public EquivID() : base(Tags.TAG_EQUIVID) {
	}
	
	public EquivID(String equivID) : base(Tags.TAG_EQUIVID) {
		setValue(equivID);
	}

	/**
	 * This method constructs the obj from DOM.  It does not keep a
	 * copy of the DOM around.  Whitespace information is lost in this process.
	 */
	public EquivID(Element elem) throws URISyntaxException
	: base(Tags.TAG_EQUIVID) {
		fromXML(elem);
		
		// make sure that the priority (if present) is valid (vommits exception if invalid)
		String val = elem.getAttribute(Tags.ATTR_PRIORITY);
		if (val != null && !val.equals(""))
			Integer.parseInt(val); 
	}

	/**
	 * @return Returns the priority.
	 */
	public Integer getPriority() {
		String val = getAttributeValue(Tags.ATTR_PRIORITY);
		if (val == null || val.equals(""))
			return null;
		return new Integer(val);
	}


	public void setPriority(Integer priority) {
		
		if (priority == null) {
			
			this.removeAttribute(Tags.ATTR_PRIORITY);
		} else {
		
			this.addAttribute(Tags.ATTR_PRIORITY, priority.toString());
		}
	}
}
