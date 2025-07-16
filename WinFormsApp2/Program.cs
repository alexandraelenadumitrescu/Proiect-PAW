using System.Data.SQLite;

namespace WinFormsApp2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static CosCumparaturi Cos;
        [STAThread]
        
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Produs produs = new Produs(1, "Laptop", 3500.99m, 2);
            Cos = new CosCumparaturi();
            Cos.produse = new List<Produs>();
            Cos.AdaugaProdus(produs);
            Cos.AdaugaProdus(new Produs(2, "Telefon", 1500.50m, 1));
            Cos.AdaugaProdus(new Produs(3, "Tableta", 1200.75m, 3));

            CosCumparaturi cos = new CosCumparaturi();

            InitializeDatabase();
            LoadFromDatabase(cos);
            Program.Cos = cos;

            Application.ApplicationExit += (sender, e) =>
            {
                SaveToDatabase(cos);
            };



            Application.Run(new Form1());
        }
        // Program.cs sau într-o clasă helper
        private const string connectionString = "Data Source=cos.db;Version=3;";

        public static void InitializeDatabase()
        {
            if (!File.Exists("cos.db"))
            {
                SQLiteConnection.CreateFile("cos.db");
            }

            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            string sql = @"CREATE TABLE IF NOT EXISTS Produse (
                    Cod INTEGER PRIMARY KEY,
                    Denumire TEXT NOT NULL,
                    Pret REAL NOT NULL,
                    Cantitate INTEGER NOT NULL
                  );";

            using var cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public static void LoadFromDatabase(CosCumparaturi cos)
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            string sql = "SELECT Cod, Denumire, Pret, Cantitate FROM Produse";
            using var cmd = new SQLiteCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var produs = new Produs
                {
                    Cod = reader.GetInt32(0),
                    Denumire = reader.GetString(1),
                    Pret = (decimal)reader.GetDouble(2),
                    Cantitate = reader.GetInt32(3)
                };

                cos.AdaugaProdus(produs);
            }
        }
        public static void SaveToDatabase(CosCumparaturi cos)
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            // Ștergem tot pentru simplitate
            using var deleteCmd = new SQLiteCommand("DELETE FROM Produse", conn);
            deleteCmd.ExecuteNonQuery();

            foreach (var produs in cos.ToList())
            {
                var insertCmd = new SQLiteCommand("INSERT INTO Produse (Cod, Denumire, Pret, Cantitate) VALUES (@c, @d, @p, @q)", conn);
                insertCmd.Parameters.AddWithValue("@c", produs.Cod);
                insertCmd.Parameters.AddWithValue("@d", produs.Denumire);
                insertCmd.Parameters.AddWithValue("@p", produs.Pret);
                insertCmd.Parameters.AddWithValue("@q", produs.Cantitate);
                insertCmd.ExecuteNonQuery();
            }
        }



    }
}