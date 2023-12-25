// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityCastTimeData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityCastTimeData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxCastTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_PostCastTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideCastBar;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TotalCastTime_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityManager_Entity_Single_Single_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyArithmeticModifiable_Public_ModificationId_SpellModArithmeticOperation_SpellModArithmeticModifiableTarget_Single_byref_SpellModArithmeticModifiableOperationData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveArithmeticModifiable_Public_Virtual_Final_New_Boolean_ModificationId_SpellModArithmeticModifiableTarget_DynamicBuffer_1_FloatModificationBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_Shared_IApplySpellModArithmeticModifiable_ApplyArithmeticModifiable_Private_Virtual_Final_New_ModificationId_SpellModArithmeticOperation_SpellModArithmeticModifiableTarget_Single_byref_SpellModArithmeticModifiableOperationData_0;
    [FieldOffset(0)]
    public ModifiableFloat MaxCastTime;
    [FieldOffset(8)]
    public ModifiableFloat PostCastTime;
    [FieldOffset(16)]
    public readonly bool HideCastBar;

    public unsafe float TotalCastTime
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 996098, RefRangeEnd = 996100, XrefRangeStart = 996096, XrefRangeEnd = 996098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityCastTimeData.NativeMethodInfoPtr_get_TotalCastTime_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 996102, RefRangeEnd = 996103, XrefRangeStart = 996100, XrefRangeEnd = 996102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityCastTimeData(
      EntityManager entityManager,
      Entity entity,
      float maxCastTime,
      float postCastTime,
      bool hideCastBar)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxCastTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &postCastTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &hideCastBar;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityCastTimeData.NativeMethodInfoPtr__ctor_Public_Void_EntityManager_Entity_Single_Single_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 996110, RefRangeEnd = 996111, XrefRangeStart = 996103, XrefRangeEnd = 996110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityCastTimeData.NativeMethodInfoPtr_ApplyArithmeticModifiable_Public_ModificationId_SpellModArithmeticOperation_SpellModArithmeticModifiableTarget_Single_byref_SpellModArithmeticModifiableOperationData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 996114, RefRangeEnd = 996115, XrefRangeStart = 996111, XrefRangeEnd = 996114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityCastTimeData.NativeMethodInfoPtr_RemoveArithmeticModifiable_Public_Virtual_Final_New_Boolean_ModificationId_SpellModArithmeticModifiableTarget_DynamicBuffer_1_FloatModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 996116, RefRangeEnd = 996117, XrefRangeStart = 996115, XrefRangeEnd = 996116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityCastTimeData.NativeMethodInfoPtr_ProjectM_Shared_IApplySpellModArithmeticModifiable_ApplyArithmeticModifiable_Private_Virtual_Final_New_ModificationId_SpellModArithmeticOperation_SpellModArithmeticModifiableTarget_Single_byref_SpellModArithmeticModifiableOperationData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AbilityCastTimeData()
    {
      Il2CppClassPointerStore<AbilityCastTimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AbilityCastTimeData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityCastTimeData>.NativeClassPtr);
      AbilityCastTimeData.NativeFieldInfoPtr_MaxCastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastTimeData>.NativeClassPtr, nameof (MaxCastTime));
      AbilityCastTimeData.NativeFieldInfoPtr_PostCastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastTimeData>.NativeClassPtr, nameof (PostCastTime));
      AbilityCastTimeData.NativeFieldInfoPtr_HideCastBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastTimeData>.NativeClassPtr, nameof (HideCastBar));
      AbilityCastTimeData.NativeMethodInfoPtr_get_TotalCastTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastTimeData>.NativeClassPtr, 100676946);
      AbilityCastTimeData.NativeMethodInfoPtr__ctor_Public_Void_EntityManager_Entity_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastTimeData>.NativeClassPtr, 100676947);
      AbilityCastTimeData.NativeMethodInfoPtr_ApplyArithmeticModifiable_Public_ModificationId_SpellModArithmeticOperation_SpellModArithmeticModifiableTarget_Single_byref_SpellModArithmeticModifiableOperationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastTimeData>.NativeClassPtr, 100676948);
      AbilityCastTimeData.NativeMethodInfoPtr_RemoveArithmeticModifiable_Public_Virtual_Final_New_Boolean_ModificationId_SpellModArithmeticModifiableTarget_DynamicBuffer_1_FloatModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastTimeData>.NativeClassPtr, 100676949);
      AbilityCastTimeData.NativeMethodInfoPtr_ProjectM_Shared_IApplySpellModArithmeticModifiable_ApplyArithmeticModifiable_Private_Virtual_Final_New_ModificationId_SpellModArithmeticOperation_SpellModArithmeticModifiableTarget_Single_byref_SpellModArithmeticModifiableOperationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastTimeData>.NativeClassPtr, 100676950);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityCastTimeData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
