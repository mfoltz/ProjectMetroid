// Decompiled with JetBrains decompiler
// Type: ProjectM.SunDamageDebuff
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SunDamageDebuff
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CooldownTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageFactorPerTick;
    private static readonly System.IntPtr NativeFieldInfoPtr_TickRate;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveSequenceState;
    [FieldOffset(0)]
    public float CooldownTime;
    [FieldOffset(4)]
    public float DamageFactorPerTick;
    [FieldOffset(8)]
    public float TickRate;
    [FieldOffset(12)]
    public SequenceGUID ActiveSequence;
    [FieldOffset(16)]
    public SequenceState ActiveSequenceState;

    static SunDamageDebuff()
    {
      Il2CppClassPointerStore<SunDamageDebuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SunDamageDebuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SunDamageDebuff>.NativeClassPtr);
      SunDamageDebuff.NativeFieldInfoPtr_CooldownTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SunDamageDebuff>.NativeClassPtr, nameof (CooldownTime));
      SunDamageDebuff.NativeFieldInfoPtr_DamageFactorPerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SunDamageDebuff>.NativeClassPtr, nameof (DamageFactorPerTick));
      SunDamageDebuff.NativeFieldInfoPtr_TickRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SunDamageDebuff>.NativeClassPtr, nameof (TickRate));
      SunDamageDebuff.NativeFieldInfoPtr_ActiveSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SunDamageDebuff>.NativeClassPtr, nameof (ActiveSequence));
      SunDamageDebuff.NativeFieldInfoPtr_ActiveSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SunDamageDebuff>.NativeClassPtr, nameof (ActiveSequenceState));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SunDamageDebuff>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
