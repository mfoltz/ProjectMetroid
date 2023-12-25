// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.Debugging.SequenceDebugUtility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Text;
using Stunlock.Sequencer;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Sequencer.Debugging
{
  public static class SequenceDebugUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPrintableSequenceState_Public_Static_String_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AppendStateRecursive_Private_Static_Void_EntityManager_Entity_byref_SequenceBlob_NativeArray_1_EventStateElement_Blackboard_Int32_Int32_StringBuilder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AppendBlackboardData_Private_Static_Void_EntityManager_Entity_Blackboard_SequenceAsset_StringBuilder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBlackboardEntryString_Private_Static_String_Blackboard_BlackboardRegisterType_Int32_String_String_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1108823, RefRangeEnd = 1108825, XrefRangeStart = 1108789, XrefRangeEnd = 1108823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetPrintableSequenceState(
      EntityManager entityManager,
      Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SequenceDebugUtility.NativeMethodInfoPtr_GetPrintableSequenceState_Public_Static_String_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1108967, RefRangeEnd = 1108969, XrefRangeStart = 1108825, XrefRangeEnd = 1108967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AppendStateRecursive(
      EntityManager entityManager,
      Entity entity,
      ref SequenceBlob sequenceBlob,
      NativeArray<EventStateElement> eventStates,
      Blackboard blackboard,
      int nodeIndex,
      int indentation,
      StringBuilder sb)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceBlob;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &eventStates;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &blackboard;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &indentation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceDebugUtility.NativeMethodInfoPtr_AppendStateRecursive_Private_Static_Void_EntityManager_Entity_byref_SequenceBlob_NativeArray_1_EventStateElement_Blackboard_Int32_Int32_StringBuilder_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1109011, RefRangeEnd = 1109012, XrefRangeStart = 1108969, XrefRangeEnd = 1109011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AppendBlackboardData(
      EntityManager entityManager,
      Entity entity,
      Blackboard blackboard,
      SequenceAsset sequenceAsset,
      StringBuilder sb)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &blackboard;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sequenceAsset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceDebugUtility.NativeMethodInfoPtr_AppendBlackboardData_Private_Static_Void_EntityManager_Entity_Blackboard_SequenceAsset_StringBuilder_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1109131, RefRangeEnd = 1109133, XrefRangeStart = 1109012, XrefRangeEnd = 1109131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetBlackboardEntryString(
      Blackboard blackboard,
      BlackboardRegisterType registerType,
      int registerIndex,
      string groupName,
      string name)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &blackboard;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &registerType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &registerIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(groupName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SequenceDebugUtility.NativeMethodInfoPtr_GetBlackboardEntryString_Private_Static_String_Blackboard_BlackboardRegisterType_Int32_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static SequenceDebugUtility()
    {
      Il2CppClassPointerStore<SequenceDebugUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer.Debugging", nameof (SequenceDebugUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceDebugUtility>.NativeClassPtr);
      SequenceDebugUtility.NativeMethodInfoPtr_GetPrintableSequenceState_Public_Static_String_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceDebugUtility>.NativeClassPtr, 100687805);
      SequenceDebugUtility.NativeMethodInfoPtr_AppendStateRecursive_Private_Static_Void_EntityManager_Entity_byref_SequenceBlob_NativeArray_1_EventStateElement_Blackboard_Int32_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceDebugUtility>.NativeClassPtr, 100687806);
      SequenceDebugUtility.NativeMethodInfoPtr_AppendBlackboardData_Private_Static_Void_EntityManager_Entity_Blackboard_SequenceAsset_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceDebugUtility>.NativeClassPtr, 100687807);
      SequenceDebugUtility.NativeMethodInfoPtr_GetBlackboardEntryString_Private_Static_String_Blackboard_BlackboardRegisterType_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceDebugUtility>.NativeClassPtr, 100687808);
    }

    public SequenceDebugUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
