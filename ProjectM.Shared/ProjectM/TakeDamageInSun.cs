// Decompiled with JetBrains decompiler
// Type: ProjectM.TakeDamageInSun
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TakeDamageInSun
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Debuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChargeValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_CooldownValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_SunDamageDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SunChargeUpTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_SunCooldownTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_NextTickTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChargeUpSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChargeUpSunbeamSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChargeUpSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChargeUpSunbeamSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CooldownSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_CooldownSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_SunIntensity;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsInSun;
    [FieldOffset(0)]
    public PrefabGUID Debuff;
    [FieldOffset(4)]
    public float ChargeValue;
    [FieldOffset(8)]
    public float CooldownValue;
    [FieldOffset(12)]
    public bool SunDamageDisabled;
    [FieldOffset(16)]
    public ModifiableFloat SunChargeUpTime;
    [FieldOffset(24)]
    public float SunCooldownTime;
    [FieldOffset(32)]
    public double NextTickTime;
    [FieldOffset(40)]
    public SequenceGUID ChargeUpSequence;
    [FieldOffset(44)]
    public SequenceGUID ChargeUpSunbeamSequence;
    [FieldOffset(48)]
    public SequenceState ChargeUpSequenceState;
    [FieldOffset(56)]
    public SequenceState ChargeUpSunbeamSequenceState;
    [FieldOffset(64)]
    public SequenceGUID CooldownSequence;
    [FieldOffset(68)]
    public SequenceState CooldownSequenceState;
    [FieldOffset(76)]
    public float SunIntensity;
    [FieldOffset(80)]
    public bool IsInSun;

    static TakeDamageInSun()
    {
      Il2CppClassPointerStore<TakeDamageInSun>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TakeDamageInSun));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TakeDamageInSun>.NativeClassPtr);
      TakeDamageInSun.NativeFieldInfoPtr_Debuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeDamageInSun>.NativeClassPtr, nameof (Debuff));
      TakeDamageInSun.NativeFieldInfoPtr_ChargeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeDamageInSun>.NativeClassPtr, nameof (ChargeValue));
      TakeDamageInSun.NativeFieldInfoPtr_CooldownValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeDamageInSun>.NativeClassPtr, nameof (CooldownValue));
      TakeDamageInSun.NativeFieldInfoPtr_SunDamageDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeDamageInSun>.NativeClassPtr, nameof (SunDamageDisabled));
      TakeDamageInSun.NativeFieldInfoPtr_SunChargeUpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeDamageInSun>.NativeClassPtr, nameof (SunChargeUpTime));
      TakeDamageInSun.NativeFieldInfoPtr_SunCooldownTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeDamageInSun>.NativeClassPtr, nameof (SunCooldownTime));
      TakeDamageInSun.NativeFieldInfoPtr_NextTickTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeDamageInSun>.NativeClassPtr, nameof (NextTickTime));
      TakeDamageInSun.NativeFieldInfoPtr_ChargeUpSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeDamageInSun>.NativeClassPtr, nameof (ChargeUpSequence));
      TakeDamageInSun.NativeFieldInfoPtr_ChargeUpSunbeamSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeDamageInSun>.NativeClassPtr, nameof (ChargeUpSunbeamSequence));
      TakeDamageInSun.NativeFieldInfoPtr_ChargeUpSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeDamageInSun>.NativeClassPtr, nameof (ChargeUpSequenceState));
      TakeDamageInSun.NativeFieldInfoPtr_ChargeUpSunbeamSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeDamageInSun>.NativeClassPtr, nameof (ChargeUpSunbeamSequenceState));
      TakeDamageInSun.NativeFieldInfoPtr_CooldownSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeDamageInSun>.NativeClassPtr, nameof (CooldownSequence));
      TakeDamageInSun.NativeFieldInfoPtr_CooldownSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeDamageInSun>.NativeClassPtr, nameof (CooldownSequenceState));
      TakeDamageInSun.NativeFieldInfoPtr_SunIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeDamageInSun>.NativeClassPtr, nameof (SunIntensity));
      TakeDamageInSun.NativeFieldInfoPtr_IsInSun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeDamageInSun>.NativeClassPtr, nameof (IsInSun));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TakeDamageInSun>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
