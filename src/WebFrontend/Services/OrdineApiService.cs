using Shared.DTO;
using Shared.Models;

namespace WebFrontend.Services {
	public interface IOrdineApiService {
		Task<List<OrdineDTO>?> GetAllAsync();
		Task<OrdineDTO?> GetByIdAsync(int id);
		Task<OrdineDTO> CreateAsync(CreateOrdineDTO dto);
		Task DeleteAsync(int id);
		Task AddLineaAsync(int ordineId, LineaOrdine linea);
		Task UpdateLineaAsync(int ordineId, int lineaId, LineaOrdine linea);
		Task DeleteLineaAsync(int ordineId, int lineaId);
	}

	public class OrdineApiService : IOrdineApiService {
		private readonly HttpClient _httpClient;
		private const string BaseUrl = "/ordini";

		public OrdineApiService(HttpClient httpClient) {
			_httpClient = httpClient;
		}

		public async Task<List<OrdineDTO>?> GetAllAsync() {
			try {
				var response = await _httpClient.GetAsync(BaseUrl);
				response.EnsureSuccessStatusCode();
				return await response.Content.ReadFromJsonAsync<List<OrdineDTO>>();
			} catch (Exception ex) {
				throw new HttpRequestException($"Errore nel recupero degli ordini: {ex.Message}", ex);
			}
		}

		public async Task<OrdineDTO?> GetByIdAsync(int id) {
			try {
				var response = await _httpClient.GetAsync($"{BaseUrl}/{id}");
				if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
					return null;

				response.EnsureSuccessStatusCode();
				return await response.Content.ReadFromJsonAsync<OrdineDTO>();
			} catch (Exception ex) {
				throw new HttpRequestException($"Errore nel recupero dell'ordine {id}: {ex.Message}", ex);
			}
		}

		public async Task<OrdineDTO> CreateAsync(CreateOrdineDTO dto) {
			try {
				var response = await _httpClient.PostAsJsonAsync(BaseUrl, dto);
				response.EnsureSuccessStatusCode();
				return (await response.Content.ReadFromJsonAsync<OrdineDTO>())!;
			} catch (Exception ex) {
				throw new HttpRequestException($"Errore nella creazione dell'ordine: {ex.Message}", ex);
			}
		}

		public async Task DeleteAsync(int id) {
			try {
				var response = await _httpClient.DeleteAsync($"{BaseUrl}/{id}");
				response.EnsureSuccessStatusCode();
			} catch (Exception ex) {
				throw new HttpRequestException($"Errore nell'eliminazione dell'ordine {id}: {ex.Message}", ex);
			}
		}

		public async Task AddLineaAsync(int ordineId, LineaOrdine linea) {
			try {
				var response = await _httpClient.PostAsJsonAsync($"{BaseUrl}/{ordineId}/linee", linea);
				response.EnsureSuccessStatusCode();
			} catch (Exception ex) {
				throw new HttpRequestException($"Errore nell'aggiunta della linea: {ex.Message}", ex);
			}
		}

		public async Task UpdateLineaAsync(int ordineId, int lineaId, LineaOrdine linea) {
			try {
				var response = await _httpClient.PutAsJsonAsync($"{BaseUrl}/{ordineId}/linee/{lineaId}", linea);
				response.EnsureSuccessStatusCode();
			} catch (Exception ex) {
				throw new HttpRequestException($"Errore nell'aggiornamento della linea: {ex.Message}", ex);
			}
		}

		public async Task DeleteLineaAsync(int ordineId, int lineaId) {
			try {
				var response = await _httpClient.DeleteAsync($"{BaseUrl}/{ordineId}/linee/{lineaId}");
				response.EnsureSuccessStatusCode();
			} catch (Exception ex) {
				throw new HttpRequestException($"Errore nell'eliminazione della linea: {ex.Message}", ex);
			}
		}
	}
}
