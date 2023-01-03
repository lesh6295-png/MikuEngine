using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Miku.Types.Assets;
using Miku.Types.Base;
namespace Miku.Interfaces
{
    public interface IGraphics
    {
        /// <summary>
        /// Set background
        /// </summary>
        /// <param name="asset">ImageAsset object, who represent new background</param>
        void SetBackground(ImageAsset asset);
        /// <summary>
        /// Create new object, who render new actor on screen
        /// </summary>
        /// <param name="asset">ImageAsset, who represent sprite to new actor</param>
        /// <param name="position">Vector2 object that describes position</param>
        /// <returns>Unique integer, which identifies the created object. With this integer, we can update or delete object</returns>
        int RenderActorSprite(ImageAsset asset, Vector2 position);
        /// <summary>
        /// Create new object, who render new actor on screen
        /// </summary>
        /// <param name="asset">ImageAsset, who represent sprite to new actor</param>
        /// <param name="x">Horizontal render position, where 0.0 - left, 1.0 - right, 0.5 - center</param>
        /// <param name="y">Vertical render position, where 0.5 - center, 0.0-bottom, 1.0 -top</param>
        /// <returns>Unique integer, which identifies the created object. With this integer, we can update or delete object</returns>
        int RenderActorSprite(ImageAsset asset, double x, double y)
        {
            return RenderActorSprite(asset, new(x, y));
        }
        /// <summary>
        /// Update sprite on exsisting actor
        /// </summary>
        /// <param name="asset">Object who represent a new sprite</param>
        /// <param name="id">Actor id</param>
        void UpdateActorSprite(ImageAsset asset, int id);
        /// <summary>
        /// Update position for actor with <c>actorId</c>
        /// </summary>
        /// <param name="actorId">Integer, who represent actor object</param>
        /// <param name="newPosition">Vector2 object, who describes new actor position</param>
        void UpdateActorPosition(int actorId, Vector2 newPosition);
        /// <summary>
        /// Update position for actor with <c>actorId</c>
        /// </summary>
        /// <param name="actorId">Integer, who represent actor object</param>
        /// <param name="x">New horisontal position, -1 to ignore</param>
        /// <param name="y">New vertical position, -1 to ignore</param>
        void UpdateActorPosition(int actorId, double x, double y)
        {
            UpdateActorPosition(actorId, new(x, y));
        }
        /// <summary>
        /// Delete object who render specefic actor
        /// </summary>
        /// <param name="id">Object id, who get after <see cref="RenderActorSprite(ImageAsset, Vector2)">RenderActorSprite</see></param>
        void DeleteActorSprite(int id);
    }
}
