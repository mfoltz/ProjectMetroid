// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.NodeDataPtr
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct NodeDataPtr
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Ptr;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromBuffer_Public_Static_NodeDataPtr_byref_BehaviourTreeNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Read_Public_byref_T_0;
    [FieldOffset(0)]
    public readonly unsafe void* _Ptr;

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1343923, RefRangeEnd = 1343928, XrefRangeStart = 1343920, XrefRangeEnd = 1343923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NodeDataPtr FromBuffer(ref BehaviourTreeNode treeNode)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref treeNode;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NodeDataPtr.NativeMethodInfoPtr_FromBuffer_Public_Static_NodeDataPtr_byref_BehaviourTreeNode_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NodeDataPtr*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NodeDataPtr(void* ptr)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ptr;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NodeDataPtr.NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 1343928, RefRangeEnd = 1343936, XrefRangeStart = 1343928, XrefRangeEnd = 1343928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public ref T Read<T>()
    {
      // ISSUE: unable to decompile the method.
    }

    static NodeDataPtr()
    {
      Il2CppClassPointerStore<NodeDataPtr>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (NodeDataPtr));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NodeDataPtr>.NativeClassPtr);
      NodeDataPtr.NativeFieldInfoPtr__Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeDataPtr>.NativeClassPtr, nameof (_Ptr));
      NodeDataPtr.NativeMethodInfoPtr_FromBuffer_Public_Static_NodeDataPtr_byref_BehaviourTreeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeDataPtr>.NativeClassPtr, 100665394);
      NodeDataPtr.NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeDataPtr>.NativeClassPtr, 100665395);
      NodeDataPtr.NativeMethodInfoPtr_Read_Public_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeDataPtr>.NativeClassPtr, 100665396);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NodeDataPtr>.NativeClassPtr, (System.IntPtr) ref this));
    }

    private sealed class MethodInfoStoreGeneric_Read_Public_byref_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NodeDataPtr.NativeMethodInfoPtr_Read_Public_byref_T_0, Il2CppClassPointerStore<NodeDataPtr>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
