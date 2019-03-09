using AutoMapper;
using InternalLogicIntefaces.Mapping;
using System.Collections.Generic;
using System.Linq;

namespace InternalLogicServices.Mapping
{
    public class MapperService : IMapperService
    {
        protected IMapper _mapper;

        public MapperService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<TDestination> MapList<TSource, TDestination>(IQueryable<TSource> source)
        {
            return _mapper.Map<IEnumerable<TSource>, List<TDestination>>(source);
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return _mapper.Map<TSource, TDestination>(source);
        }
    }
}
