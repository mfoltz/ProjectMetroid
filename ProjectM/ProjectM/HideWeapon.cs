// Decompiled with JetBrains decompiler
// Type: ProjectM.HideWeapon
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HideWeapon
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HideWeaponSequenceGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideWeaponState;
    [FieldOffset(0)]
    public SequenceGUID HideWeaponSequenceGUID;
    [FieldOffset(4)]
    public SequenceState HideWeaponState;

    static HideWeapon()
    {
      Il2CppClassPointerStore<HideWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (HideWeapon));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideWeapon>.NativeClassPtr);
      HideWeapon.NativeFieldInfoPtr_HideWeaponSequenceGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideWeapon>.NativeClassPtr, nameof (HideWeaponSequenceGUID));
      HideWeapon.NativeFieldInfoPtr_HideWeaponState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideWeapon>.NativeClassPtr, nameof (HideWeaponState));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HideWeapon>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
