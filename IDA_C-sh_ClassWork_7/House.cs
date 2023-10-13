using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork_7
{
    internal class House 
    {
        public int Build_state { get; set; } = 0;
        public List<IPart> HouseParts_status_list { get; set; } = new List<IPart>();
        public enum HouseProject
        {
            NULL, Basement, Wall1, Wall2, Wall3, Wall4,
            Door, Window1, Window2, Window3, Window4, Roof, _end_of_construction_
        }
        static public readonly IPart[] house_project = new IPart[] { new Basement(), new Walls(), new Walls(), new Walls(), new Walls(), 
        new Door(), new Window(), new Window(),new Window(),new Window(), new Roof()};

        public HouseProject House_project_ { set; get; } = HouseProject.NULL;


    }
    
}
