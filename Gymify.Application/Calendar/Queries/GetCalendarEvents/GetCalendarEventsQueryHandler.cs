﻿using System.Collections;
using Gymify.Application.Interfaces;
using Gymify.Domain.Entities;
using Gymify.Shared.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Gymify.Application.Calendar.Queries.GetCalendarEvents;

public class GetCalendarEventsQueryHandler : IRequestHandler<GetCalendarEventsQuery, IEnumerable<CalendarEventDTO>>
{
    private readonly IGymifyDbContext _gymifyDbContext;

    public GetCalendarEventsQueryHandler(IGymifyDbContext gymifyDbContext)
    {
        _gymifyDbContext = gymifyDbContext;
    }
    
    public async Task<IEnumerable<CalendarEventDTO>> Handle(GetCalendarEventsQuery request, CancellationToken cancellationToken)
    {
        IEnumerable<CalendarEventDTO> trainings = await GetTrainingEvents(request.Date, request.UserUid, cancellationToken);
        IEnumerable<CalendarEventDTO> groupSessions = await GetGroupSessionEvents(request.Date, request.UserUid, cancellationToken);
        IEnumerable<CalendarEventDTO> coachHours = await GetCoachHoursEvents(request.Date, request.UserUid, cancellationToken);
        
        return trainings.Concat(groupSessions).Concat(coachHours);
    }

    private async Task<IEnumerable<CalendarEventDTO>> GetTrainingEvents(DateTime date, Guid userUid, CancellationToken cancellationToken)
    {
        List<Training> trainings = await _gymifyDbContext.Training
            .Include(x => x.UserTrainings)
            .Where(x => x.UserTrainings.Any(t => t.UserUid == userUid))
            .ToListAsync(cancellationToken);

        List<CalendarEventDTO> result = new List<CalendarEventDTO>();

        trainings.ForEach(x =>
        {
            if (!x.IsCyclical)
            {
                result.Add(new CalendarEventDTO
                {
                    StartDate = x.TrainingDate,
                    EventType = CalendarEventType.Trainings,
                    Title = x.TrainingName
                });
            }
            else 
            {
                int weeks2 = (int)(new DateTime(x.TrainingDate.Year, 12, 31) - x.TrainingDate).TotalDays / 7;
                DateTime trainingDate = x.TrainingDate;
                for (int i = 0; i < weeks2; i++)
                {
                    if (trainingDate.Month == date.Month)
                    {
                        result.Add(new CalendarEventDTO
                        {
                            StartDate = trainingDate,
                            EventType = CalendarEventType.Trainings,
                            Title = x.TrainingName
                        });
                    }
                    trainingDate = trainingDate.AddDays(7);
                }
            }
        });
        return result;
    }

    private async Task<IEnumerable<CalendarEventDTO>> GetGroupSessionEvents(DateTime date, Guid userUid, CancellationToken cancellationToken)
    {
        List<GroupSession> groupSessions = await _gymifyDbContext.GroupSessions
            .Include(x => x.ClientGroupSessions)
            .Where(x => x.SessionStartDate.Date.Month == date.Date.Month && x.ClientGroupSessions.Any(c => c.ClientUid == userUid))
            .ToListAsync(cancellationToken);

        return groupSessions.Select(x => new CalendarEventDTO
        {
            StartDate = x.SessionStartDate,
            EndDate = x.SessionEndDate,
            Title = x.SessionName,
            EventType = CalendarEventType.GroupSessions
        });
    }

    private async Task<IEnumerable<CalendarEventDTO>> GetCoachHoursEvents(DateTime date, Guid userUid, CancellationToken cancellationToken)
    {
        List<CoachHour> coachHours = await _gymifyDbContext.CoachHours
            .Include(x => x.Coach)
            .ThenInclude(x => x.User)
            .Where(x => x.StartDate.Date.Month == date.Date.Month && x.ClientUid == userUid)
            .ToListAsync(cancellationToken);

        return coachHours.Select(x => new CalendarEventDTO
        {
            StartDate = x.StartDate,
            EndDate = x.EndDate,
            Title = $"Training with {x.Coach.User.FirstName} {x.Coach.User.LastName}",
            EventType = CalendarEventType.CoachHours
        });
    }
}