﻿using System;
using AutoMapper;
using Contracts.DataTransferObjects;
using Entities.DataTransferObjects;
using Entities.Models;

namespace AccountOwnerServer
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Owner, OwnerDto>();
			CreateMap<Account, AccountDto>();
			CreateMap<OwnerForCreationDto, Owner>();
			CreateMap<OwnerForUpdateDto, Owner>();
		}
	}
}

