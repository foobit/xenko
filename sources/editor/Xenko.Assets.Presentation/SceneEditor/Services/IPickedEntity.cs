// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using Xenko.Assets.Presentation.AssetEditors.EntityHierarchyEditor.ViewModels;

namespace Xenko.Assets.Presentation.SceneEditor.Services
{
    /// <summary>
    /// This interface represents an entity picked up from a <see cref="IEntityPickerDialog"/>.
    /// </summary>
    public interface IPickedEntity
    {
        /// <summary>
        /// Gets the <see cref="EntityViewModel"/> corresponding to the selected entity.
        /// </summary>
        EntityViewModel Entity { get; }

        /// <summary>
        /// Gets the index of the selected component, when the <see cref="IEntityPickerDialog"/> was used to pickup a component.
        /// </summary>
        int ComponentIndex { get; }
    }
}
