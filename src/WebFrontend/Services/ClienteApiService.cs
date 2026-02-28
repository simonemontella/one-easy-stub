using Shared.DTO;

namespace WebFrontend.Services {
	public interface IClienteApiService {
		Task<List<ClienteListDTO>?> GetAllAsync();
		Task<ClienteDTO?> GetByIdAsync(int id);
		Task<ClienteDTO> CreateAsync(CreateClienteDTO dto);
		Task<ClienteDTO> UpdateAsync(int id, UpdateClienteDTO dto);
		Task DeleteAsync(int id);
	}

	public class ClienteApiService : IClienteApiService {
		private readonly HttpClient _httpClient;
		private const string BaseUrl = "/clienti";

		public ClienteApiService(HttpClient httpClient) {
			_httpClient = httpClient;
		}

		public async Task<List<ClienteListDTO>?> GetAllAsync() {
			try {
				var response = await _httpClient.GetAsync(BaseUrl);
				response.EnsureSuccessStatusCode();
				return await response.Content.ReadFromJsonAsync<List<ClienteListDTO>>();
			} catch (Exception ex) {
				throw new HttpRequestException($"Errore nel recupero dei clienti: {ex.Message}", ex);
			}
		}

		public async Task<ClienteDTO?> GetByIdAsync(int id) {
			try {
				var response = await _httpClient.GetAsync($"{BaseUrl}/{id}");
				if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
					return null;

				response.EnsureSuccessStatusCode();
				return await response.Content.ReadFromJsonAsync<ClienteDTO>();
			} catch (Exception ex) {
				throw new HttpRequestException($"Errore nel recupero del cliente {id}: {ex.Message}", ex);
			}
		}

		public async Task<ClienteDTO> CreateAsync(CreateClienteDTO dto) {
			try {
				var response = await _httpClient.PostAsJsonAsync(BaseUrl, dto);
				response.EnsureSuccessStatusCode();
				return (await response.Content.ReadFromJsonAsync<ClienteDTO>())!;
			} catch (Exception ex) {
				throw new HttpRequestException($"Errore nella creazione del cliente: {ex.Message}", ex);
			}
		}

		public async Task<ClienteDTO> UpdateAsync(int id, UpdateClienteDTO dto) {
			try {
				var response = await _httpClient.PutAsJsonAsync($"{BaseUrl}/{id}", dto);
				response.EnsureSuccessStatusCode();
				return (await response.Content.ReadFromJsonAsync<ClienteDTO>())!;
			} catch (Exception ex) {
				throw new HttpRequestException($"Errore nell'aggiornamento del cliente {id}: {ex.Message}", ex);
			}
		}

		public async Task DeleteAsync(int id) {
			try {
				var response = await _httpClient.DeleteAsync($"{BaseUrl}/{id}");
				response.EnsureSuccessStatusCode();
			} catch (Exception ex) {
				throw new HttpRequestException($"Errore nell'eliminazione del cliente {id}: {ex.Message}", ex);
			}
		}
	}
}
