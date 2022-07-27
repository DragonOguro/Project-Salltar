using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;


namespace Project_Salltar
{
    class Coneccion
    {
        SqlConnection Jarves = new SqlConnection();

        public Coneccion()
        {
            Jarves.ConnectionString = @"User ID = aluno12; Password = aluno_5368; Data Source = localhost\SQLEXPRESS; Initial Catalog = Eproc_aluno12; Persist Security Info = True; Timeout = 120; TrustServerCertificate = True";
        }
        public SqlConnection Conec()
        {
            if (Jarves.State == System.Data.ConnectionState.Closed)
            {
                Jarves.Open();
            }

            return Jarves;

        }
        public SqlConnection Desc()
        {

            if (Jarves.State == System.Data.ConnectionState.Open)
            {
                Jarves.Close();
            }

            return Jarves;
        }

    }
}
