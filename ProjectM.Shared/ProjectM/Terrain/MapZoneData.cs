// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.MapZoneData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MapZoneData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxVertices;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDiscoveries;
    private static readonly System.IntPtr NativeFieldInfoPtr_ZoneFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_ZoneIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Description;
    private static readonly System.IntPtr NativeFieldInfoPtr_LoreText;
    private static readonly System.IntPtr NativeFieldInfoPtr_Color;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChunkCoordinate;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServantMissionAsset;
    private static readonly System.IntPtr NativeFieldInfoPtr_CenterPosWS;
    private static readonly System.IntPtr NativeFieldInfoPtr_AspectRatio;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxUV;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinUV;
    private static readonly System.IntPtr NativeFieldInfoPtr_TextureDataIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ZoneId_Public_get_MapZoneId_0;
    [FieldOffset(0)]
    public MapZoneFlags ZoneFlags;
    [FieldOffset(1)]
    public byte ZoneIndex;
    [FieldOffset(4)]
    public LocalizationKey Name;
    [FieldOffset(20)]
    public LocalizationKey Description;
    [FieldOffset(36)]
    public LocalizationKey LoreText;
    [FieldOffset(52)]
    public Color Color;
    [FieldOffset(68)]
    public TerrainChunk ChunkCoordinate;
    [FieldOffset(76)]
    public PrefabGUID ServantMissionAsset;
    [FieldOffset(80)]
    public float2 CenterPosWS;
    [FieldOffset(88)]
    public float2 AspectRatio;
    [FieldOffset(96)]
    public float2 MaxUV;
    [FieldOffset(104)]
    public float2 MinUV;
    [FieldOffset(112)]
    public int TextureDataIndex;

    public unsafe MapZoneId ZoneId
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 766639, RefRangeEnd = 766647, XrefRangeStart = 766639, XrefRangeEnd = 766639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneData.NativeMethodInfoPtr_get_ZoneId_Public_get_MapZoneId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(MapZoneId*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static MapZoneData()
    {
      Il2CppClassPointerStore<MapZoneData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (MapZoneData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapZoneData>.NativeClassPtr);
      MapZoneData.NativeFieldInfoPtr_MaxVertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneData>.NativeClassPtr, nameof (MaxVertices));
      MapZoneData.NativeFieldInfoPtr_MaxDiscoveries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneData>.NativeClassPtr, nameof (MaxDiscoveries));
      MapZoneData.NativeFieldInfoPtr_ZoneFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneData>.NativeClassPtr, nameof (ZoneFlags));
      MapZoneData.NativeFieldInfoPtr_ZoneIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneData>.NativeClassPtr, nameof (ZoneIndex));
      MapZoneData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneData>.NativeClassPtr, nameof (Name));
      MapZoneData.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneData>.NativeClassPtr, nameof (Description));
      MapZoneData.NativeFieldInfoPtr_LoreText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneData>.NativeClassPtr, nameof (LoreText));
      MapZoneData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneData>.NativeClassPtr, nameof (Color));
      MapZoneData.NativeFieldInfoPtr_ChunkCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneData>.NativeClassPtr, nameof (ChunkCoordinate));
      MapZoneData.NativeFieldInfoPtr_ServantMissionAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneData>.NativeClassPtr, nameof (ServantMissionAsset));
      MapZoneData.NativeFieldInfoPtr_CenterPosWS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneData>.NativeClassPtr, nameof (CenterPosWS));
      MapZoneData.NativeFieldInfoPtr_AspectRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneData>.NativeClassPtr, nameof (AspectRatio));
      MapZoneData.NativeFieldInfoPtr_MaxUV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneData>.NativeClassPtr, nameof (MaxUV));
      MapZoneData.NativeFieldInfoPtr_MinUV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneData>.NativeClassPtr, nameof (MinUV));
      MapZoneData.NativeFieldInfoPtr_TextureDataIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneData>.NativeClassPtr, nameof (TextureDataIndex));
      MapZoneData.NativeMethodInfoPtr_get_ZoneId_Public_get_MapZoneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneData>.NativeClassPtr, 100667782);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapZoneData>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int MaxVertices
    {
      get
      {
        int maxVertices;
        IL2CPP.il2cpp_field_static_get_value(MapZoneData.NativeFieldInfoPtr_MaxVertices, (void*) &maxVertices);
        return maxVertices;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MapZoneData.NativeFieldInfoPtr_MaxVertices, (void*) &value);
      }
    }

    public static unsafe int MaxDiscoveries
    {
      get
      {
        int maxDiscoveries;
        IL2CPP.il2cpp_field_static_get_value(MapZoneData.NativeFieldInfoPtr_MaxDiscoveries, (void*) &maxDiscoveries);
        return maxDiscoveries;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MapZoneData.NativeFieldInfoPtr_MaxDiscoveries, (void*) &value);
      }
    }
  }
}
