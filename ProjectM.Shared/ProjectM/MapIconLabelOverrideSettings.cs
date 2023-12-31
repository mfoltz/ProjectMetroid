// Decompiled with JetBrains decompiler
// Type: ProjectM.MapIconLabelOverrideSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct MapIconLabelOverrideSettings
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideShowOnBigMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowOnBigMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideShowOnMiniMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowOnMiniMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_Color;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideTransitionTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_TransitionTime;
    [FieldOffset(0)]
    public bool OverrideShowOnBigMap;
    [FieldOffset(1)]
    public bool ShowOnBigMap;
    [FieldOffset(2)]
    public bool OverrideShowOnMiniMap;
    [FieldOffset(3)]
    public bool ShowOnMiniMap;
    [FieldOffset(4)]
    public bool OverrideColor;
    [FieldOffset(8)]
    public Color Color;
    [FieldOffset(24)]
    public bool OverrideTransitionTime;
    [FieldOffset(28)]
    public float TransitionTime;

    static MapIconLabelOverrideSettings()
    {
      Il2CppClassPointerStore<MapIconLabelOverrideSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MapIconLabelOverrideSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapIconLabelOverrideSettings>.NativeClassPtr);
      MapIconLabelOverrideSettings.NativeFieldInfoPtr_OverrideShowOnBigMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconLabelOverrideSettings>.NativeClassPtr, nameof (OverrideShowOnBigMap));
      MapIconLabelOverrideSettings.NativeFieldInfoPtr_ShowOnBigMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconLabelOverrideSettings>.NativeClassPtr, nameof (ShowOnBigMap));
      MapIconLabelOverrideSettings.NativeFieldInfoPtr_OverrideShowOnMiniMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconLabelOverrideSettings>.NativeClassPtr, nameof (OverrideShowOnMiniMap));
      MapIconLabelOverrideSettings.NativeFieldInfoPtr_ShowOnMiniMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconLabelOverrideSettings>.NativeClassPtr, nameof (ShowOnMiniMap));
      MapIconLabelOverrideSettings.NativeFieldInfoPtr_OverrideColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconLabelOverrideSettings>.NativeClassPtr, nameof (OverrideColor));
      MapIconLabelOverrideSettings.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconLabelOverrideSettings>.NativeClassPtr, nameof (Color));
      MapIconLabelOverrideSettings.NativeFieldInfoPtr_OverrideTransitionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconLabelOverrideSettings>.NativeClassPtr, nameof (OverrideTransitionTime));
      MapIconLabelOverrideSettings.NativeFieldInfoPtr_TransitionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconLabelOverrideSettings>.NativeClassPtr, nameof (TransitionTime));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapIconLabelOverrideSettings>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
