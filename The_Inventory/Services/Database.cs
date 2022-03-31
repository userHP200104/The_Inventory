using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using The_Inventory.Models;

namespace The_Inventory.Services
{
	public class Database
	{

		// configuration to connect to localhost database
		private static string serverConfiguration = @"server=localhost;port=8889;userid=root;password=root;database=TheInventory;";

		// test our database connection is working by returning the version of our database
		public static string GetVersion()
		{
			// creating a new connection to our db using our config and NuGet package
			var con = new MySqlConnection(serverConfiguration);
			con.Open();


			return con.ServerVersion;
		}

		//get all our chemicals

		public static List<Chemical> GetAllChemicals()
		{
			// creating a new connection to our db using our config and NuGet package
			using var con = new MySqlConnection(serverConfiguration);
			con.Open();

			// set up our query

			string sql = "SELECT * FROM chemical WHERE location_id = '1';";
			using var cmd = new MySqlCommand(sql, con); // performs this command which is sql and do it in the config

			using MySqlDataReader reader = cmd.ExecuteReader();

			var results = new List<Chemical>();

			while (reader.Read())
			{
				var chemical = new Chemical(reader.GetInt32(3))
				{
					Id = reader.GetInt32(0),
					LocationId = reader.GetInt32(1),
					Name = reader.GetString(2),
					Cost = reader.GetInt32(4),
					State = reader.GetString(5),
					Category = reader.GetString(6),
					Image = reader.GetString(7)

				};

				results.Add(chemical);
			}

			return results;

		}

		public static void UpdateChemicalQuantity(int id, int newQuantity)
		{
			using var con = new MySqlConnection(serverConfiguration);
			con.Open();

			string sql = $"UPDATE chemical SET quantity = @quantity WHERE id = @id";
			using var cmd = new MySqlCommand(sql, con);

			cmd.Parameters.AddWithValue("@id", id);
			cmd.Parameters.AddWithValue("@count", newQuantity);

			cmd.Prepare();
			cmd.ExecuteNonQuery();

		}

		public static List<Reaction> GetAllReactions()
		{
			// creating a new connection to our db using our config and NuGet package
			using var con = new MySqlConnection(serverConfiguration);
			con.Open();

			// set up our query

			string sql = "SELECT * FROM reaction;";
			using var cmd = new MySqlCommand(sql, con); // performs this command which is sql and do it in the config

			using MySqlDataReader reader = cmd.ExecuteReader();

			var results = new List<Reaction>();

			while (reader.Read())
			{
				var reaction = new Reaction()
				{
					Id = reader.GetInt32(0),
					Name = reader.GetString(1),
					Image = reader.GetString(15),
					State = reader.GetString(16),
					Category = reader.GetString(17)

				};

				var rawChemical = new List<string>();
				rawChemical.Add(reader.GetString(2)); // chemical 1
				rawChemical.Add(reader.GetString(4)); // chemical 2
				rawChemical.Add(reader.GetString(6)); // chemical 3
				rawChemical.Add(reader.GetString(8)); // chemical 4
				rawChemical.Add(reader.GetString(10)); // chemical 5
				rawChemical.Add(reader.GetString(12)); // chemical 6

				reaction.RawChemical = rawChemical;

				//var rawChemicalQuantity = new List<string>();
				//rawChemical.Add(reader.GetString(3)); // chemical 1
				//rawChemical.Add(reader.GetString(5)); // chemical 2
				//rawChemical.Add(reader.GetString(7)); // chemical 3
				//rawChemical.Add(reader.GetString(9)); // chemical 4
				//rawChemical.Add(reader.GetString(11)); // chemical 5
				//rawChemical.Add(reader.GetString(13)); // chemical 6

				//reaction.RawChemicalQuantity = rawChemicalQuantity;

				results.Add(reaction);
			}

			return results;

		}


		public static void CreateReaction(string name, string state, string catergory)
        {
			// creating a new connection to our db using our config and NuGet package
			using var con = new MySqlConnection(serverConfiguration);
			con.Open();

			// set up our query

			string sql = "SELECT * FROM chemical WHERE name = @name AND location_id = 1;";

			using var cmd = new MySqlCommand(sql, con); 

			cmd.Parameters.AddWithValue("@name", name);

			using MySqlDataReader reader = cmd.ExecuteReader();

			var nameCheck = "";
			var currentQuantity = 0;

			while (reader.Read())
			{

				nameCheck = reader.GetString(2);
				currentQuantity = reader.GetInt32(3);

			}

			con.Close();

			if (nameCheck == name)
			{
				Console.WriteLine("I made it");
			}


            Console.WriteLine(name);

            if (nameCheck == name)
            {
                UpdateChemicalQuantity(name, currentQuantity);
            }
            else
            {
                InsertNewChemical(name, state, catergory);
            }
        }

		public static void UpdateChemicalQuantity(string name, int currentQuantity)
        {
			// creating a new connection to our db using our config and NuGet package
			using var con = new MySqlConnection(serverConfiguration);
			con.Open();

			string sql = "UPDATE `chemical` SET `quantity`=@currentQuantity+1 WHERE `name` = @name AND `location_id` = '1';";

			using var cmd = new MySqlCommand(sql, con);

			cmd.Parameters.AddWithValue("@name", name);
			cmd.Parameters.AddWithValue("@currentQuantity", currentQuantity);

			cmd.Prepare();
			cmd.ExecuteNonQuery();
		}

