﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceApplication
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SelfHost" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select SelfHost.svc or SelfHost.svc.cs at the Solution Explorer and start debugging.
	public class SelfHost : ISelfHost
	{
		public void DoWork()
		{
		}
	}
}
