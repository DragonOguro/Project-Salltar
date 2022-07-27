using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Project_Salltar
{
    public class Manipulation
    {
        SqlCommand cmd = new SqlCommand();
        Coneccion conec = new Coneccion();

        public void InsertPdt(string name, double preco, int quant) 
        {
            cmd.CommandText = "INSERT INTO Produtos(nomePdt, precoPdt, qntPdt) values (@nome, @preco, @quantidade)"; 
            cmd.Parameters.AddWithValue("@nome", name);
            cmd.Parameters.AddWithValue("@preco", preco);
            cmd.Parameters.AddWithValue("@quantidade", quant);

            try
            {

                cmd.Connection = conec.Conec();
                cmd.ExecuteNonQuery();
                conec.Desc();

            }
            catch (SqlException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        public void UpdatePdt(int code,string name, double preco, int quant)
        {
            cmd.CommandText = "UPDATE Produtos set nomePdt=@nome, precoPdt=@preco, qntPdt=@quantidade where code=@code";
            cmd.Parameters.AddWithValue("@nome", name);
            cmd.Parameters.AddWithValue("@code", code);
            cmd.Parameters.AddWithValue("@preco", preco);
            cmd.Parameters.AddWithValue("@quantidade", quant);

            try
            {

                cmd.Connection = conec.Conec();
                cmd.ExecuteNonQuery();
                conec.Desc();

            }
            catch (SqlException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public void RemovePdt(int code)
        {
            cmd.CommandText = "Delete From Produtos where code=@code";
            cmd.Parameters.AddWithValue("@code", code);

            try
            {
                cmd.Connection = conec.Conec();
                cmd.ExecuteNonQuery();
                conec.Desc();
            }
            catch (SqlException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public void SelectPdt()
        {
            cmd.CommandText = "Select * FROM Produtos";

            try
            {
                cmd.Connection = conec.Conec();
                var i = cmd.ExecuteReader(); 

                while (i.Read())
                {
                    Console.WriteLine($"\nCódigo:{i[0]}\nNome:{i[1]} \nPreço:{i[2]} \nQuantidade:{i[3]}" );
                }

                conec.Desc();
            }
            catch(SqlException exeption)
            {
                Console.WriteLine(exeption);
            }
        }


    }
}
