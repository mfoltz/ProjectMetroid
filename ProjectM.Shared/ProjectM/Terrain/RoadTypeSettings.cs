// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.RoadTypeSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RoadTypeSettings
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Width;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditorColor;
    [FieldOffset(0)]
    public float Width;
    [FieldOffset(4)]
    public Color EditorColor;

    static RoadTypeSettings()
    {
      Il2CppClassPointerStore<RoadTypeSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (RoadTypeSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoadTypeSettings>.NativeClassPtr);
      RoadTypeSettings.NativeFieldInfoPtr_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadTypeSettings>.NativeClassPtr, nameof (Width));
      RoadTypeSettings.NativeFieldInfoPtr_EditorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadTypeSettings>.NativeClassPtr, nameof (EditorColor));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoadTypeSettings>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
