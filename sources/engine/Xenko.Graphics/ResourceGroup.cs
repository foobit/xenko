// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

namespace Xenko.Graphics
{
    /// <summary>
    /// Contains resources and a constant buffer, that usually change at a given frequency.
    /// </summary>
    public class ResourceGroup
    {
        /// <summary>
        /// Resources.
        /// </summary>
        public DescriptorSet DescriptorSet;

        /// <summary>
        /// Constant buffer.
        /// </summary>
        public BufferPoolAllocationResult ConstantBuffer;
    }
}
