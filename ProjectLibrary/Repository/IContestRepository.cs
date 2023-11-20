﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ProjectLibrary.DataAccess;

namespace ProjectLibrary.Repository
{
    public interface IContestRepository
    {
        List<Contest> GetContests();
        void SaveContest(Contest c);
        Contest GetContestById(int id);
        void DeleteContest(Contest c);
        void UpdateContest(Contest c);
    }
}
