// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.SyncRegistry_Server`1
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
  public struct SyncRegistry_Server<T>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Registry;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserSyncFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr__NextAvailableId_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NextAvailableId_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_NextAvailableId_Private_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PersistenceLoad_Public_Void_Int32_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_T_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGet_Public_Boolean_Int32_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasSyncedToUser_Public_Boolean_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetSyncedToUser_Public_Void_Int32_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearUser_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    public NativeHashMap<int, T> Registry;
    public NativeHashMap<int, UserBitMask128> UserSyncFlags;
    public int _NextAvailableId_k__BackingField;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 785312, RefRangeEnd = 785313, XrefRangeStart = 785304, XrefRangeEnd = 785312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SyncRegistry_Server(int initialCapacity, Allocator allocator = Allocator.Persistent)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &initialCapacity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncRegistry_Server<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Allocator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe int NextAvailableId
    {
      [CallerCount(36), CachedScanResults(RefRangeStart = 29682, RefRangeEnd = 29718, XrefRangeStart = 29682, XrefRangeEnd = 29718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncRegistry_Server<T>.NativeMethodInfoPtr_get_NextAvailableId_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SyncRegistry_Server<T>.NativeMethodInfoPtr_set_NextAvailableId_Private_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 785320, RefRangeEnd = 785321, XrefRangeStart = 785313, XrefRangeEnd = 785320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PersistenceLoad(int syncId, [In] ref T value)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) &syncId;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncRegistry_Server<T>.NativeMethodInfoPtr_PersistenceLoad_Public_Void_Int32_byref_T_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref T local = ref value;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
      local = (T) valueGeneric;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 785330, RefRangeEnd = 785331, XrefRangeStart = 785321, XrefRangeEnd = 785330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Add([In] ref T value)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncRegistry_Server<T>.NativeMethodInfoPtr_Add_Public_Void_byref_T_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref T local = ref value;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
      local = (T) valueGeneric;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785331, XrefRangeEnd = 785333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe T Get(int syncId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &syncId;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(SyncRegistry_Server<T>.NativeMethodInfoPtr_Get_Public_T_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 785337, RefRangeEnd = 785338, XrefRangeStart = 785333, XrefRangeEnd = 785337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SyncRegistry_Server<T>.NativeMethodInfoPtr_TryGet_Public_Boolean_Int32_byref_T_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
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
    [CachedScanResults(RefRangeStart = 785342, RefRangeEnd = 785343, XrefRangeStart = 785338, XrefRangeEnd = 785342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasSyncedToUser(int syncId, int userIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &syncId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncRegistry_Server<T>.NativeMethodInfoPtr_HasSyncedToUser_Public_Boolean_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 785352, RefRangeEnd = 785354, XrefRangeStart = 785343, XrefRangeEnd = 785352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetSyncedToUser(int syncId, bool isSynced, int userIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &syncId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isSynced;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &userIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncRegistry_Server<T>.NativeMethodInfoPtr_SetSyncedToUser_Public_Void_Int32_Boolean_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 785382, RefRangeEnd = 785384, XrefRangeStart = 785354, XrefRangeEnd = 785382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearUser(int userIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &userIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncRegistry_Server<T>.NativeMethodInfoPtr_ClearUser_Public_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 785389, RefRangeEnd = 785390, XrefRangeStart = 785384, XrefRangeEnd = 785389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncRegistry_Server<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SyncRegistry_Server()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<SyncRegistry_Server<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", "SyncRegistry_Server`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncRegistry_Server<T>>.NativeClassPtr);
      SyncRegistry_Server<T>.NativeFieldInfoPtr_Registry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncRegistry_Server<T>>.NativeClassPtr, nameof (Registry));
      SyncRegistry_Server<T>.NativeFieldInfoPtr_UserSyncFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncRegistry_Server<T>>.NativeClassPtr, nameof (UserSyncFlags));
      SyncRegistry_Server<T>.NativeFieldInfoPtr__NextAvailableId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncRegistry_Server<T>>.NativeClassPtr, "<NextAvailableId>k__BackingField");
      SyncRegistry_Server<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRegistry_Server<T>>.NativeClassPtr, 100669199);
      SyncRegistry_Server<T>.NativeMethodInfoPtr_get_NextAvailableId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRegistry_Server<T>>.NativeClassPtr, 100669200);
      SyncRegistry_Server<T>.NativeMethodInfoPtr_set_NextAvailableId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRegistry_Server<T>>.NativeClassPtr, 100669201);
      SyncRegistry_Server<T>.NativeMethodInfoPtr_PersistenceLoad_Public_Void_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRegistry_Server<T>>.NativeClassPtr, 100669202);
      SyncRegistry_Server<T>.NativeMethodInfoPtr_Add_Public_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRegistry_Server<T>>.NativeClassPtr, 100669203);
      SyncRegistry_Server<T>.NativeMethodInfoPtr_Get_Public_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRegistry_Server<T>>.NativeClassPtr, 100669204);
      SyncRegistry_Server<T>.NativeMethodInfoPtr_TryGet_Public_Boolean_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRegistry_Server<T>>.NativeClassPtr, 100669205);
      SyncRegistry_Server<T>.NativeMethodInfoPtr_HasSyncedToUser_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRegistry_Server<T>>.NativeClassPtr, 100669206);
      SyncRegistry_Server<T>.NativeMethodInfoPtr_SetSyncedToUser_Public_Void_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRegistry_Server<T>>.NativeClassPtr, 100669207);
      SyncRegistry_Server<T>.NativeMethodInfoPtr_ClearUser_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRegistry_Server<T>>.NativeClassPtr, 100669208);
      SyncRegistry_Server<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRegistry_Server<T>>.NativeClassPtr, 100669209);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SyncRegistry_Server<T>>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
