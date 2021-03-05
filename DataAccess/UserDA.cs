using Dapper;
using Logic.Model;
using DataInterface;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class UserDA : IUserDA
    {
        const string connString = "User ID=postgres;Password=dino123;Host=localhost;Port=5432;Database=IdleGameDB;";


        public User Create(User user)
        {
            string sql = "INSERT INTO user_account VALUES (@Id, @Ip, @Username);";

            using (var connection = new NpgsqlConnection(connString))
            {
                var affectedRows = connection.Execute(sql, user);

                return user;
            }
        }

        public List<User> ReadAll()
        {
            string sql = "SELECT * FROM user_account;";

            using (var connection = new NpgsqlConnection(connString))
            {
                var users = connection.Query<User>(sql).ToList();

                return users;
            }
        }
        public int Delete(Guid id)
        {
            string sql = "DELETE FROM user_account WHERE id=@Id;";

            using (var connection = new NpgsqlConnection(connString))
            {
                var affectedRows = connection.Execute(sql, new { Id = id });
                return affectedRows;
            }
        }
    }
}
