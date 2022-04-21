﻿using AutoMapper;
using TrackService.Application.TrackLogic.CQRS.Commands;
using TrackService.Application.TrackLogic.CQRS.Responses;
using TrackService.Core.Entities;
using TrackService.Shared.DTOs.TrackDTOs;

namespace TrackService.Application.TrackLogic.AutoMapper
{
  public class TrackProfile : Profile
  {
    public TrackProfile()
    {
      // Source -> Target
      CreateMap<CreateTrackDTO, CreateTrackCommand>();
      CreateMap<CreateTrackCommand, Track>();

      CreateMap<Track, TrackResponse>();
      CreateMap<TrackResponse, ReadTrackDTO>();
    }
  }
}
