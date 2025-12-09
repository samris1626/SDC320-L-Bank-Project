/*********************************************
* Name: Samantha Riser
* Date: 12/08/2025
* Assignment: SDC320L - WK 4
*
* Provides SQLite database helper methods for
* CRUD operations with Account objects.
*/

using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace BankProject
{
    public class AccountRecord
    {
        public int Id { get; set; }
        public Account Account { get; set; }

        public AccountRecord(int id, Account account)
        {
            Id = id;
            Account = account;
        }
    }

    public static class DatabaseHelper
    {
        private const string DbFile = "BankAccounts.db";

        public static void InitializeDatabase()
        {
            using var connection = new SQLiteConnection($"Data Source={DbFile}");
            connection.Open();

            string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS Accounts (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    OwnerName TEXT NOT NULL,
                    Address TEXT,
                    Phone TEXT,
                    Email TEXT,
                    AccountType TEXT,
                    Balance REAL
                );";

            using var command = new SQLiteCommand(createTableQuery, connection);
            command.ExecuteNonQuery();
        }

        public static void AddAccount(Account account)
        {
            using var connection = new SQLiteConnection($"Data Source={DbFile}");
            connection.Open();

            string insertQuery = @"
                INSERT INTO Accounts (OwnerName, Address, Phone, Email, AccountType, Balance)
                VALUES (@OwnerName, @Address, @Phone, @Email, @AccountType, @Balance);";

            using var command = new SQLiteCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@OwnerName", account.OwnerName);
            command.Parameters.AddWithValue("@Address", account.Contact.Address);
            command.Parameters.AddWithValue("@Phone", account.Contact.Phone);
            command.Parameters.AddWithValue("@Email", account.Contact.Email);
            command.Parameters.AddWithValue("@AccountType", account.GetType().Name);
            command.Parameters.AddWithValue("@Balance", account.Balance);

            command.ExecuteNonQuery();
        }

        public static List<AccountRecord> GetAllAccounts()
        {
            List<AccountRecord> records = new List<AccountRecord>();
            using var connection = new SQLiteConnection($"Data Source={DbFile}");
            connection.Open();

            string selectQuery = "SELECT * FROM Accounts;";
            using var command = new SQLiteCommand(selectQuery, connection);
            using SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string owner = reader["OwnerName"].ToString();
                string address = reader["Address"].ToString();
                string phone = reader["Phone"].ToString();
                string email = reader["Email"].ToString();
                string accountType = reader["AccountType"].ToString();
                decimal balance = Convert.ToDecimal(reader["Balance"]);

                ContactInfo contact = new ContactInfo(address, phone, email);
                Account account = accountType switch
                {
                    "CheckingAccount" => new CheckingAccount(owner, contact, balance),
                    "SavingsAccount" => new SavingsAccount(owner, contact, balance),
                    _ => null
                };

                if (account != null)
                    records.Add(new AccountRecord(id, account));
            }

            return records;
        }

        public static void UpdateAccountBalance(int id, decimal newBalance)
        {
            using var connection = new SQLiteConnection($"Data Source={DbFile}");
            connection.Open();

            string updateQuery = "UPDATE Accounts SET Balance = @Balance WHERE Id = @Id;";
            using var command = new SQLiteCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@Balance", newBalance);
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
        }

        public static void DeleteAccount(int id)
        {
            using var connection = new SQLiteConnection($"Data Source={DbFile}");
            connection.Open();

            string deleteQuery = "DELETE FROM Accounts WHERE Id = @Id;";
            using var command = new SQLiteCommand(deleteQuery, connection);
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
        }
    }
}
