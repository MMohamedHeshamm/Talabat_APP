using Microsoft.IdentityModel.Tokens;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Talabat.Core.Entites;
using Talabat.Core.Repoisitories_Interfaces_;

namespace Talabat.Repoistory
{
    public class BasketRepo : IBasketRepo


    {
        private readonly IDatabase database;
        public BasketRepo(IConnectionMultiplexer redis)
        {
            database = redis.GetDatabase();
        }

        public async Task<bool> DeleteBasketAsync(string basketId)
        {
            return await database.KeyDeleteAsync(basketId);
        }

        public async Task<CustomerBasket?> GetBasketAsync(string basketId)
        {
            var basket = await database.StringGetAsync(basketId);
            return basket.IsNull ? null : JsonSerializer.DeserializeAsync<CustomerBasket>(basket);
        }

        public async Task<CustomerBasket?> UpdateBasketAsync(CustomerBasket basket)
        {
            var UpdatedOrCreated = await database.StringSetAsync(basket.Id, JsonSerializer.Serialize(basket), TimeSpan.FromDays(1));
            if (UpdatedOrCreated is false) return null;
            return await GetBasketAsync(basket.Id);


        }
    }
}
