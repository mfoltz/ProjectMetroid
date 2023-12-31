// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.SyncRegistry_Client`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Network
{
  public struct SyncRegistry_Client<T>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Registry;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToSync;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGet_Public_Boolean_Int32_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Sync_Public_Void_Int32_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    public NativeHashMap<int, T> Registry;
    public NativeList<int> ToSync;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 785397, RefRangeEnd = 785398, XrefRangeStart = 785390, XrefRangeEnd = 785397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SyncRegistry_Client(int initialCapacity, Allocator allocator = Allocator.Persistent)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &initialCapacity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncRegistry_Client<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Allocator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 785400, RefRangeEnd = 785402, XrefRangeStart = 785398, XrefRangeEnd = 785400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGet(int syncId, out T value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &syncId;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(T*) &zero);
      }
      else
        local1 = ref value;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SyncRegistry_Client<T>.NativeMethodInfoPtr_TryGet_Public_Boolean_Int32_byref_T_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref value;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local2 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 785409, RefRangeEnd = 785410, XrefRangeStart = 785402, XrefRangeEnd = 785409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Sync(int syncId, [In] ref T value)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) &syncId;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncRegistry_Client<T>.NativeMethodInfoPtr_Sync_Public_Void_Int32_byref_T_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref T local = ref value;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
      local = (T) valueGeneric;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 785415, RefRangeEnd = 785416, XrefRangeStart = 785410, XrefRangeEnd = 785415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncRegistry_Client<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SyncRegistry_Client()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<SyncRegistry_Client<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", "SyncRegistry_Client`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncRegistry_Client<T>>.NativeClassPtr);
      SyncRegistry_Client<T>.NativeFieldInfoPtr_Registry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncRegistry_Client<T>>.NativeClassPtr, nameof (Registry));
      SyncRegistry_Client<T>.NativeFieldInfoPtr_ToSync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncRegistry_Client<T>>.NativeClassPtr, nameof (ToSync));
      SyncRegistry_Client<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRegistry_Client<T>>.NativeClassPtr, 100669210);
      SyncRegistry_Client<T>.NativeMethodInfoPtr_TryGet_Public_Boolean_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRegistry_Client<T>>.NativeClassPtr, 100669211);
      SyncRegistry_Client<T>.NativeMethodInfoPtr_Sync_Public_Void_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRegistry_Client<T>>.NativeClassPtr, 100669212);
      SyncRegistry_Client<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRegistry_Client<T>>.NativeClassPtr, 100669213);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SyncRegistry_Client<T>>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
