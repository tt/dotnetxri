/*
 * Copyright 2005 OpenXRI Foundation
 * Subsequently ported and altered by Andrew Arnott and Troels Thomsen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace DotNetXri.Syntax.Xri3
{
	public interface XRI : XRISyntaxComponent
	{
		public bool hasScheme();
		public bool hasAuthority();
		public bool hasPath();
		public bool hasQuery();
		public bool hasFragment();

		public string getScheme();
		public XRIAuthority getAuthority();
		public XRIPath getPath();
		public XRIQuery getQuery();
		public XRIFragment getFragment();

		public bool isIName();
		public bool isINumber();
		public bool isReserved();

		public bool isValidXRIReference();
		public XRIReference toXRIReference();

		public bool startsWith(XRI xri);
	}
}