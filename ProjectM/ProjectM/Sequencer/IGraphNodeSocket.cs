// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.IGraphNodeSocket
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Sequencer;
using System;

#nullable disable
namespace ProjectM.Sequencer
{
  public class IGraphNodeSocket : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_get_SocketType_Public_Abstract_Virtual_New_get_BlackboardRegisterType_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_SocketType_Public_Abstract_Virtual_New_set_Void_BlackboardRegisterType_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_Guid_Public_Abstract_Virtual_New_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_Node_Public_Abstract_Virtual_New_get_SequenceGraphNode_0;

    public virtual unsafe BlackboardRegisterType SocketType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGraphNodeSocket.NativeMethodInfoPtr_get_SocketType_Public_Abstract_Virtual_New_get_BlackboardRegisterType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BlackboardRegisterType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGraphNodeSocket.NativeMethodInfoPtr_set_SocketType_Public_Abstract_Virtual_New_set_Void_BlackboardRegisterType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public virtual unsafe string Guid
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGraphNodeSocket.NativeMethodInfoPtr_get_Guid_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public virtual unsafe SequenceGraphNode Node
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGraphNodeSocket.NativeMethodInfoPtr_get_Node_Public_Abstract_Virtual_New_get_SequenceGraphNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (SequenceGraphNode) null : new SequenceGraphNode(pointer);
      }
    }

    static IGraphNodeSocket()
    {
      Il2CppClassPointerStore<IGraphNodeSocket>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (IGraphNodeSocket));
      IGraphNodeSocket.NativeMethodInfoPtr_get_SocketType_Public_Abstract_Virtual_New_get_BlackboardRegisterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGraphNodeSocket>.NativeClassPtr, 100687158);
      IGraphNodeSocket.NativeMethodInfoPtr_set_SocketType_Public_Abstract_Virtual_New_set_Void_BlackboardRegisterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGraphNodeSocket>.NativeClassPtr, 100687159);
      IGraphNodeSocket.NativeMethodInfoPtr_get_Guid_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGraphNodeSocket>.NativeClassPtr, 100687160);
      IGraphNodeSocket.NativeMethodInfoPtr_get_Node_Public_Abstract_Virtual_New_get_SequenceGraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGraphNodeSocket>.NativeClassPtr, 100687161);
    }

    public IGraphNodeSocket(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
