// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.BehaviourTreeSystemUtility
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Entities;

#nullable disable
namespace ProjectM.Behaviours
{
  public static class BehaviourTreeSystemUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_AbortParentNodes_Public_Static_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AbortNode_Public_Static_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ExternalTransition_Public_Static_Void_byref_BehaviourTreeBlob_GenericEnemyState_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_byref_DynamicBuffer_1_BehaviourTreeNodeInstanceElement_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1342545, RefRangeEnd = 1342547, XrefRangeStart = 1342538, XrefRangeEnd = 1342545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AbortParentNodes(
      ref BehaviourTreeBlob treeBlob,
      ref BehaviourTreeNode node,
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref treeBlob;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystemUtility.NativeMethodInfoPtr_AbortParentNodes_Public_Static_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1342550, RefRangeEnd = 1342552, XrefRangeStart = 1342547, XrefRangeEnd = 1342550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AbortNode(
      ref BehaviourTreeBlob treeBlob,
      ref BehaviourTreeNode node,
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref treeBlob;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystemUtility.NativeMethodInfoPtr_AbortNode_Public_Static_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1342573, RefRangeEnd = 1342574, XrefRangeStart = 1342552, XrefRangeEnd = 1342573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ExternalTransition(
      ref BehaviourTreeBlob treeBlob,
      GenericEnemyState state,
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData,
      ref DynamicBuffer<BehaviourTreeNodeInstanceElement> runningNodes)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref treeBlob;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &state;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref runningNodes;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystemUtility.NativeMethodInfoPtr_ExternalTransition_Public_Static_Void_byref_BehaviourTreeBlob_GenericEnemyState_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_byref_DynamicBuffer_1_BehaviourTreeNodeInstanceElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BehaviourTreeSystemUtility()
    {
      Il2CppClassPointerStore<BehaviourTreeSystemUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (BehaviourTreeSystemUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeSystemUtility>.NativeClassPtr);
      BehaviourTreeSystemUtility.NativeMethodInfoPtr_AbortParentNodes_Public_Static_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystemUtility>.NativeClassPtr, 100665249);
      BehaviourTreeSystemUtility.NativeMethodInfoPtr_AbortNode_Public_Static_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystemUtility>.NativeClassPtr, 100665250);
      BehaviourTreeSystemUtility.NativeMethodInfoPtr_ExternalTransition_Public_Static_Void_byref_BehaviourTreeBlob_GenericEnemyState_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_byref_DynamicBuffer_1_BehaviourTreeNodeInstanceElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystemUtility>.NativeClassPtr, 100665251);
    }

    public BehaviourTreeSystemUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
