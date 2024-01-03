using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class Bee
    {
        public virtual float CostPerShift { get; private set; }

        public string Job { get; private set; }
        
       

        public Bee(string job)
        {
            Job = job;
        }


        public void WorkTheNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPerShift))
            {
                DoJob();
            }
        }

        protected virtual void DoJob() { }
    }
}
