using System;
using System.Linq;

namespace Shorty
{
    /// <inheritdoc />
    public class Shorty : IShorty
    {
        private Random Random { get; } = new Random();

        private string ValidChars { get; } = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        /// <inheritdoc />
        public string Generate(ShortyOptions options)
        {
            var value = new string(Enumerable.Repeat(ValidChars, options.Length)
                .Select(x => x[Random.Next(x.Length)])
                .ToArray()
            );

            return value;
        }

        /// <inheritdoc />
        public string Generate() => Generate(new ShortyOptions() { Length = 20 });
    }
}
