// Decompiled with JetBrains decompiler
// Type: ProjectM.SequenceStateExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using ProjectM.Scripting;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class SequenceStateExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBlackboardInput_Public_Static_Void_SequenceState_ClientGameManager_byref_FixedString64_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBlackboardInput_Public_Static_Void_SequenceState_EntityManager_byref_FixedString64_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBlackboardDefaultValue_Public_Static_Void_SequenceState_DynamicBuffer_1_DefaultBlackboardValueElement_byref_FixedString64_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBlackboardDefaultValue_Public_Static_Void_SequenceState_DynamicBuffer_1_DefaultBlackboardValueElement_byref_FixedString64_SocketDefaultValue_BlackboardRegisterType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBlackboardInput_Public_Static_Void_SequenceState_byref_BlobArray_1_SequenceInputElement_DynamicBuffer_1_BlackboardElement_byref_FixedString64_T_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 748122, RefRangeEnd = 748123, XrefRangeStart = 748100, XrefRangeEnd = 748122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetBlackboardInput<T>(
      this SequenceState sequenceInstance,
      ClientGameManager game,
      [In] ref FixedString64 blackboardName,
      T value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &sequenceInstance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &game;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref blackboardName;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) value;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceStateExtensions.MethodInfoStoreGeneric_SetBlackboardInput_Public_Static_Void_SequenceState_ClientGameManager_byref_FixedString64_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 748140, RefRangeEnd = 748142, XrefRangeStart = 748123, XrefRangeEnd = 748140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetBlackboardInput<T>(
      this SequenceState sequenceInstance,
      EntityManager entityManager,
      [In] ref FixedString64 blackboardName,
      T value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &sequenceInstance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref blackboardName;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) value;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceStateExtensions.MethodInfoStoreGeneric_SetBlackboardInput_Public_Static_Void_SequenceState_EntityManager_byref_FixedString64_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 748145, RefRangeEnd = 748147, XrefRangeStart = 748142, XrefRangeEnd = 748145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetBlackboardDefaultValue<T>(
      this SequenceState sequenceInstance,
      DynamicBuffer<DefaultBlackboardValueElement> defaultValues,
      [In] ref FixedString64 blackboardName,
      T value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &sequenceInstance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultValues;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref blackboardName;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) value;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceStateExtensions.MethodInfoStoreGeneric_SetBlackboardDefaultValue_Public_Static_Void_SequenceState_DynamicBuffer_1_DefaultBlackboardValueElement_byref_FixedString64_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 748150, RefRangeEnd = 748162, XrefRangeStart = 748147, XrefRangeEnd = 748150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetBlackboardDefaultValue(
      this SequenceState sequenceInstance,
      DynamicBuffer<DefaultBlackboardValueElement> defaultValues,
      [In] ref FixedString64 blackboardName,
      SocketDefaultValue defaultValue,
      BlackboardRegisterType registerType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &sequenceInstance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultValues;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref blackboardName;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &registerType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceStateExtensions.NativeMethodInfoPtr_SetBlackboardDefaultValue_Public_Static_Void_SequenceState_DynamicBuffer_1_DefaultBlackboardValueElement_byref_FixedString64_SocketDefaultValue_BlackboardRegisterType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748162, XrefRangeEnd = 748177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetBlackboardInput<T>(
      this SequenceState sequenceInstance,
      ref BlobArray<SequenceInputElement> blackboardInputs,
      DynamicBuffer<BlackboardElement> blackBoardBuffer,
      [In] ref FixedString64 blackboardName,
      T value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &sequenceInstance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref blackboardInputs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &blackBoardBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref blackboardName;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) value;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceStateExtensions.MethodInfoStoreGeneric_SetBlackboardInput_Public_Static_Void_SequenceState_byref_BlobArray_1_SequenceInputElement_DynamicBuffer_1_BlackboardElement_byref_FixedString64_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SequenceStateExtensions()
    {
      Il2CppClassPointerStore<SequenceStateExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SequenceStateExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceStateExtensions>.NativeClassPtr);
      SequenceStateExtensions.NativeMethodInfoPtr_SetBlackboardInput_Public_Static_Void_SequenceState_ClientGameManager_byref_FixedString64_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceStateExtensions>.NativeClassPtr, 100665883);
      SequenceStateExtensions.NativeMethodInfoPtr_SetBlackboardInput_Public_Static_Void_SequenceState_EntityManager_byref_FixedString64_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceStateExtensions>.NativeClassPtr, 100665884);
      SequenceStateExtensions.NativeMethodInfoPtr_SetBlackboardDefaultValue_Public_Static_Void_SequenceState_DynamicBuffer_1_DefaultBlackboardValueElement_byref_FixedString64_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceStateExtensions>.NativeClassPtr, 100665885);
      SequenceStateExtensions.NativeMethodInfoPtr_SetBlackboardDefaultValue_Public_Static_Void_SequenceState_DynamicBuffer_1_DefaultBlackboardValueElement_byref_FixedString64_SocketDefaultValue_BlackboardRegisterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceStateExtensions>.NativeClassPtr, 100665886);
      SequenceStateExtensions.NativeMethodInfoPtr_SetBlackboardInput_Public_Static_Void_SequenceState_byref_BlobArray_1_SequenceInputElement_DynamicBuffer_1_BlackboardElement_byref_FixedString64_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceStateExtensions>.NativeClassPtr, 100665887);
    }

    public SequenceStateExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    private sealed class MethodInfoStoreGeneric_SetBlackboardInput_Public_Static_Void_SequenceState_ClientGameManager_byref_FixedString64_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceStateExtensions.NativeMethodInfoPtr_SetBlackboardInput_Public_Static_Void_SequenceState_ClientGameManager_byref_FixedString64_T_0, Il2CppClassPointerStore<SequenceStateExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_SetBlackboardInput_Public_Static_Void_SequenceState_EntityManager_byref_FixedString64_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceStateExtensions.NativeMethodInfoPtr_SetBlackboardInput_Public_Static_Void_SequenceState_EntityManager_byref_FixedString64_T_0, Il2CppClassPointerStore<SequenceStateExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_SetBlackboardDefaultValue_Public_Static_Void_SequenceState_DynamicBuffer_1_DefaultBlackboardValueElement_byref_FixedString64_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceStateExtensions.NativeMethodInfoPtr_SetBlackboardDefaultValue_Public_Static_Void_SequenceState_DynamicBuffer_1_DefaultBlackboardValueElement_byref_FixedString64_T_0, Il2CppClassPointerStore<SequenceStateExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_SetBlackboardInput_Public_Static_Void_SequenceState_byref_BlobArray_1_SequenceInputElement_DynamicBuffer_1_BlackboardElement_byref_FixedString64_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceStateExtensions.NativeMethodInfoPtr_SetBlackboardInput_Public_Static_Void_SequenceState_byref_BlobArray_1_SequenceInputElement_DynamicBuffer_1_BlackboardElement_byref_FixedString64_T_0, Il2CppClassPointerStore<SequenceStateExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
