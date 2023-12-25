// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MapIconRenderData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MapIconRenderData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AnchoredPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseQ;
    private static readonly System.IntPtr NativeFieldInfoPtr_RRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_QRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapIconDataPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_RenderOrder;
    private static readonly System.IntPtr NativeFieldInfoPtr_LabelOverides;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowLabelIfExists;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowSiege;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverridedCastleIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapIconDrawMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_WaypointNetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClickType;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlphaOverride;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowOverFOW;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnLocationSelector;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnLocationIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnLocationIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapIconData;
    [FieldOffset(0)]
    public Vector3 AnchoredPosition;
    [FieldOffset(12)]
    public bool UseQ;
    [FieldOffset(16)]
    public Rotation RRotation;
    [FieldOffset(32)]
    public Quaternion QRotation;
    [FieldOffset(48)]
    public PrefabGUID MapIconDataPrefabGuid;
    [FieldOffset(52)]
    public Entity Entity;
    [FieldOffset(60)]
    public int RenderOrder;
    [FieldOffset(64)]
    public LabelOverrides LabelOverides;
    [FieldOffset(164)]
    public bool ShowLabelIfExists;
    [FieldOffset(165)]
    public bool ShowSiege;
    [FieldOffset(168)]
    public int OverridedCastleIcon;
    [FieldOffset(172)]
    public MapIconDrawMode MapIconDrawMode;
    [FieldOffset(176)]
    public NetworkId WaypointNetworkId;
    [FieldOffset(184)]
    public MapClickType ClickType;
    [FieldOffset(188)]
    public Nullable_Unboxed<float> AlphaOverride;
    [FieldOffset(196)]
    public bool ShowOverFOW;
    [FieldOffset(200)]
    public SpawnLocationSelector SpawnLocationSelector;
    [FieldOffset(208)]
    public NetworkId SpawnLocationIcon;
    [FieldOffset(216)]
    public int SpawnLocationIndex;
    [FieldOffset(220)]
    public MapIconData MapIconData;

    static MapIconRenderData()
    {
      Il2CppClassPointerStore<MapIconRenderData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MapIconRenderData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapIconRenderData>.NativeClassPtr);
      MapIconRenderData.NativeFieldInfoPtr_AnchoredPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconRenderData>.NativeClassPtr, nameof (AnchoredPosition));
      MapIconRenderData.NativeFieldInfoPtr_UseQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconRenderData>.NativeClassPtr, nameof (UseQ));
      MapIconRenderData.NativeFieldInfoPtr_RRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconRenderData>.NativeClassPtr, nameof (RRotation));
      MapIconRenderData.NativeFieldInfoPtr_QRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconRenderData>.NativeClassPtr, nameof (QRotation));
      MapIconRenderData.NativeFieldInfoPtr_MapIconDataPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconRenderData>.NativeClassPtr, nameof (MapIconDataPrefabGuid));
      MapIconRenderData.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconRenderData>.NativeClassPtr, nameof (Entity));
      MapIconRenderData.NativeFieldInfoPtr_RenderOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconRenderData>.NativeClassPtr, nameof (RenderOrder));
      MapIconRenderData.NativeFieldInfoPtr_LabelOverides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconRenderData>.NativeClassPtr, nameof (LabelOverides));
      MapIconRenderData.NativeFieldInfoPtr_ShowLabelIfExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconRenderData>.NativeClassPtr, nameof (ShowLabelIfExists));
      MapIconRenderData.NativeFieldInfoPtr_ShowSiege = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconRenderData>.NativeClassPtr, nameof (ShowSiege));
      MapIconRenderData.NativeFieldInfoPtr_OverridedCastleIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconRenderData>.NativeClassPtr, nameof (OverridedCastleIcon));
      MapIconRenderData.NativeFieldInfoPtr_MapIconDrawMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconRenderData>.NativeClassPtr, nameof (MapIconDrawMode));
      MapIconRenderData.NativeFieldInfoPtr_WaypointNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconRenderData>.NativeClassPtr, nameof (WaypointNetworkId));
      MapIconRenderData.NativeFieldInfoPtr_ClickType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconRenderData>.NativeClassPtr, nameof (ClickType));
      MapIconRenderData.NativeFieldInfoPtr_AlphaOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconRenderData>.NativeClassPtr, nameof (AlphaOverride));
      MapIconRenderData.NativeFieldInfoPtr_ShowOverFOW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconRenderData>.NativeClassPtr, nameof (ShowOverFOW));
      MapIconRenderData.NativeFieldInfoPtr_SpawnLocationSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconRenderData>.NativeClassPtr, nameof (SpawnLocationSelector));
      MapIconRenderData.NativeFieldInfoPtr_SpawnLocationIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconRenderData>.NativeClassPtr, nameof (SpawnLocationIcon));
      MapIconRenderData.NativeFieldInfoPtr_SpawnLocationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconRenderData>.NativeClassPtr, nameof (SpawnLocationIndex));
      MapIconRenderData.NativeFieldInfoPtr_MapIconData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconRenderData>.NativeClassPtr, nameof (MapIconData));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapIconRenderData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
