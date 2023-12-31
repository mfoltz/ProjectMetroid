// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModSequenceGuid
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpellModSequenceGuid
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Condition;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMod;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShouldApplyOnClient_Public_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_Shared_ISpellModComponent_GetSpellModPrefabGuid_Private_Virtual_Final_New_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_Shared_ISpellModComponent_HasCondition_Private_Virtual_Final_New_Boolean_0;
    [FieldOffset(0)]
    public BlobAssetReference<ConditionBlob> Condition;
    [FieldOffset(8)]
    public PrefabGUID SpellMod;
    [FieldOffset(12)]
    public SequenceGUID Sequence;
    [FieldOffset(16)]
    public SpellModSequenceGuidTarget Target;
    [FieldOffset(20)]
    public int TargetIndex;

    [CallerCount(1858)]
    [CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool ShouldApplyOnClient()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModSequenceGuid.NativeMethodInfoPtr_ShouldApplyOnClient_Public_Virtual_Final_New_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(33)]
    [CachedScanResults(RefRangeStart = 40848, RefRangeEnd = 40881, XrefRangeStart = 40848, XrefRangeEnd = 40881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe PrefabGUID ProjectM_Shared_ISpellModComponent_GetSpellModPrefabGuid()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModSequenceGuid.NativeMethodInfoPtr_ProjectM_Shared_ISpellModComponent_GetSpellModPrefabGuid_Private_Virtual_Final_New_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 799328, XrefRangeEnd = 799331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool ProjectM_Shared_ISpellModComponent_HasCondition()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModSequenceGuid.NativeMethodInfoPtr_ProjectM_Shared_ISpellModComponent_HasCondition_Private_Virtual_Final_New_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SpellModSequenceGuid()
    {
      Il2CppClassPointerStore<SpellModSequenceGuid>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SpellModSequenceGuid));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModSequenceGuid>.NativeClassPtr);
      SpellModSequenceGuid.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSequenceGuid>.NativeClassPtr, nameof (Condition));
      SpellModSequenceGuid.NativeFieldInfoPtr_SpellMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSequenceGuid>.NativeClassPtr, nameof (SpellMod));
      SpellModSequenceGuid.NativeFieldInfoPtr_Sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSequenceGuid>.NativeClassPtr, nameof (Sequence));
      SpellModSequenceGuid.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSequenceGuid>.NativeClassPtr, nameof (Target));
      SpellModSequenceGuid.NativeFieldInfoPtr_TargetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSequenceGuid>.NativeClassPtr, nameof (TargetIndex));
      SpellModSequenceGuid.NativeMethodInfoPtr_ShouldApplyOnClient_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModSequenceGuid>.NativeClassPtr, 100670534);
      SpellModSequenceGuid.NativeMethodInfoPtr_ProjectM_Shared_ISpellModComponent_GetSpellModPrefabGuid_Private_Virtual_Final_New_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModSequenceGuid>.NativeClassPtr, 100670535);
      SpellModSequenceGuid.NativeMethodInfoPtr_ProjectM_Shared_ISpellModComponent_HasCondition_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModSequenceGuid>.NativeClassPtr, 100670536);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellModSequenceGuid>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
