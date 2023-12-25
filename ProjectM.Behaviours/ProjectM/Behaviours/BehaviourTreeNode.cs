// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.BehaviourTreeNode
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BehaviourTreeNode
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_InvalidIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParentNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_Blackboard;
    private static readonly System.IntPtr NativeFieldInfoPtr_Children;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetParent_Public_byref_BehaviourTreeNode_byref_BehaviourTreeBlob_0;
    [FieldOffset(0)]
    public ushort ParentNode;
    [FieldOffset(2)]
    public ushort NodeIndex;
    [FieldOffset(4)]
    public BehaviourTreeNodeType Type;
    [FieldOffset(8)]
    public BlobArray<byte> Blackboard;
    [FieldOffset(16)]
    public BlobArray<ushort> Children;

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 1336131, RefRangeEnd = 1336143, XrefRangeStart = 1336128, XrefRangeEnd = 1336131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public ref BehaviourTreeNode GetParent(ref BehaviourTreeBlob treeBlob)
    {
      // ISSUE: unable to decompile the method.
    }

    static BehaviourTreeNode()
    {
      Il2CppClassPointerStore<BehaviourTreeNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (BehaviourTreeNode));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeNode>.NativeClassPtr);
      BehaviourTreeNode.NativeFieldInfoPtr_InvalidIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeNode>.NativeClassPtr, nameof (InvalidIndex));
      BehaviourTreeNode.NativeFieldInfoPtr_ParentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeNode>.NativeClassPtr, nameof (ParentNode));
      BehaviourTreeNode.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeNode>.NativeClassPtr, nameof (NodeIndex));
      BehaviourTreeNode.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeNode>.NativeClassPtr, nameof (Type));
      BehaviourTreeNode.NativeFieldInfoPtr_Blackboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeNode>.NativeClassPtr, nameof (Blackboard));
      BehaviourTreeNode.NativeFieldInfoPtr_Children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeNode>.NativeClassPtr, nameof (Children));
      BehaviourTreeNode.NativeMethodInfoPtr_GetParent_Public_byref_BehaviourTreeNode_byref_BehaviourTreeBlob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeNode>.NativeClassPtr, 100664433);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeNode>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe ushort InvalidIndex
    {
      get
      {
        ushort invalidIndex;
        IL2CPP.il2cpp_field_static_get_value(BehaviourTreeNode.NativeFieldInfoPtr_InvalidIndex, (void*) &invalidIndex);
        return invalidIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BehaviourTreeNode.NativeFieldInfoPtr_InvalidIndex, (void*) &value);
      }
    }
  }
}
