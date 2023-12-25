// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.ChunkMapZoneAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM.Terrain
{
  public class ChunkMapZoneAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ZoneType;
    private static readonly IntPtr NativeFieldInfoPtr_AddCustomZoneFlags;
    private static readonly IntPtr NativeFieldInfoPtr_RemoveCustomZoneFlags;
    private static readonly IntPtr NativeFieldInfoPtr_Name;
    private static readonly IntPtr NativeFieldInfoPtr_Description;
    private static readonly IntPtr NativeFieldInfoPtr_LoreText;
    private static readonly IntPtr NativeFieldInfoPtr_ColorAsset;
    private static readonly IntPtr NativeFieldInfoPtr_DiscoverableAsset;
    private static readonly IntPtr NativeFieldInfoPtr_ServantMissionAsset;
    private static readonly IntPtr NativeMethodInfoPtr_GetZoneColor_Public_Color_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetVertices_Public_List_1_ChunkMapZoneVertexAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetNativePolygon_Public_NativeList_1_float2_Allocator_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetEdgeColor_Public_Color_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetMapZoneFlags_Public_MapZoneFlags_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1124599, RefRangeEnd = 1124600, XrefRangeStart = 1124594, XrefRangeEnd = 1124599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Color GetZoneColor()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkMapZoneAuthoring.NativeMethodInfoPtr_GetZoneColor_Public_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1124631, RefRangeEnd = 1124632, XrefRangeStart = 1124600, XrefRangeEnd = 1124631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<ChunkMapZoneVertexAuthoring> GetVertices()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkMapZoneAuthoring.NativeMethodInfoPtr_GetVertices_Public_List_1_ChunkMapZoneVertexAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (List<ChunkMapZoneVertexAuthoring>) null : new List<ChunkMapZoneVertexAuthoring>(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1124664, RefRangeEnd = 1124665, XrefRangeStart = 1124632, XrefRangeEnd = 1124664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeList<float2> GetNativePolygon(Allocator allocator)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &allocator;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkMapZoneAuthoring.NativeMethodInfoPtr_GetNativePolygon_Public_NativeList_1_float2_Allocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<float2>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124665, XrefRangeEnd = 1124682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Color GetEdgeColor()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkMapZoneAuthoring.NativeMethodInfoPtr_GetEdgeColor_Public_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1124683, RefRangeEnd = 1124684, XrefRangeStart = 1124682, XrefRangeEnd = 1124683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MapZoneFlags GetMapZoneFlags()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkMapZoneAuthoring.NativeMethodInfoPtr_GetMapZoneFlags_Public_MapZoneFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(MapZoneFlags*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChunkMapZoneAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkMapZoneAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkMapZoneAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ChunkMapZoneAuthoring()
    {
      Il2CppClassPointerStore<ChunkMapZoneAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Terrain", nameof (ChunkMapZoneAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkMapZoneAuthoring>.NativeClassPtr);
      ChunkMapZoneAuthoring.NativeFieldInfoPtr_ZoneType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneAuthoring>.NativeClassPtr, nameof (ZoneType));
      ChunkMapZoneAuthoring.NativeFieldInfoPtr_AddCustomZoneFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneAuthoring>.NativeClassPtr, nameof (AddCustomZoneFlags));
      ChunkMapZoneAuthoring.NativeFieldInfoPtr_RemoveCustomZoneFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneAuthoring>.NativeClassPtr, nameof (RemoveCustomZoneFlags));
      ChunkMapZoneAuthoring.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneAuthoring>.NativeClassPtr, nameof (Name));
      ChunkMapZoneAuthoring.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneAuthoring>.NativeClassPtr, nameof (Description));
      ChunkMapZoneAuthoring.NativeFieldInfoPtr_LoreText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneAuthoring>.NativeClassPtr, nameof (LoreText));
      ChunkMapZoneAuthoring.NativeFieldInfoPtr_ColorAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneAuthoring>.NativeClassPtr, nameof (ColorAsset));
      ChunkMapZoneAuthoring.NativeFieldInfoPtr_DiscoverableAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneAuthoring>.NativeClassPtr, nameof (DiscoverableAsset));
      ChunkMapZoneAuthoring.NativeFieldInfoPtr_ServantMissionAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneAuthoring>.NativeClassPtr, nameof (ServantMissionAsset));
      ChunkMapZoneAuthoring.NativeMethodInfoPtr_GetZoneColor_Public_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneAuthoring>.NativeClassPtr, 100689224);
      ChunkMapZoneAuthoring.NativeMethodInfoPtr_GetVertices_Public_List_1_ChunkMapZoneVertexAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneAuthoring>.NativeClassPtr, 100689225);
      ChunkMapZoneAuthoring.NativeMethodInfoPtr_GetNativePolygon_Public_NativeList_1_float2_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneAuthoring>.NativeClassPtr, 100689226);
      ChunkMapZoneAuthoring.NativeMethodInfoPtr_GetEdgeColor_Public_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneAuthoring>.NativeClassPtr, 100689227);
      ChunkMapZoneAuthoring.NativeMethodInfoPtr_GetMapZoneFlags_Public_MapZoneFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneAuthoring>.NativeClassPtr, 100689228);
      ChunkMapZoneAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneAuthoring>.NativeClassPtr, 100689229);
    }

    public ChunkMapZoneAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe MapZoneType ZoneType
    {
      get
      {
        return *(MapZoneType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneAuthoring.NativeFieldInfoPtr_ZoneType));
      }
      [param: In] set
      {
        *(MapZoneType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneAuthoring.NativeFieldInfoPtr_ZoneType)) = value;
      }
    }

    public unsafe MapZoneFlags AddCustomZoneFlags
    {
      get
      {
        return *(MapZoneFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneAuthoring.NativeFieldInfoPtr_AddCustomZoneFlags));
      }
      [param: In] set
      {
        *(MapZoneFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneAuthoring.NativeFieldInfoPtr_AddCustomZoneFlags)) = value;
      }
    }

    public unsafe MapZoneFlags RemoveCustomZoneFlags
    {
      get
      {
        return *(MapZoneFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneAuthoring.NativeFieldInfoPtr_RemoveCustomZoneFlags));
      }
      [param: In] set
      {
        *(MapZoneFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneAuthoring.NativeFieldInfoPtr_RemoveCustomZoneFlags)) = value;
      }
    }

    public unsafe LocalizationKey Name
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneAuthoring.NativeFieldInfoPtr_Name));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneAuthoring.NativeFieldInfoPtr_Name)) = value;
      }
    }

    public unsafe LocalizationKey Description
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneAuthoring.NativeFieldInfoPtr_Description));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneAuthoring.NativeFieldInfoPtr_Description)) = value;
      }
    }

    public unsafe LocalizationKey LoreText
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneAuthoring.NativeFieldInfoPtr_LoreText));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneAuthoring.NativeFieldInfoPtr_LoreText)) = value;
      }
    }

    public unsafe ColorAsset ColorAsset
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneAuthoring.NativeFieldInfoPtr_ColorAsset));
        return pointer == IntPtr.Zero ? (ColorAsset) null : new ColorAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneAuthoring.NativeFieldInfoPtr_ColorAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ChunkMapZoneDiscoverables DiscoverableAsset
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneAuthoring.NativeFieldInfoPtr_DiscoverableAsset));
        return pointer == IntPtr.Zero ? (ChunkMapZoneDiscoverables) null : new ChunkMapZoneDiscoverables(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneAuthoring.NativeFieldInfoPtr_DiscoverableAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MissionDataAsset ServantMissionAsset
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneAuthoring.NativeFieldInfoPtr_ServantMissionAsset));
        return pointer == IntPtr.Zero ? (MissionDataAsset) null : new MissionDataAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneAuthoring.NativeFieldInfoPtr_ServantMissionAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
