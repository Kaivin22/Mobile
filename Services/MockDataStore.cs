using App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SQLite;

namespace App1.Services
{
    public class MockDataStore 
    {
       
        private SQLiteAsyncConnection csdl;

        public MockDataStore(string duongdan)
        {
            csdl = new SQLiteAsyncConnection(duongdan);
            csdl.CreateTableAsync<HocSinh>().Wait();

            //HocSinh = new List<HocSinh>()
            //{
            //    new HocSinh { HocSinhId = Guid.NewGuid().ToString(),  = "First item", Description="This is an item description." },
            //    //new Item { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
            //    //new Item { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
            //    //new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
            //    //new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
            //    //new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." }
            //};
        }

        public Task <List<HocSinh>> HocSinhList()
        {
            return csdl.Table<HocSinh>().ToListAsync();
        }

        public Task<int> HocSinhSave(HocSinh hs)
        {
            if (hs.HocSinhId == 0)
                return csdl.InsertAsync(hs);
            else
                return csdl.UpdateAsync(hs);
        }

        public Task<int> HocSinhDelete(HocSinh hs)
        {
            return csdl.DeleteAsync(hs);
        }

        /*public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }*/

        //public Task<HocSinh> GetItemAsync(int id)
        //{
        //    return csdl.Table<HocSinh>().Where(s => s.HocSinhId == id).FirstOrDefaultAsync();
        //}

        //public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        //{
        //    return await Task.FromResult(items);
        //}
    }
}