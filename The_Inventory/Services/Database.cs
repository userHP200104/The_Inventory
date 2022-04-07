using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using The_Inventory.Models;
using XSystem.Security.Cryptography;

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

			string sql = "SELECT * FROM chemical";
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

				var rawChemicalQuantity = new List<int>();
				rawChemicalQuantity.Add(reader.GetInt32(3)); // chemical 1
				rawChemicalQuantity.Add(reader.GetInt32(5)); // chemical 2
				rawChemicalQuantity.Add(reader.GetInt32(7)); // chemical 3
				rawChemicalQuantity.Add(reader.GetInt32(9)); // chemical 4
				rawChemicalQuantity.Add(reader.GetInt32(11)); // chemical 5
				rawChemicalQuantity.Add(reader.GetInt32(13)); // chemical 6

				reaction.RawChemicalQuantity = rawChemicalQuantity;

				results.Add(reaction);
			}

			return results;

		}

		//public static List<Reaction> GetAllReactionsQunatity()
		//{
		//	// creating a new connection to our db using our config and NuGet package
		//	using var con = new MySqlConnection(serverConfiguration);
		//	con.Open();

		//	// set up our query

		//	string sql = "SELECT * FROM reaction;";
		//	using var cmd = new MySqlCommand(sql, con); // performs this command which is sql and do it in the config

		//	using MySqlDataReader reader = cmd.ExecuteReader();

		//	var results = new List<Reaction>();

		//	while (reader.Read())
		//	{
		//		var reaction = new Reaction()
		//		{
		//			Id = reader.GetInt32(0),
		//			Name = reader.GetString(1),
		//			Image = reader.GetString(15),
		//			State = reader.GetString(16),
		//			Category = reader.GetString(17)

		//		};

		//		var rawChemicalQuantity = new List<int>();
		//		rawChemicalQuantity.Add(reader.GetInt32(3)); // chemical 1
		//		rawChemicalQuantity.Add(reader.GetInt32(5)); // chemical 2
		//		rawChemicalQuantity.Add(reader.GetInt32(7)); // chemical 3
		//		rawChemicalQuantity.Add(reader.GetInt32(9)); // chemical 4
		//		rawChemicalQuantity.Add(reader.GetInt32(11)); // chemical 5
		//		rawChemicalQuantity.Add(reader.GetInt32(13)); // chemical 6

		//		reaction.RawChemicalQuantity = rawChemicalQuantity;

		//		results.Add(reaction);
		//	}

		//	return results;

		//}


		public static void CreateReaction(string name, string state, string catergory, int activeLocation)
        {
			// creating a new connection to our db using our config and NuGet package
			using var con = new MySqlConnection(serverConfiguration);
			con.Open();

			// set up our query

			string sql = "SELECT * FROM chemical WHERE name = @name AND location_id = @activeLocation;";

			using var cmd = new MySqlCommand(sql, con); 

			cmd.Parameters.AddWithValue("@name", name);
			cmd.Parameters.AddWithValue("@activeLocation", activeLocation);

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
                InsertNewChemical(name, state, catergory, activeLocation);
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

		public static void InsertNewChemical(string name, string state, string catergory, int activeLocation)
        {
			// creating a new connection to our db using our config and NuGet package
			using var con = new MySqlConnection(serverConfiguration);
			con.Open();

			 //TODO: Create cost calculation function

			string sql= "INSERT INTO `chemical` (`location_id`, `name`, `quantity`, `cost`, `state`, `catergory`, `image`, `access_key`) VALUES (@activeLocation, @name, '1', '50', @state, @catergory, '/', SHA('1234'));";

			using var cmd = new MySqlCommand(sql, con);

			cmd.Parameters.AddWithValue("@name", name);
			cmd.Parameters.AddWithValue("@state", state);
			cmd.Parameters.AddWithValue("@catergory", catergory);
			cmd.Parameters.AddWithValue("@activeLocation", activeLocation);

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

		public static int GetQuantity(string name, int locationId)
        {
			using var con = new MySqlConnection(serverConfiguration);
			con.Open();

			// set up our query

			string sql = "SELECT * FROM chemical WHERE name = @name AND location_id = @locationId;";

			using var cmd = new MySqlCommand(sql, con); 

			cmd.Parameters.AddWithValue("@name", name);
			cmd.Parameters.AddWithValue("@locationId", locationId);

			using MySqlDataReader reader = cmd.ExecuteReader();

			var currentQuantity = 0;


			while (reader.Read())
			{
				currentQuantity = reader.GetInt32(3);

			}

			con.Close();

			return currentQuantity;
		}

		public static void DecreaseRawChemical(string name, int activeLocation)
        {

			var currentQuantity = GetQuantity(name, activeLocation);

			using var con = new MySqlConnection(serverConfiguration);
			con.Open();

			// set up our query

			string sql = "UPDATE `chemical` SET `quantity`=@currentQuantity-1 WHERE `name` = @name AND `location_id` = @activeLocation;";

			using var cmd = new MySqlCommand(sql, con); 


			cmd.Parameters.AddWithValue("@name", name);
			cmd.Parameters.AddWithValue("@currentQuantity", currentQuantity);
			cmd.Parameters.AddWithValue("@activeLocation", activeLocation);


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

						Id = (reader.GetInt32(0)),
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

		public static void switchLocation(string name)
        {
			using var con = new MySqlConnection(serverConfiguration);
			con.Open();

			// set up our query

			string sql = "UPDATE `location` SET `location_active`= 1 WHERE `name` = @name";

			using var cmd = new MySqlCommand(sql, con);

			cmd.Parameters.AddWithValue("@name", name);


			cmd.Prepare();
			cmd.ExecuteNonQuery();

		}

		public static void deactivateAllLocations()
        {
			using var con = new MySqlConnection(serverConfiguration);
			con.Open();

			string sql = "UPDATE `location` SET `location_active`= 0 WHERE 1";

			using var cmd = new MySqlCommand(sql, con);


			cmd.Prepare();
			cmd.ExecuteNonQuery();

		}

		public static void chemicalIncrease(string name, int activeLocation, int newQuantity)
        {
			var currentQuantity = GetQuantity(name, activeLocation);

			using var con = new MySqlConnection(serverConfiguration);
			con.Open();

			// set up our query

			string sql = "UPDATE `chemical` SET `quantity`=@currentQuantity + @newQuantity WHERE `name` = @name AND `location_id` = @activeLocation;";

			using var cmd = new MySqlCommand(sql, con);


			cmd.Parameters.AddWithValue("@name", name);
			cmd.Parameters.AddWithValue("@activeLocation", activeLocation);
			cmd.Parameters.AddWithValue("@currentQuantity", currentQuantity);
			cmd.Parameters.AddWithValue("@newQuantity", newQuantity);

			cmd.Prepare();
			cmd.ExecuteNonQuery();
		}

		public static void moneyDecrease(string name, int activeLocation, int cost, int currentMoney, int newQuantity)
        {
			//var currentMoney= getMoney(activeLocation);
			//var cost = getChemicalCost(name, activeLocation);

			cost = cost * newQuantity;

			using var con = new MySqlConnection(serverConfiguration);
			con.Open();

			// set up our query

			string sql = "UPDATE `location` SET `money`=@currentMoney - @cost WHERE `id` = @activeLocation;";

			using var cmd = new MySqlCommand(sql, con);


			cmd.Parameters.AddWithValue("@activeLocation", activeLocation);
			cmd.Parameters.AddWithValue("@currentMoney", currentMoney);
			cmd.Parameters.AddWithValue("@cost", cost);

			cmd.Prepare();
			cmd.ExecuteNonQuery();

		}

		public static decimal getSolids(int locationId)
        {
			// creating a new connection to our db using our config and NuGet package
			using var con = new MySqlConnection(serverConfiguration);

			// set up our query

			string sql = "SELECT SUM(quantity) FROM chemical WHERE state = 'solid' AND location_id = @locationId;";

			using var cmd = new MySqlCommand(sql, con);

			con.Open();

			cmd.Parameters.AddWithValue("@locationId", locationId);


			decimal total = (decimal)cmd.ExecuteScalar();


			con.Close();

			return total;
		}

		public static decimal getLiquids(int locationId)
		{
			// creating a new connection to our db using our config and NuGet package
			using var con = new MySqlConnection(serverConfiguration);

			// set up our query

			string sql = "SELECT SUM(quantity) FROM chemical WHERE state = 'liquid' AND location_id = @locationId;";

			using var cmd = new MySqlCommand(sql, con);

			con.Open();

			cmd.Parameters.AddWithValue("@locationId", locationId);


			decimal total = (decimal)cmd.ExecuteScalar();


			con.Close();

			return total;
		}

		public static decimal getGases(int locationId)
		{
			// creating a new connection to our db using our config and NuGet package
			using var con = new MySqlConnection(serverConfiguration);

			// set up our query

			string sql = "SELECT SUM(quantity) FROM chemical WHERE state = 'gas' AND location_id = @locationId;";

			using var cmd = new MySqlCommand(sql, con);

			con.Open();

			cmd.Parameters.AddWithValue("@locationId", locationId);


			decimal total = (decimal)cmd.ExecuteScalar();


			con.Close();

			return total;
		}

		public static int GetPayValue(string name)
        {
			using var con = new MySqlConnection(serverConfiguration);
			con.Open();

			// set up our query

			string sql = "SELECT payment FROM reaction WHERE name = @name;";

			using var cmd = new MySqlCommand(sql, con);

			cmd.Parameters.AddWithValue("@name", name);

			using MySqlDataReader reader = cmd.ExecuteReader();

			var pay = 0;

			while (reader.Read())
			{
				pay = reader.GetInt32(0);

			}

			con.Close();

			return pay;
		}

		public static void Pay(string name, int activeLocation)
		{

			int pay = GetPayValue(name);

			using var con = new MySqlConnection(serverConfiguration);
			con.Open();

			// set up our query

			string sql = "UPDATE location SET money = money + @pay WHERE id = @activeLocation;";

			using var cmd = new MySqlCommand(sql, con);


			cmd.Parameters.AddWithValue("@activeLocation", activeLocation);
			cmd.Parameters.AddWithValue("@pay", pay);


			cmd.Prepare();
			cmd.ExecuteNonQuery();
		}

		public static bool CheckBuyAccess(string name, string access)
		{
			using var con = new MySqlConnection(serverConfiguration);
			con.Open();

			var sql = "SELECT access_key FROM chemical WHERE `name` = @name";
			using var cmd = new MySqlCommand(sql, con);

			cmd.Parameters.AddWithValue("@name", name);

			using MySqlDataReader reader = cmd.ExecuteReader();

			var passwordCheck = "";

			while (reader.Read())
			{
				passwordCheck = reader.GetString(0);
			}

			con.Close();

			var data = Encoding.ASCII.GetBytes(access);


			var hashData = new SHA1Managed().ComputeHash(data);

			var userInputHashCode = string.Empty;

			foreach (var key in hashData)
			{
				userInputHashCode += key.ToString("X2");
			}

			Console.WriteLine($"---------- Database Verify Code: {passwordCheck}");
			Console.WriteLine($"---------- Input Verify Code: {userInputHashCode}");

			if (passwordCheck.ToUpper() == userInputHashCode)
			{
				Console.WriteLine("Correct");
				return true;
			}
			else
			{
				Console.WriteLine("Incorrect");
				return false;
			}

		}

		public static bool CheckReactAccess(string name, string access)
		{
			using var con = new MySqlConnection(serverConfiguration);
			con.Open();

			var sql = "SELECT access_key FROM reaction WHERE `name` = @name";
			using var cmd = new MySqlCommand(sql, con);

			cmd.Parameters.AddWithValue("@name", name);

			using MySqlDataReader reader = cmd.ExecuteReader();

			var passwordCheck = "";

			while (reader.Read())
			{
				passwordCheck = reader.GetString(0);
			}

			con.Close();

			var data = Encoding.ASCII.GetBytes(access);


			var hashData = new SHA1Managed().ComputeHash(data);

			var userInputHashCode = string.Empty;

			foreach (var key in hashData)
			{
				userInputHashCode += key.ToString("X2");
			}

			Console.WriteLine($"---------- Database Verify Code: {passwordCheck}");
			Console.WriteLine($"---------- Input Verify Code: {userInputHashCode}");

			if (passwordCheck.ToUpper() == userInputHashCode)
			{
				Console.WriteLine("Correct");
				return true;
			}
			else
			{
				Console.WriteLine("Incorrect");
				return false;
			}

		}

	}
}

