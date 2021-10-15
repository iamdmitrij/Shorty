namespace Shorty
{
    /// <summary>
    /// Generator for random value.
    /// </summary>
    public interface IShorty
    {
        /// <summary>
        /// Generates random value.
        /// </summary>
        /// <returns>Random sequence of characters.</returns>
        string Generate();

        /// <summary>
        /// Generates random value depending on given options.
        /// </summary>
        /// <param name="options">Options instance.</param>
        /// <returns>Random sequence of characters.</returns>
        string Generate(ShortyOptions options);
    }
}
