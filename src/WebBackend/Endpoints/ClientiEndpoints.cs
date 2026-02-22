namespace WebBackend.Endpoints {
	public static class ClientiEndpoints {

		public static void MapClientiEndpoints(this WebApplication app) {
			var group = app.MapGroup("/clienti").WithTags("Clienti");

			group.MapGet("/", GetAll);
			group.MapGet("/{id:int}", GetById);
			group.MapPost("/", Create);
			group.MapPut("/{id:int}", Update);
			group.MapDelete("/{id:int}", Delete);
		}

		private static IResult GetAll() {
		}

		private static IResult GetById(int id) {
		}

		private static IResult Create() {
		}

		private static IResult Update(int id) {
		}

		private static IResult Delete(int id) {
		}
	}
}
