using AutoMapper;
using FluentValidation;
using Domain.Base;

namespace Service.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : IBaseEntity
    {
        private readonly IBaseRepository<TEntity> _baseRepository;
        private readonly IMapper _mapper;

        public BaseService(IBaseRepository<TEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public void AttachObject(object obj)
        {
            _baseRepository.AttachObject(obj);
        }

        public TOutputModel Add<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TValidator : AbstractValidator<TEntity>
            where TInputModel : class
            where TOutputModel : class
        {
            var entity = _mapper.Map<TEntity>(inputModel);

            Validate(entity, Activator.CreateInstance<TValidator>());

            _baseRepository.Insert(entity);

            var outputModel = _mapper.Map<TOutputModel>(entity);

            return outputModel;
        }

        public void Delete(int id)
            => _baseRepository.Delete(id);

        public IEnumerable<TOutputModel> Get<TOutputModel>(IList<string>? includes = null) where TOutputModel : class
        {
            var entities = _baseRepository.Select(includes);
            var outputModels = entities.Select(s => _mapper.Map<TOutputModel>(s));
            return outputModels;
        }

        public TOutputModel GetById<TOutputModel>(int id, IList<string>? includes = null) where TOutputModel : class
        {
            var entity = _baseRepository.Select(id, includes);
            var outputModel = _mapper.Map<TOutputModel>(entity);
            return outputModel;
        }

        // Método GetById sobrecarregado implementado para evitar NotImplementedException
        public TOutputModel GetById<TOutputModel>(int id) where TOutputModel : class
        {
            return GetById<TOutputModel>(id, null);
        }

        public TOutputModel Update<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TValidator : AbstractValidator<TEntity>
            where TInputModel : class
            where TOutputModel : class
        {
            var entity = _mapper.Map<TEntity>(inputModel);

            Validate(entity, Activator.CreateInstance<TValidator>());

            //_baseRepository.ClearChangeTracker(); // Descomente se necessário.
            _baseRepository.Update(entity);

            var outputModel = _mapper.Map<TOutputModel>(entity);

            return outputModel;
        }

        private void Validate(TEntity obj, AbstractValidator<TEntity> validator)
        {
            if (obj == null)
                throw new Exception("Registros não detectados!");

            validator.ValidateAndThrow(obj);
        }
    }
}
