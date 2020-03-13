using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Console1App
{
    static class Utils
    {
        public static IQueryable<TDto> As<TEntity, TDto>(this IQueryable<TEntity> query)
            where TDto : TEntity
            => query.Select(a => default(TDto));
    }


    static class EntityUtils
    {
        public static IQueryable<TDto> As<TDto>(this IQueryable<Animal> query)
            where TDto : Animal
            => query.Select(a => default(TDto));
    }

    class MyDbc : DbContext
    {
        public DbSet<Animal> Animals { get; set; }

    }

    class Program
    {
        static async void Main(string[] args)
        {
            var dbc = new MyDbc();

            await
                dbc
                    .Animals
                    .Apply(new AnimalPost())

            var tuxTeaser =
                await dbc
                    .Animals
                    .Where(a => a.Name == "Tux")
                    .As<AnimalTeaserGet>()
                    .FirstAsync();
        }
    }
}
