// Decompiled with JetBrains decompiler
// Type: ProjectM.TilePosition
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TilePosition
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Tile;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompressedHeight;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HeightLevel_Public_get_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHeight_Public_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2_Single_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TilePosition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromBakedSpaceToWorldSpace_Public_Static_TilePosition_byref_TilePosition_int2_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTilePosition_Public_Static_TilePosition_byref_LocalToWorld_byref_TileData_0;
    [FieldOffset(0)]
    public int2 Tile;
    [FieldOffset(8)]
    public TileRotation TileRotation;
    [FieldOffset(10)]
    public ushort CompressedHeight;

    public unsafe byte HeightLevel
    {
      [CallerCount(64), CachedScanResults(RefRangeStart = 731995, RefRangeEnd = 732059, XrefRangeStart = 731992, XrefRangeEnd = 731995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TilePosition.NativeMethodInfoPtr_get_HeightLevel_Public_get_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(byte*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 732060, RefRangeEnd = 732068, XrefRangeStart = 732059, XrefRangeEnd = 732060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetHeight()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TilePosition.NativeMethodInfoPtr_GetHeight_Public_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 732069, RefRangeEnd = 732080, XrefRangeStart = 732068, XrefRangeEnd = 732069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TilePosition(int2 tile, float yPos, TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &tile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &yPos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TilePosition.NativeMethodInfoPtr__ctor_Public_Void_int2_Single_TileRotation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 732080, RefRangeEnd = 732083, XrefRangeStart = 732080, XrefRangeEnd = 732080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(TilePosition other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TilePosition.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TilePosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732083, XrefRangeEnd = 732096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TilePosition.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 732098, RefRangeEnd = 732104, XrefRangeStart = 732096, XrefRangeEnd = 732098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TilePosition FromBakedSpaceToWorldSpace(
      [In] ref TilePosition bakedTilePosition,
      int2 chunkOffset,
      TileRotation chunkRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref bakedTilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkOffset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TilePosition.NativeMethodInfoPtr_FromBakedSpaceToWorldSpace_Public_Static_TilePosition_byref_TilePosition_int2_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TilePosition*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 732117, RefRangeEnd = 732132, XrefRangeStart = 732104, XrefRangeEnd = 732117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TilePosition GetTilePosition(
      [In] ref LocalToWorld localToWorld,
      [In] ref TileData tileData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref localToWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TilePosition.NativeMethodInfoPtr_GetTilePosition_Public_Static_TilePosition_byref_LocalToWorld_byref_TileData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TilePosition*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TilePosition()
    {
      Il2CppClassPointerStore<TilePosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TilePosition));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TilePosition>.NativeClassPtr);
      TilePosition.NativeFieldInfoPtr_Tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilePosition>.NativeClassPtr, nameof (Tile));
      TilePosition.NativeFieldInfoPtr_TileRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilePosition>.NativeClassPtr, nameof (TileRotation));
      TilePosition.NativeFieldInfoPtr_CompressedHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilePosition>.NativeClassPtr, nameof (CompressedHeight));
      TilePosition.NativeMethodInfoPtr_get_HeightLevel_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilePosition>.NativeClassPtr, 100664673);
      TilePosition.NativeMethodInfoPtr_GetHeight_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilePosition>.NativeClassPtr, 100664674);
      TilePosition.NativeMethodInfoPtr__ctor_Public_Void_int2_Single_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilePosition>.NativeClassPtr, 100664675);
      TilePosition.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TilePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilePosition>.NativeClassPtr, 100664676);
      TilePosition.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilePosition>.NativeClassPtr, 100664677);
      TilePosition.NativeMethodInfoPtr_FromBakedSpaceToWorldSpace_Public_Static_TilePosition_byref_TilePosition_int2_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilePosition>.NativeClassPtr, 100664678);
      TilePosition.NativeMethodInfoPtr_GetTilePosition_Public_Static_TilePosition_byref_LocalToWorld_byref_TileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilePosition>.NativeClassPtr, 100664679);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TilePosition>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
