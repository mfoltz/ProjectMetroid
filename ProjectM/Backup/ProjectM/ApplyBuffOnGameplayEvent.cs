// Decompiled with JetBrains decompiler
// Type: ProjectM.ApplyBuffOnGameplayEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ApplyBuffOnGameplayEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Stacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff0;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff1;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff2;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff3;
    private static readonly System.IntPtr NativeFieldInfoPtr_EventOnConsume;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConsumeIfAlreadyExists;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConsumeConditional;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyPrefabGUID_Public_Virtual_Final_New_Void_SpellModPrefabGuid_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0;
    [FieldOffset(0)]
    public ApplyBuffTarget BuffTarget;
    [FieldOffset(4)]
    public SetSpellTarget SpellTarget;
    [FieldOffset(8)]
    public SetEntityOwner EntityOwner;
    [FieldOffset(12)]
    public Nullable_Unboxed<float> OverrideDuration;
    [FieldOffset(20)]
    public byte Stacks;
    [FieldOffset(24)]
    public PrefabGUID Buff0;
    [FieldOffset(28)]
    public PrefabGUID Buff1;
    [FieldOffset(32)]
    public PrefabGUID Buff2;
    [FieldOffset(36)]
    public PrefabGUID Buff3;
    [FieldOffset(40)]
    public GameplayEventId EventOnConsume;
    [FieldOffset(48)]
    public bool ConsumeIfAlreadyExists;
    [FieldOffset(56)]
    public BlobAssetReference<ConditionBlob> ConsumeConditional;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1007762, RefRangeEnd = 1007764, XrefRangeStart = 1007762, XrefRangeEnd = 1007762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ApplyPrefabGUID(SpellModPrefabGuid spellMod, PrefabGUID prefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spellMod;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ApplyBuffOnGameplayEvent.NativeMethodInfoPtr_ApplyPrefabGUID_Public_Virtual_Final_New_Void_SpellModPrefabGuid_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1007773, RefRangeEnd = 1007774, XrefRangeStart = 1007764, XrefRangeEnd = 1007773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ApplyArithmetic(SpellModArithmetic spellMod, float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spellMod;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ApplyBuffOnGameplayEvent.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ApplyBuffOnGameplayEvent()
    {
      Il2CppClassPointerStore<ApplyBuffOnGameplayEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ApplyBuffOnGameplayEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplyBuffOnGameplayEvent>.NativeClassPtr);
      ApplyBuffOnGameplayEvent.NativeFieldInfoPtr_BuffTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEvent>.NativeClassPtr, nameof (BuffTarget));
      ApplyBuffOnGameplayEvent.NativeFieldInfoPtr_SpellTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEvent>.NativeClassPtr, nameof (SpellTarget));
      ApplyBuffOnGameplayEvent.NativeFieldInfoPtr_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEvent>.NativeClassPtr, nameof (EntityOwner));
      ApplyBuffOnGameplayEvent.NativeFieldInfoPtr_OverrideDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEvent>.NativeClassPtr, nameof (OverrideDuration));
      ApplyBuffOnGameplayEvent.NativeFieldInfoPtr_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEvent>.NativeClassPtr, nameof (Stacks));
      ApplyBuffOnGameplayEvent.NativeFieldInfoPtr_Buff0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEvent>.NativeClassPtr, nameof (Buff0));
      ApplyBuffOnGameplayEvent.NativeFieldInfoPtr_Buff1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEvent>.NativeClassPtr, nameof (Buff1));
      ApplyBuffOnGameplayEvent.NativeFieldInfoPtr_Buff2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEvent>.NativeClassPtr, nameof (Buff2));
      ApplyBuffOnGameplayEvent.NativeFieldInfoPtr_Buff3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEvent>.NativeClassPtr, nameof (Buff3));
      ApplyBuffOnGameplayEvent.NativeFieldInfoPtr_EventOnConsume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEvent>.NativeClassPtr, nameof (EventOnConsume));
      ApplyBuffOnGameplayEvent.NativeFieldInfoPtr_ConsumeIfAlreadyExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEvent>.NativeClassPtr, nameof (ConsumeIfAlreadyExists));
      ApplyBuffOnGameplayEvent.NativeFieldInfoPtr_ConsumeConditional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEvent>.NativeClassPtr, nameof (ConsumeConditional));
      ApplyBuffOnGameplayEvent.NativeMethodInfoPtr_ApplyPrefabGUID_Public_Virtual_Final_New_Void_SpellModPrefabGuid_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyBuffOnGameplayEvent>.NativeClassPtr, 100678236);
      ApplyBuffOnGameplayEvent.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyBuffOnGameplayEvent>.NativeClassPtr, 100678237);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ApplyBuffOnGameplayEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
