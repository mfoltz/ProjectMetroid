// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.BehaviourTreeBlobBuilder
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Behaviours
{
  public class BehaviourTreeBlobBuilder : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Nodes;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNode_Public_UInt16_UInt16_BehaviourTreeNodeType_Il2CppStructArray_1_Byte_List_1_UInt16_List_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateBlobAsset_Public_BlobAssetReference_1_BehaviourTreeBlob_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336143, XrefRangeEnd = 1336150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ushort AddNode(
      ushort parentNode,
      BehaviourTreeNodeType type,
      Il2CppStructArray<byte> blackboard,
      List<ushort> children,
      List<int> referencedBehaviourTreeFields)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &parentNode;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboard);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) children);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) referencedBehaviourTreeFields);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeBlobBuilder.NativeMethodInfoPtr_AddNode_Public_UInt16_UInt16_BehaviourTreeNodeType_Il2CppStructArray_1_Byte_List_1_UInt16_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ushort*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1336207, RefRangeEnd = 1336208, XrefRangeStart = 1336150, XrefRangeEnd = 1336207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BlobAssetReference<BehaviourTreeBlob> CreateBlobAsset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeBlobBuilder.NativeMethodInfoPtr_CreateBlobAsset_Public_BlobAssetReference_1_BehaviourTreeBlob_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BlobAssetReference<BehaviourTreeBlob>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336208, XrefRangeEnd = 1336216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeBlobBuilder()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BehaviourTreeBlobBuilder>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeBlobBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BehaviourTreeBlobBuilder()
    {
      Il2CppClassPointerStore<BehaviourTreeBlobBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (BehaviourTreeBlobBuilder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeBlobBuilder>.NativeClassPtr);
      BehaviourTreeBlobBuilder.NativeFieldInfoPtr_Nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeBlobBuilder>.NativeClassPtr, nameof (Nodes));
      BehaviourTreeBlobBuilder.NativeMethodInfoPtr_AddNode_Public_UInt16_UInt16_BehaviourTreeNodeType_Il2CppStructArray_1_Byte_List_1_UInt16_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeBlobBuilder>.NativeClassPtr, 100664434);
      BehaviourTreeBlobBuilder.NativeMethodInfoPtr_CreateBlobAsset_Public_BlobAssetReference_1_BehaviourTreeBlob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeBlobBuilder>.NativeClassPtr, 100664435);
      BehaviourTreeBlobBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeBlobBuilder>.NativeClassPtr, 100664436);
    }

    public BehaviourTreeBlobBuilder(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<BehaviourTreeBlobBuilder.NodeData> Nodes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeBlobBuilder.NativeFieldInfoPtr_Nodes));
        return pointer == System.IntPtr.Zero ? (List<BehaviourTreeBlobBuilder.NodeData>) null : new List<BehaviourTreeBlobBuilder.NodeData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeBlobBuilder.NativeFieldInfoPtr_Nodes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class NodeData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ParentNode;
      private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_Type;
      private static readonly System.IntPtr NativeFieldInfoPtr_Blackboard;
      private static readonly System.IntPtr NativeFieldInfoPtr_Children;
      private static readonly System.IntPtr NativeFieldInfoPtr_ReferencedBehaviourTreeFields;

      static NodeData()
      {
        Il2CppClassPointerStore<BehaviourTreeBlobBuilder.NodeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeBlobBuilder>.NativeClassPtr, nameof (NodeData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeBlobBuilder.NodeData>.NativeClassPtr);
        BehaviourTreeBlobBuilder.NodeData.NativeFieldInfoPtr_ParentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeBlobBuilder.NodeData>.NativeClassPtr, nameof (ParentNode));
        BehaviourTreeBlobBuilder.NodeData.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeBlobBuilder.NodeData>.NativeClassPtr, nameof (NodeIndex));
        BehaviourTreeBlobBuilder.NodeData.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeBlobBuilder.NodeData>.NativeClassPtr, nameof (Type));
        BehaviourTreeBlobBuilder.NodeData.NativeFieldInfoPtr_Blackboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeBlobBuilder.NodeData>.NativeClassPtr, nameof (Blackboard));
        BehaviourTreeBlobBuilder.NodeData.NativeFieldInfoPtr_Children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeBlobBuilder.NodeData>.NativeClassPtr, nameof (Children));
        BehaviourTreeBlobBuilder.NodeData.NativeFieldInfoPtr_ReferencedBehaviourTreeFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeBlobBuilder.NodeData>.NativeClassPtr, nameof (ReferencedBehaviourTreeFields));
      }

      public NodeData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public NodeData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BehaviourTreeBlobBuilder.NodeData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeBlobBuilder.NodeData>.NativeClassPtr, data));
      }

      public unsafe ushort ParentNode
      {
        get
        {
          return *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeBlobBuilder.NodeData.NativeFieldInfoPtr_ParentNode));
        }
        [param: In] set
        {
          *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeBlobBuilder.NodeData.NativeFieldInfoPtr_ParentNode)) = value;
        }
      }

      public unsafe ushort NodeIndex
      {
        get
        {
          return *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeBlobBuilder.NodeData.NativeFieldInfoPtr_NodeIndex));
        }
        [param: In] set
        {
          *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeBlobBuilder.NodeData.NativeFieldInfoPtr_NodeIndex)) = value;
        }
      }

      public unsafe BehaviourTreeNodeType Type
      {
        get
        {
          return *(BehaviourTreeNodeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeBlobBuilder.NodeData.NativeFieldInfoPtr_Type));
        }
        [param: In] set
        {
          *(BehaviourTreeNodeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeBlobBuilder.NodeData.NativeFieldInfoPtr_Type)) = value;
        }
      }

      public unsafe Il2CppStructArray<byte> Blackboard
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeBlobBuilder.NodeData.NativeFieldInfoPtr_Blackboard));
          return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeBlobBuilder.NodeData.NativeFieldInfoPtr_Blackboard), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe List<ushort> Children
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeBlobBuilder.NodeData.NativeFieldInfoPtr_Children));
          return pointer == System.IntPtr.Zero ? (List<ushort>) null : new List<ushort>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeBlobBuilder.NodeData.NativeFieldInfoPtr_Children), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe List<int> ReferencedBehaviourTreeFields
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeBlobBuilder.NodeData.NativeFieldInfoPtr_ReferencedBehaviourTreeFields));
          return pointer == System.IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeBlobBuilder.NodeData.NativeFieldInfoPtr_ReferencedBehaviourTreeFields), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
