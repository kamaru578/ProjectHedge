﻿/// Entity Manager Class
/// Dev: Calum Mathison 
/// Created on: 25/06/2020
/// Change Log:
/// 

#region Externs
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
#endregion

namespace Engine.ECM
{
    /// <summary>
    /// This struct is a system to be attached to a scene in order to handle and store Entities.
    /// </summary>
    public struct EntityManager
    {
        #region Fields
        public List<Entity> List;
        #endregion

        #region Methods
        /// <summary>
        /// Initialise Method. Initialises all entities attached to the manager.
        /// Could be used as a reset method.
        /// </summary>
        public void Initialise()
        {
            foreach (Entity entity in List)
            {
                entity.Initialise();
            }
        }

        /// <summary>
        /// Load Method. 
        /// Calls the load method for all entities attached to the manager.
        /// </summary>
        /// <param name="content"></param>
        public void Load(ContentManager content)
        {
            foreach (Entity entity in List)
            {
                entity.Load(content);
            }
        }

        /// <summary>
        /// Update Method.
        /// Calls the Update method for all entities attached to the manager.
        /// </summary>
        /// <param name="gt"></param>
        public void Update(GameTime gt)
        {
            foreach (Entity entity in List)
            {
                entity.Update(gt);
            }
        }

        /// <summary>
        /// Draw Method.
        /// Call the Draw method for all entities attached to the manager.
        /// </summary>
        /// <param name="sb"></param>
        public void Draw(SpriteBatch sb)
        {
            foreach (Entity entity in List)
            {
                entity.Draw(sb);
            }
        }

        /// <summary>
        /// Find Entity Method.
        /// Finds an entity of a given type from the list.
        /// </summary>
        /// <typeparam name="T">Entity Type</typeparam>
        /// <returns>Entity of T</returns>
        public T FindEntity<T>() where T : Entity
        {
            foreach (Entity entity in List)
            {
                if (entity is T)
                {
                    return (T)entity;
                }
            }

            return null;
        }
        #endregion
    }
