// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.MapZoneNameOverride
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Stunlock.Localization;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MapZoneNameOverride
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FromName;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToName;
    [FieldOffset(0)]
    public LocalizationKey FromName;
    [FieldOffset(16)]
    public LocalizationKey ToName;

    static MapZoneNameOverride()
    {
      Il2CppClassPointerStore<MapZoneNameOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (MapZoneNameOverride));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapZoneNameOverride>.NativeClassPtr);
      MapZoneNameOverride.NativeFieldInfoPtr_FromName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneNameOverride>.NativeClassPtr, nameof (FromName));
      MapZoneNameOverride.NativeFieldInfoPtr_ToName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneNameOverride>.NativeClassPtr, nameof (ToName));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapZoneNameOverride>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
