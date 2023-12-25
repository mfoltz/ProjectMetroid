// Decompiled with JetBrains decompiler
// Type: ProjectM.LifeLeechOnGameplayEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct LifeLeechOnGameplayEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Factor;
    private static readonly System.IntPtr NativeFieldInfoPtr_EventIdIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_EventIdCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_Condition;
    private static readonly System.IntPtr NativeFieldInfoPtr_LifeLeechSettingsGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0;
    [FieldOffset(0)]
    public float Factor;
    [FieldOffset(4)]
    public int EventIdIndex;
    [FieldOffset(8)]
    public int EventIdCount;
    [FieldOffset(16)]
    public BlobAssetReference<ConditionBlob> Condition;
    [FieldOffset(24)]
    public PrefabGUID LifeLeechSettingsGuid;
    [FieldOffset(28)]
    public LifeLeechTarget Target;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008067, XrefRangeEnd = 1008073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ApplyArithmetic(SpellModArithmetic spellMod, float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spellMod;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LifeLeechOnGameplayEvent.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LifeLeechOnGameplayEvent()
    {
      Il2CppClassPointerStore<LifeLeechOnGameplayEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (LifeLeechOnGameplayEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LifeLeechOnGameplayEvent>.NativeClassPtr);
      LifeLeechOnGameplayEvent.NativeFieldInfoPtr_Factor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifeLeechOnGameplayEvent>.NativeClassPtr, nameof (Factor));
      LifeLeechOnGameplayEvent.NativeFieldInfoPtr_EventIdIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifeLeechOnGameplayEvent>.NativeClassPtr, nameof (EventIdIndex));
      LifeLeechOnGameplayEvent.NativeFieldInfoPtr_EventIdCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifeLeechOnGameplayEvent>.NativeClassPtr, nameof (EventIdCount));
      LifeLeechOnGameplayEvent.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifeLeechOnGameplayEvent>.NativeClassPtr, nameof (Condition));
      LifeLeechOnGameplayEvent.NativeFieldInfoPtr_LifeLeechSettingsGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifeLeechOnGameplayEvent>.NativeClassPtr, nameof (LifeLeechSettingsGuid));
      LifeLeechOnGameplayEvent.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifeLeechOnGameplayEvent>.NativeClassPtr, nameof (Target));
      LifeLeechOnGameplayEvent.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifeLeechOnGameplayEvent>.NativeClassPtr, 100678295);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LifeLeechOnGameplayEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
