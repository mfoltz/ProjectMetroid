// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.WeakRefTracker
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct WeakRefTracker
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_References_WeakRef_ToNetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_References_ToNetworkId_FromWeakRef;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewEntities;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBufferLength_Public_Void_NetworkId_WeakRefFieldId_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddOrUpdateComponentWeakRef_Public_Void_NetworkId_NetworkId_WeakRefFieldId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddOrUpdateBufferWeakRef_Public_Void_NetworkId_NetworkId_WeakRefFieldId_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddOrUpdateWeakRef_Private_Void_WeakRefId_NetworkId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddWeakRef_Private_Void_WeakRefId_NetworkId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreatePersistent_Public_Static_WeakRefTracker_0;
    [FieldOffset(0)]
    public NativeHashMap<WeakRefTracker.WeakRefId, NetworkId> References_WeakRef_ToNetworkId;
    [FieldOffset(16)]
    public NativeMultiHashMap<NetworkId, WeakRefTracker.WeakRefId> References_ToNetworkId_FromWeakRef;
    [FieldOffset(32)]
    public NativeQueue<WeakRefTracker.NewEntityEntry> NewEntities;

    [CallerCount(178)]
    [CachedScanResults(RefRangeStart = 788345, RefRangeEnd = 788523, XrefRangeStart = 788334, XrefRangeEnd = 788345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetBufferLength(NetworkId fromNetworkId, WeakRefFieldId fieldId, int length)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &fromNetworkId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fieldId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WeakRefTracker.NativeMethodInfoPtr_SetBufferLength_Public_Void_NetworkId_WeakRefFieldId_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(976)]
    [CachedScanResults(RefRangeStart = 788524, RefRangeEnd = 789500, XrefRangeStart = 788523, XrefRangeEnd = 788524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddOrUpdateComponentWeakRef(
      NetworkId from,
      NetworkId to,
      WeakRefFieldId fieldId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &from;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fieldId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WeakRefTracker.NativeMethodInfoPtr_AddOrUpdateComponentWeakRef_Public_Void_NetworkId_NetworkId_WeakRefFieldId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(178)]
    [CachedScanResults(RefRangeStart = 789501, RefRangeEnd = 789679, XrefRangeStart = 789500, XrefRangeEnd = 789501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddOrUpdateBufferWeakRef(
      NetworkId from,
      NetworkId to,
      WeakRefFieldId fieldId,
      int bufferIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &from;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fieldId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &bufferIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WeakRefTracker.NativeMethodInfoPtr_AddOrUpdateBufferWeakRef_Public_Void_NetworkId_NetworkId_WeakRefFieldId_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 789692, RefRangeEnd = 789694, XrefRangeStart = 789679, XrefRangeEnd = 789692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddOrUpdateWeakRef(WeakRefTracker.WeakRefId weakRef, NetworkId to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &weakRef;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WeakRefTracker.NativeMethodInfoPtr_AddOrUpdateWeakRef_Private_Void_WeakRefId_NetworkId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 789694, XrefRangeEnd = 789700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddWeakRef(WeakRefTracker.WeakRefId weakRef, NetworkId to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &weakRef;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WeakRefTracker.NativeMethodInfoPtr_AddWeakRef_Private_Void_WeakRefId_NetworkId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 789709, RefRangeEnd = 789710, XrefRangeStart = 789700, XrefRangeEnd = 789709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WeakRefTracker.NativeMethodInfoPtr_Dispose_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 789719, RefRangeEnd = 789720, XrefRangeStart = 789710, XrefRangeEnd = 789719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe WeakRefTracker CreatePersistent()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WeakRefTracker.NativeMethodInfoPtr_CreatePersistent_Public_Static_WeakRefTracker_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(WeakRefTracker*) IL2CPP.il2cpp_object_unbox(num);
    }

    static WeakRefTracker()
    {
      Il2CppClassPointerStore<WeakRefTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (WeakRefTracker));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeakRefTracker>.NativeClassPtr);
      WeakRefTracker.NativeFieldInfoPtr_References_WeakRef_ToNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeakRefTracker>.NativeClassPtr, nameof (References_WeakRef_ToNetworkId));
      WeakRefTracker.NativeFieldInfoPtr_References_ToNetworkId_FromWeakRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeakRefTracker>.NativeClassPtr, nameof (References_ToNetworkId_FromWeakRef));
      WeakRefTracker.NativeFieldInfoPtr_NewEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeakRefTracker>.NativeClassPtr, nameof (NewEntities));
      WeakRefTracker.NativeMethodInfoPtr_SetBufferLength_Public_Void_NetworkId_WeakRefFieldId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakRefTracker>.NativeClassPtr, 100669459);
      WeakRefTracker.NativeMethodInfoPtr_AddOrUpdateComponentWeakRef_Public_Void_NetworkId_NetworkId_WeakRefFieldId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakRefTracker>.NativeClassPtr, 100669460);
      WeakRefTracker.NativeMethodInfoPtr_AddOrUpdateBufferWeakRef_Public_Void_NetworkId_NetworkId_WeakRefFieldId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakRefTracker>.NativeClassPtr, 100669461);
      WeakRefTracker.NativeMethodInfoPtr_AddOrUpdateWeakRef_Private_Void_WeakRefId_NetworkId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakRefTracker>.NativeClassPtr, 100669462);
      WeakRefTracker.NativeMethodInfoPtr_AddWeakRef_Private_Void_WeakRefId_NetworkId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakRefTracker>.NativeClassPtr, 100669463);
      WeakRefTracker.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakRefTracker>.NativeClassPtr, 100669464);
      WeakRefTracker.NativeMethodInfoPtr_CreatePersistent_Public_Static_WeakRefTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakRefTracker>.NativeClassPtr, 100669465);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WeakRefTracker>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct WeakRefId
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FromNetworkId;
      private static readonly System.IntPtr NativeFieldInfoPtr_FieldId;
      private static readonly System.IntPtr NativeFieldInfoPtr_BufferIndex;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_WeakRefId_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      [FieldOffset(0)]
      public NetworkId FromNetworkId;
      [FieldOffset(8)]
      public WeakRefFieldId FieldId;
      [FieldOffset(12)]
      public int BufferIndex;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 788329, XrefRangeEnd = 788332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WeakRefTracker.WeakRefId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 788332, XrefRangeEnd = 788334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(WeakRefTracker.WeakRefId other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WeakRefTracker.WeakRefId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_WeakRefId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WeakRefTracker.WeakRefId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static WeakRefId()
      {
        Il2CppClassPointerStore<WeakRefTracker.WeakRefId>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeakRefTracker>.NativeClassPtr, nameof (WeakRefId));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeakRefTracker.WeakRefId>.NativeClassPtr);
        WeakRefTracker.WeakRefId.NativeFieldInfoPtr_FromNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeakRefTracker.WeakRefId>.NativeClassPtr, nameof (FromNetworkId));
        WeakRefTracker.WeakRefId.NativeFieldInfoPtr_FieldId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeakRefTracker.WeakRefId>.NativeClassPtr, nameof (FieldId));
        WeakRefTracker.WeakRefId.NativeFieldInfoPtr_BufferIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeakRefTracker.WeakRefId>.NativeClassPtr, nameof (BufferIndex));
        WeakRefTracker.WeakRefId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakRefTracker.WeakRefId>.NativeClassPtr, 100669466);
        WeakRefTracker.WeakRefId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_WeakRefId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakRefTracker.WeakRefId>.NativeClassPtr, 100669467);
        WeakRefTracker.WeakRefId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakRefTracker.WeakRefId>.NativeClassPtr, 100669468);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WeakRefTracker.WeakRefId>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct NewEntityEntry
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_NetworkId;
      [FieldOffset(0)]
      public Entity Entity;
      [FieldOffset(8)]
      public NetworkId NetworkId;

      static NewEntityEntry()
      {
        Il2CppClassPointerStore<WeakRefTracker.NewEntityEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeakRefTracker>.NativeClassPtr, nameof (NewEntityEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeakRefTracker.NewEntityEntry>.NativeClassPtr);
        WeakRefTracker.NewEntityEntry.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeakRefTracker.NewEntityEntry>.NativeClassPtr, nameof (Entity));
        WeakRefTracker.NewEntityEntry.NativeFieldInfoPtr_NetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeakRefTracker.NewEntityEntry>.NativeClassPtr, nameof (NetworkId));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WeakRefTracker.NewEntityEntry>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
