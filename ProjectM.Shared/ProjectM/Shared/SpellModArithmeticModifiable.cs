// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModArithmeticModifiable
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
  public struct SpellModArithmeticModifiable
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Condition;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMod;
    private static readonly System.IntPtr NativeFieldInfoPtr_Operation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ValueIndex;
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
    public SpellModArithmeticOperation Operation;
    [FieldOffset(13)]
    public byte ValueIndex;
    [FieldOffset(14)]
    public SpellModArithmeticModifiableTarget Target;
    [FieldOffset(16)]
    public int TargetIndex;

    [CallerCount(0)]
    public virtual unsafe bool ShouldApplyOnClient()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModArithmeticModifiable.NativeMethodInfoPtr_ShouldApplyOnClient_Public_Virtual_Final_New_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(33)]
    [CachedScanResults(RefRangeStart = 40848, RefRangeEnd = 40881, XrefRangeStart = 40848, XrefRangeEnd = 40881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe PrefabGUID ProjectM_Shared_ISpellModComponent_GetSpellModPrefabGuid()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModArithmeticModifiable.NativeMethodInfoPtr_ProjectM_Shared_ISpellModComponent_GetSpellModPrefabGuid_Private_Virtual_Final_New_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 798509, XrefRangeEnd = 798512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool ProjectM_Shared_ISpellModComponent_HasCondition()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModArithmeticModifiable.NativeMethodInfoPtr_ProjectM_Shared_ISpellModComponent_HasCondition_Private_Virtual_Final_New_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SpellModArithmeticModifiable()
    {
      Il2CppClassPointerStore<SpellModArithmeticModifiable>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SpellModArithmeticModifiable));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModArithmeticModifiable>.NativeClassPtr);
      SpellModArithmeticModifiable.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModArithmeticModifiable>.NativeClassPtr, nameof (Condition));
      SpellModArithmeticModifiable.NativeFieldInfoPtr_SpellMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModArithmeticModifiable>.NativeClassPtr, nameof (SpellMod));
      SpellModArithmeticModifiable.NativeFieldInfoPtr_Operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModArithmeticModifiable>.NativeClassPtr, nameof (Operation));
      SpellModArithmeticModifiable.NativeFieldInfoPtr_ValueIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModArithmeticModifiable>.NativeClassPtr, nameof (ValueIndex));
      SpellModArithmeticModifiable.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModArithmeticModifiable>.NativeClassPtr, nameof (Target));
      SpellModArithmeticModifiable.NativeFieldInfoPtr_TargetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModArithmeticModifiable>.NativeClassPtr, nameof (TargetIndex));
      SpellModArithmeticModifiable.NativeMethodInfoPtr_ShouldApplyOnClient_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModArithmeticModifiable>.NativeClassPtr, 100670404);
      SpellModArithmeticModifiable.NativeMethodInfoPtr_ProjectM_Shared_ISpellModComponent_GetSpellModPrefabGuid_Private_Virtual_Final_New_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModArithmeticModifiable>.NativeClassPtr, 100670405);
      SpellModArithmeticModifiable.NativeMethodInfoPtr_ProjectM_Shared_ISpellModComponent_HasCondition_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModArithmeticModifiable>.NativeClassPtr, 100670406);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellModArithmeticModifiable>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
