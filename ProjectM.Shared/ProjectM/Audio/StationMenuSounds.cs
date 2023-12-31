// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.StationMenuSounds
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Stunlock.Fmod;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Audio
{
  [StructLayout(LayoutKind.Explicit)]
  public struct StationMenuSounds
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OpenSound;
    private static readonly System.IntPtr NativeFieldInfoPtr_CloseSound;
    [FieldOffset(0)]
    public FmodEventGuid OpenSound;
    [FieldOffset(16)]
    public FmodEventGuid CloseSound;

    static StationMenuSounds()
    {
      Il2CppClassPointerStore<StationMenuSounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Audio", nameof (StationMenuSounds));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationMenuSounds>.NativeClassPtr);
      StationMenuSounds.NativeFieldInfoPtr_OpenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationMenuSounds>.NativeClassPtr, nameof (OpenSound));
      StationMenuSounds.NativeFieldInfoPtr_CloseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationMenuSounds>.NativeClassPtr, nameof (CloseSound));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StationMenuSounds>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
