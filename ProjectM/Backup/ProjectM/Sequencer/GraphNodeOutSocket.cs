// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.GraphNodeOutSocket
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Sequencer;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public class GraphNodeOutSocket : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr__SocketType;
    private static readonly System.IntPtr NativeFieldInfoPtr__Node;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Guid_Public_Virtual_Final_New_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetGuidOverride_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SocketType_Public_Virtual_Final_New_get_BlackboardRegisterType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SocketType_Public_Virtual_Final_New_set_Void_BlackboardRegisterType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Node_Public_Virtual_Final_New_get_SequenceGraphNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceGraphNode_0;

    public virtual unsafe string Guid
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GraphNodeOutSocket.NativeMethodInfoPtr_get_Guid_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 16451, RefRangeEnd = 16455, XrefRangeStart = 16451, XrefRangeEnd = 16455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetGuidOverride(string guid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(guid);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphNodeOutSocket.NativeMethodInfoPtr_SetGuidOverride_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe BlackboardRegisterType SocketType
    {
      [CallerCount(264), CachedScanResults(RefRangeStart = 39170, RefRangeEnd = 39434, XrefRangeStart = 39170, XrefRangeEnd = 39434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphNodeOutSocket.NativeMethodInfoPtr_get_SocketType_Public_Virtual_Final_New_get_BlackboardRegisterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BlackboardRegisterType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 20483, RefRangeEnd = 20486, XrefRangeStart = 20483, XrefRangeEnd = 20486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GraphNodeOutSocket.NativeMethodInfoPtr_set_SocketType_Public_Virtual_Final_New_set_Void_BlackboardRegisterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public virtual unsafe SequenceGraphNode Node
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphNodeOutSocket.NativeMethodInfoPtr_get_Node_Public_Virtual_Final_New_get_SequenceGraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (SequenceGraphNode) null : new SequenceGraphNode(pointer);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1098125, RefRangeEnd = 1098126, XrefRangeStart = 1098117, XrefRangeEnd = 1098125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GraphNodeOutSocket(SequenceGraphNode node)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphNodeOutSocket>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphNodeOutSocket.NativeMethodInfoPtr__ctor_Public_Void_SequenceGraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GraphNodeOutSocket()
    {
      Il2CppClassPointerStore<GraphNodeOutSocket>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (GraphNodeOutSocket));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphNodeOutSocket>.NativeClassPtr);
      GraphNodeOutSocket.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphNodeOutSocket>.NativeClassPtr, nameof (_Guid));
      GraphNodeOutSocket.NativeFieldInfoPtr__SocketType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphNodeOutSocket>.NativeClassPtr, nameof (_SocketType));
      GraphNodeOutSocket.NativeFieldInfoPtr__Node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphNodeOutSocket>.NativeClassPtr, nameof (_Node));
      GraphNodeOutSocket.NativeMethodInfoPtr_get_Guid_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeOutSocket>.NativeClassPtr, 100687194);
      GraphNodeOutSocket.NativeMethodInfoPtr_SetGuidOverride_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeOutSocket>.NativeClassPtr, 100687195);
      GraphNodeOutSocket.NativeMethodInfoPtr_get_SocketType_Public_Virtual_Final_New_get_BlackboardRegisterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeOutSocket>.NativeClassPtr, 100687196);
      GraphNodeOutSocket.NativeMethodInfoPtr_set_SocketType_Public_Virtual_Final_New_set_Void_BlackboardRegisterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeOutSocket>.NativeClassPtr, 100687197);
      GraphNodeOutSocket.NativeMethodInfoPtr_get_Node_Public_Virtual_Final_New_get_SequenceGraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeOutSocket>.NativeClassPtr, 100687198);
      GraphNodeOutSocket.NativeMethodInfoPtr__ctor_Public_Void_SequenceGraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeOutSocket>.NativeClassPtr, 100687199);
    }

    public GraphNodeOutSocket(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphNodeOutSocket.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphNodeOutSocket.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe BlackboardRegisterType _SocketType
    {
      get
      {
        return *(BlackboardRegisterType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphNodeOutSocket.NativeFieldInfoPtr__SocketType));
      }
      [param: In] set
      {
        *(BlackboardRegisterType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphNodeOutSocket.NativeFieldInfoPtr__SocketType)) = value;
      }
    }

    public unsafe SequenceGraphNode _Node
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphNodeOutSocket.NativeFieldInfoPtr__Node));
        return pointer == System.IntPtr.Zero ? (SequenceGraphNode) null : new SequenceGraphNode(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphNodeOutSocket.NativeFieldInfoPtr__Node), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
