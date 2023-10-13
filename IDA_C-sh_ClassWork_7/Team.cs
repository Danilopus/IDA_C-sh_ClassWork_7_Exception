using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork_7
{
    internal class Team
    {
        House house_of_this_team;
        public List <IWorker> Team_list = new List<IWorker>();
        //public List<IWorker> Workers_list;
        public Team(): this((int)ServiceFunction.Get_Random(3,10)) { }
            public Team (int workers_quantity)
        {
            Team_list.Add(new TeamLeader());
            for (int i = 1; i <= workers_quantity; i++) 
            { Team_list.Add(new Worker()); }
        }
        public House GetHouse() 
        {
            house_of_this_team = new House();
            return house_of_this_team;
        }
        public bool Construct(House house_obj)
        {
            if (Team_list.Count < 2) throw new Exception("Team without workers");
            
            //int worker_at_duty = 
            //try
            //{
                Team_list[1].Construct(house_obj);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //};

            return true;
        }

    }
}
