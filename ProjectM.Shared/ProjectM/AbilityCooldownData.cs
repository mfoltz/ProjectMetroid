// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityCooldownData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityCooldownData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreCooldownModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_Cooldown;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Single_Entity_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyArithmeticModifiable_Public_ModificationId_SpellModArithmeticOperation_SpellModArithmeticModifiableTarget_Single_byref_SpellModArithmeticModifiableOperationData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveArithmeticModifiable_Public_Virtual_Final_New_Boolean_ModificationId_SpellModArithmeticModifiableTarget_DynamicBuffer_1_FloatModificationBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_Shared_IApplySpellModArithmeticModifiable_ApplyArithmeticModifiable_Private_Virtual_Final_New_ModificationId_SpellModArithmeticOperation_SpellModArithmeticModifiableTarget_Single_byref_SpellModArithmeticModifiableOperationData_0;
    [FieldOffset(0)]
    public readonly bool IgnoreCooldownModifier;
    [FieldOffset(4)]
    public ModifiableFloat Cooldown;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 726522, RefRangeEnd = 726523, XrefRangeStart = 726521, XrefRangeEnd = 726522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityCooldownData(
      bool ignoreCooldownModifier,
      float cooldown,
      Entity entity,
      EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &ignoreCooldownModifier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cooldown;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityCooldownData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Single_Entity_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726523, XrefRangeEnd = 726529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ModificationId ApplyArithmeticModifiable(
      SpellModArithmeticOperation operation,
      SpellModArithmeticModifiableTarget target,
      float value,
      [In] ref SpellModArithmeticModifiableOperationData operationData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref operationData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityCooldownData.NativeMethodInfoPtr_ApplyArithmeticModifiable_Public_ModificationId_SpellModArithmeticOperation_SpellModArithmeticModifiableTarget_Single_byref_SpellModArithmeticModifiableOperationData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726529, XrefRangeEnd = 726532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool RemoveArithmeticModifiable(
      ModificationId modId,
      SpellModArithmeticModifiableTarget target,
      DynamicBuffer<FloatModificationBuffer> modificationBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &modId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &modificationBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityCooldownData.NativeMethodInfoPtr_RemoveArithmeticModifiable_Public_Virtual_Final_New_Boolean_ModificationId_SpellModArithmeticModifiableTarget_DynamicBuffer_1_FloatModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe ModificationId ProjectM_Shared_IApplySpellModArithmeticModifiable_ApplyArithmeticModifiable(
      SpellModArithmeticOperation operation,
      SpellModArithmeticModifiableTarget target,
      float value,
      [In] ref SpellModArithmeticModifiableOperationData operationData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref operationData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityCooldownData.NativeMethodInfoPtr_ProjectM_Shared_IApplySpellModArithmeticModifiable_ApplyArithmeticModifiable_Private_Virtual_Final_New_ModificationId_SpellModArithmeticOperation_SpellModArithmeticModifiableTarget_Single_byref_SpellModArithmeticModifiableOperationData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AbilityCooldownData()
    {
      Il2CppClassPointerStore<AbilityCooldownData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AbilityCooldownData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityCooldownData>.NativeClassPtr);
      AbilityCooldownData.NativeFieldInfoPtr_IgnoreCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCooldownData>.NativeClassPtr, nameof (IgnoreCooldownModifier));
      AbilityCooldownData.NativeFieldInfoPtr_Cooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCooldownData>.NativeClassPtr, nameof (Cooldown));
      AbilityCooldownData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Single_Entity_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCooldownData>.NativeClassPtr, 100664212);
      AbilityCooldownData.NativeMethodInfoPtr_ApplyArithmeticModifiable_Public_ModificationId_SpellModArithmeticOperation_SpellModArithmeticModifiableTarget_Single_byref_SpellModArithmeticModifiableOperationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCooldownData>.NativeClassPtr, 100664213);
      AbilityCooldownData.NativeMethodInfoPtr_RemoveArithmeticModifiable_Public_Virtual_Final_New_Boolean_ModificationId_SpellModArithmeticModifiableTarget_DynamicBuffer_1_FloatModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCooldownData>.NativeClassPtr, 100664214);
      AbilityCooldownData.NativeMethodInfoPtr_ProjectM_Shared_IApplySpellModArithmeticModifiable_ApplyArithmeticModifiable_Private_Virtual_Final_New_ModificationId_SpellModArithmeticOperation_SpellModArithmeticModifiableTarget_Single_byref_SpellModArithmeticModifiableOperationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCooldownData>.NativeClassPtr, 100664215);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityCooldownData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
