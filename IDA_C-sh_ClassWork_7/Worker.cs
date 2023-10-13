using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork_7
{
    internal class Worker : IWorker
    {
        public bool Construct(House house)
        {
            if (house.Build_state >= House.house_project.Length)
                throw new Exception("House is already constructed");            
            
            house.HouseParts_status_list.Add(House.house_project[house.Build_state]);
            
            house.Build_state++;
            
            return true;
        }
    }
}
