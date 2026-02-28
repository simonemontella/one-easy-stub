using Microsoft.EntityFrameworkCore;
using Shared.DTO;
using Shared.Models;
using WebBackend.Data;

namespace WebBackend.Services {
	public interface IClienteService {
		Task<List<ClienteListDTO>> GetAllAsync();
		Task<ClienteDTO?> GetByIdAsync(int id);
		Task<ClienteDTO> CreateAsync(CreateClienteDTO dto);
		Task<ClienteDTO> UpdateAsync(int id, UpdateClienteDTO dto);
		Task<bool> DeleteAsync(int id);
	}

	public class ClienteService : IClienteService {
		private readonly OneEasyStubContext _context;

		public ClienteService(OneEasyStubContext context) {
			_context = context;
		}

		public async Task<List<ClienteListDTO>> GetAllAsync() {
			var clienti = await _context.Clienti.ToListAsync();
			return clienti.Select(MapToListDTO).ToList();
		}

		public async Task<ClienteDTO?> GetByIdAsync(int id) {
			var cliente = await _context.Clienti.FindAsync(id);
			if (cliente == null)
				return null;

			return MapToDTO(cliente);
		}

		public async Task<ClienteDTO> CreateAsync(CreateClienteDTO dto) {
			var cliente = new Cliente {
				RagioneSociale = dto.RagioneSociale,
				Email = dto.Email,
				Telefono = dto.Telefono,
				Indirizzo = dto.Indirizzo,
				Citta = dto.Citta,
				Cap = dto.Cap,
				Provincia = dto.Provincia
			};

			_context.Clienti.Add(cliente);
			await _context.SaveChangesAsync();

			return MapToDTO(cliente);
		}

		public async Task<ClienteDTO> UpdateAsync(int id, UpdateClienteDTO dto) {
			var cliente = await _context.Clienti.FindAsync(id);
			if (cliente == null)
				throw new InvalidOperationException($"Cliente con ID {id} non trovato");

			cliente.RagioneSociale = dto.RagioneSociale;
			cliente.Email = dto.Email;
			cliente.Telefono = dto.Telefono;
			cliente.Indirizzo = dto.Indirizzo;
			cliente.Citta = dto.Citta;
			cliente.Cap = dto.Cap;
			cliente.Provincia = dto.Provincia;

			_context.Clienti.Update(cliente);
			await _context.SaveChangesAsync();

			return MapToDTO(cliente);
		}

		public async Task<bool> DeleteAsync(int id) {
			var cliente = await _context.Clienti.FindAsync(id);
			if (cliente == null)
				return false;

			_context.Clienti.Remove(cliente);
			await _context.SaveChangesAsync();
			return true;
		}

		private static ClienteDTO MapToDTO(Cliente cliente) {
			return new ClienteDTO {
				Id = cliente.ID,
				RagioneSociale = cliente.RagioneSociale,
				Email = cliente.Email,
				Telefono = cliente.Telefono,
				Indirizzo = cliente.Indirizzo,
				Citta = cliente.Citta,
				Cap = cliente.Cap,
				Provincia = cliente.Provincia
			};
		}

		private static ClienteListDTO MapToListDTO(Cliente cliente) {
			return new ClienteListDTO {
				Id = cliente.ID,
				RagioneSociale = cliente.RagioneSociale,
				Email = cliente.Email,
				Citta = cliente.Citta
			};
		}
	}
}
