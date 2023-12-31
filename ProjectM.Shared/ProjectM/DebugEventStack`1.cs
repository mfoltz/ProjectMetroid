// Decompiled with JetBrains decompiler
// Type: ProjectM.DebugEventStack`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Unity.Collections.LowLevel.Unsafe;

#nullable disable
namespace ProjectM
{
  public struct DebugEventStack<T> where T : unmanaged
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__UnconsumedEventCount;
    private static readonly System.IntPtr NativeFieldInfoPtr__Data;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MaximumEventCapcity_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UnsafeList_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PushEvent_Public_DebugEventPushResult_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResetFrame_Public_Void_byref_Int64_byref_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasEvents_Public_Boolean_0;
    public long _UnconsumedEventCount;
    public UnsafeList<T> _Data;

    public unsafe int MaximumEventCapcity
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 733305, RefRangeEnd = 733306, XrefRangeStart = 733301, XrefRangeEnd = 733305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventStack<T>.NativeMethodInfoPtr_get_MaximumEventCapcity_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 733313, RefRangeEnd = 733317, XrefRangeStart = 733306, XrefRangeEnd = 733313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DebugEventStack(UnsafeList<T> data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventStack<T>.NativeMethodInfoPtr__ctor_Public_Void_UnsafeList_1_T_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 733324, RefRangeEnd = 733325, XrefRangeStart = 733317, XrefRangeEnd = 733324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DebugEventPushResult PushEvent(T data)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (System.ValueType) data;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref data;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventStack<T>.NativeMethodInfoPtr_PushEvent_Public_DebugEventPushResult_T_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DebugEventPushResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 733327, RefRangeEnd = 733328, XrefRangeStart = 733325, XrefRangeEnd = 733327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ResetFrame(out long unconsumedEventCount, out long eventsRequestedForFrame)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref unconsumedEventCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventsRequestedForFrame;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventStack<T>.NativeMethodInfoPtr_ResetFrame_Public_Void_byref_Int64_byref_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 733329, RefRangeEnd = 733332, XrefRangeStart = 733328, XrefRangeEnd = 733329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasEvents()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugEventStack<T>.NativeMethodInfoPtr_HasEvents_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DebugEventStack()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<DebugEventStack<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", "DebugEventStack`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventStack<T>>.NativeClassPtr);
      DebugEventStack<T>.NativeFieldInfoPtr__UnconsumedEventCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventStack<T>>.NativeClassPtr, nameof (_UnconsumedEventCount));
      DebugEventStack<T>.NativeFieldInfoPtr__Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventStack<T>>.NativeClassPtr, nameof (_Data));
      DebugEventStack<T>.NativeMethodInfoPtr_get_MaximumEventCapcity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventStack<T>>.NativeClassPtr, 100664807);
      DebugEventStack<T>.NativeMethodInfoPtr__ctor_Public_Void_UnsafeList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventStack<T>>.NativeClassPtr, 100664808);
      DebugEventStack<T>.NativeMethodInfoPtr_PushEvent_Public_DebugEventPushResult_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventStack<T>>.NativeClassPtr, 100664809);
      DebugEventStack<T>.NativeMethodInfoPtr_ResetFrame_Public_Void_byref_Int64_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventStack<T>>.NativeClassPtr, 100664810);
      DebugEventStack<T>.NativeMethodInfoPtr_HasEvents_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventStack<T>>.NativeClassPtr, 100664811);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugEventStack<T>>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
