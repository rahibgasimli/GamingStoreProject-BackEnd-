﻿using GamingStoreTekrar.Areas.admin_panel.Models;

namespace GamingStoreTekrar.Areas.admin_panel.ViewModels
{
    public class UsersIndexVm
    {
        public List<AllUsersModel> Users { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPage { get; set; }
        public int PageSize { get; set; }
        public List<int> PageSizes { get; set; } = new() { 5, 15, 25 };
    }
}
