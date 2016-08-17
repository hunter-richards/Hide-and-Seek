using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace houselongexercise_pg332
{
    class Outside : Location
    {
        
        public Outside(string name, bool hot) : base(name)
        {
            this.hot = hot;
        }

        private bool hot;


        public override string Description
        {
            get
            {
                string newDescription = base.Description;
                if (hot)
                    newDescription += " It's very hot.";
                return newDescription;
            }
        }
        
    }
}
