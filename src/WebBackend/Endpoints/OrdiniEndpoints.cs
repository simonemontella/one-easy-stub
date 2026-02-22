using Shared.DTO;
using Shared.Models;

namespace WebBackend.Endpoints {

	public static class OrdiniEndpoints {

		public static void MapOrdiniEndpoints(this WebApplication app) {
			var group = app.MapGroup("/ordini").WithTags("Ordini");

			group.MapGet("/", GetAll);
			group.MapGet("/{id:int}", GetById);
			group.MapGet("/cliente/{clienteId:int}", GetByCliente);
			group.MapPost("/", Create);
			group.MapPut("/{id:int}", Update);
			group.MapDelete("/{id:int}", Delete);
		}

		private static IResult GetAll() {
		}

		private static IResult GetById(int id) {
		}

		private static IResult GetByCliente(int clienteId) {
		}

		private static IResult Create() {
		}

		private static IResult Update(int id) {
		}

		private static IResult Delete(int id) {
		}

	}

}
