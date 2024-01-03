using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    class HiveDefender : Bee
    {

        public override float CostPerShift => base.CostPerShift;

        protected override void DoJob()
        {
            base.DoJob();
        }

        public HiveDefender()
            :base("Hive Defender")
        {

        }

 

    }
}
