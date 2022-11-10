
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WishesApp_Core.Model;

namespace WishesApp_Core.DAO
{
     class WishesAdoDao : IWishesDao
    {
        private const string CONN_STRING = @"Data Source = C:/Users/WIN 10/source/repos/WishesApp/DB/wishes.db";
        public bool AddWish(Wish wish)
        {
            using SQLiteConnection conn = new SQLiteConnection(CONN_STRING);
            conn.Open();

            SQLiteCommand command = conn.CreateCommand();

            command.CommandText = "INSERT INTO Wishes " +
            "(Name, Age, Wish, Amount) VALUES " +
            "(@name, @age, @wish, @amount)";

            command.Parameters.Add("name", System.Data.DbType.String).Value = wish.Name;
            command.Parameters.Add("age", System.Data.DbType.Int32).Value = wish.Age;
            command.Parameters.Add("wish", System.Data.DbType.String).Value = wish.WishName;
            command.Parameters.Add("amount", System.Data.DbType.Int32).Value = wish.Amount;

            if (command.ExecuteNonQuery() != 1)
                return false;

            return true;
        }

        public IEnumerable<Wish> GetWishes()
        {
            List<Wish> wishes = new List<Wish>();

            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "select * from Wishes order by Amount desc";

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                wishes.Add(
                new Wish
                {
                    ID = reader.GetInt32(reader.GetOrdinal("ID")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Age = reader.GetInt32(reader.GetOrdinal("Age")),
                    WishName = reader.GetString(reader.GetOrdinal("Wish")),
                    Amount = reader.GetInt32(reader.GetOrdinal("Amount"))
                }
                );
            }
            return wishes;
        }

        public bool ModifyWish(Wish wish)
        {
            using SQLiteConnection conn = new SQLiteConnection(CONN_STRING);
            conn.Open();

            SQLiteCommand command = conn.CreateCommand();

            command.CommandText = "UPDATE Wishes SET " +
            "Name=@name, Age=@age, Wish=@wish, Amount=@amount " +
            "WHERE ID=@id";

            command.Parameters.Add("name", System.Data.DbType.String).Value = wish.Name;
            command.Parameters.Add("age", System.Data.DbType.Int32).Value = wish.Age;
            command.Parameters.Add("wish", System.Data.DbType.String).Value = wish.WishName;
            command.Parameters.Add("amount", System.Data.DbType.Int32).Value = wish.Amount;
            command.Parameters.Add("id", System.Data.DbType.Int32).Value = wish.ID;

            if (command.ExecuteNonQuery() != 1)
                return false;

            return true;
        }
    }
}
