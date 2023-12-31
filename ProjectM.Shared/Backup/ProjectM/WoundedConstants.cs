// Decompiled with JetBrains decompiler
// Type: ProjectM.WoundedConstants
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct WoundedConstants
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_WoundedTriggerSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_WoundedSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_TriggerKnockbackOnWounded;
    private static readonly System.IntPtr NativeFieldInfoPtr_KnockbackPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_KnockbackDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_KnockbackRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_WoundedKnockbackResistanceIndex;
    [FieldOffset(0)]
    public float HealthFactor;
    [FieldOffset(4)]
    public SequenceGUID WoundedTriggerSequenceGuid;
    [FieldOffset(8)]
    public SequenceGUID WoundedSequenceGuid;
    [FieldOffset(12)]
    public bool TriggerKnockbackOnWounded;
    [FieldOffset(16)]
    public KnockbackPower KnockbackPower;
    [FieldOffset(196)]
    public float KnockbackDuration;
    [FieldOffset(200)]
    public float KnockbackRange;
    [FieldOffset(204)]
    public int WoundedKnockbackResistanceIndex;

    static WoundedConstants()
    {
      Il2CppClassPointerStore<WoundedConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (WoundedConstants));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WoundedConstants>.NativeClassPtr);
      WoundedConstants.NativeFieldInfoPtr_HealthFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WoundedConstants>.NativeClassPtr, nameof (HealthFactor));
      WoundedConstants.NativeFieldInfoPtr_WoundedTriggerSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WoundedConstants>.NativeClassPtr, nameof (WoundedTriggerSequenceGuid));
      WoundedConstants.NativeFieldInfoPtr_WoundedSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WoundedConstants>.NativeClassPtr, nameof (WoundedSequenceGuid));
      WoundedConstants.NativeFieldInfoPtr_TriggerKnockbackOnWounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WoundedConstants>.NativeClassPtr, nameof (TriggerKnockbackOnWounded));
      WoundedConstants.NativeFieldInfoPtr_KnockbackPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WoundedConstants>.NativeClassPtr, nameof (KnockbackPower));
      WoundedConstants.NativeFieldInfoPtr_KnockbackDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WoundedConstants>.NativeClassPtr, nameof (KnockbackDuration));
      WoundedConstants.NativeFieldInfoPtr_KnockbackRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WoundedConstants>.NativeClassPtr, nameof (KnockbackRange));
      WoundedConstants.NativeFieldInfoPtr_WoundedKnockbackResistanceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WoundedConstants>.NativeClassPtr, nameof (WoundedKnockbackResistanceIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WoundedConstants>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
