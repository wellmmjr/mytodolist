﻿using mytodolist.Hypermedia.Abstract;
using System;
using System.Collections.Generic;

namespace mytodolist.Hypermedia.Utils
{
    public class PagedSearchDTO<T> where T : ISupportHyperMedia
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalResults { get; set; }
        public string SortFields { get; set; }
        public string SortDirection { get; set; }
        public Dictionary<string, Object> Filters { get; set; }
        public List<T> List { get; set; }

        public PagedSearchDTO()
        {
        }

        public PagedSearchDTO(int currentPage, int pageSize, string sortFields, string sortDirection)
        {
            CurrentPage = currentPage;
            PageSize = pageSize;
            SortFields = sortFields;
            SortDirection = sortDirection;
        }

        public PagedSearchDTO(int currentPage, int pageSize, string sortFields, string sortDirection, Dictionary<string, object> filters) : this(currentPage, pageSize, sortFields, sortDirection)
        {
            CurrentPage = currentPage;
            PageSize = pageSize;
            SortFields = sortFields;
            SortDirection = sortDirection;
            Filters = filters;
        }

        public PagedSearchDTO(int currentPage, string sortFields, string sortDirection) 
            : this(currentPage, 10, sortFields, sortDirection) {}

        public int GetCurrentPage()
        {
            return CurrentPage == 0 ? 2 : CurrentPage;
        }

        public int GetPageSize()
        {
            return PageSize == 0 ? 10 : PageSize;
        }

    }
}
