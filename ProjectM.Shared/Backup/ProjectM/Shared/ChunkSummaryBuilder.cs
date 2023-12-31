// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.ChunkSummaryBuilder
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

#nullable disable
namespace ProjectM.Shared
{
  public class ChunkSummaryBuilder : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__NodeCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr__ParentStack;
    private static readonly System.IntPtr NativeFieldInfoPtr__ParentObjects;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_RootNodes;
    private static readonly System.IntPtr NativeFieldInfoPtr_RawTreeNodes;
    private static readonly System.IntPtr NativeFieldInfoPtr__Remappings;
    private static readonly System.IntPtr NativeMethodInfoPtr_StartChild_Public_TreeNodeId_NodeType_Object_Single_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndChild_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessChild_Public_Void_Object_Int32_Single_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddResourceProvider_Private_Void_IChunkSummaryDataSource_Object_String_Single_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AdjustForRemapping_Public_TRemapping_PrefabGUID_TRemapping_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterRemapping_Public_Void_PrefabGUID_TRemapping_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessChunk_Public_Void_Scene_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetChildSummaryType_Public_Void_ChildSummaryType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessChildGroup_Public_ChildGroupBuilder_Object_ChildSummaryType_Single_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddProvidedResouce_Public_Void_Object_Single_Single_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 803073, RefRangeEnd = 803076, XrefRangeStart = 803054, XrefRangeEnd = 803073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChunkSummaryBuilder.TreeNodeId StartChild(
      ChunkSummaryBuilder.NodeType nodeType,
      Il2CppSystem.Object nodeIdentifier,
      float resourceMultiplier,
      int level)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &nodeType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) nodeIdentifier);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &resourceMultiplier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &level;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkSummaryBuilder.NativeMethodInfoPtr_StartChild_Public_TreeNodeId_NodeType_Object_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ChunkSummaryBuilder.TreeNodeId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 803081, RefRangeEnd = 803082, XrefRangeStart = 803076, XrefRangeEnd = 803081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EndChild()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkSummaryBuilder.NativeMethodInfoPtr_EndChild_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkSummaryBuilder.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 803101, RefRangeEnd = 803106, XrefRangeStart = 803082, XrefRangeEnd = 803101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessChild(UnityEngine.Object obj, int quantity, float resourceMultiplier, int level = 0)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &quantity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &resourceMultiplier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &level;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkSummaryBuilder.NativeMethodInfoPtr_ProcessChild_Public_Void_Object_Int32_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 803123, RefRangeEnd = 803124, XrefRangeStart = 803106, XrefRangeEnd = 803123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddResourceProvider(
      IChunkSummaryDataSource dataSource,
      UnityEngine.Object obj,
      string name,
      float resourceMultiplier,
      int level)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dataSource);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &resourceMultiplier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &level;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkSummaryBuilder.NativeMethodInfoPtr_AddResourceProvider_Private_Void_IChunkSummaryDataSource_Object_String_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 803132, RefRangeEnd = 803136, XrefRangeStart = 803124, XrefRangeEnd = 803132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TRemapping AdjustForRemapping<TRemapping>(PrefabGUID key, TRemapping original) where TRemapping : UnityEngine.Object
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &key;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TRemapping& local1;
      if (!typeof (TRemapping).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TRemapping> local2 = (object) original;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TRemapping&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TRemapping&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref original;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(ChunkSummaryBuilder.MethodInfoStoreGeneric_AdjustForRemapping_Public_TRemapping_PrefabGUID_TRemapping_0<TRemapping>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<TRemapping>(objectPointer, false, true);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803136, XrefRangeEnd = 803140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterRemapping<TRemapping>(PrefabGUID from, TRemapping to) where TRemapping : UnityEngine.Object
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &from;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TRemapping& local1;
      if (!typeof (TRemapping).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TRemapping> local2 = (object) to;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TRemapping&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TRemapping&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref to;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkSummaryBuilder.MethodInfoStoreGeneric_RegisterRemapping_Public_Void_PrefabGUID_TRemapping_0<TRemapping>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803140, XrefRangeEnd = 803217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessChunk(Scene chunkScene)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &chunkScene;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkSummaryBuilder.NativeMethodInfoPtr_ProcessChunk_Public_Void_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void SetChildSummaryType(ChunkSummaryBuilder.ChildSummaryType summaryType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &summaryType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkSummaryBuilder.NativeMethodInfoPtr_SetChildSummaryType_Public_Void_ChildSummaryType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803217, XrefRangeEnd = 803219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChunkSummaryBuilder.ChildGroupBuilder ProcessChildGroup(
      Il2CppSystem.Object groupIdentifier,
      ChunkSummaryBuilder.ChildSummaryType yieldType,
      float resourceMultiplier = 1f,
      int level = 0)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) groupIdentifier);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &yieldType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &resourceMultiplier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &level;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ChunkSummaryBuilder.NativeMethodInfoPtr_ProcessChildGroup_Public_ChildGroupBuilder_Object_ChildSummaryType_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new ChunkSummaryBuilder.ChildGroupBuilder(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803219, XrefRangeEnd = 803258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddProvidedResouce(
      UnityEngine.Object resource,
      float bestAmount,
      float resourceMultiplier = 1f,
      int level = 0)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) resource);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bestAmount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &resourceMultiplier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &level;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkSummaryBuilder.NativeMethodInfoPtr_AddProvidedResouce_Public_Void_Object_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803258, XrefRangeEnd = 803294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChunkSummaryBuilder()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkSummaryBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ChunkSummaryBuilder()
    {
      Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (ChunkSummaryBuilder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr);
      ChunkSummaryBuilder.NativeFieldInfoPtr__NodeCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr, nameof (_NodeCounter));
      ChunkSummaryBuilder.NativeFieldInfoPtr__ParentStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr, nameof (_ParentStack));
      ChunkSummaryBuilder.NativeFieldInfoPtr__ParentObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr, nameof (_ParentObjects));
      ChunkSummaryBuilder.NativeFieldInfoPtr__CurrentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr, nameof (_CurrentNode));
      ChunkSummaryBuilder.NativeFieldInfoPtr_RootNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr, nameof (RootNodes));
      ChunkSummaryBuilder.NativeFieldInfoPtr_RawTreeNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr, nameof (RawTreeNodes));
      ChunkSummaryBuilder.NativeFieldInfoPtr__Remappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr, nameof (_Remappings));
      ChunkSummaryBuilder.NativeMethodInfoPtr_StartChild_Public_TreeNodeId_NodeType_Object_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr, 100670789);
      ChunkSummaryBuilder.NativeMethodInfoPtr_EndChild_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr, 100670790);
      ChunkSummaryBuilder.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr, 100670791);
      ChunkSummaryBuilder.NativeMethodInfoPtr_ProcessChild_Public_Void_Object_Int32_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr, 100670792);
      ChunkSummaryBuilder.NativeMethodInfoPtr_AddResourceProvider_Private_Void_IChunkSummaryDataSource_Object_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr, 100670793);
      ChunkSummaryBuilder.NativeMethodInfoPtr_AdjustForRemapping_Public_TRemapping_PrefabGUID_TRemapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr, 100670794);
      ChunkSummaryBuilder.NativeMethodInfoPtr_RegisterRemapping_Public_Void_PrefabGUID_TRemapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr, 100670795);
      ChunkSummaryBuilder.NativeMethodInfoPtr_ProcessChunk_Public_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr, 100670796);
      ChunkSummaryBuilder.NativeMethodInfoPtr_SetChildSummaryType_Public_Void_ChildSummaryType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr, 100670797);
      ChunkSummaryBuilder.NativeMethodInfoPtr_ProcessChildGroup_Public_ChildGroupBuilder_Object_ChildSummaryType_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr, 100670798);
      ChunkSummaryBuilder.NativeMethodInfoPtr_AddProvidedResouce_Public_Void_Object_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr, 100670799);
      ChunkSummaryBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr, 100670800);
    }

    public ChunkSummaryBuilder(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int _NodeCounter
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.NativeFieldInfoPtr__NodeCounter));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.NativeFieldInfoPtr__NodeCounter)) = value;
      }
    }

    public unsafe Stack<ChunkSummaryBuilder.TreeNodeData> _ParentStack
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.NativeFieldInfoPtr__ParentStack));
        return pointer == System.IntPtr.Zero ? (Stack<ChunkSummaryBuilder.TreeNodeData>) null : new Stack<ChunkSummaryBuilder.TreeNodeData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.NativeFieldInfoPtr__ParentStack), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HashSet<IChunkSummaryDataSource> _ParentObjects
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.NativeFieldInfoPtr__ParentObjects));
        return pointer == System.IntPtr.Zero ? (HashSet<IChunkSummaryDataSource>) null : new HashSet<IChunkSummaryDataSource>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.NativeFieldInfoPtr__ParentObjects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ChunkSummaryBuilder.TreeNodeData _CurrentNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.NativeFieldInfoPtr__CurrentNode));
        return pointer == System.IntPtr.Zero ? (ChunkSummaryBuilder.TreeNodeData) null : new ChunkSummaryBuilder.TreeNodeData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.NativeFieldInfoPtr__CurrentNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ChunkSummaryBuilder.TreeNodeId> RootNodes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.NativeFieldInfoPtr_RootNodes));
        return pointer == System.IntPtr.Zero ? (List<ChunkSummaryBuilder.TreeNodeId>) null : new List<ChunkSummaryBuilder.TreeNodeId>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.NativeFieldInfoPtr_RootNodes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<ChunkSummaryBuilder.TreeNodeId, ChunkSummaryBuilder.TreeNodeData> RawTreeNodes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.NativeFieldInfoPtr_RawTreeNodes));
        return pointer == System.IntPtr.Zero ? (Dictionary<ChunkSummaryBuilder.TreeNodeId, ChunkSummaryBuilder.TreeNodeData>) null : new Dictionary<ChunkSummaryBuilder.TreeNodeId, ChunkSummaryBuilder.TreeNodeData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.NativeFieldInfoPtr_RawTreeNodes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<PrefabGUID, UnityEngine.Object> _Remappings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.NativeFieldInfoPtr__Remappings));
        return pointer == System.IntPtr.Zero ? (Dictionary<PrefabGUID, UnityEngine.Object>) null : new Dictionary<PrefabGUID, UnityEngine.Object>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.NativeFieldInfoPtr__Remappings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct TreeNodeId
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Id;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TreeNodeId_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      [FieldOffset(0)]
      public int Id;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803036, XrefRangeEnd = 803037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(ChunkSummaryBuilder.TreeNodeId other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkSummaryBuilder.TreeNodeId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TreeNodeId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803037, XrefRangeEnd = 803040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkSummaryBuilder.TreeNodeId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(409)]
      [CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkSummaryBuilder.TreeNodeId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static TreeNodeId()
      {
        Il2CppClassPointerStore<ChunkSummaryBuilder.TreeNodeId>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr, nameof (TreeNodeId));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkSummaryBuilder.TreeNodeId>.NativeClassPtr);
        ChunkSummaryBuilder.TreeNodeId.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkSummaryBuilder.TreeNodeId>.NativeClassPtr, nameof (Id));
        ChunkSummaryBuilder.TreeNodeId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TreeNodeId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkSummaryBuilder.TreeNodeId>.NativeClassPtr, 100670801);
        ChunkSummaryBuilder.TreeNodeId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkSummaryBuilder.TreeNodeId>.NativeClassPtr, 100670802);
        ChunkSummaryBuilder.TreeNodeId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkSummaryBuilder.TreeNodeId>.NativeClassPtr, 100670803);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkSummaryBuilder.TreeNodeId>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public enum NodeType
    {
      ResourceProvider,
      NodeGroup,
      ResourceNode,
    }

    public class TreeNodeData : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TreeNodeId;
      private static readonly System.IntPtr NativeFieldInfoPtr_ParentTreeNodeId;
      private static readonly System.IntPtr NativeFieldInfoPtr_NodeIdentifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_NodeType;
      private static readonly System.IntPtr NativeFieldInfoPtr_ResourceData;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChildSummaryType;
      private static readonly System.IntPtr NativeFieldInfoPtr_ResourceMultiplier;
      private static readonly System.IntPtr NativeFieldInfoPtr_Level;
      private static readonly System.IntPtr NativeFieldInfoPtr_Children;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 803048, RefRangeEnd = 803049, XrefRangeStart = 803040, XrefRangeEnd = 803048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TreeNodeData()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkSummaryBuilder.TreeNodeData>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkSummaryBuilder.TreeNodeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TreeNodeData()
      {
        Il2CppClassPointerStore<ChunkSummaryBuilder.TreeNodeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr, nameof (TreeNodeData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkSummaryBuilder.TreeNodeData>.NativeClassPtr);
        ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_TreeNodeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkSummaryBuilder.TreeNodeData>.NativeClassPtr, nameof (TreeNodeId));
        ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_ParentTreeNodeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkSummaryBuilder.TreeNodeData>.NativeClassPtr, nameof (ParentTreeNodeId));
        ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_NodeIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkSummaryBuilder.TreeNodeData>.NativeClassPtr, nameof (NodeIdentifier));
        ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_NodeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkSummaryBuilder.TreeNodeData>.NativeClassPtr, nameof (NodeType));
        ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_ResourceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkSummaryBuilder.TreeNodeData>.NativeClassPtr, nameof (ResourceData));
        ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_ChildSummaryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkSummaryBuilder.TreeNodeData>.NativeClassPtr, nameof (ChildSummaryType));
        ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_ResourceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkSummaryBuilder.TreeNodeData>.NativeClassPtr, nameof (ResourceMultiplier));
        ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkSummaryBuilder.TreeNodeData>.NativeClassPtr, nameof (Level));
        ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_Children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkSummaryBuilder.TreeNodeData>.NativeClassPtr, nameof (Children));
        ChunkSummaryBuilder.TreeNodeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkSummaryBuilder.TreeNodeData>.NativeClassPtr, 100670804);
      }

      public TreeNodeData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe ChunkSummaryBuilder.TreeNodeId TreeNodeId
      {
        get
        {
          return *(ChunkSummaryBuilder.TreeNodeId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_TreeNodeId));
        }
        [param: In] set
        {
          *(ChunkSummaryBuilder.TreeNodeId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_TreeNodeId)) = value;
        }
      }

      public unsafe Nullable_Unboxed<ChunkSummaryBuilder.TreeNodeId> ParentTreeNodeId
      {
        get
        {
          return *(Nullable_Unboxed<ChunkSummaryBuilder.TreeNodeId>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_ParentTreeNodeId));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_ParentTreeNodeId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<ChunkSummaryBuilder.TreeNodeId>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Il2CppSystem.Object NodeIdentifier
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_NodeIdentifier));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_NodeIdentifier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ChunkSummaryBuilder.NodeType NodeType
      {
        get
        {
          return *(ChunkSummaryBuilder.NodeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_NodeType));
        }
        [param: In] set
        {
          *(ChunkSummaryBuilder.NodeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_NodeType)) = value;
        }
      }

      public ChunkSummaryBuilder.ResourceData ResourceData
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_ResourceData);
          return new ChunkSummaryBuilder.ResourceData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkSummaryBuilder.ResourceData>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_ResourceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ChunkSummaryBuilder.ResourceData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ChunkSummaryBuilder.ChildSummaryType ChildSummaryType
      {
        get
        {
          return *(ChunkSummaryBuilder.ChildSummaryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_ChildSummaryType));
        }
        [param: In] set
        {
          *(ChunkSummaryBuilder.ChildSummaryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_ChildSummaryType)) = value;
        }
      }

      public unsafe float ResourceMultiplier
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_ResourceMultiplier));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_ResourceMultiplier)) = value;
        }
      }

      public unsafe int Level
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_Level));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_Level)) = value;
        }
      }

      public unsafe List<ChunkSummaryBuilder.TreeNodeId> Children
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_Children));
          return pointer == System.IntPtr.Zero ? (List<ChunkSummaryBuilder.TreeNodeId>) null : new List<ChunkSummaryBuilder.TreeNodeId>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.TreeNodeData.NativeFieldInfoPtr_Children), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public sealed class ResourceData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_BestAmount;
      private static readonly System.IntPtr NativeFieldInfoPtr_ResourceObject;

      static ResourceData()
      {
        Il2CppClassPointerStore<ChunkSummaryBuilder.ResourceData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr, nameof (ResourceData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkSummaryBuilder.ResourceData>.NativeClassPtr);
        ChunkSummaryBuilder.ResourceData.NativeFieldInfoPtr_BestAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkSummaryBuilder.ResourceData>.NativeClassPtr, nameof (BestAmount));
        ChunkSummaryBuilder.ResourceData.NativeFieldInfoPtr_ResourceObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkSummaryBuilder.ResourceData>.NativeClassPtr, nameof (ResourceObject));
      }

      public ResourceData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public ResourceData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ChunkSummaryBuilder.ResourceData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkSummaryBuilder.ResourceData>.NativeClassPtr, data));
      }

      public unsafe float BestAmount
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.ResourceData.NativeFieldInfoPtr_BestAmount));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.ResourceData.NativeFieldInfoPtr_BestAmount)) = value;
        }
      }

      public unsafe UnityEngine.Object ResourceObject
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.ResourceData.NativeFieldInfoPtr_ResourceObject));
          return pointer == System.IntPtr.Zero ? (UnityEngine.Object) null : new UnityEngine.Object(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.ResourceData.NativeFieldInfoPtr_ResourceObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public enum ChildSummaryType
    {
      SelectBestSiblingYield,
      CombineAllYields,
    }

    public sealed class ChildGroupBuilder : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_SummaryBuilder;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803049, XrefRangeEnd = 803050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkSummaryBuilder.ChildGroupBuilder.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ChildGroupBuilder()
      {
        Il2CppClassPointerStore<ChunkSummaryBuilder.ChildGroupBuilder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr, nameof (ChildGroupBuilder));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkSummaryBuilder.ChildGroupBuilder>.NativeClassPtr);
        ChunkSummaryBuilder.ChildGroupBuilder.NativeFieldInfoPtr_SummaryBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkSummaryBuilder.ChildGroupBuilder>.NativeClassPtr, nameof (SummaryBuilder));
        ChunkSummaryBuilder.ChildGroupBuilder.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkSummaryBuilder.ChildGroupBuilder>.NativeClassPtr, 100670805);
      }

      public ChildGroupBuilder(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public ChildGroupBuilder()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ChunkSummaryBuilder.ChildGroupBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkSummaryBuilder.ChildGroupBuilder>.NativeClassPtr, data));
      }

      public unsafe ChunkSummaryBuilder SummaryBuilder
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.ChildGroupBuilder.NativeFieldInfoPtr_SummaryBuilder));
          return pointer == System.IntPtr.Zero ? (ChunkSummaryBuilder) null : new ChunkSummaryBuilder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkSummaryBuilder.ChildGroupBuilder.NativeFieldInfoPtr_SummaryBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.Shared.ChunkSummaryBuilder/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__14_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ProcessChunk_b__14_0_Internal_IEnumerable_1_IChunkSummaryDataSource_GameObject_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkSummaryBuilder.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkSummaryBuilder.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803050, XrefRangeEnd = 803054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe IEnumerable<IChunkSummaryDataSource> _ProcessChunk_b__14_0(GameObject x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkSummaryBuilder.__c.NativeMethodInfoPtr__ProcessChunk_b__14_0_Internal_IEnumerable_1_IChunkSummaryDataSource_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerable<IChunkSummaryDataSource>) null : new IEnumerable<IChunkSummaryDataSource>(pointer);
      }

      static __c()
      {
        Il2CppClassPointerStore<ChunkSummaryBuilder.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkSummaryBuilder.__c>.NativeClassPtr);
        ChunkSummaryBuilder.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkSummaryBuilder.__c>.NativeClassPtr, "<>9");
        ChunkSummaryBuilder.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkSummaryBuilder.__c>.NativeClassPtr, "<>9__14_0");
        ChunkSummaryBuilder.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkSummaryBuilder.__c>.NativeClassPtr, 100670807);
        ChunkSummaryBuilder.__c.NativeMethodInfoPtr__ProcessChunk_b__14_0_Internal_IEnumerable_1_IChunkSummaryDataSource_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkSummaryBuilder.__c>.NativeClassPtr, 100670808);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe ChunkSummaryBuilder.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ChunkSummaryBuilder.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (ChunkSummaryBuilder.__c) null : new ChunkSummaryBuilder.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ChunkSummaryBuilder.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<GameObject, IEnumerable<IChunkSummaryDataSource>> __9__14_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ChunkSummaryBuilder.__c.NativeFieldInfoPtr___9__14_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<GameObject, IEnumerable<IChunkSummaryDataSource>>) null : new Il2CppSystem.Func<GameObject, IEnumerable<IChunkSummaryDataSource>>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ChunkSummaryBuilder.__c.NativeFieldInfoPtr___9__14_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_AdjustForRemapping_Public_TRemapping_PrefabGUID_TRemapping_0<TRemapping>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ChunkSummaryBuilder.NativeMethodInfoPtr_AdjustForRemapping_Public_TRemapping_PrefabGUID_TRemapping_0, Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRemapping>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_RegisterRemapping_Public_Void_PrefabGUID_TRemapping_0<TRemapping>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ChunkSummaryBuilder.NativeMethodInfoPtr_RegisterRemapping_Public_Void_PrefabGUID_TRemapping_0, Il2CppClassPointerStore<ChunkSummaryBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRemapping>.NativeClassPtr))
      }))));
    }
  }
}
