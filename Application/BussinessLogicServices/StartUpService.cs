using BussinessLogicInterfaces;
using BussinessLogicInterfaces.Core;
using DataEntities.Entities;
using DomainEntities.External;
using InternalLogicIntefaces.Mapping;
using System;
using System.Collections.Generic;

namespace BussinessLogicServices
{
    public class StartUpService : IStartUpInterface
    {
        private IServiceInterface _service;
        private IMapperService _mapper;

        public StartUpService(IServiceInterface service, IMapperService mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public List<StartUpDto> GetStartUps()
        {
            var startUps = _service.GetEntities<StartUp>();
            var result = _mapper.MapList<StartUp, StartUpDto>(startUps);
            return result;
        }

        public StartUpDto GetStartUpById(Guid id)
        {
            var startUp = _service.GetEntityById<StartUp>(id);
            return _mapper.Map<StartUp, StartUpDto>(startUp);
        }

        public StartUpDto AddStartUp(StartUpDto startUpDto)
        {
            var startUp = _mapper.Map<StartUpDto, StartUp>(startUpDto);
            _service.AddEntity(startUp, isAutoSave: true, afterInsert: () => { startUpDto.Id = startUp.ExternalID; });
            return startUpDto;
        }

        public StartUpDto EditStartUp(StartUpDto startUpDto)
        {
            var startUp = _service.GetEntityById<StartUp>(startUpDto.Id);
            _service.UpdateEntity(startUp, isAutoSave: true, beforeInsert: () =>
            {
                MapProService(startUpDto, startUp);
            });
            return startUpDto;
        }

        public bool DeleteStartUp(Guid id)
        {
            return _service.DeleteEntity<StartUp>(id, true);
        }

        #region Mapping
        private void MapProService(StartUpDto startUpDto, StartUp startUp)
        {
            startUp.Active = startUpDto.Active;
            startUp.IsDraft = startUpDto.IsDraft;
            startUp.VentureName = startUpDto.VentureName;
            startUp.InvestmentRequired = startUpDto.InvestmentRequired;
            startUp.Sector = startUpDto.Sector;
            startUp.SubSector = startUpDto.SubSector;
            startUp.CurrentStage = startUpDto.CurrentStage;
            startUp.ExtraMessage = startUpDto.ExtraMessage;
            startUp.GetToKnow = startUpDto.GetToKnow;
        }
        #endregion Mapping
    }
}
