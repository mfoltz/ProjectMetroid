// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.IApplySpellModArithmeticModifiable
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Shared
{
  public class IApplySpellModArithmeticModifiable : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_ApplyArithmeticModifiable_Public_Abstract_Virtual_New_ModificationId_SpellModArithmeticOperation_SpellModArithmeticModifiableTarget_Single_byref_SpellModArithmeticModifiableOperationData_0;
    private static readonly IntPtr NativeMethodInfoPtr_RemoveArithmeticModifiable_Public_Abstract_Virtual_New_Boolean_ModificationId_SpellModArithmeticModifiableTarget_DynamicBuffer_1_FloatModificationBuffer_0;

    [CallerCount(0)]
    public virtual unsafe ModificationId ApplyArithmeticModifiable(
      SpellModArithmeticOperation operation,
      SpellModArithmeticModifiableTarget target,
      float value,
      [In] ref SpellModArithmeticModifiableOperationData operationData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &operation;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &target;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &value;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) ref operationData;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IApplySpellModArithmeticModifiable.NativeMethodInfoPtr_ApplyArithmeticModifiable_Public_Abstract_Virtual_New_ModificationId_SpellModArithmeticOperation_SpellModArithmeticModifiableTarget_Single_byref_SpellModArithmeticModifiableOperationData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public virtual unsafe bool RemoveArithmeticModifiable(
      ModificationId modId,
      SpellModArithmeticModifiableTarget target,
      DynamicBuffer<FloatModificationBuffer> modificationBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &modId;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &target;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &modificationBuffer;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IApplySpellModArithmeticModifiable.NativeMethodInfoPtr_RemoveArithmeticModifiable_Public_Abstract_Virtual_New_Boolean_ModificationId_SpellModArithmeticModifiableTarget_DynamicBuffer_1_FloatModificationBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static IApplySpellModArithmeticModifiable()
    {
      Il2CppClassPointerStore<IApplySpellModArithmeticModifiable>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (IApplySpellModArithmeticModifiable));
      IApplySpellModArithmeticModifiable.NativeMethodInfoPtr_ApplyArithmeticModifiable_Public_Abstract_Virtual_New_ModificationId_SpellModArithmeticOperation_SpellModArithmeticModifiableTarget_Single_byref_SpellModArithmeticModifiableOperationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IApplySpellModArithmeticModifiable>.NativeClassPtr, 100670408);
      IApplySpellModArithmeticModifiable.NativeMethodInfoPtr_RemoveArithmeticModifiable_Public_Abstract_Virtual_New_Boolean_ModificationId_SpellModArithmeticModifiableTarget_DynamicBuffer_1_FloatModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IApplySpellModArithmeticModifiable>.NativeClassPtr, 100670409);
    }

    public IApplySpellModArithmeticModifiable(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
