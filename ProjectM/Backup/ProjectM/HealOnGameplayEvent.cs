﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.HealOnGameplayEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct HealOnGameplayEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthPercent;
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthPerSpellPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_showSCT;
    private static readonly System.IntPtr NativeFieldInfoPtr_TrueHealing;
    private static readonly System.IntPtr NativeFieldInfoPtr_Who;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0;
    [FieldOffset(0)]
    public float Health;
    [FieldOffset(4)]
    public float HealthPercent;
    [FieldOffset(8)]
    public float HealthPerSpellPower;
    [FieldOffset(12)]
    public bool showSCT;
    [FieldOffset(13)]
    public bool TrueHealing;
    [FieldOffset(16)]
    public HealOnGameplayEventWho Who;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008036, XrefRangeEnd = 1008044, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ApplyArithmetic(SpellModArithmetic spellMod, float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spellMod;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HealOnGameplayEvent.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HealOnGameplayEvent()
    {
      Il2CppClassPointerStore<HealOnGameplayEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (HealOnGameplayEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HealOnGameplayEvent>.NativeClassPtr);
      HealOnGameplayEvent.NativeFieldInfoPtr_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealOnGameplayEvent>.NativeClassPtr, nameof (Health));
      HealOnGameplayEvent.NativeFieldInfoPtr_HealthPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealOnGameplayEvent>.NativeClassPtr, nameof (HealthPercent));
      HealOnGameplayEvent.NativeFieldInfoPtr_HealthPerSpellPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealOnGameplayEvent>.NativeClassPtr, nameof (HealthPerSpellPower));
      HealOnGameplayEvent.NativeFieldInfoPtr_showSCT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealOnGameplayEvent>.NativeClassPtr, nameof (showSCT));
      HealOnGameplayEvent.NativeFieldInfoPtr_TrueHealing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealOnGameplayEvent>.NativeClassPtr, nameof (TrueHealing));
      HealOnGameplayEvent.NativeFieldInfoPtr_Who = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealOnGameplayEvent>.NativeClassPtr, nameof (Who));
      HealOnGameplayEvent.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealOnGameplayEvent>.NativeClassPtr, 100678290);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HealOnGameplayEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
