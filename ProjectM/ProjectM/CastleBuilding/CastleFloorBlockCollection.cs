// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleFloorBlockCollection
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleFloorBlockCollection
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Floors;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_NativeHashMap_2_CastleBlock_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetFloor_Public_Boolean_CastleBlock_byref_Entity_0;
    [FieldOffset(0)]
    public readonly NativeHashMap<CastleBlock, Entity> _Floors;

    [CallerCount(103)]
    [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleFloorBlockCollection(NativeHashMap<CastleBlock, Entity> floors)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &floors;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleFloorBlockCollection.NativeMethodInfoPtr__ctor_Internal_Void_NativeHashMap_2_CastleBlock_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 1126769, RefRangeEnd = 1126778, XrefRangeStart = 1126766, XrefRangeEnd = 1126769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetFloor(CastleBlock block, out Entity floorEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &block;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref floorEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleFloorBlockCollection.NativeMethodInfoPtr_TryGetFloor_Public_Boolean_CastleBlock_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CastleFloorBlockCollection()
    {
      Il2CppClassPointerStore<CastleFloorBlockCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (CastleFloorBlockCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleFloorBlockCollection>.NativeClassPtr);
      CastleFloorBlockCollection.NativeFieldInfoPtr__Floors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorBlockCollection>.NativeClassPtr, nameof (_Floors));
      CastleFloorBlockCollection.NativeMethodInfoPtr__ctor_Internal_Void_NativeHashMap_2_CastleBlock_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorBlockCollection>.NativeClassPtr, 100689487);
      CastleFloorBlockCollection.NativeMethodInfoPtr_TryGetFloor_Public_Boolean_CastleBlock_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorBlockCollection>.NativeClassPtr, 100689488);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleFloorBlockCollection>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
