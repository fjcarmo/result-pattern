namespace result_pattern.Objects
{
    public sealed class ResultT<TValue> : Result
    {
        private readonly TValue? _value;

        private ResultT(TValue value) : base()
        {
            _value = value;
        }

        private ResultT(Error error) : base(error)
        {
            _value = default;
        }

        public TValue Value => IsSuccess ? _value! : throw new InvalidOperationException("Result was not successful");

        public static ResultT<TValue> Success(TValue value) => new(value);

        public static new ResultT<TValue> Failure(Error error) => new(error);
    }
}
