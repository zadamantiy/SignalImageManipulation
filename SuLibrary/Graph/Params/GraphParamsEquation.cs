using System.Collections.Generic;
using System.Linq;

namespace SuLibrary.Graph.Params
{
    public class GraphParamsEquation : GraphParams.GraphParams
    {
        private readonly Dictionary<string, double> _parameters;

        public GraphParamsEquation()
        {
            _parameters = new Dictionary<string, double>();
        }

        public void AddParameter(string name, double value)
        {
            _parameters.Add(name, value);
        }

        public bool ParameterExists(string name)
        {
            return _parameters.ContainsKey(name);
        }

        public double GetParameter(string name)
        {
            return _parameters[name];
        }

        public List<string> GetParametersList()
        {
            return _parameters.Keys.ToList();
        }
    }
}
