// Decompiled with JetBrains decompiler
// Type: ProjectM.Roofs.TileBlobUtilities
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Terrain;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Roofs
{
  public static class TileBlobUtilities : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawWireframe_Public_Static_Void_float3_TileBlobRootType_OrthogonalRotation_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawLine_Private_Static_Void_float3_float3_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCornerCoord_Private_Static_float3_float3_int2_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEdgeCoord_Private_Static_float3_float3_int2_Boolean_Boolean_Boolean_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawBox_Private_Static_Void_int2_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCoord_Private_Static_float3_Int32_Int32_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCoord_Private_Static_float2_Int32_Int32_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1191633, RefRangeEnd = 1191634, XrefRangeStart = 1191597, XrefRangeEnd = 1191633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DrawWireframe(
      float3 worldOffset,
      TileBlobRootType rootType,
      OrthogonalRotation rotation,
      bool drawAsGizmo)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &worldOffset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rootType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &drawAsGizmo;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileBlobUtilities.NativeMethodInfoPtr_DrawWireframe_Public_Static_Void_float3_TileBlobRootType_OrthogonalRotation_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 1191645, RefRangeEnd = 1191657, XrefRangeStart = 1191634, XrefRangeEnd = 1191645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DrawLine(float3 pos1, float3 pos2, bool drawAsGizmo)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &pos1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pos2;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &drawAsGizmo;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileBlobUtilities.NativeMethodInfoPtr_DrawLine_Private_Static_Void_float3_float3_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe float3 GetCornerCoord(float3 worldOffset, int2 tileCoord, bool isSet)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &worldOffset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileCoord;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isSet;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBlobUtilities.NativeMethodInfoPtr_GetCornerCoord_Private_Static_float3_float3_int2_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191657, XrefRangeEnd = 1191660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float3 GetEdgeCoord(
      float3 worldOffset,
      int2 tileCoord,
      bool cornerA,
      bool edge,
      bool cornerB,
      out bool fullEdge)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &worldOffset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileCoord;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &cornerA;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &edge;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &cornerB;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref fullEdge;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBlobUtilities.NativeMethodInfoPtr_GetEdgeCoord_Private_Static_float3_float3_int2_Boolean_Boolean_Boolean_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191660, XrefRangeEnd = 1191663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DrawBox(int2 cornerCoord, float3 worldCoord)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &cornerCoord;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &worldCoord;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileBlobUtilities.NativeMethodInfoPtr_DrawBox_Private_Static_Void_int2_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe float3 GetCoord(int tileX, int tileZ, float yHeightFactor)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &tileX;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileZ;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &yHeightFactor;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBlobUtilities.NativeMethodInfoPtr_GetCoord_Private_Static_float3_Int32_Int32_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe float2 GetCoord(int tileX, int tileZ)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tileX;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileZ;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBlobUtilities.NativeMethodInfoPtr_GetCoord_Private_Static_float2_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TileBlobUtilities()
    {
      Il2CppClassPointerStore<TileBlobUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.Roofs", nameof (TileBlobUtilities));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileBlobUtilities>.NativeClassPtr);
      TileBlobUtilities.NativeMethodInfoPtr_DrawWireframe_Public_Static_Void_float3_TileBlobRootType_OrthogonalRotation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBlobUtilities>.NativeClassPtr, 100663470);
      TileBlobUtilities.NativeMethodInfoPtr_DrawLine_Private_Static_Void_float3_float3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBlobUtilities>.NativeClassPtr, 100663471);
      TileBlobUtilities.NativeMethodInfoPtr_GetCornerCoord_Private_Static_float3_float3_int2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBlobUtilities>.NativeClassPtr, 100663472);
      TileBlobUtilities.NativeMethodInfoPtr_GetEdgeCoord_Private_Static_float3_float3_int2_Boolean_Boolean_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBlobUtilities>.NativeClassPtr, 100663473);
      TileBlobUtilities.NativeMethodInfoPtr_DrawBox_Private_Static_Void_int2_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBlobUtilities>.NativeClassPtr, 100663474);
      TileBlobUtilities.NativeMethodInfoPtr_GetCoord_Private_Static_float3_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBlobUtilities>.NativeClassPtr, 100663475);
      TileBlobUtilities.NativeMethodInfoPtr_GetCoord_Private_Static_float2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBlobUtilities>.NativeClassPtr, 100663476);
    }

    public TileBlobUtilities(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
