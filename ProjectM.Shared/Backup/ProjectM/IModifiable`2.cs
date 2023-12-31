// Decompiled with JetBrains decompiler
// Type: ProjectM.IModifiable`2
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class IModifiable<TValue, TModification> : Il2CppObjectBase
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_TValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Value_Public_Abstract_Virtual_New_set_Void_TValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsFixed_Public_Abstract_Virtual_New_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseValue_Public_Abstract_Virtual_New_TValue_DynamicBuffer_1_TModification_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBaseValue_Public_Abstract_Virtual_New_Void_TValue_DynamicBuffer_1_TModification_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCalculatedValue_Public_Abstract_Virtual_New_Void_DynamicBuffer_1_TModification_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyValue_Public_Abstract_Virtual_New_Void_byref_TValue_byref_TValue_ModificationType_TValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModification_Public_Abstract_Virtual_New_ModificationId_ModificationStructure_ModificationType_TValue_Int32_DynamicBuffer_1_TModification_Entity_Entity_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyModification_Public_Abstract_Virtual_New_Boolean_ModificationId_TValue_DynamicBuffer_1_TModification_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveModification_Public_Abstract_Virtual_New_Boolean_ModificationId_DynamicBuffer_1_TModification_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOrAddModificationsBuffer_Public_Abstract_Virtual_New_DynamicBuffer_1_TModification_EntityManager_Entity_0;

    public virtual unsafe TValue Value
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IModifiable<TValue, TModification>.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_TValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.PointerToValueGeneric<TValue>(objectPointer, false, true);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
        System.IntPtr* numPtr2 = numPtr1;
        TValue& local1;
        if (!typeof (TValue).IsValueType)
        {
          __Boxed<TValue> local2 = (object) value;
          local1 = local2 is string ? (TValue&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TValue&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
        }
        else
          local1 = ref value;
        *numPtr2 = (System.IntPtr) ref local1;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IModifiable<TValue, TModification>.NativeMethodInfoPtr_set_Value_Public_Abstract_Virtual_New_set_Void_TValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public virtual unsafe bool IsFixed
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IModifiable<TValue, TModification>.NativeMethodInfoPtr_get_IsFixed_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    public virtual unsafe TValue GetBaseValue(DynamicBuffer<TModification> modifications)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &modifications;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IModifiable<TValue, TModification>.NativeMethodInfoPtr_GetBaseValue_Public_Abstract_Virtual_New_TValue_DynamicBuffer_1_TModification_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<TValue>(objectPointer, false, true);
    }

    [CallerCount(0)]
    public virtual unsafe void SetBaseValue(
      TValue newValue,
      DynamicBuffer<TModification> modifications)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      TValue& local1;
      if (!typeof (TValue).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TValue> local2 = (object) newValue;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TValue&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TValue&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref newValue;
      *numPtr2 = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IModifiable<TValue, TModification>.NativeMethodInfoPtr_SetBaseValue_Public_Abstract_Virtual_New_Void_TValue_DynamicBuffer_1_TModification_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void UpdateCalculatedValue(DynamicBuffer<TModification> modifications)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &modifications;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IModifiable<TValue, TModification>.NativeMethodInfoPtr_UpdateCalculatedValue_Public_Abstract_Virtual_New_Void_DynamicBuffer_1_TModification_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void ModifyValue(
      ref TValue value,
      ref TValue baseValue,
      ModificationType modType,
      TValue modValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr1 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr* numPtr3 = &ptr1;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) baseValue);
      System.IntPtr* numPtr4 = &ptr2;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr4;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &modType;
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TValue& local1;
      if (!typeof (TValue).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TValue> local2 = (object) modValue;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TValue&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TValue&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref modValue;
      *(System.IntPtr*) num2 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IModifiable<TValue, TModification>.NativeMethodInfoPtr_ModifyValue_Public_Abstract_Virtual_New_Void_byref_TValue_byref_TValue_ModificationType_TValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TValue local3 = ref value;
      System.IntPtr objectPointer1 = ptr1;
      // ISSUE: variable of the null type
      __Null valueGeneric1 = objectPointer1 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TValue>(objectPointer1, false, false);
      local3 = (TValue) valueGeneric1;
      ref TValue local4 = ref baseValue;
      System.IntPtr objectPointer2 = ptr2;
      // ISSUE: variable of the null type
      __Null valueGeneric2 = objectPointer2 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TValue>(objectPointer2, false, false);
      local4 = (TValue) valueGeneric2;
    }

    [CallerCount(0)]
    public virtual unsafe ModificationId ApplyModification(
      ModificationStructure modificationStructure,
      ModificationType modType,
      TValue modValue,
      int priority,
      DynamicBuffer<TModification> modifications,
      Entity self,
      Entity target,
      string callerFilePath = null,
      int callerLineNumber = 0)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) &modificationStructure;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modType;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TValue& local1;
      if (!typeof (TValue).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TValue> local2 = (object) modValue;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TValue&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TValue&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref modValue;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &priority;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(callerFilePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &callerLineNumber;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IModifiable<TValue, TModification>.NativeMethodInfoPtr_ApplyModification_Public_Abstract_Virtual_New_ModificationId_ModificationStructure_ModificationType_TValue_Int32_DynamicBuffer_1_TModification_Entity_Entity_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public virtual unsafe bool ModifyModification(
      ModificationId id,
      TValue modValue,
      DynamicBuffer<TModification> modifications,
      string callerFilePath = null,
      int callerLineNumber = 0)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &id;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TValue& local1;
      if (!typeof (TValue).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TValue> local2 = (object) modValue;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TValue&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TValue&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref modValue;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(callerFilePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &callerLineNumber;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IModifiable<TValue, TModification>.NativeMethodInfoPtr_ModifyModification_Public_Abstract_Virtual_New_Boolean_ModificationId_TValue_DynamicBuffer_1_TModification_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public virtual unsafe bool RemoveModification(
      ModificationId id,
      DynamicBuffer<TModification> modifications,
      string callerFilePath = null,
      int callerLineNumber = 0)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(callerFilePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &callerLineNumber;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IModifiable<TValue, TModification>.NativeMethodInfoPtr_RemoveModification_Public_Abstract_Virtual_New_Boolean_ModificationId_DynamicBuffer_1_TModification_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public virtual unsafe DynamicBuffer<TModification> GetOrAddModificationsBuffer(
      EntityManager entityManager,
      Entity entity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IModifiable<TValue, TModification>.NativeMethodInfoPtr_GetOrAddModificationsBuffer_Public_Abstract_Virtual_New_DynamicBuffer_1_TModification_EntityManager_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DynamicBuffer<TModification>*) IL2CPP.il2cpp_object_unbox(num);
    }

    static IModifiable()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<IModifiable<TValue, TModification>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", "IModifiable`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TModification>.NativeClassPtr))
      }))).TypeHandle).value);
      IModifiable<TValue, TModification>.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModifiable<TValue, TModification>>.NativeClassPtr, 100665729);
      IModifiable<TValue, TModification>.NativeMethodInfoPtr_set_Value_Public_Abstract_Virtual_New_set_Void_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModifiable<TValue, TModification>>.NativeClassPtr, 100665730);
      IModifiable<TValue, TModification>.NativeMethodInfoPtr_get_IsFixed_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModifiable<TValue, TModification>>.NativeClassPtr, 100665731);
      IModifiable<TValue, TModification>.NativeMethodInfoPtr_GetBaseValue_Public_Abstract_Virtual_New_TValue_DynamicBuffer_1_TModification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModifiable<TValue, TModification>>.NativeClassPtr, 100665732);
      IModifiable<TValue, TModification>.NativeMethodInfoPtr_SetBaseValue_Public_Abstract_Virtual_New_Void_TValue_DynamicBuffer_1_TModification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModifiable<TValue, TModification>>.NativeClassPtr, 100665733);
      IModifiable<TValue, TModification>.NativeMethodInfoPtr_UpdateCalculatedValue_Public_Abstract_Virtual_New_Void_DynamicBuffer_1_TModification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModifiable<TValue, TModification>>.NativeClassPtr, 100665734);
      IModifiable<TValue, TModification>.NativeMethodInfoPtr_ModifyValue_Public_Abstract_Virtual_New_Void_byref_TValue_byref_TValue_ModificationType_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModifiable<TValue, TModification>>.NativeClassPtr, 100665735);
      IModifiable<TValue, TModification>.NativeMethodInfoPtr_ApplyModification_Public_Abstract_Virtual_New_ModificationId_ModificationStructure_ModificationType_TValue_Int32_DynamicBuffer_1_TModification_Entity_Entity_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModifiable<TValue, TModification>>.NativeClassPtr, 100665736);
      IModifiable<TValue, TModification>.NativeMethodInfoPtr_ModifyModification_Public_Abstract_Virtual_New_Boolean_ModificationId_TValue_DynamicBuffer_1_TModification_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModifiable<TValue, TModification>>.NativeClassPtr, 100665737);
      IModifiable<TValue, TModification>.NativeMethodInfoPtr_RemoveModification_Public_Abstract_Virtual_New_Boolean_ModificationId_DynamicBuffer_1_TModification_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModifiable<TValue, TModification>>.NativeClassPtr, 100665738);
      IModifiable<TValue, TModification>.NativeMethodInfoPtr_GetOrAddModificationsBuffer_Public_Abstract_Virtual_New_DynamicBuffer_1_TModification_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModifiable<TValue, TModification>>.NativeClassPtr, 100665739);
    }

    public IModifiable(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
