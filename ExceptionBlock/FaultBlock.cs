using System;

namespace ILGeneratorExtensions
{
    /// <summary>
    /// Represents a fault block in a protected region
    /// </summary>
    public sealed class FaultBlock : IDisposable
    {
        /// <summary>
        /// End the fault block
        /// </summary>
        public void Dispose()
        {
        }
    }
}
