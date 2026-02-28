using Microsoft.EntityFrameworkCore;

using Shared.DTO;
using Shared.Models;

using WebBackend.Data;

namespace WebBackend.Services {
	public interface IOrdineService {
		Task<List<OrdineDTO>> GetAllAsync();
		Task<OrdineDTO?> GetByIdAsync(int id);
		Task<OrdineDTO> CreateAsync(CreateOrdineDTO dto);
		Task<bool> DeleteAsync(int id);
		Task AddLineaAsync(int ordineId, LineaOrdine linea);
		Task UpdateLineaAsync(int ordineId, int lineaId, LineaOrdine linea);
		Task<bool> DeleteLineaAsync(int ordineId, int lineaId);
	}

	public class OrdineService : IOrdineService {
		private readonly OneEasyStubContext _context;

		public OrdineService(OneEasyStubContext context) {
			_context = context;
		}

		public async Task<List<OrdineDTO>> GetAllAsync() {
			var ordini = await _context.Ordini
				.Include(o => o.Cliente)
				.ToListAsync();

			// Carica le linee separatamente per evitare problemi di mapping
			foreach (var ordine in ordini) {
				ordine.Linee = await _context.LineeOrdini
					.Where(l => l.OrdineID == ordine.ID)
					.ToListAsync();
			}

			return ordini.Select(MapToDTO).ToList();
		}

		public async Task<OrdineDTO?> GetByIdAsync(int id) {
			var ordine = await _context.Ordini
				.Include(o => o.Cliente)
				.FirstOrDefaultAsync(o => o.ID == id);

			if (ordine == null)
				return null;

			// Carica le linee separatamente
			ordine.Linee = await _context.LineeOrdini
				.Where(l => l.OrdineID == ordine.ID)
				.ToListAsync();

			return MapToDTO(ordine);
		}

		public async Task<OrdineDTO> CreateAsync(CreateOrdineDTO dto) {
			var cliente = await _context.Clienti.FindAsync(dto.ClienteId);
			if (cliente == null)
				throw new InvalidOperationException($"Cliente con ID {dto.ClienteId} non trovato");

			var ordine = new Ordine {
				ClienteID = dto.ClienteId,
				Data = dto.Data,
				Totale = dto.Totale,
				Linee = []
			};

			if (dto.Linee != null && dto.Linee.Count > 0) {
				foreach (var linea in dto.Linee) {
					ordine.Linee.Add(linea);
				}
			}

			_context.Ordini.Add(ordine);
			await _context.SaveChangesAsync();

			return MapToDTO(ordine);
		}

		public async Task<bool> DeleteAsync(int id) {
			var ordine = await _context.Ordini.FindAsync(id);
			if (ordine == null)
				return false;

			_context.Ordini.Remove(ordine);
			await _context.SaveChangesAsync();
			return true;
		}

		public async Task AddLineaAsync(int ordineId, LineaOrdine linea) {
			var ordine = await _context.Ordini
				.Include(o => o.Linee)
				.FirstOrDefaultAsync(o => o.ID == ordineId);

			if (ordine == null)
				throw new InvalidOperationException($"Ordine con ID {ordineId} non trovato");

			ordine.Linee.Add(linea);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateLineaAsync(int ordineId, int lineaId, LineaOrdine linea) {
			var storedLinea = await _context.LineeOrdini.FirstOrDefaultAsync(l => l.ID == lineaId && l.OrdineID == ordineId);

			if (storedLinea == null)
				throw new InvalidOperationException($"Linea con ID {lineaId} non trovata");

			storedLinea.Prodotto = linea.Prodotto;
			storedLinea.Quantita = linea.Quantita;
			storedLinea.PrezzoUnitario = linea.PrezzoUnitario;
			storedLinea.Subtotale = linea.Quantita * linea.PrezzoUnitario;

			await _context.SaveChangesAsync();
		}

		public async Task<bool> DeleteLineaAsync(int ordineId, int lineaId) {
			var linea = await _context.LineeOrdini.FirstOrDefaultAsync(l => l.ID == lineaId && l.OrdineID == ordineId);

			if (linea == null)
				return false;

			_context.LineeOrdini.Remove(linea);
			await _context.SaveChangesAsync();
			return true;
		}

			private static OrdineDTO MapToDTO(Ordine ordine) {
				return new OrdineDTO {
					Id = ordine.ID,
					ClienteId = ordine.ClienteID,
					ClienteRagioneSociale = ordine.Cliente?.RagioneSociale ?? "Sconosciuto",
					Data = ordine.Data,
					Totale = ordine.Totale,
					Linee = ordine.Linee?.ToList() ?? []
				};
			}

			}
		}
