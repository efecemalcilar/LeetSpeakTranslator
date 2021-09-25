﻿using AutoMapper;
using LeetSpeakTranslator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetSpeakTranslator
{
    public class LeetSpeakMappingProfile : Profile
    {
        public LeetSpeakMappingProfile()
        {
            CreateMap<LeetSpeakResponse, LeetSpeakOutputDto>()
                .ForMember(m => m.InputText, c => c.MapFrom(s => s.Contents.Text))
                .ForMember(m => m.ConvertedText, c => c.MapFrom(s => s.Contents.Translated));
            CreateMap<LeetSpeakResponseError, LeetSpeakOutputDto>()
                .ForMember(m => m.ErrorMessage, c => c.MapFrom(s => s.Error.Message))
                .ForMember(m => m.Code, c => c.MapFrom(s => s.Error.Code));
        }
    }
}
