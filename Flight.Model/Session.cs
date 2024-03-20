using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Model
{
    public class Session
    {
        public Dictionary<PanelType, State> _states; //colectia de stari
        public PanelType InitialPanel { get; set; }

        private static Key _searchKey = new Key();

        public Dictionary<Key, PanelType> _transitions; //memorarea grafului //tranzitiile

        public Session()
        {
            _states = new Dictionary<PanelType, State>();
            _transitions = new Dictionary<Key, PanelType>();
        }

        public void Execute()
        {
            //obtinem panoul de start
            var currentPanel = _states[InitialPanel];
            
            do
            {
                
                currentPanel.Execute();

                _searchKey.Choice = State.Choice;
                _searchKey.From = currentPanel.Id;

                currentPanel = _states[_transitions[_searchKey]];
            }
            while (!currentPanel.IsFinal());
        }

        public void AddPanel(State s, PanelType type)
        {
            if (!_states.ContainsKey(type))
            {
                _states.Add(type, s);
            }
        }

        //adaugarea unei tranzitii de la panoul cu id-ul "from" si alegerea "choice"
        //catre panoul cu id-ul "to"
        public void AddTransition(PanelType from, int choice, PanelType to)
        {
            var key = new Key()
            {
                From = (int)from,
                Choice = choice
            };

            if (!_transitions.ContainsKey(key))
            {
                _transitions.Add(key, to);
            }
        }
    }
}

