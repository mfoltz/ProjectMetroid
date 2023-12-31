// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.TerrainUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Terrain
{
  public static class TerrainUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValidBlockCoordinate_Public_Static_Boolean_UInt32_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValidCornerCoordinate_Public_Static_Boolean_UInt32_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValidTileCoordinate_Public_Static_Boolean_UInt32_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCornerIndex_Public_Static_UInt32_UInt32_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileIndex_Public_Static_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileIndex_Public_Static_Int32_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBlockIndex_Public_Static_UInt32_UInt32_UInt32_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 768213, RefRangeEnd = 768215, XrefRangeStart = 768213, XrefRangeEnd = 768213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsValidBlockCoordinate(uint x, uint y)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.NativeMethodInfoPtr_IsValidBlockCoordinate_Public_Static_Boolean_UInt32_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 768215, RefRangeEnd = 768217, XrefRangeStart = 768215, XrefRangeEnd = 768215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsValidCornerCoordinate(uint x, uint y)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.NativeMethodInfoPtr_IsValidCornerCoordinate_Public_Static_Boolean_UInt32_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 768217, RefRangeEnd = 768218, XrefRangeStart = 768217, XrefRangeEnd = 768217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsValidTileCoordinate(uint x, uint y)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.NativeMethodInfoPtr_IsValidTileCoordinate_Public_Static_Boolean_UInt32_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe uint GetCornerIndex(uint x, uint y)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.NativeMethodInfoPtr_GetCornerIndex_Public_Static_UInt32_UInt32_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe int GetTileIndex(int x, int y)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.NativeMethodInfoPtr_GetTileIndex_Public_Static_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 768218, RefRangeEnd = 768223, XrefRangeStart = 768218, XrefRangeEnd = 768218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetTileIndex(int2 xy)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &xy;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.NativeMethodInfoPtr_GetTileIndex_Public_Static_Int32_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe uint GetBlockIndex(uint x, uint y)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.NativeMethodInfoPtr_GetBlockIndex_Public_Static_UInt32_UInt32_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TerrainUtility()
    {
      Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (TerrainUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr);
      TerrainUtility.NativeMethodInfoPtr_IsValidBlockCoordinate_Public_Static_Boolean_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, 100667954);
      TerrainUtility.NativeMethodInfoPtr_IsValidCornerCoordinate_Public_Static_Boolean_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, 100667955);
      TerrainUtility.NativeMethodInfoPtr_IsValidTileCoordinate_Public_Static_Boolean_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, 100667956);
      TerrainUtility.NativeMethodInfoPtr_GetCornerIndex_Public_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, 100667957);
      TerrainUtility.NativeMethodInfoPtr_GetTileIndex_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, 100667958);
      TerrainUtility.NativeMethodInfoPtr_GetTileIndex_Public_Static_Int32_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, 100667959);
      TerrainUtility.NativeMethodInfoPtr_GetBlockIndex_Public_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, 100667960);
    }

    public TerrainUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
