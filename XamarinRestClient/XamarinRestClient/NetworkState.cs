using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinRestClient
{
	public class NetworkState
	{

		public static bool IsInternet()
		{
			if (CrossConnectivity.Current.IsConnected)
			{
				return true;
			}
			else
			{
				     
				return false;
			}
		}

	}
}
