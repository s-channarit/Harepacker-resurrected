﻿using HaCreator.MapEditor.Instance;
using HaCreator.MapSimulator.DX;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaCreator.MapSimulator.Objects.FieldObject
{
    public class NpcItem : BaseItem
    {
        private readonly NpcInstance npcInstance;

        public NpcItem(NpcInstance npcInstance, List<IDXObject> frames)
            : base(frames, npcInstance.Flip)
        {
            this.npcInstance = npcInstance;
        }


        public NpcItem(NpcInstance npcInstance, IDXObject frame0)
            : base(frame0, npcInstance.Flip)
        {
            this.npcInstance = npcInstance;
        }

        public override void Draw(SpriteBatch sprite, SkeletonMeshRenderer skeletonMeshRenderer, GameTime gameTime,
            int mapShiftX, int mapShiftY, int centerX, int centerY,
            int renderWidth, int renderHeight, float RenderObjectScaling, MapRenderResolution mapRenderResolution,
            int TickCount)
        {
            base.Draw(sprite, skeletonMeshRenderer, gameTime,
                mapShiftX, mapShiftY, centerX, centerY,
                renderWidth, renderHeight, RenderObjectScaling, mapRenderResolution,
                TickCount);
        }
    }
}
