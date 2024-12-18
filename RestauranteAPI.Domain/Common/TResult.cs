namespace RestauranteAPI.Domain.Common
{
    public class TResult<T> : Result
    {
        public T? Value { get; set; }

        public TResult() : base() { }

        public void Sucess(T value)
        {
            Value = value;
        }
    }
}
