// Decompiled with JetBrains decompiler
// Type: ProjectM.MapIconLabelSettings
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
  public struct MapIconLabelSettings
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowOnBigMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowOnMiniMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_Color;
    private static readonly System.IntPtr NativeFieldInfoPtr_TransitionTime;
    [FieldOffset(0)]
    public bool ShowOnBigMap;
    [FieldOffset(1)]
    public bool ShowOnMiniMap;
    [FieldOffset(4)]
    public Color Color;
    [FieldOffset(20)]
    public float TransitionTime;

    static MapIconLabelSettings()
    {
      Il2CppClassPointerStore<MapIconLabelSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MapIconLabelSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapIconLabelSettings>.NativeClassPtr);
      MapIconLabelSettings.NativeFieldInfoPtr_ShowOnBigMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconLabelSettings>.NativeClassPtr, nameof (ShowOnBigMap));
      MapIconLabelSettings.NativeFieldInfoPtr_ShowOnMiniMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconLabelSettings>.NativeClassPtr, nameof (ShowOnMiniMap));
      MapIconLabelSettings.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconLabelSettings>.NativeClassPtr, nameof (Color));
      MapIconLabelSettings.NativeFieldInfoPtr_TransitionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconLabelSettings>.NativeClassPtr, nameof (TransitionTime));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapIconLabelSettings>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
