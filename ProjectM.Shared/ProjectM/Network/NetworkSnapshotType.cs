// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.NetworkSnapshotType
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct NetworkSnapshotType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_None;
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NetworkSnapshotType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_NetworkSnapshotType_NetworkSnapshotType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_NetworkSnapshotType_NetworkSnapshotType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_NetworkSnapshotType_UInt16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt16_NetworkSnapshotType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    [FieldOffset(0)]
    public ushort Value;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 184798, RefRangeEnd = 184809, XrefRangeStart = 184798, XrefRangeEnd = 184809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NetworkSnapshotType(ushort value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotType.NativeMethodInfoPtr__ctor_Public_Void_UInt16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 261271, RefRangeEnd = 261274, XrefRangeStart = 261271, XrefRangeEnd = 261274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(NetworkSnapshotType other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotType.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 261277, RefRangeEnd = 261288, XrefRangeStart = 261277, XrefRangeEnd = 261288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotType.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 780610, XrefRangeEnd = 780613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotType.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 450939, RefRangeEnd = 450940, XrefRangeStart = 450939, XrefRangeEnd = 450940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator ==(NetworkSnapshotType a, NetworkSnapshotType b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotType.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_NetworkSnapshotType_NetworkSnapshotType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool operator !=(NetworkSnapshotType a, NetworkSnapshotType b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotType.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_NetworkSnapshotType_NetworkSnapshotType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2538)]
    [CachedScanResults(RefRangeStart = 276988, RefRangeEnd = 279526, XrefRangeStart = 276988, XrefRangeEnd = 279526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator NetworkSnapshotType(ushort value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotType.NativeMethodInfoPtr_op_Implicit_Public_Static_NetworkSnapshotType_UInt16_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NetworkSnapshotType*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2538)]
    [CachedScanResults(RefRangeStart = 276988, RefRangeEnd = 279526, XrefRangeStart = 276988, XrefRangeEnd = 279526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator ushort(NetworkSnapshotType snapshot)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &snapshot;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotType.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt16_NetworkSnapshotType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ushort*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 780613, XrefRangeEnd = 780623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotType.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static NetworkSnapshotType()
    {
      Il2CppClassPointerStore<NetworkSnapshotType>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (NetworkSnapshotType));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkSnapshotType>.NativeClassPtr);
      NetworkSnapshotType.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkSnapshotType>.NativeClassPtr, nameof (None));
      NetworkSnapshotType.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkSnapshotType>.NativeClassPtr, nameof (Value));
      NetworkSnapshotType.NativeMethodInfoPtr__ctor_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotType>.NativeClassPtr, 100669112);
      NetworkSnapshotType.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotType>.NativeClassPtr, 100669113);
      NetworkSnapshotType.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotType>.NativeClassPtr, 100669114);
      NetworkSnapshotType.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotType>.NativeClassPtr, 100669115);
      NetworkSnapshotType.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_NetworkSnapshotType_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotType>.NativeClassPtr, 100669116);
      NetworkSnapshotType.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_NetworkSnapshotType_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotType>.NativeClassPtr, 100669117);
      NetworkSnapshotType.NativeMethodInfoPtr_op_Implicit_Public_Static_NetworkSnapshotType_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotType>.NativeClassPtr, 100669118);
      NetworkSnapshotType.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt16_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotType>.NativeClassPtr, 100669119);
      NetworkSnapshotType.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotType>.NativeClassPtr, 100669120);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkSnapshotType>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe ushort None
    {
      get
      {
        ushort none;
        IL2CPP.il2cpp_field_static_get_value(NetworkSnapshotType.NativeFieldInfoPtr_None, (void*) &none);
        return none;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkSnapshotType.NativeFieldInfoPtr_None, (void*) &value);
      }
    }
  }
}
