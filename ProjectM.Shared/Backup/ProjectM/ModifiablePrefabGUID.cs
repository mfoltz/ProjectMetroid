// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifiablePrefabGUID
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Scripting;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct ModifiablePrefabGUID
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Value;
    private static readonly System.IntPtr NativeFieldInfoPtr__Identifier;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_Final_New_set_Void_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Id_Public_Virtual_Final_New_get_UInt16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsFixed_Public_Virtual_Final_New_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PrefabGUID_ModifiablePrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_ModifiablePrefabGUID_Entity_EntityManager_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateFixed_Public_Static_ModifiablePrefabGUID_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseValue_Public_Virtual_Final_New_PrefabGUID_DynamicBuffer_1_PrefabGUIDModificationBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBaseValue_Public_Virtual_Final_New_Void_PrefabGUID_DynamicBuffer_1_PrefabGUIDModificationBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_DynamicBuffer_1_PrefabGUIDModificationBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_byref_PrefabGUID_byref_PrefabGUID_ModificationType_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ModificationStructure_ModificationType_PrefabGUID_Int32_DynamicBuffer_1_PrefabGUIDModificationBuffer_Entity_Entity_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ServerGameManager_Entity_Entity_ModificationType_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ServerGameManager_Entity_ModificationId_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ClientGameManager_Entity_Entity_ModificationType_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ClientGameManager_Entity_ModificationId_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ModificationId_PrefabGUID_DynamicBuffer_1_PrefabGUIDModificationBuffer_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_ModificationId_DynamicBuffer_1_PrefabGUIDModificationBuffer_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_EntityManager_Entity_ModificationId_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOrAddModificationsBuffer_Public_Virtual_Final_New_DynamicBuffer_1_PrefabGUIDModificationBuffer_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ModifiablePrefabGUID_0;
    [FieldOffset(0)]
    public PrefabGUID _Value;
    [FieldOffset(4)]
    public ushort _Identifier;

    public virtual unsafe PrefabGUID Value
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiablePrefabGUID.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45021, XrefRangeStart = 45001, XrefRangeEnd = 45021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModifiablePrefabGUID.NativeMethodInfoPtr_set_Value_Public_Virtual_Final_New_set_Void_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public virtual unsafe ushort Id
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiablePrefabGUID.NativeMethodInfoPtr_get_Id_Public_Virtual_Final_New_get_UInt16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiablePrefabGUID.NativeMethodInfoPtr_get_IsFixed_Public_Virtual_Final_New_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(504)]
    [CachedScanResults(RefRangeStart = 279526, RefRangeEnd = 280030, XrefRangeStart = 279526, XrefRangeEnd = 280030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator PrefabGUID(ModifiablePrefabGUID e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiablePrefabGUID.NativeMethodInfoPtr_op_Implicit_Public_Static_PrefabGUID_ModifiablePrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 746603, RefRangeEnd = 746605, XrefRangeStart = 746596, XrefRangeEnd = 746603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ModifiablePrefabGUID Create(
      Entity entity,
      EntityManager entityManager,
      PrefabGUID value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiablePrefabGUID.NativeMethodInfoPtr_Create_Public_Static_ModifiablePrefabGUID_Entity_EntityManager_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModifiablePrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(81)]
    [CachedScanResults(RefRangeStart = 745846, RefRangeEnd = 745927, XrefRangeStart = 745846, XrefRangeEnd = 745927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ModifiablePrefabGUID CreateFixed(PrefabGUID value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiablePrefabGUID.NativeMethodInfoPtr_CreateFixed_Public_Static_ModifiablePrefabGUID_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModifiablePrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 746608, RefRangeEnd = 746610, XrefRangeStart = 746605, XrefRangeEnd = 746608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe PrefabGUID GetBaseValue(
      DynamicBuffer<PrefabGUIDModificationBuffer> modifications)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &modifications;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiablePrefabGUID.NativeMethodInfoPtr_GetBaseValue_Public_Virtual_Final_New_PrefabGUID_DynamicBuffer_1_PrefabGUIDModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 746613, RefRangeEnd = 746620, XrefRangeStart = 746610, XrefRangeEnd = 746613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetBaseValue(
      PrefabGUID newValue,
      DynamicBuffer<PrefabGUIDModificationBuffer> modifications)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &newValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifiablePrefabGUID.NativeMethodInfoPtr_SetBaseValue_Public_Virtual_Final_New_Void_PrefabGUID_DynamicBuffer_1_PrefabGUIDModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746620, XrefRangeEnd = 746623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Method_Private_Virtual_Final_New_Void_DynamicBuffer_1_PrefabGUIDModificationBuffer_0(
      DynamicBuffer<PrefabGUIDModificationBuffer> modifications)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &modifications;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifiablePrefabGUID.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_DynamicBuffer_1_PrefabGUIDModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746623, XrefRangeEnd = 746628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Method_Private_Virtual_Final_New_Void_byref_PrefabGUID_byref_PrefabGUID_ModificationType_PrefabGUID_0(
      ref PrefabGUID value,
      ref PrefabGUID baseValue,
      ModificationType modType,
      PrefabGUID modValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref baseValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &modType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifiablePrefabGUID.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_byref_PrefabGUID_byref_PrefabGUID_ModificationType_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 746645, RefRangeEnd = 746647, XrefRangeStart = 746628, XrefRangeEnd = 746645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe ModificationId ApplyModification(
      ModificationStructure modificationStructure,
      ModificationType modType,
      PrefabGUID modValue,
      int priority,
      DynamicBuffer<PrefabGUIDModificationBuffer> modifications,
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiablePrefabGUID.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ModificationStructure_ModificationType_PrefabGUID_Int32_DynamicBuffer_1_PrefabGUIDModificationBuffer_Entity_Entity_String_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746647, XrefRangeEnd = 746651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe ModificationId ApplyModification(
      ServerGameManager game,
      Entity self,
      Entity other,
      ModificationType modType,
      PrefabGUID modValue,
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiablePrefabGUID.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ServerGameManager_Entity_Entity_ModificationType_PrefabGUID_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746651, XrefRangeEnd = 746655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool ModifyModification(
      ServerGameManager game,
      Entity entity,
      ModificationId id,
      PrefabGUID modValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &game;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modValue;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiablePrefabGUID.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ServerGameManager_Entity_ModificationId_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746655, XrefRangeEnd = 746659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe ModificationId ApplyModification(
      ClientGameManager game,
      Entity self,
      Entity other,
      ModificationType modType,
      PrefabGUID modValue,
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiablePrefabGUID.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ClientGameManager_Entity_Entity_ModificationType_PrefabGUID_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746659, XrefRangeEnd = 746663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool ModifyModification(
      ClientGameManager game,
      Entity entity,
      ModificationId id,
      PrefabGUID modValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &game;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modValue;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiablePrefabGUID.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ClientGameManager_Entity_ModificationId_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746663, XrefRangeEnd = 746680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool ModifyModification(
      ModificationId id,
      PrefabGUID modValue,
      DynamicBuffer<PrefabGUIDModificationBuffer> modifications,
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiablePrefabGUID.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ModificationId_PrefabGUID_DynamicBuffer_1_PrefabGUIDModificationBuffer_String_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 746697, RefRangeEnd = 746699, XrefRangeStart = 746680, XrefRangeEnd = 746697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool RemoveModification(
      ModificationId id,
      DynamicBuffer<PrefabGUIDModificationBuffer> modifications,
      string callerFilePath = null,
      int callerLineNumber = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(callerFilePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &callerLineNumber;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiablePrefabGUID.NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_ModificationId_DynamicBuffer_1_PrefabGUIDModificationBuffer_String_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746699, XrefRangeEnd = 746716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiablePrefabGUID.NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_EntityManager_Entity_ModificationId_String_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746716, XrefRangeEnd = 746726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe DynamicBuffer<PrefabGUIDModificationBuffer> GetOrAddModificationsBuffer(
      EntityManager entityManager,
      Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiablePrefabGUID.NativeMethodInfoPtr_GetOrAddModificationsBuffer_Public_Virtual_Final_New_DynamicBuffer_1_PrefabGUIDModificationBuffer_EntityManager_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DynamicBuffer<PrefabGUIDModificationBuffer>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746726, XrefRangeEnd = 746727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(ModifiablePrefabGUID other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiablePrefabGUID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ModifiablePrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ModifiablePrefabGUID()
    {
      Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ModifiablePrefabGUID));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr);
      ModifiablePrefabGUID.NativeFieldInfoPtr__Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr, nameof (_Value));
      ModifiablePrefabGUID.NativeFieldInfoPtr__Identifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr, nameof (_Identifier));
      ModifiablePrefabGUID.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr, 100665686);
      ModifiablePrefabGUID.NativeMethodInfoPtr_set_Value_Public_Virtual_Final_New_set_Void_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr, 100665687);
      ModifiablePrefabGUID.NativeMethodInfoPtr_get_Id_Public_Virtual_Final_New_get_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr, 100665688);
      ModifiablePrefabGUID.NativeMethodInfoPtr_get_IsFixed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr, 100665689);
      ModifiablePrefabGUID.NativeMethodInfoPtr_op_Implicit_Public_Static_PrefabGUID_ModifiablePrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr, 100665690);
      ModifiablePrefabGUID.NativeMethodInfoPtr_Create_Public_Static_ModifiablePrefabGUID_Entity_EntityManager_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr, 100665691);
      ModifiablePrefabGUID.NativeMethodInfoPtr_CreateFixed_Public_Static_ModifiablePrefabGUID_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr, 100665692);
      ModifiablePrefabGUID.NativeMethodInfoPtr_GetBaseValue_Public_Virtual_Final_New_PrefabGUID_DynamicBuffer_1_PrefabGUIDModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr, 100665693);
      ModifiablePrefabGUID.NativeMethodInfoPtr_SetBaseValue_Public_Virtual_Final_New_Void_PrefabGUID_DynamicBuffer_1_PrefabGUIDModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr, 100665694);
      ModifiablePrefabGUID.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_DynamicBuffer_1_PrefabGUIDModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr, 100665695);
      ModifiablePrefabGUID.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_byref_PrefabGUID_byref_PrefabGUID_ModificationType_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr, 100665696);
      ModifiablePrefabGUID.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ModificationStructure_ModificationType_PrefabGUID_Int32_DynamicBuffer_1_PrefabGUIDModificationBuffer_Entity_Entity_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr, 100665697);
      ModifiablePrefabGUID.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ServerGameManager_Entity_Entity_ModificationType_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr, 100665698);
      ModifiablePrefabGUID.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ServerGameManager_Entity_ModificationId_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr, 100665699);
      ModifiablePrefabGUID.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ClientGameManager_Entity_Entity_ModificationType_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr, 100665700);
      ModifiablePrefabGUID.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ClientGameManager_Entity_ModificationId_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr, 100665701);
      ModifiablePrefabGUID.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ModificationId_PrefabGUID_DynamicBuffer_1_PrefabGUIDModificationBuffer_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr, 100665702);
      ModifiablePrefabGUID.NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_ModificationId_DynamicBuffer_1_PrefabGUIDModificationBuffer_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr, 100665703);
      ModifiablePrefabGUID.NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_EntityManager_Entity_ModificationId_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr, 100665704);
      ModifiablePrefabGUID.NativeMethodInfoPtr_GetOrAddModificationsBuffer_Public_Virtual_Final_New_DynamicBuffer_1_PrefabGUIDModificationBuffer_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr, 100665705);
      ModifiablePrefabGUID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ModifiablePrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr, 100665706);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifiablePrefabGUID>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
