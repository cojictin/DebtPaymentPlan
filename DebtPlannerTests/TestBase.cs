﻿using DebtPlanner;

namespace DebtPlannerTests
{
    public class TestBase
    {
        protected readonly DebtInfo a0 = new DebtInfo("A", 16000, 3.25M, 225);
        protected readonly DebtInfo a1 = new DebtInfo("B", 12000, 0, 125);
        protected readonly DebtInfo a2 = new DebtInfo("C", 6000, 3.5M, 182);
        protected readonly DebtInfo a3 = new DebtInfo("D", 4000, 12.25M, 50);
        protected readonly DebtInfo a4 = new DebtInfo("E", 2000, 15.55M, 200);
        protected readonly DebtInfo a5 = new DebtInfo("F", 1000, 22, 50);
        protected readonly DebtInfo a6 = new DebtInfo("G", 500, 22, 50);
        protected readonly DebtInfo a7 = new DebtInfo("H", 0, 50.3M, 250);
        protected readonly DebtInfo b8 = new DebtInfo("I", 13000, 12, 100);
    }
}