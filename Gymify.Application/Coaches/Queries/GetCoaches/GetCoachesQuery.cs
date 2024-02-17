﻿using Gymify.Shared.Wrappers;
using MediatR;

namespace Gymify.Application.Coaches.Queries.GetCoaches;

public record GetCoachesQuery(int PageNumber, int PageSize, Guid UserUid, string? Name, int? CategoryId): IRequest<PagedResponse<CoachDTO>>;