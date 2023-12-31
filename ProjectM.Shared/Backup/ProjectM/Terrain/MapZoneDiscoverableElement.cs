// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.MapZoneDiscoverableElement
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MapZoneDiscoverableElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Prefab;
    [FieldOffset(0)]
    public PrefabGUID Prefab;

    static MapZoneDiscoverableElement()
    {
      Il2CppClassPointerStore<MapZoneDiscoverableElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (MapZoneDiscoverableElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapZoneDiscoverableElement>.NativeClassPtr);
      MapZoneDiscoverableElement.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDiscoverableElement>.NativeClassPtr, nameof (Prefab));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapZoneDiscoverableElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
