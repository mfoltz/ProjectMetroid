// Decompiled with JetBrains decompiler
// Type: ProjectM.MapPylonArea
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MapPylonArea
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AllyColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_NonAllyColor;
    [FieldOffset(0)]
    public Color AllyColor;
    [FieldOffset(16)]
    public Color NonAllyColor;

    static MapPylonArea()
    {
      Il2CppClassPointerStore<MapPylonArea>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MapPylonArea));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapPylonArea>.NativeClassPtr);
      MapPylonArea.NativeFieldInfoPtr_AllyColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPylonArea>.NativeClassPtr, nameof (AllyColor));
      MapPylonArea.NativeFieldInfoPtr_NonAllyColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPylonArea>.NativeClassPtr, nameof (NonAllyColor));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapPylonArea>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
