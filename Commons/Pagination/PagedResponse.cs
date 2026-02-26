namespace ApiCm.Commons.Pagination;

public class PagedResponse<T> : ApiResponse<T>
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int TotalCount { get; set; }
    public int TotalPages { get; set; }
    public bool HasPrevious { get; set; }
    public bool HasNext { get; set; }

    public PagedResponse(T data, int totalCount, int pageNumber, int pageSize)
        : base(true, "Datos obtenidos exitosamente", data)
    {
        TotalCount = totalCount;
        PageNumber = pageNumber;
        PageSize = pageSize;
        TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
        HasPrevious = pageNumber > 1;
        HasNext = pageNumber < TotalPages;
        StatusCode = 200;
    }

    public PagedResponse(bool success, string message)
        : base(success, message) { }
}
