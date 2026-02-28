using Shared.DTO;
using Shared.Models;

using WebBackend.Services;

namespace WebBackend.Endpoints {
	public static class OrdiniEndpoints {
		public static void MapOrdiniEndpoints(this WebApplication app) {
			var group = app.MapGroup("/ordini").WithTags("Ordini");

			group.MapGet("/", GetAll);
			group.MapGet("/{id:int}", GetById);
			group.MapPost("/", Create);
			group.MapDelete("/{id:int}", Delete);

			group.MapPost("/{ordineId:int}/linee", AddLinea);
			group.MapPut("/{ordineId:int}/linee/{lineaId:int}", UpdateLinea);
			group.MapDelete("/{ordineId:int}/linee/{lineaId:int}", DeleteLinea);
		}

		private static async Task<IResult> GetAll(IOrdineService service) {
			try {
				var ordini = await service.GetAllAsync();
				return Results.Ok(ordini);
			} catch (Exception ex) {
				return Results.Problem(detail: ex.Message, statusCode: 500);
			}
		}

		private static async Task<IResult> GetById(int id, IOrdineService service) {
			try {
				var ordine = await service.GetByIdAsync(id);
				if (ordine == null)
					return Results.NotFound();

				return Results.Ok(ordine);
			} catch (Exception ex) {
				return Results.Problem(detail: ex.Message, statusCode: 500);
			}
		}

		private static async Task<IResult> Create(CreateOrdineDTO dto, IOrdineService service) {
			try {
				var ordine = await service.CreateAsync(dto);
				return Results.Created($"/ordini/{ordine.Id}", ordine);
			} catch (InvalidOperationException ex) {
				return Results.BadRequest(ex.Message);
			} catch (Exception ex) {
				return Results.Problem(detail: ex.Message, statusCode: 500);
			}
		}

		private static async Task<IResult> Delete(int id, IOrdineService service) {
			try {
				var deleted = await service.DeleteAsync(id);
				if (!deleted)
					return Results.NotFound();

				return Results.NoContent();
			} catch (Exception ex) {
				return Results.Problem(detail: ex.Message, statusCode: 500);
			}
		}

		private static async Task<IResult> AddLinea(int ordineId, LineaOrdine linea, IOrdineService service) {
			try {
				await service.AddLineaAsync(ordineId, linea);
				return Results.Created();
			} catch (InvalidOperationException ex) {
				return Results.BadRequest(ex.Message);
			} catch (Exception ex) {
				return Results.Problem(detail: ex.Message, statusCode: 500);
			}
		}

		private static async Task<IResult> UpdateLinea(int ordineId, int lineaId, LineaOrdine linea, IOrdineService service) {
			try {
				await service.UpdateLineaAsync(ordineId, lineaId, linea);
				return Results.Ok();
			} catch (InvalidOperationException ex) {
				return Results.BadRequest(ex.Message);
			} catch (Exception ex) {
				return Results.Problem(detail: ex.Message, statusCode: 500);
			}
		}

		private static async Task<IResult> DeleteLinea(int ordineId, int lineaId, IOrdineService service) {
			try {
				var deleted = await service.DeleteLineaAsync(ordineId, lineaId);
				if (!deleted)
					return Results.NotFound();

				return Results.NoContent();
			} catch (Exception ex) {
				return Results.Problem(detail: ex.Message, statusCode: 500);
			}
		}
	}
}
