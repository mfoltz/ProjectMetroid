// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModArithmetic
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
  public struct SpellModArithmetic
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
    public SpellModArithmeticTarget Target;
    [FieldOffset(16)]
    public int TargetIndex;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 798461, RefRangeEnd = 798462, XrefRangeStart = 798461, XrefRangeEnd = 798461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool ShouldApplyOnClient()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModArithmetic.NativeMethodInfoPtr_ShouldApplyOnClient_Public_Virtual_Final_New_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(33)]
    [CachedScanResults(RefRangeStart = 40848, RefRangeEnd = 40881, XrefRangeStart = 40848, XrefRangeEnd = 40881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe PrefabGUID ProjectM_Shared_ISpellModComponent_GetSpellModPrefabGuid()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModArithmetic.NativeMethodInfoPtr_ProjectM_Shared_ISpellModComponent_GetSpellModPrefabGuid_Private_Virtual_Final_New_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 798465, RefRangeEnd = 798466, XrefRangeStart = 798462, XrefRangeEnd = 798465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool ProjectM_Shared_ISpellModComponent_HasCondition()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModArithmetic.NativeMethodInfoPtr_ProjectM_Shared_ISpellModComponent_HasCondition_Private_Virtual_Final_New_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SpellModArithmetic()
    {
      Il2CppClassPointerStore<SpellModArithmetic>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SpellModArithmetic));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModArithmetic>.NativeClassPtr);
      SpellModArithmetic.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModArithmetic>.NativeClassPtr, nameof (Condition));
      SpellModArithmetic.NativeFieldInfoPtr_SpellMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModArithmetic>.NativeClassPtr, nameof (SpellMod));
      SpellModArithmetic.NativeFieldInfoPtr_Operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModArithmetic>.NativeClassPtr, nameof (Operation));
      SpellModArithmetic.NativeFieldInfoPtr_ValueIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModArithmetic>.NativeClassPtr, nameof (ValueIndex));
      SpellModArithmetic.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModArithmetic>.NativeClassPtr, nameof (Target));
      SpellModArithmetic.NativeFieldInfoPtr_TargetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModArithmetic>.NativeClassPtr, nameof (TargetIndex));
      SpellModArithmetic.NativeMethodInfoPtr_ShouldApplyOnClient_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModArithmetic>.NativeClassPtr, 100670398);
      SpellModArithmetic.NativeMethodInfoPtr_ProjectM_Shared_ISpellModComponent_GetSpellModPrefabGuid_Private_Virtual_Final_New_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModArithmetic>.NativeClassPtr, 100670399);
      SpellModArithmetic.NativeMethodInfoPtr_ProjectM_Shared_ISpellModComponent_HasCondition_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModArithmetic>.NativeClassPtr, 100670400);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellModArithmetic>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
