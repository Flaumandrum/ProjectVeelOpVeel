using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using ProjectVeelOpVeel.MijnKlasses;

namespace ProjectVeelOpVeel.MijnKlasses
{
    class MijnDB
    {
        // Velden 
        static string _mijnConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\benjen.edu.local\Benedictuspoort$\Personeel\tom.adriaens\Documenten\databanken\Access Databanken\VeelOpVeel.accdb";
        OleDbConnection _conn = new OleDbConnection(_mijnConn);

        //Properties

        // functies en methoden
        public List<Persoon> HaalPersonenOp()
        {
            List<Persoon> antwoord = new List<Persoon>();

            string sql = "SELECT * FROM Persoon";
            OleDbCommand commando = new OleDbCommand(sql, _conn);
            OleDbDataReader mijnReader;

            int ontvId = -1;
            string ontvNaam;
            List<Sport> sports = new List<Sport>();

            _conn.Open();

            mijnReader = commando.ExecuteReader();

            while(mijnReader.Read())
            {
                ontvId = Convert.ToInt32(mijnReader["Id"]);
                ontvNaam = Convert.ToString(mijnReader["Naam"]);

                sports = HaalSportVanPersoonOp(ontvId);

            }

            _conn.Close();

            return antwoord;
        }

        public List<Sport> HaalSportVanPersoonOp(int idPersoon)
        {
            List<Sport> antwoord = new List<Sport>();

            string sql = "SELECT IdSport FROM PersoonSport WHERE IdPersoon = " + Convert.ToString(idPersoon)+ "";
            OleDbCommand commando = new OleDbCommand(sql, _conn);
            OleDbDataReader mijnReader;
            int idSport = -1;

            mijnReader = commando.ExecuteReader();

            while (mijnReader.Read())
            {
                idSport = Convert.ToInt32(mijnReader["IdSport"]);



            }


            return antwoord;
        }

        public Sport HaalSportOp( int IdSport)
        {
            Sport antwoord;
            string sql = "SELECT Naam FROM Sport WHERE Id = " + Convert.ToString(IdSport) + "";

            return antwoord;
        }

        //Constructor
        public MijnDB () { }

    }
}
