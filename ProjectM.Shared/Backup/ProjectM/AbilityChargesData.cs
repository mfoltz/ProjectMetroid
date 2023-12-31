// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityChargesData
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
  public struct AbilityChargesData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ChargeUpTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxCharges;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreCooldownModifier;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyArithmeticModifiable_Public_ModificationId_SpellModArithmeticOperation_SpellModArithmeticModifiableTarget_Single_byref_SpellModArithmeticModifiableOperationData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveArithmeticModifiable_Public_Virtual_Final_New_Boolean_ModificationId_SpellModArithmeticModifiableTarget_DynamicBuffer_1_FloatModificationBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_Shared_IApplySpellModArithmeticModifiable_ApplyArithmeticModifiable_Private_Virtual_Final_New_ModificationId_SpellModArithmeticOperation_SpellModArithmeticModifiableTarget_Single_byref_SpellModArithmeticModifiableOperationData_0;
    [FieldOffset(0)]
    public ModifiableFloat ChargeUpTime;
    [FieldOffset(8)]
    public int MaxCharges;
    [FieldOffset(12)]
    public bool IgnoreCooldownModifier;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724693, XrefRangeEnd = 724699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityChargesData.NativeMethodInfoPtr_ApplyArithmeticModifiable_Public_ModificationId_SpellModArithmeticOperation_SpellModArithmeticModifiableTarget_Single_byref_SpellModArithmeticModifiableOperationData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724699, XrefRangeEnd = 724702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityChargesData.NativeMethodInfoPtr_RemoveArithmeticModifiable_Public_Virtual_Final_New_Boolean_ModificationId_SpellModArithmeticModifiableTarget_DynamicBuffer_1_FloatModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityChargesData.NativeMethodInfoPtr_ProjectM_Shared_IApplySpellModArithmeticModifiable_ApplyArithmeticModifiable_Private_Virtual_Final_New_ModificationId_SpellModArithmeticOperation_SpellModArithmeticModifiableTarget_Single_byref_SpellModArithmeticModifiableOperationData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AbilityChargesData()
    {
      Il2CppClassPointerStore<AbilityChargesData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AbilityChargesData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityChargesData>.NativeClassPtr);
      AbilityChargesData.NativeFieldInfoPtr_ChargeUpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityChargesData>.NativeClassPtr, nameof (ChargeUpTime));
      AbilityChargesData.NativeFieldInfoPtr_MaxCharges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityChargesData>.NativeClassPtr, nameof (MaxCharges));
      AbilityChargesData.NativeFieldInfoPtr_IgnoreCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityChargesData>.NativeClassPtr, nameof (IgnoreCooldownModifier));
      AbilityChargesData.NativeMethodInfoPtr_ApplyArithmeticModifiable_Public_ModificationId_SpellModArithmeticOperation_SpellModArithmeticModifiableTarget_Single_byref_SpellModArithmeticModifiableOperationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityChargesData>.NativeClassPtr, 100664104);
      AbilityChargesData.NativeMethodInfoPtr_RemoveArithmeticModifiable_Public_Virtual_Final_New_Boolean_ModificationId_SpellModArithmeticModifiableTarget_DynamicBuffer_1_FloatModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityChargesData>.NativeClassPtr, 100664105);
      AbilityChargesData.NativeMethodInfoPtr_ProjectM_Shared_IApplySpellModArithmeticModifiable_ApplyArithmeticModifiable_Private_Virtual_Final_New_ModificationId_SpellModArithmeticOperation_SpellModArithmeticModifiableTarget_Single_byref_SpellModArithmeticModifiableOperationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityChargesData>.NativeClassPtr, 100664106);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityChargesData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
