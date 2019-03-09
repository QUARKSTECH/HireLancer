using System.Collections.Generic;
using System.Linq;

namespace InternalLogicIntefaces.Mapping
{
    public interface IMapperService
    {
        List<TDestination> MapList<TSource, TDestination>(IQueryable<TSource> source);
        TDestination Map<TSource, TDestination>(TSource source);
    }
}
