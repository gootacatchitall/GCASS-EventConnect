﻿using System;
using System.Collections.Generic;
using GCASS_EventConnect_Ballot.Models;

namespace GCASS_EventConnect_Ballot.DAL
{
	public interface IBallotRepository : IDisposable
	{
		void Add(Ballot ballot);

		IEnumerable<Ballot> GetBallots();
	}
}

