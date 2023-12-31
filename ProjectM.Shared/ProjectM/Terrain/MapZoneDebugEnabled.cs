// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.MapZoneDebugEnabled
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MapZoneDebugEnabled
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DrawZones;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrintPlayerZone;
    [FieldOffset(0)]
    public bool DrawZones;
    [FieldOffset(1)]
    public bool PrintPlayerZone;

    static MapZoneDebugEnabled()
    {
      Il2CppClassPointerStore<MapZoneDebugEnabled>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (MapZoneDebugEnabled));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapZoneDebugEnabled>.NativeClassPtr);
      MapZoneDebugEnabled.NativeFieldInfoPtr_DrawZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugEnabled>.NativeClassPtr, nameof (DrawZones));
      MapZoneDebugEnabled.NativeFieldInfoPtr_PrintPlayerZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugEnabled>.NativeClassPtr, nameof (PrintPlayerZone));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapZoneDebugEnabled>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
