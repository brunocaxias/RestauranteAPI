namespace RestauranteAPI.Domain.Common
{
    public class Result
    {
        public bool Success { get; private set; }
        public bool IsFailure => !Success;
        public ICollection<string> Errors { get; private set; } = new List<string>();

        public Result()
        {
            Success = true;
        }

        public void AddError(string error)
        {
            Errors.Add(error);

            if (Errors.Count == 1)
            {
                Success = false;
            }
        }
    }
}
