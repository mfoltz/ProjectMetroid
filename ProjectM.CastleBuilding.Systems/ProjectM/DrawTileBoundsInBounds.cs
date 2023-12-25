// Decompiled with JetBrains decompiler
// Type: ProjectM.DrawTileBoundsInBounds
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DrawTileBoundsInBounds
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DrawAtY;
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldTileBoundsType;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Bounds;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntitiesWithinBounds;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
    [FieldOffset(0)]
    public float DrawAtY;
    [FieldOffset(8)]
    public ComponentTypeHandle<TileBounds> WorldTileBoundsType;
    [FieldOffset(40)]
    public EntityTypeHandle EntityType;
    [FieldOffset(44)]
    public BoundsMinMax Bounds;
    [FieldOffset(64)]
    public NativeList<Entity> EntitiesWithinBounds;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191323, XrefRangeEnd = 1191333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &chunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DrawTileBoundsInBounds.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DrawTileBoundsInBounds()
    {
      Il2CppClassPointerStore<DrawTileBoundsInBounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM", nameof (DrawTileBoundsInBounds));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawTileBoundsInBounds>.NativeClassPtr);
      DrawTileBoundsInBounds.NativeFieldInfoPtr_DrawAtY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileBoundsInBounds>.NativeClassPtr, nameof (DrawAtY));
      DrawTileBoundsInBounds.NativeFieldInfoPtr_WorldTileBoundsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileBoundsInBounds>.NativeClassPtr, nameof (WorldTileBoundsType));
      DrawTileBoundsInBounds.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileBoundsInBounds>.NativeClassPtr, nameof (EntityType));
      DrawTileBoundsInBounds.NativeFieldInfoPtr_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileBoundsInBounds>.NativeClassPtr, nameof (Bounds));
      DrawTileBoundsInBounds.NativeFieldInfoPtr_EntitiesWithinBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawTileBoundsInBounds>.NativeClassPtr, nameof (EntitiesWithinBounds));
      DrawTileBoundsInBounds.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawTileBoundsInBounds>.NativeClassPtr, 100663444);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrawTileBoundsInBounds>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
