using BussinessLogicInterfaces;
using BussinessLogicInterfaces.Core;
using DataEntities.Entities;
using DomainEntities.External;
using InternalLogicIntefaces.Mapping;
using System;
using System.Collections.Generic;

namespace BussinessLogicServices
{
    public class ProServiceService : IProServiceInterface
    {
        private IServiceInterface _service;
        private IMapperService _mapper;

        public ProServiceService(IServiceInterface service, IMapperService mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public List<ProServiceDto> GetProServices()
        {
            var proServices = _service.GetEntities<ProService>();
            var result = _mapper.MapList<ProService, ProServiceDto>(proServices);
            return result;
        }

        public ProServiceDto GetProServiceById(Guid ExternalId)
        {
            var proService = _service.GetEntityById<ProService>(ExternalId);
            return _mapper.Map<ProService, ProServiceDto>(proService);
        }

        public ProServiceDto AddProService(ProServiceDto proServiceDto)
        {
            var proService = _mapper.Map<ProServiceDto, ProService>(proServiceDto);
            _service.AddEntity(proService, isAutoSave: true, afterInsert: () => { proServiceDto.Id = proService.ExternalID; });
            return proServiceDto;
        }

        public ProServiceDto EditProService(ProServiceDto proServiceDto)
        {
            var proService = _service.GetEntityById<ProService>(proServiceDto.Id);
            _service.UpdateEntity(proService, isAutoSave: true, beforeInsert: () =>
            {
                MapProService(proServiceDto, proService);
            });
            return proServiceDto;
        }

        public bool DeleteProService(Guid id)
        {
            return _service.DeleteEntity<ProService>(id, true);
        }

        #region Mapping
        private void MapProService(ProServiceDto proServiceDto, ProService proService)
        {
            proService.Active = proServiceDto.Active;
            proService.IsDraft = proServiceDto.IsDraft;
            proService.Name = proServiceDto.Name;
            proService.Description = proServiceDto.Description;
            proService.Rating = proServiceDto.Rating;
            proService.Price = proServiceDto.Price;
            proService.ImagePath = proServiceDto.ImagePath;
        }
        #endregion Mapping
    }
}
