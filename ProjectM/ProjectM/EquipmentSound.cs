// Decompiled with JetBrains decompiler
// Type: ProjectM.EquipmentSound
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Stunlock.Fmod;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct EquipmentSound
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EquipSoundGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnequipSoundGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsInit;
    [FieldOffset(0)]
    public FmodEventGuid EquipSoundGuid;
    [FieldOffset(16)]
    public FmodEventGuid UnequipSoundGuid;
    [FieldOffset(32)]
    public bool IsInit;

    static EquipmentSound()
    {
      Il2CppClassPointerStore<EquipmentSound>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (EquipmentSound));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipmentSound>.NativeClassPtr);
      EquipmentSound.NativeFieldInfoPtr_EquipSoundGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentSound>.NativeClassPtr, nameof (EquipSoundGuid));
      EquipmentSound.NativeFieldInfoPtr_UnequipSoundGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentSound>.NativeClassPtr, nameof (UnequipSoundGuid));
      EquipmentSound.NativeFieldInfoPtr_IsInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentSound>.NativeClassPtr, nameof (IsInit));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EquipmentSound>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
