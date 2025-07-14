using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Languages;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Languages;
using MapsterMapper;

namespace IndieGameZone.Application.Services
{
	internal sealed class LanguageService : ILanguageService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public LanguageService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}
		public async Task CreateLanguage(LanguageForCreationDto languageForCreationDto, CancellationToken ct = default)
		{
			var languageEntity = mapper.Map<Languages>(languageForCreationDto);
			languageEntity.Id = Guid.NewGuid();
			repositoryManager.LanguageRepository.CreateLanguage(languageEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task DeleteLanguage(Guid id, CancellationToken ct = default)
		{
			var languageEntity = await repositoryManager.LanguageRepository.GetLanguageById(id, false, ct);
			if (languageEntity is null)
			{
				throw new NotFoundException($"Language not found.");
			}
			repositoryManager.LanguageRepository.DeleteLanguage(languageEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task<LanguageForReturnDto> GetLanguageById(Guid id, CancellationToken ct = default)
		{
			var languageEntity = await repositoryManager.LanguageRepository.GetLanguageById(id, false, ct);
			if (languageEntity is null)
			{
				throw new NotFoundException($"Language not found.");
			}
			return mapper.Map<LanguageForReturnDto>(languageEntity);
		}

		public async Task<IEnumerable<LanguageForReturnDto>> GetLanguages(CancellationToken ct = default)
		{
			var languageEntities = await repositoryManager.LanguageRepository.GetLanguages(false, ct);
			return mapper.Map<IEnumerable<LanguageForReturnDto>>(languageEntities);
		}

		public async Task UpdateLanguage(Guid id, LanguageForUpdateDto languageForUpdateDto, CancellationToken ct = default)
		{
			var languageEntity = await repositoryManager.LanguageRepository.GetLanguageById(id, true, ct);
			if (languageEntity is null)
			{
				throw new NotFoundException($"Language not found.");
			}
			mapper.Map(languageForUpdateDto, languageEntity);
			await repositoryManager.SaveAsync(ct);
		}
	}
}
