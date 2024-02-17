﻿namespace Gymify.Shared.Wrappers;

public class PagedResponse<T>
{
    public List<T> Content { get; set; }
    public int TotalRecords { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int TotalPages { get; set; }
}