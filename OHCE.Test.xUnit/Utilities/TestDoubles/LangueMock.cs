namespace OHCE.Test.xUnit.Utilities.TestDoubles
{
    internal record LangueMock : ILangue
    {
        public string BienDit { get; init; } = string.Empty;
        public string Bonjour { get; init; } = string.Empty;
        public string DireBonjour { get; init; } = string.Empty;
        public string AuRevoir { get; init; } = string.Empty;
        public string LangageUtilise { get; init; } = string.Empty;
        public string TexteConvivial { get; init; } = string.Empty;
        public string MotInverse { get; init; } = string.Empty;
    }
}
