using AutoMapper;
using DataEntities.Entities;
using DataEntities.HelperField;
using DomainEntities.Core;
using DomainEntities.External;
using System;

namespace Extensions.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            #region DTO to Entities
            CreateMap<HelperDto, HelperFields>()
               .ForMember(destination => destination.ExternalID, option => option.MapFrom(source => source.Id))
               .ForMember(destination => destination.CreatedOn, option => option.MapFrom(source => source.CreatedOn))
               .ForMember(destination => destination.CreatedBy, option => option.MapFrom(source => source.CreatedBy))
               .ForMember(destination => destination.ModifiedOn, option => option.MapFrom(source => source.ModifiedOn))
               .ForMember(destination => destination.ModifiedBy, option => option.MapFrom(source => source.ModifiedBy))
               .ForMember(destination => destination.Active, option => option.MapFrom(source => source.Active))
               .ForMember(destination => destination.IsDraft, option => option.MapFrom(source => source.IsDraft))
               .ForMember(destination => destination.ExternalID, option => option.Ignore());

            CreateMap<ProServiceDto, ProService>()
                .ForMember(destination => destination.Name, option => option.MapFrom(source => source.Name))
                .ForMember(destination => destination.Description, option => option.MapFrom(source => source.Description))
                .ForMember(destination => destination.ImagePath, option => option.MapFrom(source => source.ImagePath))
                .ForMember(destination => destination.Rating, option => option.MapFrom(source => source.Rating))
                .ForMember(destination => destination.Price, option => option.MapFrom(source => source.Price));

            CreateMap<StartUpDto, StartUp>()
               .ForMember(destination => destination.VentureName, option => option.MapFrom(source => source.VentureName))
               .ForMember(destination => destination.InvestmentRequired, option => option.MapFrom(source => source.InvestmentRequired))
               .ForMember(destination => destination.Sector, option => option.MapFrom(source => source.Sector))
               .ForMember(destination => destination.SubSector, option => option.MapFrom(source => source.SubSector))
               .ForMember(destination => destination.CurrentStage, option => option.MapFrom(source => source.CurrentStage))
               .ForMember(destination => destination.ExtraMessage, option => option.MapFrom(source => source.ExtraMessage))
               .ForMember(destination => destination.GetToKnow, option => option.MapFrom(source => source.GetToKnow));

            #endregion DTO to Entities

            //#region Entities to DTO
            CreateMap<HelperFields, HelperDto>()
                   .ForMember(destination => destination.CreatedOn, option => option.MapFrom(source => source.CreatedOn))
                   .ForMember(destination => destination.CreatedBy, option => option.MapFrom(source => source.CreatedBy))
                   .ForMember(destination => destination.ModifiedOn, option => option.MapFrom(source => source.ModifiedOn))
                   .ForMember(destination => destination.ModifiedBy, option => option.MapFrom(source => source.ModifiedBy))
                   .ForMember(destination => destination.Active, option => option.MapFrom(source => source.Active))
                   .ForMember(destination => destination.IsDraft, option => option.MapFrom(source => source.IsDraft));

            CreateMap<ProService, ProServiceDto>()
                .ForMember(destination => destination.Id, option => option.MapFrom(source => source.ExternalID))
                .ForMember(destination => destination.Name, option => option.MapFrom(source => source.Name))
                .ForMember(destination => destination.Description, option => option.MapFrom(source => source.Description))
                .ForMember(destination => destination.ImagePath, option => option.MapFrom(source => source.ImagePath))
                .ForMember(destination => destination.Rating, option => option.MapFrom(source => source.Rating))
                .ForMember(destination => destination.Price, option => option.MapFrom(source => source.Price));

            CreateMap<StartUp, StartUpDto>()
               .ForMember(destination => destination.VentureName, option => option.MapFrom(source => source.VentureName))
               .ForMember(destination => destination.InvestmentRequired, option => option.MapFrom(source => source.InvestmentRequired))
               .ForMember(destination => destination.Sector, option => option.MapFrom(source => source.Sector))
               .ForMember(destination => destination.SubSector, option => option.MapFrom(source => source.SubSector))
               .ForMember(destination => destination.CurrentStage, option => option.MapFrom(source => source.CurrentStage))
               .ForMember(destination => destination.ExtraMessage, option => option.MapFrom(source => source.ExtraMessage))
               .ForMember(destination => destination.GetToKnow, option => option.MapFrom(source => source.GetToKnow));
            //#endregion Entities to DTO
        }
    }
}
