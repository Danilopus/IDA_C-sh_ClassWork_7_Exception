using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork_7
{
    internal class TeamLeader : IWorker
    {
        public bool Construct(House house)
        {
            Console.WriteLine("\nCurrent house status: {0}", (House.HouseProject)house.Build_state);            
            return house != null;
        }   
    }
}
