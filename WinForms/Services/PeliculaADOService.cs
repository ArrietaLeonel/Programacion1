using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using MySql.Data.MySqlClient;
using WinForms.Models.Pelicula;
using ZstdSharp;

namespace WinForms.Services
{
    public class PeliculaADOService
    {
        string connectionString = "server=127.0.0.1;user=root;password=;port=3306;database=programacion_1;";
        public async Task<List<Movie>?> GetAllAsync()
        {
           using(var connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();
                var command = new MySqlCommand("SELECT * FROM peliculas", connection);
                var reader = await command.ExecuteReaderAsync();
                List<Movie> peliculas = new List<Movie>();
                while (await reader.ReadAsync())
                {
                    Movie pelicula = new Movie
                    {
                        id = Convert.ToInt32(reader["id"]),
                        title = reader["titulo"].ToString(),
                        duration = Convert.ToInt32(reader["duracion"]),
                        cover = reader["portada"].ToString(),
                        qualification = Convert.ToDouble(reader["calificacion"])
                    };
                    peliculas.Add(pelicula);
                }
                return peliculas;

            }

        }
        public async Task<bool> DeleteAsync(int? id)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();
                var command = new MySqlCommand($"DELETE FROM peliculas WHERE {id}=id", connection);
                var rowsAffected = await command.ExecuteNonQueryAsync();
                if (rowsAffected > 0)
                    return true;
                else
                    return false;

            }

        }
        public async Task<bool> UpdateAsync(Movie movie)
        {
            //metodo no implementado
            return false;
        }
        public async Task<bool> AddAsync(Movie movie)
        {
            //metodo no implementado
            return false;
        }
    }
}
