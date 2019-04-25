using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVeelOpVeel.MijnKlasses
{
    class Persoon
    {
        //Velden
        int _id = -1;
        string _naam = "";
        List<Sport> _sporten = new List<Sport>();

        // properties
        public int PropId
        {
            get { return _id; }
        }

        public string PropNaam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public List<Sport> PropSporten
        {
            get { return _sporten; }
            set { _sporten = value; }
        }

        // functies en methoden 

        // constructor
        public Persoon (int ontvId, string ontvNaam, List<Sport> ontvSports)
        {
            _id = ontvId;
            _naam = ontvNaam;
            _sporten = ontvSports;
        }
            

    }
}
