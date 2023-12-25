﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Example_ExplosiveBarrel_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using ProjectM.Scripting;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Example_ExplosiveBarrel_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OnDamageTakenListener;
    private static readonly System.IntPtr NativeFieldInfoPtr_FuseSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_FuseSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_KnockbackPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_KnockbackDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_KnockbackRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_FuseDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_FuseActive;
    [FieldOffset(0)]
    public ListenerId OnDamageTakenListener;
    [FieldOffset(8)]
    public SequenceGUID FuseSequence;
    [FieldOffset(12)]
    public SequenceState FuseSequenceState;
    [FieldOffset(20)]
    public KnockbackPower KnockbackPower;
    [FieldOffset(200)]
    public float KnockbackDuration;
    [FieldOffset(204)]
    public float KnockbackRange;
    [FieldOffset(208)]
    public float FuseDuration;
    [FieldOffset(212)]
    public bool FuseActive;

    static Example_ExplosiveBarrel_DataShared()
    {
      Il2CppClassPointerStore<Example_ExplosiveBarrel_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Example_ExplosiveBarrel_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Example_ExplosiveBarrel_DataShared>.NativeClassPtr);
      Example_ExplosiveBarrel_DataShared.NativeFieldInfoPtr_OnDamageTakenListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Example_ExplosiveBarrel_DataShared>.NativeClassPtr, nameof (OnDamageTakenListener));
      Example_ExplosiveBarrel_DataShared.NativeFieldInfoPtr_FuseSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Example_ExplosiveBarrel_DataShared>.NativeClassPtr, nameof (FuseSequence));
      Example_ExplosiveBarrel_DataShared.NativeFieldInfoPtr_FuseSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Example_ExplosiveBarrel_DataShared>.NativeClassPtr, nameof (FuseSequenceState));
      Example_ExplosiveBarrel_DataShared.NativeFieldInfoPtr_KnockbackPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Example_ExplosiveBarrel_DataShared>.NativeClassPtr, nameof (KnockbackPower));
      Example_ExplosiveBarrel_DataShared.NativeFieldInfoPtr_KnockbackDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Example_ExplosiveBarrel_DataShared>.NativeClassPtr, nameof (KnockbackDuration));
      Example_ExplosiveBarrel_DataShared.NativeFieldInfoPtr_KnockbackRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Example_ExplosiveBarrel_DataShared>.NativeClassPtr, nameof (KnockbackRange));
      Example_ExplosiveBarrel_DataShared.NativeFieldInfoPtr_FuseDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Example_ExplosiveBarrel_DataShared>.NativeClassPtr, nameof (FuseDuration));
      Example_ExplosiveBarrel_DataShared.NativeFieldInfoPtr_FuseActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Example_ExplosiveBarrel_DataShared>.NativeClassPtr, nameof (FuseActive));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Example_ExplosiveBarrel_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
