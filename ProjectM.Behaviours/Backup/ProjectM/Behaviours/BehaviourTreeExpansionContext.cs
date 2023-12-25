// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.BehaviourTreeExpansionContext
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BehaviourTreeExpansionContext
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_JobIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Subject;
    private static readonly System.IntPtr NativeFieldInfoPtr_TreeInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr__Blackboard;
    private static readonly System.IntPtr NativeFieldInfoPtr__BlackboardBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbortedNodes;
    private static readonly System.IntPtr NativeFieldInfoPtr_RunningNodesForSubject;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBlackboardBuffer_Public_DynamicBuffer_1_BlackboardElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DynamicBuffer_1_BlackboardElement_Entity_BehaviourTreeInstance_DynamicBuffer_1_BehaviourTreeNodeInstanceElement_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAborted_Public_Void_UInt16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAborted_Public_Boolean_UInt16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteToBlackboard_Public_Void_Int32_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromBlackboard_Public_T_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteToBlackboard_Public_Void_PrivateField_1_T_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteToBlackboard_Public_Void_SharedField_1_T_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteToBlackboard_Public_Void_OptionalSharedField_1_T_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromBlackboard_Public_T_PrivateField_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromBlackboard_Public_T_SharedField_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromBlackboard_Public_T_OptionalSharedField_1_T_0;
    [FieldOffset(0)]
    public readonly int JobIndex;
    [FieldOffset(4)]
    public readonly Entity Subject;
    [FieldOffset(12)]
    public readonly BehaviourTreeInstance TreeInstance;
    [FieldOffset(24)]
    public Blackboard _Blackboard;
    [FieldOffset(32)]
    public DynamicBuffer<BlackboardElement> _BlackboardBuffer;
    [FieldOffset(48)]
    public NativeHashSet<ushort> AbortedNodes;
    [FieldOffset(64)]
    public DynamicBuffer<BehaviourTreeNodeInstanceElement> RunningNodesForSubject;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 29043, RefRangeEnd = 29047, XrefRangeStart = 29043, XrefRangeEnd = 29047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DynamicBuffer<BlackboardElement> GetBlackboardBuffer()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeExpansionContext.NativeMethodInfoPtr_GetBlackboardBuffer_Public_DynamicBuffer_1_BlackboardElement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DynamicBuffer<BlackboardElement>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1340017, RefRangeEnd = 1340020, XrefRangeStart = 1340013, XrefRangeEnd = 1340017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeExpansionContext(
      DynamicBuffer<BlackboardElement> blackboardBuffer,
      Entity subject,
      BehaviourTreeInstance treeInstance,
      DynamicBuffer<BehaviourTreeNodeInstanceElement> runningNodesForSubject,
      int jobIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &blackboardBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &subject;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &treeInstance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &runningNodesForSubject;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &jobIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeExpansionContext.NativeMethodInfoPtr__ctor_Public_Void_DynamicBuffer_1_BlackboardElement_Entity_BehaviourTreeInstance_DynamicBuffer_1_BehaviourTreeNodeInstanceElement_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1340023, RefRangeEnd = 1340026, XrefRangeStart = 1340020, XrefRangeEnd = 1340023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAborted(ushort nodeIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &nodeIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeExpansionContext.NativeMethodInfoPtr_SetAborted_Public_Void_UInt16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1340029, RefRangeEnd = 1340030, XrefRangeStart = 1340026, XrefRangeEnd = 1340029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsAborted(ushort nodeIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &nodeIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeExpansionContext.NativeMethodInfoPtr_IsAborted_Public_Boolean_UInt16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 1340030, RefRangeEnd = 1340045, XrefRangeStart = 1340030, XrefRangeEnd = 1340030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void WriteToBlackboard<T>(int registerIndex, T value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &registerIndex;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
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
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeExpansionContext.MethodInfoStoreGeneric_WriteToBlackboard_Public_Void_Int32_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(82)]
    [CachedScanResults(RefRangeStart = 1340045, RefRangeEnd = 1340127, XrefRangeStart = 1340045, XrefRangeEnd = 1340045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe T ReadFromBlackboard<T>(int registerIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &registerIndex;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeExpansionContext.MethodInfoStoreGeneric_ReadFromBlackboard_Public_T_Int32_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1340127, RefRangeEnd = 1340133, XrefRangeStart = 1340127, XrefRangeEnd = 1340127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void WriteToBlackboard<T>(PrivateField<T> register, T value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &register;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
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
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeExpansionContext.MethodInfoStoreGeneric_WriteToBlackboard_Public_Void_PrivateField_1_T_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1340127, RefRangeEnd = 1340133, XrefRangeStart = 1340127, XrefRangeEnd = 1340133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void WriteToBlackboard<T>(SharedField<T> register, T value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &register;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
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
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeExpansionContext.MethodInfoStoreGeneric_WriteToBlackboard_Public_Void_SharedField_1_T_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1340133, RefRangeEnd = 1340135, XrefRangeStart = 1340133, XrefRangeEnd = 1340133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void WriteToBlackboard<T>(OptionalSharedField<T> register, T value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &register;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
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
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeExpansionContext.MethodInfoStoreGeneric_WriteToBlackboard_Public_Void_OptionalSharedField_1_T_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(82)]
    [CachedScanResults(RefRangeStart = 1340045, RefRangeEnd = 1340127, XrefRangeStart = 1340045, XrefRangeEnd = 1340127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe T ReadFromBlackboard<T>(PrivateField<T> register)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &register;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeExpansionContext.MethodInfoStoreGeneric_ReadFromBlackboard_Public_T_PrivateField_1_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    [CallerCount(82)]
    [CachedScanResults(RefRangeStart = 1340045, RefRangeEnd = 1340127, XrefRangeStart = 1340045, XrefRangeEnd = 1340127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe T ReadFromBlackboard<T>(SharedField<T> register)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &register;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeExpansionContext.MethodInfoStoreGeneric_ReadFromBlackboard_Public_T_SharedField_1_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1340135, RefRangeEnd = 1340137, XrefRangeStart = 1340135, XrefRangeEnd = 1340135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe T ReadFromBlackboard<T>(OptionalSharedField<T> register)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &register;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeExpansionContext.MethodInfoStoreGeneric_ReadFromBlackboard_Public_T_OptionalSharedField_1_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    static BehaviourTreeExpansionContext()
    {
      Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (BehaviourTreeExpansionContext));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr);
      BehaviourTreeExpansionContext.NativeFieldInfoPtr_JobIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr, nameof (JobIndex));
      BehaviourTreeExpansionContext.NativeFieldInfoPtr_Subject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr, nameof (Subject));
      BehaviourTreeExpansionContext.NativeFieldInfoPtr_TreeInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr, nameof (TreeInstance));
      BehaviourTreeExpansionContext.NativeFieldInfoPtr__Blackboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr, nameof (_Blackboard));
      BehaviourTreeExpansionContext.NativeFieldInfoPtr__BlackboardBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr, nameof (_BlackboardBuffer));
      BehaviourTreeExpansionContext.NativeFieldInfoPtr_AbortedNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr, nameof (AbortedNodes));
      BehaviourTreeExpansionContext.NativeFieldInfoPtr_RunningNodesForSubject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr, nameof (RunningNodesForSubject));
      BehaviourTreeExpansionContext.NativeMethodInfoPtr_GetBlackboardBuffer_Public_DynamicBuffer_1_BlackboardElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr, 100665028);
      BehaviourTreeExpansionContext.NativeMethodInfoPtr__ctor_Public_Void_DynamicBuffer_1_BlackboardElement_Entity_BehaviourTreeInstance_DynamicBuffer_1_BehaviourTreeNodeInstanceElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr, 100665029);
      BehaviourTreeExpansionContext.NativeMethodInfoPtr_SetAborted_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr, 100665030);
      BehaviourTreeExpansionContext.NativeMethodInfoPtr_IsAborted_Public_Boolean_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr, 100665031);
      BehaviourTreeExpansionContext.NativeMethodInfoPtr_WriteToBlackboard_Public_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr, 100665032);
      BehaviourTreeExpansionContext.NativeMethodInfoPtr_ReadFromBlackboard_Public_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr, 100665033);
      BehaviourTreeExpansionContext.NativeMethodInfoPtr_WriteToBlackboard_Public_Void_PrivateField_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr, 100665034);
      BehaviourTreeExpansionContext.NativeMethodInfoPtr_WriteToBlackboard_Public_Void_SharedField_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr, 100665035);
      BehaviourTreeExpansionContext.NativeMethodInfoPtr_WriteToBlackboard_Public_Void_OptionalSharedField_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr, 100665036);
      BehaviourTreeExpansionContext.NativeMethodInfoPtr_ReadFromBlackboard_Public_T_PrivateField_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr, 100665037);
      BehaviourTreeExpansionContext.NativeMethodInfoPtr_ReadFromBlackboard_Public_T_SharedField_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr, 100665038);
      BehaviourTreeExpansionContext.NativeMethodInfoPtr_ReadFromBlackboard_Public_T_OptionalSharedField_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr, 100665039);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr, (System.IntPtr) ref this));
    }

    private sealed class MethodInfoStoreGeneric_WriteToBlackboard_Public_Void_Int32_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BehaviourTreeExpansionContext.NativeMethodInfoPtr_WriteToBlackboard_Public_Void_Int32_T_0, Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ReadFromBlackboard_Public_T_Int32_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BehaviourTreeExpansionContext.NativeMethodInfoPtr_ReadFromBlackboard_Public_T_Int32_0, Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_WriteToBlackboard_Public_Void_PrivateField_1_T_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BehaviourTreeExpansionContext.NativeMethodInfoPtr_WriteToBlackboard_Public_Void_PrivateField_1_T_T_0, Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_WriteToBlackboard_Public_Void_SharedField_1_T_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BehaviourTreeExpansionContext.NativeMethodInfoPtr_WriteToBlackboard_Public_Void_SharedField_1_T_T_0, Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_WriteToBlackboard_Public_Void_OptionalSharedField_1_T_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BehaviourTreeExpansionContext.NativeMethodInfoPtr_WriteToBlackboard_Public_Void_OptionalSharedField_1_T_T_0, Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ReadFromBlackboard_Public_T_PrivateField_1_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BehaviourTreeExpansionContext.NativeMethodInfoPtr_ReadFromBlackboard_Public_T_PrivateField_1_T_0, Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ReadFromBlackboard_Public_T_SharedField_1_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BehaviourTreeExpansionContext.NativeMethodInfoPtr_ReadFromBlackboard_Public_T_SharedField_1_T_0, Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ReadFromBlackboard_Public_T_OptionalSharedField_1_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BehaviourTreeExpansionContext.NativeMethodInfoPtr_ReadFromBlackboard_Public_T_OptionalSharedField_1_T_0, Il2CppClassPointerStore<BehaviourTreeExpansionContext>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
