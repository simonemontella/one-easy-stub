using Shared.DTO;
using WebBackend.Services;

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

		private static async Task<IResult> GetAll(IClienteService service) {
			try {
				var clienti = await service.GetAllAsync();
				return Results.Ok(clienti);
			} catch (Exception ex) {
				return Results.Problem(detail: ex.Message, statusCode: 500);
			}
		}

		private static async Task<IResult> GetById(int id, IClienteService service) {
			try {
				var cliente = await service.GetByIdAsync(id);
				if (cliente == null)
					return Results.NotFound();

				return Results.Ok(cliente);
			} catch (Exception ex) {
				return Results.Problem(detail: ex.Message, statusCode: 500);
			}
		}

		private static async Task<IResult> Create(CreateClienteDTO dto, IClienteService service) {
			try {
				var cliente = await service.CreateAsync(dto);
				return Results.Created($"/clienti/{cliente.Id}", cliente);
			} catch (Exception ex) {
				return Results.Problem(detail: ex.Message, statusCode: 500);
			}
		}

		private static async Task<IResult> Update(int id, UpdateClienteDTO dto, IClienteService service) {
			try {
				var cliente = await service.UpdateAsync(id, dto);
				return Results.Ok(cliente);
			} catch (InvalidOperationException) {
				return Results.NotFound();
			} catch (Exception ex) {
				return Results.Problem(detail: ex.Message, statusCode: 500);
			}
		}

		private static async Task<IResult> Delete(int id, IClienteService service) {
			try {
				var deleted = await service.DeleteAsync(id);
				if (!deleted)
					return Results.NotFound();

				return Results.NoContent();
			} catch (Exception ex) {
				return Results.Problem(detail: ex.Message, statusCode: 500);
			}
		}
	}
}
