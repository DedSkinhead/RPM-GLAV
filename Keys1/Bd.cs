using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keys
{
    internal class Bd
    {
        public Bd() { conn.Open(); }
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=keys;port=3306;User Id=root;password=12345");
        public List<Kabinet> Vse()
        {

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM keys.kabinet";
            DbDataReader reader = cmd.ExecuteReader();
            List<Kabinet> sp = new List<Kabinet>();
            if (reader.HasRows)
            {
                int count = 0;
                while (reader.Read())
                {
                    int IdkabIndex = reader.GetOrdinal("idkabinet");
                    int Idkab = reader.GetInt32(IdkabIndex);
                    int empIdIndex = reader.GetOrdinal("kabinetcol");
                    string empName = reader.GetString(empIdIndex);
                    int sosIdIndex = reader.GetOrdinal("sos");
                    int sosempName = reader.GetInt32(sosIdIndex);
                    Kabinet kabinet = new Kabinet(Idkab, empName, sosempName);
                    sp.Add(kabinet);
                    count++;
                }
            }
            return sp;

        }
        public List<String> Dob()
        {

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM keys.kabinet";
            DbDataReader reader = cmd.ExecuteReader();
            List<String> sp = new List<String>();
            if (reader.HasRows)
            {
                int count = 0;
                while (reader.Read())
                {
                    int empIdIndex = reader.GetOrdinal("kabinetcol");
                    string empName = reader.GetString(empIdIndex);
                    sp.Add(empName);
                    count++;
                }
            }
            return sp;

        }
        public void Bod(Kabinet kabin)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE keys.kabinet SET sos = @sos WHERE (kabinetcol = @grade)";
            MySqlParameter Param = new MySqlParameter("@sos", SqlDbType.Int);
            Param.Value = kabin.getSos();
            cmd.Parameters.Add(Param);
            MySqlParameter gradeParam = new MySqlParameter("@grade", SqlDbType.VarChar);
            gradeParam.Value = kabin.getNomer();
            cmd.Parameters.Add(gradeParam);
            int rowCount = cmd.ExecuteNonQuery();

        }
        public int id(int id)
        {

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT sos FROM keys.kabinet WHERE (idkabinet = @grade)";
            MySqlParameter gradeParam = new MySqlParameter("@grade", SqlDbType.VarChar);
            gradeParam.Value = id;
            cmd.Parameters.Add(gradeParam);
            DbDataReader reader = cmd.ExecuteReader();
            int sp=0;
            if (reader.HasRows)
            {
                reader.Read();
                    int sosIdIndex = reader.GetOrdinal("sos");
                    int sosempName = reader.GetInt32(sosIdIndex);
                    sp = sosempName;
            }
            return sp;

        }

    }
}
