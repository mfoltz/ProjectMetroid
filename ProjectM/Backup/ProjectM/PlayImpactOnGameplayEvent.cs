// Decompiled with JetBrains decompiler
// Type: ProjectM.PlayImpactOnGameplayEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PlayImpactOnGameplayEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrimarySequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ImpactMappingGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SkipMaterialSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationOffsetEulerMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationOffsetEulerMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_Scale;
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceRotationTarget;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplySequenceGUID_Public_Virtual_Final_New_Void_SpellModSequenceGuid_0;
    [FieldOffset(0)]
    public SequenceGUID PrimarySequenceGuid;
    [FieldOffset(4)]
    public PrefabGUID ImpactMappingGuid;
    [FieldOffset(8)]
    public bool SkipMaterialSequence;
    [FieldOffset(12)]
    public float3 RotationOffsetEulerMin;
    [FieldOffset(24)]
    public float3 RotationOffsetEulerMax;
    [FieldOffset(36)]
    public float Scale;
    [FieldOffset(40)]
    public PlaySequenceOnGameplayEventTarget SequenceRotationTarget;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1008227, RefRangeEnd = 1008228, XrefRangeStart = 1008227, XrefRangeEnd = 1008227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ApplySequenceGUID(SpellModSequenceGuid spellMod)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &spellMod;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayImpactOnGameplayEvent.NativeMethodInfoPtr_ApplySequenceGUID_Public_Virtual_Final_New_Void_SpellModSequenceGuid_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PlayImpactOnGameplayEvent()
    {
      Il2CppClassPointerStore<PlayImpactOnGameplayEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PlayImpactOnGameplayEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayImpactOnGameplayEvent>.NativeClassPtr);
      PlayImpactOnGameplayEvent.NativeFieldInfoPtr_PrimarySequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayImpactOnGameplayEvent>.NativeClassPtr, nameof (PrimarySequenceGuid));
      PlayImpactOnGameplayEvent.NativeFieldInfoPtr_ImpactMappingGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayImpactOnGameplayEvent>.NativeClassPtr, nameof (ImpactMappingGuid));
      PlayImpactOnGameplayEvent.NativeFieldInfoPtr_SkipMaterialSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayImpactOnGameplayEvent>.NativeClassPtr, nameof (SkipMaterialSequence));
      PlayImpactOnGameplayEvent.NativeFieldInfoPtr_RotationOffsetEulerMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayImpactOnGameplayEvent>.NativeClassPtr, nameof (RotationOffsetEulerMin));
      PlayImpactOnGameplayEvent.NativeFieldInfoPtr_RotationOffsetEulerMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayImpactOnGameplayEvent>.NativeClassPtr, nameof (RotationOffsetEulerMax));
      PlayImpactOnGameplayEvent.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayImpactOnGameplayEvent>.NativeClassPtr, nameof (Scale));
      PlayImpactOnGameplayEvent.NativeFieldInfoPtr_SequenceRotationTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayImpactOnGameplayEvent>.NativeClassPtr, nameof (SequenceRotationTarget));
      PlayImpactOnGameplayEvent.NativeMethodInfoPtr_ApplySequenceGUID_Public_Virtual_Final_New_Void_SpellModSequenceGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayImpactOnGameplayEvent>.NativeClassPtr, 100678318);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayImpactOnGameplayEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
