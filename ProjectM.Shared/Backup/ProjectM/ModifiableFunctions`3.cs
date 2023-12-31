// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifiableFunctions`3
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM.Scripting;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class ModifiableFunctions<TModifiable, TModification, TValue> : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModification_Public_Static_Boolean_byref_TModifiable_ModificationStructure_ModificationType_TValue_Int32_DynamicBuffer_1_TModification_Entity_Entity_byref_ModificationId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModification_Public_Static_Boolean_byref_TModifiable_EntityManager_ModificationStructure_Entity_Entity_ModificationType_TValue_Int32_byref_ModificationId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModification_Public_Static_Boolean_byref_TModifiable_ServerGameManager_Entity_Entity_ModificationType_TValue_Int32_byref_ModificationId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModification_Public_Static_Boolean_byref_TModifiable_ClientGameManager_Entity_Entity_ModificationType_TValue_Int32_byref_ModificationId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyModification_Public_Static_Boolean_byref_TModifiable_ModificationId_TValue_DynamicBuffer_1_TModification_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyModification_Private_Static_Boolean_byref_TModifiable_EntityManager_Entity_ModificationId_TValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyModification_Public_Static_Boolean_byref_TModifiable_ServerGameManager_Entity_ModificationId_TValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyModification_Public_Static_Boolean_byref_TModifiable_ClientGameManager_Entity_ModificationId_TValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveModification_Public_Static_Boolean_byref_TModifiable_EntityManager_Entity_ModificationId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveModification_Public_Static_Boolean_byref_TModifiable_ServerGameManager_Entity_ModificationId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveModification_Public_Static_Boolean_byref_TModifiable_ClientGameManager_Entity_ModificationId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveModification_Public_Static_Boolean_byref_TModifiable_ModificationId_DynamicBuffer_1_TModification_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseValue_Public_Static_TValue_byref_TModifiable_DynamicBuffer_1_TModification_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBaseValue_Public_Static_Void_byref_TModifiable_TValue_DynamicBuffer_1_TModification_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateModifiedValue_Public_Static_TValue_byref_TModifiable_DynamicBuffer_1_TModification_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 742992, RefRangeEnd = 742993, XrefRangeStart = 742977, XrefRangeEnd = 742992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ApplyModification(
      ref TModifiable modifiable,
      ModificationStructure modificationStructure,
      ModificationType modType,
      TValue modValue,
      int priority,
      DynamicBuffer<TModification> modifications,
      Entity self,
      Entity target,
      out ModificationId modificationId)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[9];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modifiable);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modificationStructure;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &modType;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
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
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &priority;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref modificationId;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_ApplyModification_Public_Static_Boolean_byref_TModifiable_ModificationStructure_ModificationType_TValue_Int32_DynamicBuffer_1_TModification_Entity_Entity_byref_ModificationId_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TModifiable local3 = ref modifiable;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TModifiable>(objectPointer, false, false);
      local3 = (TModifiable) valueGeneric;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742993, XrefRangeEnd = 743016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ApplyModification(
      ref TModifiable modifiable,
      EntityManager entityManager,
      ModificationStructure modStructure,
      Entity self,
      Entity target,
      ModificationType modType,
      TValue modValue,
      int priority,
      out ModificationId modificationId)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[9];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modifiable);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &modStructure;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &modType;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr));
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
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &priority;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref modificationId;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_ApplyModification_Public_Static_Boolean_byref_TModifiable_EntityManager_ModificationStructure_Entity_Entity_ModificationType_TValue_Int32_byref_ModificationId_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TModifiable local3 = ref modifiable;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TModifiable>(objectPointer, false, false);
      local3 = (TModifiable) valueGeneric;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 743019, RefRangeEnd = 743020, XrefRangeStart = 743016, XrefRangeEnd = 743019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ApplyModification(
      ref TModifiable modifiable,
      ServerGameManager game,
      Entity self,
      Entity target,
      ModificationType modType,
      TValue modValue,
      int priority,
      out ModificationId modificationId)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[8];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modifiable);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &game;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &modType;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr));
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
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &priority;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref modificationId;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_ApplyModification_Public_Static_Boolean_byref_TModifiable_ServerGameManager_Entity_Entity_ModificationType_TValue_Int32_byref_ModificationId_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TModifiable local3 = ref modifiable;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TModifiable>(objectPointer, false, false);
      local3 = (TModifiable) valueGeneric;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 743023, RefRangeEnd = 743024, XrefRangeStart = 743020, XrefRangeEnd = 743023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ApplyModification(
      ref TModifiable modifiable,
      ClientGameManager game,
      Entity self,
      Entity target,
      ModificationType modType,
      TValue modValue,
      int priority,
      out ModificationId modificationId)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[8];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modifiable);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &game;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &modType;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr));
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
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &priority;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref modificationId;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_ApplyModification_Public_Static_Boolean_byref_TModifiable_ClientGameManager_Entity_Entity_ModificationType_TValue_Int32_byref_ModificationId_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TModifiable local3 = ref modifiable;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TModifiable>(objectPointer, false, false);
      local3 = (TModifiable) valueGeneric;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 743041, RefRangeEnd = 743042, XrefRangeStart = 743024, XrefRangeEnd = 743041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ModifyModification(
      ref TModifiable modification,
      ModificationId id,
      TValue modValue,
      DynamicBuffer<TModification> modifications,
      bool log = true)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modification);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
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
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &log;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_ModifyModification_Public_Static_Boolean_byref_TModifiable_ModificationId_TValue_DynamicBuffer_1_TModification_Boolean_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TModifiable local3 = ref modification;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TModifiable>(objectPointer, false, false);
      local3 = (TModifiable) valueGeneric;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743042, XrefRangeEnd = 743065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ModifyModification(
      ref TModifiable modification,
      EntityManager entityManager,
      Entity entity,
      ModificationId id,
      TValue modValue)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modification);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr));
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
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_ModifyModification_Private_Static_Boolean_byref_TModifiable_EntityManager_Entity_ModificationId_TValue_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TModifiable local3 = ref modification;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TModifiable>(objectPointer, false, false);
      local3 = (TModifiable) valueGeneric;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 743084, RefRangeEnd = 743085, XrefRangeStart = 743065, XrefRangeEnd = 743084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ModifyModification(
      ref TModifiable modification,
      ServerGameManager game,
      Entity entity,
      ModificationId id,
      TValue modValue)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modification);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &game;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr));
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
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_ModifyModification_Public_Static_Boolean_byref_TModifiable_ServerGameManager_Entity_ModificationId_TValue_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TModifiable local3 = ref modification;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TModifiable>(objectPointer, false, false);
      local3 = (TModifiable) valueGeneric;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 743110, RefRangeEnd = 743111, XrefRangeStart = 743085, XrefRangeEnd = 743110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ModifyModification(
      ref TModifiable modification,
      ClientGameManager game,
      Entity entity,
      ModificationId id,
      TValue modValue)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modification);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &game;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr));
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
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_ModifyModification_Public_Static_Boolean_byref_TModifiable_ClientGameManager_Entity_ModificationId_TValue_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TModifiable local3 = ref modification;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TModifiable>(objectPointer, false, false);
      local3 = (TModifiable) valueGeneric;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 743147, RefRangeEnd = 743148, XrefRangeStart = 743111, XrefRangeEnd = 743147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool RemoveModification(
      ref TModifiable modification,
      EntityManager entityManager,
      Entity entity,
      ModificationId id)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modification);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_RemoveModification_Public_Static_Boolean_byref_TModifiable_EntityManager_Entity_ModificationId_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TModifiable local = ref modification;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TModifiable>(objectPointer, false, false);
      local = (TModifiable) valueGeneric;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743148, XrefRangeEnd = 743186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool RemoveModification(
      ref TModifiable modification,
      ServerGameManager game,
      Entity entity,
      ModificationId id)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modification);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &game;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_RemoveModification_Public_Static_Boolean_byref_TModifiable_ServerGameManager_Entity_ModificationId_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TModifiable local = ref modification;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TModifiable>(objectPointer, false, false);
      local = (TModifiable) valueGeneric;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743186, XrefRangeEnd = 743224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool RemoveModification(
      ref TModifiable modification,
      ClientGameManager game,
      Entity entity,
      ModificationId id)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modification);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &game;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_RemoveModification_Public_Static_Boolean_byref_TModifiable_ClientGameManager_Entity_ModificationId_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TModifiable local = ref modification;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TModifiable>(objectPointer, false, false);
      local = (TModifiable) valueGeneric;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 743241, RefRangeEnd = 743242, XrefRangeStart = 743224, XrefRangeEnd = 743241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool RemoveModification(
      ref TModifiable modification,
      ModificationId id,
      DynamicBuffer<TModification> modifications,
      bool log = true)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modification);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &log;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_RemoveModification_Public_Static_Boolean_byref_TModifiable_ModificationId_DynamicBuffer_1_TModification_Boolean_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TModifiable local = ref modification;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TModifiable>(objectPointer, false, false);
      local = (TModifiable) valueGeneric;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 743247, RefRangeEnd = 743248, XrefRangeStart = 743242, XrefRangeEnd = 743247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TValue GetBaseValue(
      ref TModifiable modification,
      DynamicBuffer<TModification> modifications)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modification);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      System.IntPtr exc;
      System.IntPtr objectPointer1 = IL2CPP.il2cpp_runtime_invoke(ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_GetBaseValue_Public_Static_TValue_byref_TModifiable_DynamicBuffer_1_TModification_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TModifiable local = ref modification;
      System.IntPtr objectPointer2 = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer2 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TModifiable>(objectPointer2, false, false);
      local = (TModifiable) valueGeneric;
      return IL2CPP.PointerToValueGeneric<TValue>(objectPointer1, false, true);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 743257, RefRangeEnd = 743258, XrefRangeStart = 743248, XrefRangeEnd = 743257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetBaseValue(
      ref TModifiable modification,
      TValue newValue,
      DynamicBuffer<TModification> modifications)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modification);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
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
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_SetBaseValue_Public_Static_Void_byref_TModifiable_TValue_DynamicBuffer_1_TModification_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TModifiable local3 = ref modification;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TModifiable>(objectPointer, false, false);
      local3 = (TModifiable) valueGeneric;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 743278, RefRangeEnd = 743279, XrefRangeStart = 743258, XrefRangeEnd = 743278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TValue CalculateModifiedValue(
      ref TModifiable modifiable,
      DynamicBuffer<TModification> modifications)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modifiable);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      System.IntPtr exc;
      System.IntPtr objectPointer1 = IL2CPP.il2cpp_runtime_invoke(ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_CalculateModifiedValue_Public_Static_TValue_byref_TModifiable_DynamicBuffer_1_TModification_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TModifiable local = ref modifiable;
      System.IntPtr objectPointer2 = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer2 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TModifiable>(objectPointer2, false, false);
      local = (TModifiable) valueGeneric;
      return IL2CPP.PointerToValueGeneric<TValue>(objectPointer1, false, true);
    }

    static ModifiableFunctions()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<ModifiableFunctions<TModifiable, TModification, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", "ModifiableFunctions`3"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TModifiable>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TModification>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifiableFunctions<TModifiable, TModification, TValue>>.NativeClassPtr);
      ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_ApplyModification_Public_Static_Boolean_byref_TModifiable_ModificationStructure_ModificationType_TValue_Int32_DynamicBuffer_1_TModification_Entity_Entity_byref_ModificationId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFunctions<TModifiable, TModification, TValue>>.NativeClassPtr, 100665505);
      ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_ApplyModification_Public_Static_Boolean_byref_TModifiable_EntityManager_ModificationStructure_Entity_Entity_ModificationType_TValue_Int32_byref_ModificationId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFunctions<TModifiable, TModification, TValue>>.NativeClassPtr, 100665506);
      ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_ApplyModification_Public_Static_Boolean_byref_TModifiable_ServerGameManager_Entity_Entity_ModificationType_TValue_Int32_byref_ModificationId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFunctions<TModifiable, TModification, TValue>>.NativeClassPtr, 100665507);
      ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_ApplyModification_Public_Static_Boolean_byref_TModifiable_ClientGameManager_Entity_Entity_ModificationType_TValue_Int32_byref_ModificationId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFunctions<TModifiable, TModification, TValue>>.NativeClassPtr, 100665508);
      ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_ModifyModification_Public_Static_Boolean_byref_TModifiable_ModificationId_TValue_DynamicBuffer_1_TModification_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFunctions<TModifiable, TModification, TValue>>.NativeClassPtr, 100665509);
      ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_ModifyModification_Private_Static_Boolean_byref_TModifiable_EntityManager_Entity_ModificationId_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFunctions<TModifiable, TModification, TValue>>.NativeClassPtr, 100665510);
      ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_ModifyModification_Public_Static_Boolean_byref_TModifiable_ServerGameManager_Entity_ModificationId_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFunctions<TModifiable, TModification, TValue>>.NativeClassPtr, 100665511);
      ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_ModifyModification_Public_Static_Boolean_byref_TModifiable_ClientGameManager_Entity_ModificationId_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFunctions<TModifiable, TModification, TValue>>.NativeClassPtr, 100665512);
      ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_RemoveModification_Public_Static_Boolean_byref_TModifiable_EntityManager_Entity_ModificationId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFunctions<TModifiable, TModification, TValue>>.NativeClassPtr, 100665513);
      ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_RemoveModification_Public_Static_Boolean_byref_TModifiable_ServerGameManager_Entity_ModificationId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFunctions<TModifiable, TModification, TValue>>.NativeClassPtr, 100665514);
      ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_RemoveModification_Public_Static_Boolean_byref_TModifiable_ClientGameManager_Entity_ModificationId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFunctions<TModifiable, TModification, TValue>>.NativeClassPtr, 100665515);
      ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_RemoveModification_Public_Static_Boolean_byref_TModifiable_ModificationId_DynamicBuffer_1_TModification_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFunctions<TModifiable, TModification, TValue>>.NativeClassPtr, 100665516);
      ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_GetBaseValue_Public_Static_TValue_byref_TModifiable_DynamicBuffer_1_TModification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFunctions<TModifiable, TModification, TValue>>.NativeClassPtr, 100665517);
      ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_SetBaseValue_Public_Static_Void_byref_TModifiable_TValue_DynamicBuffer_1_TModification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFunctions<TModifiable, TModification, TValue>>.NativeClassPtr, 100665518);
      ModifiableFunctions<TModifiable, TModification, TValue>.NativeMethodInfoPtr_CalculateModifiedValue_Public_Static_TValue_byref_TModifiable_DynamicBuffer_1_TModification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFunctions<TModifiable, TModification, TValue>>.NativeClassPtr, 100665519);
    }

    public ModifiableFunctions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
