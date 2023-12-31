// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifiableFloat3
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Scripting;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct ModifiableFloat3
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Value;
    private static readonly System.IntPtr NativeFieldInfoPtr__Identifier;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_Final_New_set_Void_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Id_Public_Virtual_Final_New_get_UInt16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsFixed_Public_Virtual_Final_New_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_ModifiableFloat3_Entity_EntityManager_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateFixed_Public_Static_ModifiableFloat3_float3_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseValue_Public_Virtual_Final_New_float3_DynamicBuffer_1_Float3ModificationBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBaseValue_Public_Virtual_Final_New_Void_float3_DynamicBuffer_1_Float3ModificationBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_DynamicBuffer_1_Float3ModificationBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_byref_float3_byref_float3_ModificationType_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ModificationStructure_ModificationType_float3_Int32_DynamicBuffer_1_Float3ModificationBuffer_Entity_Entity_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ServerGameManager_Entity_Entity_ModificationType_float3_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ServerGameManager_Entity_ModificationId_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ClientGameManager_Entity_Entity_ModificationType_float3_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ClientGameManager_Entity_ModificationId_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ModificationId_float3_DynamicBuffer_1_Float3ModificationBuffer_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_ModificationId_DynamicBuffer_1_Float3ModificationBuffer_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_EntityManager_Entity_ModificationId_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOrAddModificationsBuffer_Public_Virtual_Final_New_DynamicBuffer_1_Float3ModificationBuffer_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ModifiableFloat3_0;
    [FieldOffset(0)]
    public float3 _Value;
    [FieldOffset(12)]
    public ushort _Identifier;

    public virtual unsafe float3 Value
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 538765, RefRangeEnd = 538766, XrefRangeStart = 538765, XrefRangeEnd = 538766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat3.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float3*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(13), CachedScanResults(RefRangeStart = 203152, RefRangeEnd = 203165, XrefRangeStart = 203152, XrefRangeEnd = 203165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModifiableFloat3.NativeMethodInfoPtr_set_Value_Public_Virtual_Final_New_set_Void_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public virtual unsafe ushort Id
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat3.NativeMethodInfoPtr_get_Id_Public_Virtual_Final_New_get_UInt16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat3.NativeMethodInfoPtr_get_IsFixed_Public_Virtual_Final_New_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 745686, RefRangeEnd = 745687, XrefRangeStart = 745679, XrefRangeEnd = 745686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ModifiableFloat3 Create(
      Entity entity,
      EntityManager entityManager,
      float3 value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat3.NativeMethodInfoPtr_Create_Public_Static_ModifiableFloat3_Entity_EntityManager_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModifiableFloat3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe ModifiableFloat3 CreateFixed(float3 baseValue, float3 value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &baseValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat3.NativeMethodInfoPtr_CreateFixed_Public_Static_ModifiableFloat3_float3_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModifiableFloat3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745687, XrefRangeEnd = 745690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe float3 GetBaseValue(
      DynamicBuffer<Float3ModificationBuffer> modifications)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &modifications;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat3.NativeMethodInfoPtr_GetBaseValue_Public_Virtual_Final_New_float3_DynamicBuffer_1_Float3ModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 745693, RefRangeEnd = 745696, XrefRangeStart = 745690, XrefRangeEnd = 745693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetBaseValue(
      float3 newValue,
      DynamicBuffer<Float3ModificationBuffer> modifications)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &newValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifiableFloat3.NativeMethodInfoPtr_SetBaseValue_Public_Virtual_Final_New_Void_float3_DynamicBuffer_1_Float3ModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745696, XrefRangeEnd = 745699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Method_Private_Virtual_Final_New_Void_DynamicBuffer_1_Float3ModificationBuffer_0(
      DynamicBuffer<Float3ModificationBuffer> modifications)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &modifications;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifiableFloat3.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_DynamicBuffer_1_Float3ModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745699, XrefRangeEnd = 745727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Method_Private_Virtual_Final_New_Void_byref_float3_byref_float3_ModificationType_float3_0(
      ref float3 value,
      ref float3 baseValue,
      ModificationType modType,
      float3 modValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref baseValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &modType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifiableFloat3.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_byref_float3_byref_float3_ModificationType_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745727, XrefRangeEnd = 745744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe ModificationId ApplyModification(
      ModificationStructure modificationStructure,
      ModificationType modType,
      float3 modValue,
      int priority,
      DynamicBuffer<Float3ModificationBuffer> modifications,
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat3.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ModificationStructure_ModificationType_float3_Int32_DynamicBuffer_1_Float3ModificationBuffer_Entity_Entity_String_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745744, XrefRangeEnd = 745748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe ModificationId ApplyModification(
      ServerGameManager game,
      Entity self,
      Entity other,
      ModificationType modType,
      float3 modValue,
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat3.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ServerGameManager_Entity_Entity_ModificationType_float3_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745748, XrefRangeEnd = 745752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool ModifyModification(
      ServerGameManager game,
      Entity entity,
      ModificationId id,
      float3 modValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &game;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modValue;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat3.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ServerGameManager_Entity_ModificationId_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745752, XrefRangeEnd = 745756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe ModificationId ApplyModification(
      ClientGameManager game,
      Entity self,
      Entity other,
      ModificationType modType,
      float3 modValue,
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat3.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ClientGameManager_Entity_Entity_ModificationType_float3_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745756, XrefRangeEnd = 745760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool ModifyModification(
      ClientGameManager game,
      Entity entity,
      ModificationId id,
      float3 modValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &game;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modValue;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat3.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ClientGameManager_Entity_ModificationId_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745760, XrefRangeEnd = 745777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool ModifyModification(
      ModificationId id,
      float3 modValue,
      DynamicBuffer<Float3ModificationBuffer> modifications,
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat3.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ModificationId_float3_DynamicBuffer_1_Float3ModificationBuffer_String_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745777, XrefRangeEnd = 745794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool RemoveModification(
      ModificationId id,
      DynamicBuffer<Float3ModificationBuffer> modifications,
      string callerFilePath = null,
      int callerLineNumber = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(callerFilePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &callerLineNumber;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat3.NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_ModificationId_DynamicBuffer_1_Float3ModificationBuffer_String_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745794, XrefRangeEnd = 745811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat3.NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_EntityManager_Entity_ModificationId_String_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745811, XrefRangeEnd = 745821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe DynamicBuffer<Float3ModificationBuffer> GetOrAddModificationsBuffer(
      EntityManager entityManager,
      Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat3.NativeMethodInfoPtr_GetOrAddModificationsBuffer_Public_Virtual_Final_New_DynamicBuffer_1_Float3ModificationBuffer_EntityManager_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DynamicBuffer<Float3ModificationBuffer>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745821, XrefRangeEnd = 745823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(ModifiableFloat3 other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiableFloat3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ModifiableFloat3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ModifiableFloat3()
    {
      Il2CppClassPointerStore<ModifiableFloat3>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ModifiableFloat3));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifiableFloat3>.NativeClassPtr);
      ModifiableFloat3.NativeFieldInfoPtr__Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableFloat3>.NativeClassPtr, nameof (_Value));
      ModifiableFloat3.NativeFieldInfoPtr__Identifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableFloat3>.NativeClassPtr, nameof (_Identifier));
      ModifiableFloat3.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat3>.NativeClassPtr, 100665596);
      ModifiableFloat3.NativeMethodInfoPtr_set_Value_Public_Virtual_Final_New_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat3>.NativeClassPtr, 100665597);
      ModifiableFloat3.NativeMethodInfoPtr_get_Id_Public_Virtual_Final_New_get_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat3>.NativeClassPtr, 100665598);
      ModifiableFloat3.NativeMethodInfoPtr_get_IsFixed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat3>.NativeClassPtr, 100665599);
      ModifiableFloat3.NativeMethodInfoPtr_Create_Public_Static_ModifiableFloat3_Entity_EntityManager_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat3>.NativeClassPtr, 100665600);
      ModifiableFloat3.NativeMethodInfoPtr_CreateFixed_Public_Static_ModifiableFloat3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat3>.NativeClassPtr, 100665601);
      ModifiableFloat3.NativeMethodInfoPtr_GetBaseValue_Public_Virtual_Final_New_float3_DynamicBuffer_1_Float3ModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat3>.NativeClassPtr, 100665602);
      ModifiableFloat3.NativeMethodInfoPtr_SetBaseValue_Public_Virtual_Final_New_Void_float3_DynamicBuffer_1_Float3ModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat3>.NativeClassPtr, 100665603);
      ModifiableFloat3.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_DynamicBuffer_1_Float3ModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat3>.NativeClassPtr, 100665604);
      ModifiableFloat3.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_byref_float3_byref_float3_ModificationType_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat3>.NativeClassPtr, 100665605);
      ModifiableFloat3.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ModificationStructure_ModificationType_float3_Int32_DynamicBuffer_1_Float3ModificationBuffer_Entity_Entity_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat3>.NativeClassPtr, 100665606);
      ModifiableFloat3.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ServerGameManager_Entity_Entity_ModificationType_float3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat3>.NativeClassPtr, 100665607);
      ModifiableFloat3.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ServerGameManager_Entity_ModificationId_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat3>.NativeClassPtr, 100665608);
      ModifiableFloat3.NativeMethodInfoPtr_ApplyModification_Public_Virtual_Final_New_ModificationId_ClientGameManager_Entity_Entity_ModificationType_float3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat3>.NativeClassPtr, 100665609);
      ModifiableFloat3.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ClientGameManager_Entity_ModificationId_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat3>.NativeClassPtr, 100665610);
      ModifiableFloat3.NativeMethodInfoPtr_ModifyModification_Public_Virtual_Final_New_Boolean_ModificationId_float3_DynamicBuffer_1_Float3ModificationBuffer_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat3>.NativeClassPtr, 100665611);
      ModifiableFloat3.NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_ModificationId_DynamicBuffer_1_Float3ModificationBuffer_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat3>.NativeClassPtr, 100665612);
      ModifiableFloat3.NativeMethodInfoPtr_RemoveModification_Public_Virtual_Final_New_Boolean_EntityManager_Entity_ModificationId_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat3>.NativeClassPtr, 100665613);
      ModifiableFloat3.NativeMethodInfoPtr_GetOrAddModificationsBuffer_Public_Virtual_Final_New_DynamicBuffer_1_Float3ModificationBuffer_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat3>.NativeClassPtr, 100665614);
      ModifiableFloat3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ModifiableFloat3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiableFloat3>.NativeClassPtr, 100665615);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifiableFloat3>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
