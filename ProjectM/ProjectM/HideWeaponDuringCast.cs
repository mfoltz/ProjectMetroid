// Decompiled with JetBrains decompiler
// Type: ProjectM.HideWeaponDuringCast
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HideWeaponDuringCast
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CastStartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastStartCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    [FieldOffset(0)]
    public double CastStartTime;
    [FieldOffset(8)]
    public float Duration;
    [FieldOffset(12)]
    public int CastStartCounter;
    [FieldOffset(16)]
    public HideWeaponDuringCastType Type;

    static HideWeaponDuringCast()
    {
      Il2CppClassPointerStore<HideWeaponDuringCast>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (HideWeaponDuringCast));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideWeaponDuringCast>.NativeClassPtr);
      HideWeaponDuringCast.NativeFieldInfoPtr_CastStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideWeaponDuringCast>.NativeClassPtr, nameof (CastStartTime));
      HideWeaponDuringCast.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideWeaponDuringCast>.NativeClassPtr, nameof (Duration));
      HideWeaponDuringCast.NativeFieldInfoPtr_CastStartCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideWeaponDuringCast>.NativeClassPtr, nameof (CastStartCounter));
      HideWeaponDuringCast.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideWeaponDuringCast>.NativeClassPtr, nameof (Type));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HideWeaponDuringCast>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
