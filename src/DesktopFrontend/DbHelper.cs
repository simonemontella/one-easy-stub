using System.Data.SqlClient;

namespace DesktopFrontend {
	public class DbHelper {
		private static string _connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=OneEasyStub;Integrated Security=True;";

		public static string GetConnectionString() {
			return _connectionString;
		}

		public static void SetConnectionString(string connectionString) {
			_connectionString = connectionString;
		}

		public static SqlConnection GetConnection() {
			return new SqlConnection(_connectionString);
		}

		public static bool TestConnection() {
			try {
				using (var connection = GetConnection()) {
					connection.Open();
					return true;
				}
			} catch {
				return false;
			}
		}
	}
}
