using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDevXamarin.Core.Models.Domain
{
    public class _Region
    {
        public string Name { get; set; }
        public List<State> States { get; set; }

        public void SetStatesOnRegion(List<State> states)
        {
            States = new List<State>();
            foreach (var state in states)
            {
                if (state.Region.Name == this.Name)
                {
                    try
                    {
                        States.Add(state);
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                  
                }
            }
        }

    }
}   
