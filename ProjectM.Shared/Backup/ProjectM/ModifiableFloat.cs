// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifiableFloat
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
  public struct ModifiableFloat
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Value;
    private static readonly System.IntPtr NativeFieldInfoPtr__Identifier;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_Final_New_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Id_Public_Virtual_Final_New_get_UInt16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsFixed_Public_Virtual_Final_New_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Single_ModifiableFloat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_ModifiableFloat_Entity_EntityManager_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateFixed_Public_Static_ModifiableFloat_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseValue_Public_Virtual_Final_New_Single_DynamicBuffer_1_FloatModificationBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBaseValue_Public_Virtual_Final_New_Void_Single_DynamicBuffer_1_FloatModificationBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_DynamicBuffer_1_FloatModificationBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_byref_Single_byref_Single_ModificationType_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ModificationStructure_ModificationType_Single_Int32_DynamicBuffer_1_FloatModificationBuffer_Entity_Entity_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ServerGameManager_Entity_Entity_ModificationType_Single_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ServerGameManager_Entity_ModificationId_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ClientGameManager_Entity_Entity_ModificationType_Single_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ClientGameManager_Entity_ModificationId_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ModificationId_Single_DynamicBuffer_1_FloatModificationBuffer_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_ModificationId_DynamicBuffer_1_FloatModificationBuffer_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_EntityManager_Entity_ModificationId_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOrAddModificationsBuffer_Public_Virtual_Final_New_DynamicBuffer_1_FloatModificationBuffer_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ModifiableFloat_0;
    [FieldOffset(0)]
    public float _Value;
    [FieldOffset(4)]
    public ushort _Identifier;

    public virtual unsafe float Value
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 538356, RefRangeEnd = 538358, XrefRangeStart = 538356, XrefRangeEnd = 538358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(32), CachedScanResults(RefRangeStart = 195710, RefRangeEnd = 195742, XrefRangeStart = 195710, XrefRangeEnd = 195742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModifiableFloat.NativeMethodInfoPtr_set_Value_Public_Virtual_Final_New_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public virtual unsafe ushort Id
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat.NativeMethodInfoPtr_get_Id_Public_Virtual_Final_New_get_UInt16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat.NativeMethodInfoPtr_get_IsFixed_Public_Virtual_Final_New_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(216)]
    [CachedScanResults(RefRangeStart = 743969, RefRangeEnd = 744185, XrefRangeStart = 743969, XrefRangeEnd = 743969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator float(ModifiableFloat e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat.NativeMethodInfoPtr_op_Implicit_Public_Static_Single_ModifiableFloat_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(92)]
    [CachedScanResults(RefRangeStart = 744192, RefRangeEnd = 744284, XrefRangeStart = 744185, XrefRangeEnd = 744192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ModifiableFloat Create(
      Entity entity,
      EntityManager entityManager,
      float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat.NativeMethodInfoPtr_Create_Public_Static_ModifiableFloat_Entity_EntityManager_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModifiableFloat*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(612)]
    [CachedScanResults(RefRangeStart = 744284, RefRangeEnd = 744896, XrefRangeStart = 744284, XrefRangeEnd = 744284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ModifiableFloat CreateFixed(float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat.NativeMethodInfoPtr_CreateFixed_Public_Static_ModifiableFloat_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModifiableFloat*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 744899, RefRangeEnd = 744906, XrefRangeStart = 744896, XrefRangeEnd = 744899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe float GetBaseValue(
      DynamicBuffer<FloatModificationBuffer> modifications)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &modifications;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat.NativeMethodInfoPtr_GetBaseValue_Public_Virtual_Final_New_Single_DynamicBuffer_1_FloatModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(601)]
    [CachedScanResults(RefRangeStart = 744909, RefRangeEnd = 745510, XrefRangeStart = 744906, XrefRangeEnd = 744909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetBaseValue(
      float newValue,
      DynamicBuffer<FloatModificationBuffer> modifications)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &newValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifiableFloat.NativeMethodInfoPtr_SetBaseValue_Public_Virtual_Final_New_Void_Single_DynamicBuffer_1_FloatModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 745513, RefRangeEnd = 745514, XrefRangeStart = 745510, XrefRangeEnd = 745513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Method_Private_Virtual_Final_New_Void_DynamicBuffer_1_FloatModificationBuffer_0(
      DynamicBuffer<FloatModificationBuffer> modifications)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &modifications;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifiableFloat.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_DynamicBuffer_1_FloatModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745514, XrefRangeEnd = 745518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Method_Private_Virtual_Final_New_Void_byref_Single_byref_Single_ModificationType_Single_0(
      ref float value,
      ref float baseValue,
      ModificationType modType,
      float modValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref baseValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &modType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifiableFloat.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_byref_Single_byref_Single_ModificationType_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(26)]
    [CachedScanResults(RefRangeStart = 745535, RefRangeEnd = 745561, XrefRangeStart = 745518, XrefRangeEnd = 745535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe ModificationId ApplyModification(
      ModificationStructure modificationStructure,
      ModificationType modType,
      float modValue,
      int priority,
      DynamicBuffer<FloatModificationBuffer> modifications,
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ModificationStructure_ModificationType_Single_Int32_DynamicBuffer_1_FloatModificationBuffer_Entity_Entity_String_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745561, XrefRangeEnd = 745565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe ModificationId ApplyModification(
      ServerGameManager game,
      Entity self,
      Entity other,
      ModificationType modType,
      float modValue,
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ServerGameManager_Entity_Entity_ModificationType_Single_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745565, XrefRangeEnd = 745569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool ModifyModification(
      ServerGameManager game,
      Entity entity,
      ModificationId id,
      float modValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &game;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modValue;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ServerGameManager_Entity_ModificationId_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745569, XrefRangeEnd = 745573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe ModificationId ApplyModification(
      ClientGameManager game,
      Entity self,
      Entity other,
      ModificationType modType,
      float modValue,
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ClientGameManager_Entity_Entity_ModificationType_Single_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745573, XrefRangeEnd = 745577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool ModifyModification(
      ClientGameManager game,
      Entity entity,
      ModificationId id,
      float modValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &game;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modValue;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ClientGameManager_Entity_ModificationId_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 745594, RefRangeEnd = 745610, XrefRangeStart = 745577, XrefRangeEnd = 745594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool ModifyModification(
      ModificationId id,
      float modValue,
      DynamicBuffer<FloatModificationBuffer> modifications,
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ModificationId_Single_DynamicBuffer_1_FloatModificationBuffer_String_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(22)]
    [CachedScanResults(RefRangeStart = 745627, RefRangeEnd = 745649, XrefRangeStart = 745610, XrefRangeEnd = 745627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool RemoveModification(
      ModificationId id,
      DynamicBuffer<FloatModificationBuffer> modifications,
      string callerFilePath = null,
      int callerLineNumber = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(callerFilePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &callerLineNumber;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat.NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_ModificationId_DynamicBuffer_1_FloatModificationBuffer_String_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745649, XrefRangeEnd = 745666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat.NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_EntityManager_Entity_ModificationId_String_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 745676, RefRangeEnd = 745679, XrefRangeStart = 745666, XrefRangeEnd = 745676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe DynamicBuffer<FloatModificationBuffer> GetOrAddModificationsBuffer(
      EntityManager entityManager,
      Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat.NativeMethodInfoPtr_GetOrAddModificationsBuffer_Public_Virtual_Final_New_DynamicBuffer_1_FloatModificationBuffer_EntityManager_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DynamicBuffer<FloatModificationBuffer>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public virtual unsafe bool Equals(ModifiableFloat other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ModifiableFloat_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ModifiableFloat()
    {
      Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ModifiableFloat));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr);
      ModifiableFloat.NativeFieldInfoPtr__Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr, nameof (_Value));
      ModifiableFloat.NativeFieldInfoPtr__Identifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr, nameof (_Identifier));
      ModifiableFloat.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr, 100665573);
      ModifiableFloat.NativeMethodInfoPtr_set_Value_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr, 100665574);
      ModifiableFloat.NativeMethodInfoPtr_get_Id_Public_Virtual_Final_New_get_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr, 100665575);
      ModifiableFloat.NativeMethodInfoPtr_get_IsFixed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr, 100665576);
      ModifiableFloat.NativeMethodInfoPtr_op_Implicit_Public_Static_Single_ModifiableFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr, 100665577);
      ModifiableFloat.NativeMethodInfoPtr_Create_Public_Static_ModifiableFloat_Entity_EntityManager_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr, 100665578);
      ModifiableFloat.NativeMethodInfoPtr_CreateFixed_Public_Static_ModifiableFloat_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr, 100665579);
      ModifiableFloat.NativeMethodInfoPtr_GetBaseValue_Public_Virtual_Final_New_Single_DynamicBuffer_1_FloatModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr, 100665580);
      ModifiableFloat.NativeMethodInfoPtr_SetBaseValue_Public_Virtual_Final_New_Void_Single_DynamicBuffer_1_FloatModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr, 100665581);
      ModifiableFloat.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_DynamicBuffer_1_FloatModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr, 100665582);
      ModifiableFloat.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_byref_Single_byref_Single_ModificationType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr, 100665583);
      ModifiableFloat.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ModificationStructure_ModificationType_Single_Int32_DynamicBuffer_1_FloatModificationBuffer_Entity_Entity_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr, 100665584);
      ModifiableFloat.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ServerGameManager_Entity_Entity_ModificationType_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr, 100665585);
      ModifiableFloat.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ServerGameManager_Entity_ModificationId_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr, 100665586);
      ModifiableFloat.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ClientGameManager_Entity_Entity_ModificationType_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr, 100665587);
      ModifiableFloat.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ClientGameManager_Entity_ModificationId_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr, 100665588);
      ModifiableFloat.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ModificationId_Single_DynamicBuffer_1_FloatModificationBuffer_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr, 100665589);
      ModifiableFloat.NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_ModificationId_DynamicBuffer_1_FloatModificationBuffer_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr, 100665590);
      ModifiableFloat.NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_EntityManager_Entity_ModificationId_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr, 100665591);
      ModifiableFloat.NativeMethodInfoPtr_GetOrAddModificationsBuffer_Public_Virtual_Final_New_DynamicBuffer_1_FloatModificationBuffer_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr, 100665592);
      ModifiableFloat.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ModifiableFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr, 100665593);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifiableFloat>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
