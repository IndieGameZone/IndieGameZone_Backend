using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Tags;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Tags;
using MapsterMapper;

namespace IndieGameZone.Application.Services
{
	internal sealed class TagService : ITagService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public TagService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}
		public async Task CreateTag(TagForCreationDto tagDto, CancellationToken ct = default)
		{
			//Check if tag already exists
			var existingTag = await repositoryManager.TagRepository.GetTagByName(tagDto.Name.ToLower(), false, ct);
			if (existingTag != null)
			{
				throw new BadRequestException($"Tag with name '{tagDto.Name}' already exists.");
			}
			var tagEntity = mapper.Map<Tags>(tagDto);
			tagEntity.Id = Guid.NewGuid();
			repositoryManager.TagRepository.CreateTag(tagEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task DeleteTag(Guid id, CancellationToken ct = default)
		{
			var tagEntity = await repositoryManager.TagRepository.GetTagById(id, true, ct);
			if (tagEntity is null)
			{
				throw new NotFoundException($"Tag not found.");
			}
			tagEntity.IsDeleted = true;
			await repositoryManager.SaveAsync(ct);
		}

		public async Task<TagForReturnDto?> GetTagById(Guid id, CancellationToken ct = default)
		{
			var tagEntity = await repositoryManager.TagRepository.GetTagById(id, false, ct);
			if (tagEntity is null)
			{
				throw new NotFoundException($"Tag not found.");
			}
			return mapper.Map<TagForReturnDto>(tagEntity);
		}

		public async Task<IEnumerable<TagForReturnDto>> GetTags(TagParameters tagParameters, CancellationToken ct = default)
		{
			var tagEntities = await repositoryManager.TagRepository.GetTags(tagParameters, false, ct);
			return mapper.Map<IEnumerable<TagForReturnDto>>(tagEntities);
		}

		public async Task UpdateTag(Guid id, TagForUpdateDto tagDto, CancellationToken ct = default)
		{
			var tagEntity = await repositoryManager.TagRepository.GetTagById(id, true, ct);
			if (tagEntity is null)
			{
				throw new NotFoundException($"Tag not found.");
			}
			mapper.Map(tagDto, tagEntity);
			await repositoryManager.SaveAsync(ct);
		}
	}
}
