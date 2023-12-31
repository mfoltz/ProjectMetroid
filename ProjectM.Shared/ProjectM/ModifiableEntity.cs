// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifiableEntity
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Scripting;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct ModifiableEntity
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Value;
    private static readonly System.IntPtr NativeFieldInfoPtr__Identifier;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_Final_New_set_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Id_Public_Virtual_Final_New_get_UInt16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsFixed_Public_Virtual_Final_New_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_ModifiableEntity_Entity_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateFixed_Public_Static_ModifiableEntity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ForceSet_Public_Static_ModifiableEntity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseValue_Public_Virtual_Final_New_Entity_DynamicBuffer_1_EntityModificationBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBaseValue_Public_Virtual_Final_New_Void_Entity_DynamicBuffer_1_EntityModificationBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_DynamicBuffer_1_EntityModificationBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_byref_Entity_byref_Entity_ModificationType_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ModificationStructure_ModificationType_Entity_Int32_DynamicBuffer_1_EntityModificationBuffer_Entity_Entity_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ServerGameManager_Entity_Entity_ModificationType_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ServerGameManager_Entity_ModificationId_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ClientGameManager_Entity_Entity_ModificationType_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ClientGameManager_Entity_ModificationId_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ModificationId_Entity_DynamicBuffer_1_EntityModificationBuffer_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_ModificationId_DynamicBuffer_1_EntityModificationBuffer_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_EntityManager_Entity_ModificationId_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOrAddModificationsBuffer_Public_Virtual_Final_New_DynamicBuffer_1_EntityModificationBuffer_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Entity_ModifiableEntity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ModifiableEntity_ModifiableEntity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ModifiableEntity_ModifiableEntity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ModifiableEntity_0;
    [FieldOffset(0)]
    public Entity _Value;
    [FieldOffset(8)]
    public ushort _Identifier;

    public virtual unsafe Entity Value
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_set_Value_Public_Virtual_Final_New_set_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public virtual unsafe ushort Id
    {
      [CallerCount(6), CachedScanResults(RefRangeStart = 743821, RefRangeEnd = 743827, XrefRangeStart = 743821, XrefRangeEnd = 743821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_get_Id_Public_Virtual_Final_New_get_UInt16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ushort*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public virtual unsafe bool IsFixed
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_get_IsFixed_Public_Virtual_Final_New_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 743834, RefRangeEnd = 743837, XrefRangeStart = 743827, XrefRangeEnd = 743834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ModifiableEntity Create(
      Entity entity,
      EntityManager entityManager,
      Entity value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_Create_Public_Static_ModifiableEntity_Entity_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModifiableEntity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe ModifiableEntity CreateFixed(Entity value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_CreateFixed_Public_Static_ModifiableEntity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModifiableEntity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe ModifiableEntity ForceSet(Entity value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_ForceSet_Public_Static_ModifiableEntity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModifiableEntity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 743840, RefRangeEnd = 743841, XrefRangeStart = 743837, XrefRangeEnd = 743840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Entity GetBaseValue(
      DynamicBuffer<EntityModificationBuffer> modifications)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &modifications;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_GetBaseValue_Public_Virtual_Final_New_Entity_DynamicBuffer_1_EntityModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 743844, RefRangeEnd = 743852, XrefRangeStart = 743841, XrefRangeEnd = 743844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetBaseValue(
      Entity newValue,
      DynamicBuffer<EntityModificationBuffer> modifications)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &newValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_SetBaseValue_Public_Virtual_Final_New_Void_Entity_DynamicBuffer_1_EntityModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743852, XrefRangeEnd = 743855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Method_Private_Virtual_Final_New_Void_DynamicBuffer_1_EntityModificationBuffer_0(
      DynamicBuffer<EntityModificationBuffer> modifications)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &modifications;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_DynamicBuffer_1_EntityModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743855, XrefRangeEnd = 743860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Method_Private_Virtual_Final_New_Void_byref_Entity_byref_Entity_ModificationType_Entity_0(
      ref Entity value,
      ref Entity _,
      ModificationType modType,
      Entity modValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref _;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &modType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_byref_Entity_byref_Entity_ModificationType_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 743877, RefRangeEnd = 743880, XrefRangeStart = 743860, XrefRangeEnd = 743877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe ModificationId ApplyModification(
      ModificationStructure modificationStructure,
      ModificationType modType,
      Entity modValue,
      int priority,
      DynamicBuffer<EntityModificationBuffer> modifications,
      Entity self,
      Entity target,
      string callerFilePath = null,
      int callerLineNumber = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) &modificationStructure;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &modValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &priority;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(callerFilePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &callerLineNumber;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ModificationStructure_ModificationType_Entity_Int32_DynamicBuffer_1_EntityModificationBuffer_Entity_Entity_String_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743880, XrefRangeEnd = 743884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe ModificationId ApplyModification(
      ServerGameManager game,
      Entity self,
      Entity other,
      ModificationType modType,
      Entity modValue,
      int priority = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &game;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &other;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &modValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &priority;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ServerGameManager_Entity_Entity_ModificationType_Entity_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743884, XrefRangeEnd = 743888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool ModifyModification(
      ServerGameManager game,
      Entity entity,
      ModificationId id,
      Entity modValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &game;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modValue;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ServerGameManager_Entity_ModificationId_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743888, XrefRangeEnd = 743892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe ModificationId ApplyModification(
      ClientGameManager game,
      Entity self,
      Entity other,
      ModificationType modType,
      Entity modValue,
      int priority = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &game;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &other;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &modValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &priority;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ClientGameManager_Entity_Entity_ModificationType_Entity_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743892, XrefRangeEnd = 743896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool ModifyModification(
      ClientGameManager game,
      Entity entity,
      ModificationId id,
      Entity modValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &game;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modValue;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ClientGameManager_Entity_ModificationId_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 743913, RefRangeEnd = 743914, XrefRangeStart = 743896, XrefRangeEnd = 743913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool ModifyModification(
      ModificationId id,
      Entity modValue,
      DynamicBuffer<EntityModificationBuffer> modifications,
      string callerFilePath = null,
      int callerLineNumber = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(callerFilePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &callerLineNumber;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ModificationId_Entity_DynamicBuffer_1_EntityModificationBuffer_String_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 743931, RefRangeEnd = 743935, XrefRangeStart = 743914, XrefRangeEnd = 743931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool RemoveModification(
      ModificationId id,
      DynamicBuffer<EntityModificationBuffer> modifications,
      string callerFilePath = null,
      int callerLineNumber = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(callerFilePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &callerLineNumber;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_ModificationId_DynamicBuffer_1_EntityModificationBuffer_String_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743935, XrefRangeEnd = 743952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool RemoveModification(
      EntityManager entityManager,
      Entity entity,
      ModificationId id,
      string callerFilePath = null,
      int callerLineNumber = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(callerFilePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &callerLineNumber;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_EntityManager_Entity_ModificationId_String_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743952, XrefRangeEnd = 743962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe DynamicBuffer<EntityModificationBuffer> GetOrAddModificationsBuffer(
      EntityManager entityManager,
      Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_GetOrAddModificationsBuffer_Public_Virtual_Final_New_DynamicBuffer_1_EntityModificationBuffer_EntityManager_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DynamicBuffer<EntityModificationBuffer>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(54)]
    [CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator Entity(ModifiableEntity e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_op_Implicit_Public_Static_Entity_ModifiableEntity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743962, XrefRangeEnd = 743963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator ==(ModifiableEntity a, ModifiableEntity b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ModifiableEntity_ModifiableEntity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 743964, RefRangeEnd = 743965, XrefRangeStart = 743963, XrefRangeEnd = 743964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator !=(ModifiableEntity a, ModifiableEntity b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ModifiableEntity_ModifiableEntity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743965, XrefRangeEnd = 743968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object o)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) o);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(409)]
    [CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743968, XrefRangeEnd = 743969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(ModifiableEntity other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableEntity.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ModifiableEntity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ModifiableEntity()
    {
      Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ModifiableEntity));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr);
      ModifiableEntity.NativeFieldInfoPtr__Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, nameof (_Value));
      ModifiableEntity.NativeFieldInfoPtr__Identifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, nameof (_Identifier));
      ModifiableEntity.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665545);
      ModifiableEntity.NativeMethodInfoPtr_set_Value_Public_Virtual_Final_New_set_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665546);
      ModifiableEntity.NativeMethodInfoPtr_get_Id_Public_Virtual_Final_New_get_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665547);
      ModifiableEntity.NativeMethodInfoPtr_get_IsFixed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665548);
      ModifiableEntity.NativeMethodInfoPtr_Create_Public_Static_ModifiableEntity_Entity_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665549);
      ModifiableEntity.NativeMethodInfoPtr_CreateFixed_Public_Static_ModifiableEntity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665550);
      ModifiableEntity.NativeMethodInfoPtr_ForceSet_Public_Static_ModifiableEntity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665551);
      ModifiableEntity.NativeMethodInfoPtr_GetBaseValue_Public_Virtual_Final_New_Entity_DynamicBuffer_1_EntityModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665552);
      ModifiableEntity.NativeMethodInfoPtr_SetBaseValue_Public_Virtual_Final_New_Void_Entity_DynamicBuffer_1_EntityModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665553);
      ModifiableEntity.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_DynamicBuffer_1_EntityModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665554);
      ModifiableEntity.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_byref_Entity_byref_Entity_ModificationType_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665555);
      ModifiableEntity.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ModificationStructure_ModificationType_Entity_Int32_DynamicBuffer_1_EntityModificationBuffer_Entity_Entity_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665556);
      ModifiableEntity.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ServerGameManager_Entity_Entity_ModificationType_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665557);
      ModifiableEntity.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ServerGameManager_Entity_ModificationId_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665558);
      ModifiableEntity.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ClientGameManager_Entity_Entity_ModificationType_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665559);
      ModifiableEntity.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ClientGameManager_Entity_ModificationId_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665560);
      ModifiableEntity.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ModificationId_Entity_DynamicBuffer_1_EntityModificationBuffer_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665561);
      ModifiableEntity.NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_ModificationId_DynamicBuffer_1_EntityModificationBuffer_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665562);
      ModifiableEntity.NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_EntityManager_Entity_ModificationId_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665563);
      ModifiableEntity.NativeMethodInfoPtr_GetOrAddModificationsBuffer_Public_Virtual_Final_New_DynamicBuffer_1_EntityModificationBuffer_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665564);
      ModifiableEntity.NativeMethodInfoPtr_op_Implicit_Public_Static_Entity_ModifiableEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665565);
      ModifiableEntity.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ModifiableEntity_ModifiableEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665566);
      ModifiableEntity.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ModifiableEntity_ModifiableEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665567);
      ModifiableEntity.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665568);
      ModifiableEntity.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665569);
      ModifiableEntity.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ModifiableEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, 100665570);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifiableEntity>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
