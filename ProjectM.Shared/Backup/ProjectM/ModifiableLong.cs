// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifiableLong
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
  public struct ModifiableLong
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Value;
    private static readonly System.IntPtr NativeFieldInfoPtr__Identifier;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_Final_New_set_Void_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Id_Public_Virtual_Final_New_get_UInt16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsFixed_Public_Virtual_Final_New_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int64_ModifiableLong_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_ModifiableLong_Entity_EntityManager_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateFixed_Public_Static_ModifiableLong_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseValue_Public_Virtual_Final_New_Int64_DynamicBuffer_1_LongModificationBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBaseValue_Public_Virtual_Final_New_Void_Int64_DynamicBuffer_1_LongModificationBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_DynamicBuffer_1_LongModificationBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_byref_Int64_byref_Int64_ModificationType_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ModificationStructure_ModificationType_Int64_Int32_DynamicBuffer_1_LongModificationBuffer_Entity_Entity_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ServerGameManager_Entity_Entity_ModificationType_Int64_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ServerGameManager_Entity_ModificationId_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ClientGameManager_Entity_Entity_ModificationType_Int64_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ClientGameManager_Entity_ModificationId_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ModificationId_Int64_DynamicBuffer_1_LongModificationBuffer_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_ModificationId_DynamicBuffer_1_LongModificationBuffer_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_EntityManager_Entity_ModificationId_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOrAddModificationsBuffer_Public_Virtual_Final_New_DynamicBuffer_1_LongModificationBuffer_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ModifiableLong_0;
    [FieldOffset(0)]
    public long _Value;
    [FieldOffset(8)]
    public ushort _Identifier;

    public virtual unsafe long Value
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableLong.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(long*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModifiableLong.NativeMethodInfoPtr_set_Value_Public_Virtual_Final_New_set_Void_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public virtual unsafe ushort Id
    {
      [CallerCount(6), CachedScanResults(RefRangeStart = 743821, RefRangeEnd = 743827, XrefRangeStart = 743821, XrefRangeEnd = 743827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableLong.NativeMethodInfoPtr_get_Id_Public_Virtual_Final_New_get_UInt16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableLong.NativeMethodInfoPtr_get_IsFixed_Public_Virtual_Final_New_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(54)]
    [CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator long(ModifiableLong e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableLong.NativeMethodInfoPtr_op_Implicit_Public_Static_Int64_ModifiableLong_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(long*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 746136, RefRangeEnd = 746138, XrefRangeStart = 746129, XrefRangeEnd = 746136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ModifiableLong Create(
      Entity entity,
      EntityManager entityManager,
      long value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableLong.NativeMethodInfoPtr_Create_Public_Static_ModifiableLong_Entity_EntityManager_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModifiableLong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(108)]
    [CachedScanResults(RefRangeStart = 746138, RefRangeEnd = 746246, XrefRangeStart = 746138, XrefRangeEnd = 746138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ModifiableLong CreateFixed(long value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableLong.NativeMethodInfoPtr_CreateFixed_Public_Static_ModifiableLong_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModifiableLong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746246, XrefRangeEnd = 746249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe long GetBaseValue(
      DynamicBuffer<LongModificationBuffer> modifications)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &modifications;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableLong.NativeMethodInfoPtr_GetBaseValue_Public_Virtual_Final_New_Int64_DynamicBuffer_1_LongModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(long*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(108)]
    [CachedScanResults(RefRangeStart = 746252, RefRangeEnd = 746360, XrefRangeStart = 746249, XrefRangeEnd = 746252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetBaseValue(
      long newValue,
      DynamicBuffer<LongModificationBuffer> modifications)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &newValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifiableLong.NativeMethodInfoPtr_SetBaseValue_Public_Virtual_Final_New_Void_Int64_DynamicBuffer_1_LongModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746360, XrefRangeEnd = 746363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Method_Private_Virtual_Final_New_Void_DynamicBuffer_1_LongModificationBuffer_0(
      DynamicBuffer<LongModificationBuffer> modifications)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &modifications;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifiableLong.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_DynamicBuffer_1_LongModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746363, XrefRangeEnd = 746366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Method_Private_Virtual_Final_New_Void_byref_Int64_byref_Int64_ModificationType_Int64_0(
      ref long value,
      ref long baseValue,
      ModificationType modType,
      long modValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref baseValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &modType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifiableLong.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_byref_Int64_byref_Int64_ModificationType_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 746383, RefRangeEnd = 746390, XrefRangeStart = 746366, XrefRangeEnd = 746383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe ModificationId ApplyModification(
      ModificationStructure modificationStructure,
      ModificationType modType,
      long modValue,
      int priority,
      DynamicBuffer<LongModificationBuffer> modifications,
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableLong.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ModificationStructure_ModificationType_Int64_Int32_DynamicBuffer_1_LongModificationBuffer_Entity_Entity_String_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746390, XrefRangeEnd = 746394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe ModificationId ApplyModification(
      ServerGameManager game,
      Entity self,
      Entity other,
      ModificationType modType,
      long modValue,
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableLong.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ServerGameManager_Entity_Entity_ModificationType_Int64_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746394, XrefRangeEnd = 746398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool ModifyModification(
      ServerGameManager game,
      Entity entity,
      ModificationId id,
      long modValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &game;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modValue;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableLong.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ServerGameManager_Entity_ModificationId_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746398, XrefRangeEnd = 746402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe ModificationId ApplyModification(
      ClientGameManager game,
      Entity self,
      Entity other,
      ModificationType modType,
      long modValue,
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableLong.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ClientGameManager_Entity_Entity_ModificationType_Int64_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746402, XrefRangeEnd = 746406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool ModifyModification(
      ClientGameManager game,
      Entity entity,
      ModificationId id,
      long modValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &game;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modValue;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableLong.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ClientGameManager_Entity_ModificationId_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 746423, RefRangeEnd = 746425, XrefRangeStart = 746406, XrefRangeEnd = 746423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool ModifyModification(
      ModificationId id,
      long modValue,
      DynamicBuffer<LongModificationBuffer> modifications,
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableLong.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ModificationId_Int64_DynamicBuffer_1_LongModificationBuffer_String_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 746442, RefRangeEnd = 746450, XrefRangeStart = 746425, XrefRangeEnd = 746442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool RemoveModification(
      ModificationId id,
      DynamicBuffer<LongModificationBuffer> modifications,
      string callerFilePath = null,
      int callerLineNumber = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(callerFilePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &callerLineNumber;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableLong.NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_ModificationId_DynamicBuffer_1_LongModificationBuffer_String_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746450, XrefRangeEnd = 746467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableLong.NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_EntityManager_Entity_ModificationId_String_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746467, XrefRangeEnd = 746477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe DynamicBuffer<LongModificationBuffer> GetOrAddModificationsBuffer(
      EntityManager entityManager,
      Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableLong.NativeMethodInfoPtr_GetOrAddModificationsBuffer_Public_Virtual_Final_New_DynamicBuffer_1_LongModificationBuffer_EntityManager_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DynamicBuffer<LongModificationBuffer>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public virtual unsafe bool Equals(ModifiableLong other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableLong.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ModifiableLong_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ModifiableLong()
    {
      Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ModifiableLong));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr);
      ModifiableLong.NativeFieldInfoPtr__Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr, nameof (_Value));
      ModifiableLong.NativeFieldInfoPtr__Identifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr, nameof (_Identifier));
      ModifiableLong.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr, 100665641);
      ModifiableLong.NativeMethodInfoPtr_set_Value_Public_Virtual_Final_New_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr, 100665642);
      ModifiableLong.NativeMethodInfoPtr_get_Id_Public_Virtual_Final_New_get_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr, 100665643);
      ModifiableLong.NativeMethodInfoPtr_get_IsFixed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr, 100665644);
      ModifiableLong.NativeMethodInfoPtr_op_Implicit_Public_Static_Int64_ModifiableLong_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr, 100665645);
      ModifiableLong.NativeMethodInfoPtr_Create_Public_Static_ModifiableLong_Entity_EntityManager_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr, 100665646);
      ModifiableLong.NativeMethodInfoPtr_CreateFixed_Public_Static_ModifiableLong_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr, 100665647);
      ModifiableLong.NativeMethodInfoPtr_GetBaseValue_Public_Virtual_Final_New_Int64_DynamicBuffer_1_LongModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr, 100665648);
      ModifiableLong.NativeMethodInfoPtr_SetBaseValue_Public_Virtual_Final_New_Void_Int64_DynamicBuffer_1_LongModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr, 100665649);
      ModifiableLong.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_DynamicBuffer_1_LongModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr, 100665650);
      ModifiableLong.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_byref_Int64_byref_Int64_ModificationType_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr, 100665651);
      ModifiableLong.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ModificationStructure_ModificationType_Int64_Int32_DynamicBuffer_1_LongModificationBuffer_Entity_Entity_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr, 100665652);
      ModifiableLong.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ServerGameManager_Entity_Entity_ModificationType_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr, 100665653);
      ModifiableLong.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ServerGameManager_Entity_ModificationId_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr, 100665654);
      ModifiableLong.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ClientGameManager_Entity_Entity_ModificationType_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr, 100665655);
      ModifiableLong.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ClientGameManager_Entity_ModificationId_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr, 100665656);
      ModifiableLong.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ModificationId_Int64_DynamicBuffer_1_LongModificationBuffer_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr, 100665657);
      ModifiableLong.NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_ModificationId_DynamicBuffer_1_LongModificationBuffer_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr, 100665658);
      ModifiableLong.NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_EntityManager_Entity_ModificationId_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr, 100665659);
      ModifiableLong.NativeMethodInfoPtr_GetOrAddModificationsBuffer_Public_Virtual_Final_New_DynamicBuffer_1_LongModificationBuffer_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr, 100665660);
      ModifiableLong.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ModifiableLong_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr, 100665661);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifiableLong>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
