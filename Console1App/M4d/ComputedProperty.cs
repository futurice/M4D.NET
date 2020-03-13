using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Console1App
{
    public class ComputedProperty<TEntity, TProp, TValue>
    {
        public static Expression<Func<TEntity, TValue>> Expr { get; protected set; }

        public TValue Value { get; }

        public virtual Task<TValue> Adjust(TValue originalValue) =>
            Task.FromResult(originalValue);

        class As<TDto> : ComputedProperty<TValue, As<TDto>, TDto>
        {

        }
    }

    public abstract class ComputedProperty<TEntity, TProp, TOrigValue, TFinalValue> : ComputedProperty<TEntity, TProp, TOrigValue>
    {
        public abstract Task<TFinalValue> Transform(TOrigValue originalValue);
    }
}