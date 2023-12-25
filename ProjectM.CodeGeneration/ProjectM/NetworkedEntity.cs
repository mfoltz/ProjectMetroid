// Decompiled with JetBrains decompiler
// Type: ProjectM.NetworkedEntity
// Assembly: ProjectM.CodeGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE751F2E-D812-4D5F-A9DE-9160851E105B
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CodeGeneration.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct NetworkedEntity
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Empty;
    private static readonly System.IntPtr NativeFieldInfoPtr__Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr__WaitingForSync;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SyncStateEquals_Public_Static_Boolean_byref_NetworkedEntity_byref_NetworkedEntity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ServerEntity_Public_Static_NetworkedEntity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_NetworkedEntity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSyncedEntity_Public_Boolean_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntityOnServer_Public_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSyncedEntityOrNull_Public_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    [FieldOffset(0)]
    public Entity _Entity;
    [FieldOffset(8)]
    public bool _WaitingForSync;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 632929, RefRangeEnd = 632931, XrefRangeStart = 632929, XrefRangeEnd = 632929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NetworkedEntity(bool waitingForSync, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &waitingForSync;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkedEntity.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe bool SyncStateEquals([In] ref NetworkedEntity one, [In] ref NetworkedEntity two)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref one;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref two;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkedEntity.NativeMethodInfoPtr_SyncStateEquals_Public_Static_Boolean_byref_NetworkedEntity_byref_NetworkedEntity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(260)]
    [CachedScanResults(RefRangeStart = 632931, RefRangeEnd = 633191, XrefRangeStart = 632931, XrefRangeEnd = 632931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NetworkedEntity ServerEntity(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkedEntity.NativeMethodInfoPtr_ServerEntity_Public_Static_NetworkedEntity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NetworkedEntity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(260)]
    [CachedScanResults(RefRangeStart = 632931, RefRangeEnd = 633191, XrefRangeStart = 632931, XrefRangeEnd = 633191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator NetworkedEntity(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkedEntity.NativeMethodInfoPtr_op_Implicit_Public_Static_NetworkedEntity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NetworkedEntity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(220)]
    [CachedScanResults(RefRangeStart = 633191, RefRangeEnd = 633411, XrefRangeStart = 633191, XrefRangeEnd = 633191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetSyncedEntity(out Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkedEntity.NativeMethodInfoPtr_TryGetSyncedEntity_Public_Boolean_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(54)]
    [CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity GetEntityOnServer()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkedEntity.NativeMethodInfoPtr_GetEntityOnServer_Public_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(188)]
    [CachedScanResults(RefRangeStart = 633412, RefRangeEnd = 633600, XrefRangeStart = 633411, XrefRangeEnd = 633412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity GetSyncedEntityOrNull()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkedEntity.NativeMethodInfoPtr_GetSyncedEntityOrNull_Public_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkedEntity.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static NetworkedEntity()
    {
      Il2CppClassPointerStore<NetworkedEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM", nameof (NetworkedEntity));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkedEntity>.NativeClassPtr);
      NetworkedEntity.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedEntity>.NativeClassPtr, nameof (Empty));
      NetworkedEntity.NativeFieldInfoPtr__Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedEntity>.NativeClassPtr, nameof (_Entity));
      NetworkedEntity.NativeFieldInfoPtr__WaitingForSync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedEntity>.NativeClassPtr, nameof (_WaitingForSync));
      NetworkedEntity.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEntity>.NativeClassPtr, 100663311);
      NetworkedEntity.NativeMethodInfoPtr_SyncStateEquals_Public_Static_Boolean_byref_NetworkedEntity_byref_NetworkedEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEntity>.NativeClassPtr, 100663312);
      NetworkedEntity.NativeMethodInfoPtr_ServerEntity_Public_Static_NetworkedEntity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEntity>.NativeClassPtr, 100663313);
      NetworkedEntity.NativeMethodInfoPtr_op_Implicit_Public_Static_NetworkedEntity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEntity>.NativeClassPtr, 100663314);
      NetworkedEntity.NativeMethodInfoPtr_TryGetSyncedEntity_Public_Boolean_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEntity>.NativeClassPtr, 100663315);
      NetworkedEntity.NativeMethodInfoPtr_GetEntityOnServer_Public_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEntity>.NativeClassPtr, 100663316);
      NetworkedEntity.NativeMethodInfoPtr_GetSyncedEntityOrNull_Public_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEntity>.NativeClassPtr, 100663317);
      NetworkedEntity.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEntity>.NativeClassPtr, 100663318);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkedEntity>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe NetworkedEntity Empty
    {
      get
      {
        NetworkedEntity empty;
        IL2CPP.il2cpp_field_static_get_value(NetworkedEntity.NativeFieldInfoPtr_Empty, (void*) &empty);
        return empty;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkedEntity.NativeFieldInfoPtr_Empty, (void*) &value);
      }
    }
  }
}
