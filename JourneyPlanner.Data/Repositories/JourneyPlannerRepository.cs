using System;
using System.Collections;
using System.Collections.Generic;

namespace JourneyPlanner.Data
{
	public class JourneyPlannerRepository : IJourneyPlannerRepository
	{
		public List<Node> Get()
		{

			//Create the whole Map with hardcoded data
			var st1 = new Station { Name = "Leicester Square" };
			var st2 = new Station { Name = "Covent Garden" };
			var st3 = new Station { Name = "Holborn" };
			var st4 = new Station { Name = "Tottenham Court Road" };
			var st5 = new Station { Name = "Charing Cross" };
			var st6 = new Station { Name = "Embankment" };
			var st7 = new Station { Name = "Temple" };
			var st8 = new Station { Name = "Blackfriars" };
			var st9 = new Station { Name = "Mansion House" };
			var st10 = new Station { Name = "Cannon Street" };
			var st11 = new Station { Name = "Monument" };
			var st12 = new Station { Name = "Chancery Lane" };
			var st13 = new Station { Name = "St. Paul's" };
			var st14 = new Station { Name = "Bank" };

			var nLestSq = new Node { Station = st1 };
			var nCovGrdn = new Node { Station = st2 };
			var nHol = new Node { Station = st3 };
			var nTotCRd = new Node { Station = st4 };
			var nChaCross = new Node { Station = st5 };
			var nEmb = new Node { Station = st6 };
			var nTem = new Node { Station = st7 };
			var nBla = new Node { Station = st8 };
			var nManHouse = new Node { Station = st9 };
			var nCanStr = new Node { Station = st10 };
			var nMon = new Node { Station = st11 };
			var nChanLane = new Node { Station = st12 };
			var nStP = new Node { Station = st13 };
			var nBank = new Node { Station = st14 };

			nLestSq.Connected.Add(nCovGrdn);
			nLestSq.Connected.Add(nTotCRd);
			nLestSq.Connected.Add(nChaCross);

			nTotCRd.Connected.Add(nLestSq);

			nCovGrdn.Connected.Add(nLestSq);
			nCovGrdn.Connected.Add(nHol);

			nHol.Connected.Add(nChanLane);
			nHol.Connected.Add(nCovGrdn);

			nChanLane.Connected.Add(nStP);
			nChanLane.Connected.Add(nHol);

			nStP.Connected.Add(nChanLane);
			nStP.Connected.Add(nBank);

			nBank.Connected.Add(nStP);
			nBank.Connected.Add(nMon);

			nMon.Connected.Add(nBank);
			nMon.Connected.Add(nCanStr);

			nCanStr.Connected.Add(nMon);
			nCanStr.Connected.Add(nManHouse);

			nManHouse.Connected.Add(nCanStr);
			nManHouse.Connected.Add(nBla);

			nBla.Connected.Add(nManHouse);
			nBla.Connected.Add(nTem);

			nTem.Connected.Add(nEmb);
			nTem.Connected.Add(nBla);

			nEmb.Connected.Add(nTem);
			nEmb.Connected.Add(nChaCross);

			nChaCross.Connected.Add(nEmb);
			nChaCross.Connected.Add(nLestSq);

			var graph = new List<Node>();
			graph.AddRange(new[] { nLestSq, nTotCRd, nCovGrdn, nManHouse, nChanLane, nChaCross, nEmb, nBla, nStP, nTem, nHol, nMon, nBank, nCanStr });

			return graph;
		}
	}
}
