// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Systems.CastleRailingsCollection
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding.Systems
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleRailingsCollection
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Railings;
    private static readonly System.IntPtr NativeFieldInfoPtr__Corners;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NativeHashMap_2_CastleWallBlock_Entity_NativeHashMap_2_CastleBlock_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetRailing_Public_Boolean_byref_CastleWallBlock_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCorner_Public_Boolean_byref_CastleBlock_byref_Entity_0;
    [FieldOffset(0)]
    public readonly NativeHashMap<CastleWallBlock, Entity> _Railings;
    [FieldOffset(16)]
    public readonly NativeHashMap<CastleBlock, Entity> _Corners;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 254289, RefRangeEnd = 254293, XrefRangeStart = 254289, XrefRangeEnd = 254293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleRailingsCollection(
      NativeHashMap<CastleWallBlock, Entity> railings,
      NativeHashMap<CastleBlock, Entity> corners)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &railings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &corners;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleRailingsCollection.NativeMethodInfoPtr__ctor_Public_Void_NativeHashMap_2_CastleWallBlock_Entity_NativeHashMap_2_CastleBlock_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1203634, RefRangeEnd = 1203636, XrefRangeStart = 1203631, XrefRangeEnd = 1203634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetRailing([In] ref CastleWallBlock railingBlock, out Entity railingEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref railingBlock;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref railingEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleRailingsCollection.NativeMethodInfoPtr_TryGetRailing_Public_Boolean_byref_CastleWallBlock_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1203639, RefRangeEnd = 1203641, XrefRangeStart = 1203636, XrefRangeEnd = 1203639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetCorner([In] ref CastleBlock cornerBlock, out Entity cornerEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref cornerBlock;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cornerEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleRailingsCollection.NativeMethodInfoPtr_TryGetCorner_Public_Boolean_byref_CastleBlock_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CastleRailingsCollection()
    {
      Il2CppClassPointerStore<CastleRailingsCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.CastleBuilding.Systems", nameof (CastleRailingsCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleRailingsCollection>.NativeClassPtr);
      CastleRailingsCollection.NativeFieldInfoPtr__Railings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsCollection>.NativeClassPtr, nameof (_Railings));
      CastleRailingsCollection.NativeFieldInfoPtr__Corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsCollection>.NativeClassPtr, nameof (_Corners));
      CastleRailingsCollection.NativeMethodInfoPtr__ctor_Public_Void_NativeHashMap_2_CastleWallBlock_Entity_NativeHashMap_2_CastleBlock_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsCollection>.NativeClassPtr, 100664612);
      CastleRailingsCollection.NativeMethodInfoPtr_TryGetRailing_Public_Boolean_byref_CastleWallBlock_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsCollection>.NativeClassPtr, 100664613);
      CastleRailingsCollection.NativeMethodInfoPtr_TryGetCorner_Public_Boolean_byref_CastleBlock_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsCollection>.NativeClassPtr, 100664614);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleRailingsCollection>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
