// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.BehaviourTreePartials
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BehaviourTreePartials
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Expand_Public_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_NodeDataPtr_Boolean_byref_BehaviourTreeResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Abort_Public_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_NodeDataPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GeneratedExpansion_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_NodeDataPtr_Boolean_byref_BehaviourTreeResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GeneratedAbortion_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_NodeDataPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTriedToTickNonTickableNodeException_Private_InvalidOperationException_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1342337, RefRangeEnd = 1342338, XrefRangeStart = 1342336, XrefRangeEnd = 1342337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Expand(
      ref BehaviourTreeBlob treeBlob,
      ref BehaviourTreeNode node,
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData,
      NodeDataPtr nodeDataPtr,
      bool shouldTick,
      ref BehaviourTreeResult result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) ref treeBlob;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeDataPtr;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &shouldTick;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreePartials.NativeMethodInfoPtr_Expand_Public_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_NodeDataPtr_Boolean_byref_BehaviourTreeResult_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1342339, RefRangeEnd = 1342342, XrefRangeStart = 1342338, XrefRangeEnd = 1342339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Abort(
      ref BehaviourTreeBlob treeBlob,
      ref BehaviourTreeNode node,
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData,
      NodeDataPtr nodeDataPtr)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref treeBlob;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeDataPtr;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreePartials.NativeMethodInfoPtr_Abort_Public_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_NodeDataPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1342507, RefRangeEnd = 1342508, XrefRangeStart = 1342342, XrefRangeEnd = 1342507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GeneratedExpansion(
      ref BehaviourTreeBlob treeBlob,
      ref BehaviourTreeNode node,
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData,
      NodeDataPtr nodeDataPtr,
      bool shouldTick,
      ref BehaviourTreeResult result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) ref treeBlob;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeDataPtr;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &shouldTick;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreePartials.NativeMethodInfoPtr_GeneratedExpansion_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_NodeDataPtr_Boolean_byref_BehaviourTreeResult_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1342523, RefRangeEnd = 1342524, XrefRangeStart = 1342508, XrefRangeEnd = 1342523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GeneratedAbortion(
      ref BehaviourTreeBlob treeBlob,
      ref BehaviourTreeNode node,
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData,
      NodeDataPtr nodeDataPtr)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref treeBlob;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeDataPtr;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreePartials.NativeMethodInfoPtr_GeneratedAbortion_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_NodeDataPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342524, XrefRangeEnd = 1342538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppSystem.InvalidOperationException GetTriedToTickNonTickableNodeException(
      ref BehaviourTreeNode node,
      ref BehaviourTreeExpansionContext context)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref node;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreePartials.NativeMethodInfoPtr_GetTriedToTickNonTickableNodeException_Private_InvalidOperationException_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.InvalidOperationException) null : new Il2CppSystem.InvalidOperationException(pointer);
    }

    static BehaviourTreePartials()
    {
      Il2CppClassPointerStore<BehaviourTreePartials>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (BehaviourTreePartials));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreePartials>.NativeClassPtr);
      BehaviourTreePartials.NativeMethodInfoPtr_Expand_Public_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_NodeDataPtr_Boolean_byref_BehaviourTreeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreePartials>.NativeClassPtr, 100665242);
      BehaviourTreePartials.NativeMethodInfoPtr_Abort_Public_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_NodeDataPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreePartials>.NativeClassPtr, 100665243);
      BehaviourTreePartials.NativeMethodInfoPtr_GeneratedExpansion_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_NodeDataPtr_Boolean_byref_BehaviourTreeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreePartials>.NativeClassPtr, 100665244);
      BehaviourTreePartials.NativeMethodInfoPtr_GeneratedAbortion_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_NodeDataPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreePartials>.NativeClassPtr, 100665245);
      BehaviourTreePartials.NativeMethodInfoPtr_GetTriedToTickNonTickableNodeException_Private_InvalidOperationException_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreePartials>.NativeClassPtr, 100665246);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreePartials>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct BehaviourTreeProfilingParams
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GeneratedInitialize_Private_Void_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Initialize()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreePartials.BehaviourTreeProfilingParams.NativeMethodInfoPtr_Initialize_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void GeneratedInitialize()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreePartials.BehaviourTreeProfilingParams.NativeMethodInfoPtr_GeneratedInitialize_Private_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static BehaviourTreeProfilingParams()
      {
        Il2CppClassPointerStore<BehaviourTreePartials.BehaviourTreeProfilingParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreePartials>.NativeClassPtr, nameof (BehaviourTreeProfilingParams));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreePartials.BehaviourTreeProfilingParams>.NativeClassPtr);
        BehaviourTreePartials.BehaviourTreeProfilingParams.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreePartials.BehaviourTreeProfilingParams>.NativeClassPtr, 100665247);
        BehaviourTreePartials.BehaviourTreeProfilingParams.NativeMethodInfoPtr_GeneratedInitialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreePartials.BehaviourTreeProfilingParams>.NativeClassPtr, 100665248);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreePartials.BehaviourTreeProfilingParams>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
