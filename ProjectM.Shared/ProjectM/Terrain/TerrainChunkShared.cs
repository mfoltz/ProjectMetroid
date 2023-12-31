// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.TerrainChunkShared
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Terrain
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct TerrainChunkShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Chunk;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_X_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Y_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileOffset_Public_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBlockOffset_Public_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldOffset_Public_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TerrainChunkShared_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromPosition_Public_Static_TerrainChunkShared_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRelativeTileCoordinate_Public_int2_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalTileCoordinate_Public_Static_int2_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBounds_Public_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldTransformMatrix_Public_float4x4_OrthogonalRotation_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    [FieldOffset(0)]
    public TerrainChunk Chunk;

    public unsafe int X
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunkShared.NativeMethodInfoPtr_get_X_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int Y
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 107697, RefRangeEnd = 107730, XrefRangeStart = 107697, XrefRangeEnd = 107730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunkShared.NativeMethodInfoPtr_get_Y_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TerrainChunkShared(int2 chunkCoordinate)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &chunkCoordinate;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TerrainChunkShared.NativeMethodInfoPtr__ctor_Public_Void_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(57)]
    [CachedScanResults(RefRangeStart = 56553, RefRangeEnd = 56610, XrefRangeStart = 56553, XrefRangeEnd = 56610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TerrainChunkShared(int x, int y)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TerrainChunkShared.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767466, XrefRangeEnd = 767467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int2 GetTileOffset()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunkShared.NativeMethodInfoPtr_GetTileOffset_Public_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767467, XrefRangeEnd = 767468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int2 GetBlockOffset()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunkShared.NativeMethodInfoPtr_GetBlockOffset_Public_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767468, XrefRangeEnd = 767469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float2 GetWorldOffset()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunkShared.NativeMethodInfoPtr_GetWorldOffset_Public_float2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767469, XrefRangeEnd = 767470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunkShared.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767470, XrefRangeEnd = 767474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunkShared.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 261548, RefRangeEnd = 261550, XrefRangeStart = 261548, XrefRangeEnd = 261550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(int2 other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunkShared.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 767475, RefRangeEnd = 767476, XrefRangeStart = 767474, XrefRangeEnd = 767475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(TerrainChunkShared other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunkShared.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TerrainChunkShared_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767476, XrefRangeEnd = 767477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TerrainChunkShared FromPosition(float3 worldPos)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldPos;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunkShared.NativeMethodInfoPtr_FromPosition_Public_Static_TerrainChunkShared_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TerrainChunkShared*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767477, XrefRangeEnd = 767478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int2 GetRelativeTileCoordinate(float3 worldPos)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldPos;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunkShared.NativeMethodInfoPtr_GetRelativeTileCoordinate_Public_int2_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767478, XrefRangeEnd = 767479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int2 GetLocalTileCoordinate(float3 worldPos)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldPos;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunkShared.NativeMethodInfoPtr_GetLocalTileCoordinate_Public_Static_int2_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767479, XrefRangeEnd = 767480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BoundsMinMax GetBounds()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunkShared.NativeMethodInfoPtr_GetBounds_Public_BoundsMinMax_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 767481, RefRangeEnd = 767483, XrefRangeStart = 767480, XrefRangeEnd = 767481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float4x4 GetWorldTransformMatrix(
      OrthogonalRotation rotation,
      bool includeWorldOffset = true)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &includeWorldOffset;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunkShared.NativeMethodInfoPtr_GetWorldTransformMatrix_Public_float4x4_OrthogonalRotation_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float4x4*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767483, XrefRangeEnd = 767491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TerrainChunkShared.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static TerrainChunkShared()
    {
      Il2CppClassPointerStore<TerrainChunkShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (TerrainChunkShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainChunkShared>.NativeClassPtr);
      TerrainChunkShared.NativeFieldInfoPtr_Chunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainChunkShared>.NativeClassPtr, nameof (Chunk));
      TerrainChunkShared.NativeMethodInfoPtr_get_X_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunkShared>.NativeClassPtr, 100667894);
      TerrainChunkShared.NativeMethodInfoPtr_get_Y_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunkShared>.NativeClassPtr, 100667895);
      TerrainChunkShared.NativeMethodInfoPtr__ctor_Public_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunkShared>.NativeClassPtr, 100667896);
      TerrainChunkShared.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunkShared>.NativeClassPtr, 100667897);
      TerrainChunkShared.NativeMethodInfoPtr_GetTileOffset_Public_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunkShared>.NativeClassPtr, 100667898);
      TerrainChunkShared.NativeMethodInfoPtr_GetBlockOffset_Public_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunkShared>.NativeClassPtr, 100667899);
      TerrainChunkShared.NativeMethodInfoPtr_GetWorldOffset_Public_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunkShared>.NativeClassPtr, 100667900);
      TerrainChunkShared.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunkShared>.NativeClassPtr, 100667901);
      TerrainChunkShared.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunkShared>.NativeClassPtr, 100667902);
      TerrainChunkShared.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunkShared>.NativeClassPtr, 100667903);
      TerrainChunkShared.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TerrainChunkShared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunkShared>.NativeClassPtr, 100667904);
      TerrainChunkShared.NativeMethodInfoPtr_FromPosition_Public_Static_TerrainChunkShared_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunkShared>.NativeClassPtr, 100667905);
      TerrainChunkShared.NativeMethodInfoPtr_GetRelativeTileCoordinate_Public_int2_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunkShared>.NativeClassPtr, 100667906);
      TerrainChunkShared.NativeMethodInfoPtr_GetLocalTileCoordinate_Public_Static_int2_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunkShared>.NativeClassPtr, 100667907);
      TerrainChunkShared.NativeMethodInfoPtr_GetBounds_Public_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunkShared>.NativeClassPtr, 100667908);
      TerrainChunkShared.NativeMethodInfoPtr_GetWorldTransformMatrix_Public_float4x4_OrthogonalRotation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunkShared>.NativeClassPtr, 100667909);
      TerrainChunkShared.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunkShared>.NativeClassPtr, 100667910);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TerrainChunkShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
