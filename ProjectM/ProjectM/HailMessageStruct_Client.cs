// Decompiled with JetBrains decompiler
// Type: ProjectM.HailMessageStruct_Client
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Network;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public sealed class HailMessageStruct_Client : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_VERSION;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlatformIds;
    private static readonly System.IntPtr NativeFieldInfoPtr_SessionTicket;
    private static readonly System.IntPtr NativeFieldInfoPtr_Password;
    private static readonly System.IntPtr NativeFieldInfoPtr_Version;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsBot;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromConnectData_Public_Static_Void_byref_ClientConnectData_byref_HailMessageStruct_Client_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_NetBufferOut_byref_HailMessageStruct_Client_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_Boolean_byref_NetBufferIn_byref_HailMessageStruct_Client_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 978953, RefRangeEnd = 978954, XrefRangeStart = 978950, XrefRangeEnd = 978953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void FromConnectData(
      [In] ref ClientConnectData connectData,
      out HailMessageStruct_Client hailData)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) connectData);
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HailMessageStruct_Client.NativeMethodInfoPtr_FromConnectData_Public_Static_Void_byref_ClientConnectData_byref_HailMessageStruct_Client_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref HailMessageStruct_Client local = ref hailData;
      System.IntPtr pointer = zero;
      HailMessageStruct_Client messageStructClient = pointer == System.IntPtr.Zero ? (HailMessageStruct_Client) null : new HailMessageStruct_Client(pointer);
      local = messageStructClient;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 978983, RefRangeEnd = 978984, XrefRangeStart = 978954, XrefRangeEnd = 978983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Serialize(
      ref NetBufferOut netBufferOut,
      [In] ref HailMessageStruct_Client hailData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBufferOut;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) hailData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HailMessageStruct_Client.NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_NetBufferOut_byref_HailMessageStruct_Client_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 979035, RefRangeEnd = 979036, XrefRangeStart = 978984, XrefRangeEnd = 979035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Deserialize(
      ref NetBufferIn netBufferIn,
      out HailMessageStruct_Client hailData)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) ref netBufferIn;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HailMessageStruct_Client.NativeMethodInfoPtr_Deserialize_Public_Static_Boolean_byref_NetBufferIn_byref_HailMessageStruct_Client_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref HailMessageStruct_Client local = ref hailData;
      System.IntPtr pointer = zero;
      HailMessageStruct_Client messageStructClient = pointer == System.IntPtr.Zero ? (HailMessageStruct_Client) null : new HailMessageStruct_Client(pointer);
      local = messageStructClient;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    static HailMessageStruct_Client()
    {
      Il2CppClassPointerStore<HailMessageStruct_Client>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (HailMessageStruct_Client));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HailMessageStruct_Client>.NativeClassPtr);
      HailMessageStruct_Client.NativeFieldInfoPtr_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HailMessageStruct_Client>.NativeClassPtr, nameof (VERSION));
      HailMessageStruct_Client.NativeFieldInfoPtr_PlatformIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HailMessageStruct_Client>.NativeClassPtr, nameof (PlatformIds));
      HailMessageStruct_Client.NativeFieldInfoPtr_SessionTicket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HailMessageStruct_Client>.NativeClassPtr, nameof (SessionTicket));
      HailMessageStruct_Client.NativeFieldInfoPtr_Password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HailMessageStruct_Client>.NativeClassPtr, nameof (Password));
      HailMessageStruct_Client.NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HailMessageStruct_Client>.NativeClassPtr, nameof (Version));
      HailMessageStruct_Client.NativeFieldInfoPtr_IsBot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HailMessageStruct_Client>.NativeClassPtr, nameof (IsBot));
      HailMessageStruct_Client.NativeMethodInfoPtr_FromConnectData_Public_Static_Void_byref_ClientConnectData_byref_HailMessageStruct_Client_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HailMessageStruct_Client>.NativeClassPtr, 100675627);
      HailMessageStruct_Client.NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_NetBufferOut_byref_HailMessageStruct_Client_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HailMessageStruct_Client>.NativeClassPtr, 100675628);
      HailMessageStruct_Client.NativeMethodInfoPtr_Deserialize_Public_Static_Boolean_byref_NetBufferIn_byref_HailMessageStruct_Client_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HailMessageStruct_Client>.NativeClassPtr, 100675629);
    }

    public HailMessageStruct_Client(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public HailMessageStruct_Client()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HailMessageStruct_Client>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HailMessageStruct_Client>.NativeClassPtr, data));
    }

    public static unsafe byte VERSION
    {
      get
      {
        byte version;
        IL2CPP.il2cpp_field_static_get_value(HailMessageStruct_Client.NativeFieldInfoPtr_VERSION, (void*) &version);
        return version;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HailMessageStruct_Client.NativeFieldInfoPtr_VERSION, (void*) &value);
      }
    }

    public unsafe PlatformIdCollection PlatformIds
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HailMessageStruct_Client.NativeFieldInfoPtr_PlatformIds));
        return pointer == System.IntPtr.Zero ? (PlatformIdCollection) null : new PlatformIdCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HailMessageStruct_Client.NativeFieldInfoPtr_PlatformIds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<byte> SessionTicket
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HailMessageStruct_Client.NativeFieldInfoPtr_SessionTicket));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HailMessageStruct_Client.NativeFieldInfoPtr_SessionTicket), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string Password
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HailMessageStruct_Client.NativeFieldInfoPtr_Password)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HailMessageStruct_Client.NativeFieldInfoPtr_Password), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int Version
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HailMessageStruct_Client.NativeFieldInfoPtr_Version));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HailMessageStruct_Client.NativeFieldInfoPtr_Version)) = value;
      }
    }

    public unsafe bool IsBot
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HailMessageStruct_Client.NativeFieldInfoPtr_IsBot));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HailMessageStruct_Client.NativeFieldInfoPtr_IsBot)) = value;
      }
    }
  }
}