		public static void InsertNewChemical(string name, string state, string catergory)
        {
			// creating a new connection to our db using our config and NuGet package
			using var con = new MySqlConnection(serverConfiguration);
			con.Open();

			string sql= "INSERT INTO `chemical` (`location_id`, `name`, `quantity`, `cost`, `state`, `catergory`, `image`) VALUES ('1', @name, '1', '50', @state, @catergory, '/');";

			using var cmd = new MySqlCommand(sql, con);

			cmd.Parameters.AddWithValue("@name", name);
			cmd.Parameters.AddWithValue("@state", state);
			cmd.Parameters.AddWithValue("@catergory", catergory);

			cmd.Prepare();
			cmd.ExecuteNonQuery();
		}


		public static List<string> GetRawChemical(string name)
        {
			// creating a new connection to our db using our config and NuGet package
			using var con = new MySqlConnection(serverConfiguration);
			con.Open();

			// set up our query

			string sql = "SELECT * FROM reaction WHERE name = @name;";

			using var cmd = new MySqlCommand(sql, con); 

			cmd.Parameters.AddWithValue("@name", name);

			using MySqlDataReader reader = cmd.ExecuteReader();

			var rawChemical = new List<string>();

			while (reader.Read())
			{
			
				rawChemical.Add(reader.GetString(2)); // chemical 1
				rawChemical.Add(reader.GetString(4)); // chemical 2
				rawChemical.Add(reader.GetString(6)); // chemical 3
				rawChemical.Add(reader.GetString(8)); // chemical 4
				rawChemical.Add(reader.GetString(10)); // chemical 5
				rawChemical.Add(reader.GetString(12)); // chemical 6



			}
				return rawChemical;
		}

		public static int GetQuantity(string name)
        {
			using var con = new MySqlConnection(serverConfiguration);
			con.Open();

			// set up our query

			string sql = "SELECT * FROM chemical WHERE name = @name AND location_id = 1;";

			using var cmd = new MySqlCommand(sql, con); 

			cmd.Parameters.AddWithValue("@name", name);

			using MySqlDataReader reader = cmd.ExecuteReader();

			var currentQuantity = 0;


			while (reader.Read())
			{
				currentQuantity = reader.GetInt32(3);

			}

			con.Close();

			return currentQuantity;
		}

		public static void DecreaseRawChemical(string name)
        {

			var currentQuantity = GetQuantity(name);

			using var con = new MySqlConnection(serverConfiguration);
			con.Open();

			// set up our query

			string sql = "UPDATE `chemical` SET `quantity`=@currentQuantity-1 WHERE `name` = @name AND `location_id` = '1';";

			using var cmd = new MySqlCommand(sql, con); 


			cmd.Parameters.AddWithValue("@name", name);
			cmd.Parameters.AddWithValue("@currentQuantity", currentQuantity);


			cmd.Prepare();
			cmd.ExecuteNonQuery();
		}

		public static bool isLocationActive(string name)
        {
			using var con = new MySqlConnection(serverConfiguration);
			con.Open();

			// set up our query

			string sql = "SELECT location_active FROM location WHERE name = @name;";

			using var cmd = new MySqlCommand(sql, con);

			cmd.Parameters.AddWithValue("@name", name);

			using MySqlDataReader reader = cmd.ExecuteReader();

			var isActive = false;


			while (reader.Read())
			{
				isActive = reader.GetBoolean(0);

			}

			con.Close();

            if (isActive)
            {
				return true;
            }
			else
            {
				return false;
            }
		}

		public static List<Location> getActiveLocation()
        {
			using var con = new MySqlConnection(serverConfiguration);
			con.Open();

			// set up our query

			string sql = "SELECT * FROM location;";

			using var cmd = new MySqlCommand(sql, con);

			using MySqlDataReader reader = cmd.ExecuteReader();

			var location = " ";

			var results = new List<Location>();

			while (reader.Read())
			{
				location = reader.GetString(1);

                if (isLocationActive(location))
                {
					var activeLocation = new Location()
					{
						Name = (reader.GetString(1)),
						Address = (reader.GetString(2)),
						Money = (reader.GetInt32(3)),
						LocationActive = (reader.GetBoolean(4))

					};

					results.Add(activeLocation);
				}
			}

			con.Close();

			return results;
		}

		public static List<Location> getAllLocations()
		{
			using var con = new MySqlConnection(serverConfiguration);
			con.Open();

			// set up our query

			string sql = "SELECT * FROM location;";

			using var cmd = new MySqlCommand(sql, con);

			using MySqlDataReader reader = cmd.ExecuteReader();

			var location = " ";

			var results = new List<Location>();

			while (reader.Read())
			{
				location = reader.GetString(1);

					var activeLocation = new Location()
					{
						Name = (reader.GetString(1)),
						Address = (reader.GetString(2)),
						Money = (reader.GetInt32(3)),
						LocationActive = (reader.GetBoolean(4))

					};

					results.Add(activeLocation);
			}

			con.Close();

			return results;
		}

	}
}

