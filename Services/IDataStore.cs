using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using App1;
using SQLite;
using App1.Models;

namespace App1.Services
{
    public interface IDataStore<T>
    {
        Task<bool> HocSinhList(T hocsinh);
        Task<bool> HocSinhSave(T hocsinh);
        Task<bool> HocSinhDelete(int id);
        Task<T> GetItemAsync(int id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
        
    }
}
