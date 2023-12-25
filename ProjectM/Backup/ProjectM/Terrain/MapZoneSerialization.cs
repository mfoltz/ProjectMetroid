// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.MapZoneSerialization
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Localization;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM.Terrain
{
  public static class MapZoneSerialization : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateSizeBytes_Public_Static_Int32_Il2CppReferenceArray_1_ChunkMapZoneAuthoring_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeArray_Public_Static_NetBufferOut_Il2CppReferenceArray_1_ChunkMapZoneAuthoring_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeArray_Public_Static_Il2CppStructArray_1_ZoneData_byref_NetBufferIn_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeZone_Public_Static_Void_byref_NetBufferOut_ZoneData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeZone_Public_Static_ZoneData_byref_NetBufferIn_Allocator_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124748, XrefRangeEnd = 1124753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int CalculateSizeBytes(
      Il2CppReferenceArray<ChunkMapZoneAuthoring> chunkMapZones)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) chunkMapZones);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneSerialization.NativeMethodInfoPtr_CalculateSizeBytes_Public_Static_Int32_Il2CppReferenceArray_1_ChunkMapZoneAuthoring_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1124830, RefRangeEnd = 1124832, XrefRangeStart = 1124753, XrefRangeEnd = 1124830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NetBufferOut SerializeArray(
      Il2CppReferenceArray<ChunkMapZoneAuthoring> chunkMapZones,
      Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) chunkMapZones);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneSerialization.NativeMethodInfoPtr_SerializeArray_Public_Static_NetBufferOut_Il2CppReferenceArray_1_ChunkMapZoneAuthoring_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NetBufferOut*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124832, XrefRangeEnd = 1124837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppStructArray<MapZoneSerialization.ZoneData> DeserializeArray(
      ref NetBufferIn netBuffer,
      Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneSerialization.NativeMethodInfoPtr_DeserializeArray_Public_Static_Il2CppStructArray_1_ZoneData_byref_NetBufferIn_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<MapZoneSerialization.ZoneData>) null : new Il2CppStructArray<MapZoneSerialization.ZoneData>(nativeObject);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1124878, RefRangeEnd = 1124879, XrefRangeStart = 1124837, XrefRangeEnd = 1124878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SerializeZone(
      ref NetBufferOut netBuffer,
      MapZoneSerialization.ZoneData data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapZoneSerialization.NativeMethodInfoPtr_SerializeZone_Public_Static_Void_byref_NetBufferOut_ZoneData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1124901, RefRangeEnd = 1124904, XrefRangeStart = 1124879, XrefRangeEnd = 1124901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe MapZoneSerialization.ZoneData DeserializeZone(
      ref NetBufferIn netBuffer,
      Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneSerialization.NativeMethodInfoPtr_DeserializeZone_Public_Static_ZoneData_byref_NetBufferIn_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(MapZoneSerialization.ZoneData*) IL2CPP.il2cpp_object_unbox(num);
    }

    static MapZoneSerialization()
    {
      Il2CppClassPointerStore<MapZoneSerialization>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Terrain", nameof (MapZoneSerialization));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapZoneSerialization>.NativeClassPtr);
      MapZoneSerialization.NativeMethodInfoPtr_CalculateSizeBytes_Public_Static_Int32_Il2CppReferenceArray_1_ChunkMapZoneAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneSerialization>.NativeClassPtr, 100689234);
      MapZoneSerialization.NativeMethodInfoPtr_SerializeArray_Public_Static_NetBufferOut_Il2CppReferenceArray_1_ChunkMapZoneAuthoring_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneSerialization>.NativeClassPtr, 100689235);
      MapZoneSerialization.NativeMethodInfoPtr_DeserializeArray_Public_Static_Il2CppStructArray_1_ZoneData_byref_NetBufferIn_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneSerialization>.NativeClassPtr, 100689236);
      MapZoneSerialization.NativeMethodInfoPtr_SerializeZone_Public_Static_Void_byref_NetBufferOut_ZoneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneSerialization>.NativeClassPtr, 100689237);
      MapZoneSerialization.NativeMethodInfoPtr_DeserializeZone_Public_Static_ZoneData_byref_NetBufferIn_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneSerialization>.NativeClassPtr, 100689238);
    }

    public MapZoneSerialization(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ZoneData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Vertices;
      private static readonly System.IntPtr NativeFieldInfoPtr_ZoneFlags;
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_Description;
      private static readonly System.IntPtr NativeFieldInfoPtr_LoreText;
      private static readonly System.IntPtr NativeFieldInfoPtr_Color;
      private static readonly System.IntPtr NativeFieldInfoPtr_Discoverables;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServantMissionPrefabGuid;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
      [FieldOffset(0)]
      public NativeArray<float2> Vertices;
      [FieldOffset(16)]
      public MapZoneFlags ZoneFlags;
      [FieldOffset(20)]
      public LocalizationKey Name;
      [FieldOffset(36)]
      public LocalizationKey Description;
      [FieldOffset(52)]
      public LocalizationKey LoreText;
      [FieldOffset(68)]
      public Color32 Color;
      [FieldOffset(72)]
      public NativeArray<PrefabGUID> Discoverables;
      [FieldOffset(88)]
      public PrefabGUID ServantMissionPrefabGuid;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124736, XrefRangeEnd = 1124748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Dispose()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapZoneSerialization.ZoneData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ZoneData()
      {
        Il2CppClassPointerStore<MapZoneSerialization.ZoneData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapZoneSerialization>.NativeClassPtr, nameof (ZoneData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapZoneSerialization.ZoneData>.NativeClassPtr);
        MapZoneSerialization.ZoneData.NativeFieldInfoPtr_Vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneSerialization.ZoneData>.NativeClassPtr, nameof (Vertices));
        MapZoneSerialization.ZoneData.NativeFieldInfoPtr_ZoneFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneSerialization.ZoneData>.NativeClassPtr, nameof (ZoneFlags));
        MapZoneSerialization.ZoneData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneSerialization.ZoneData>.NativeClassPtr, nameof (Name));
        MapZoneSerialization.ZoneData.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneSerialization.ZoneData>.NativeClassPtr, nameof (Description));
        MapZoneSerialization.ZoneData.NativeFieldInfoPtr_LoreText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneSerialization.ZoneData>.NativeClassPtr, nameof (LoreText));
        MapZoneSerialization.ZoneData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneSerialization.ZoneData>.NativeClassPtr, nameof (Color));
        MapZoneSerialization.ZoneData.NativeFieldInfoPtr_Discoverables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneSerialization.ZoneData>.NativeClassPtr, nameof (Discoverables));
        MapZoneSerialization.ZoneData.NativeFieldInfoPtr_ServantMissionPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneSerialization.ZoneData>.NativeClassPtr, nameof (ServantMissionPrefabGuid));
        MapZoneSerialization.ZoneData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneSerialization.ZoneData>.NativeClassPtr, 100689239);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapZoneSerialization.ZoneData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
