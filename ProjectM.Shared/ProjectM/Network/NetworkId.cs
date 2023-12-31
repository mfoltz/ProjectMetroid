// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.NetworkId
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
  public struct NetworkId
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Empty;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index;
    private static readonly System.IntPtr NativeFieldInfoPtr_Generation;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NetworkId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_NetworkId_NetworkId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_NetworkId_NetworkId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNetworkedEntity_Public_NetworkedEntity_NativeHashMap_2_NetworkId_Entity_0;
    [FieldOffset(0)]
    public int Index;
    [FieldOffset(4)]
    public byte Generation;

    public unsafe bool IsValid
    {
      [CallerCount(38), CachedScanResults(RefRangeStart = 723758, RefRangeEnd = 723796, XrefRangeStart = 723758, XrefRangeEnd = 723796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkId.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 779811, RefRangeEnd = 779817, XrefRangeStart = 779811, XrefRangeEnd = 779811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(NetworkId other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NetworkId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779817, XrefRangeEnd = 779820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 779820, RefRangeEnd = 779826, XrefRangeStart = 779820, XrefRangeEnd = 779820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator !=(NetworkId value1, NetworkId value2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &value1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_NetworkId_NetworkId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 779826, RefRangeEnd = 779842, XrefRangeStart = 779826, XrefRangeEnd = 779826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator ==(NetworkId value1, NetworkId value2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &value1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_NetworkId_NetworkId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779842, XrefRangeEnd = 779851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NetworkId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(648)]
    [CachedScanResults(RefRangeStart = 779861, RefRangeEnd = 780509, XrefRangeStart = 779851, XrefRangeEnd = 779861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NetworkedEntity GetNetworkedEntity(
      NativeHashMap<NetworkId, Entity> networkedEntityMap)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &networkedEntityMap;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkId.NativeMethodInfoPtr_GetNetworkedEntity_Public_NetworkedEntity_NativeHashMap_2_NetworkId_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NetworkedEntity*) IL2CPP.il2cpp_object_unbox(num);
    }

    static NetworkId()
    {
      Il2CppClassPointerStore<NetworkId>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (NetworkId));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkId>.NativeClassPtr);
      NetworkId.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkId>.NativeClassPtr, nameof (Empty));
      NetworkId.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkId>.NativeClassPtr, nameof (Index));
      NetworkId.NativeFieldInfoPtr_Generation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkId>.NativeClassPtr, nameof (Generation));
      NetworkId.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkId>.NativeClassPtr, 100669094);
      NetworkId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NetworkId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkId>.NativeClassPtr, 100669095);
      NetworkId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkId>.NativeClassPtr, 100669096);
      NetworkId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_NetworkId_NetworkId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkId>.NativeClassPtr, 100669097);
      NetworkId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_NetworkId_NetworkId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkId>.NativeClassPtr, 100669098);
      NetworkId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkId>.NativeClassPtr, 100669099);
      NetworkId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkId>.NativeClassPtr, 100669100);
      NetworkId.NativeMethodInfoPtr_GetNetworkedEntity_Public_NetworkedEntity_NativeHashMap_2_NetworkId_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkId>.NativeClassPtr, 100669101);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkId>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe NetworkId Empty
    {
      get
      {
        NetworkId empty;
        IL2CPP.il2cpp_field_static_get_value(NetworkId.NativeFieldInfoPtr_Empty, (void*) &empty);
        return empty;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkId.NativeFieldInfoPtr_Empty, (void*) &value);
      }
    }
  }
}
