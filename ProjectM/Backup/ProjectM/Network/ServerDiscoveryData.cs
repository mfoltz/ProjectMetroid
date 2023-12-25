// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.ServerDiscoveryData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Network
{
  public sealed class ServerDiscoveryData : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_VERSION;
    private static readonly System.IntPtr NativeFieldInfoPtr_BUFFER_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasData;
    private static readonly System.IntPtr NativeFieldInfoPtr_Data;
    private static readonly System.IntPtr NativeFieldInfoPtr_Address;
    private static readonly System.IntPtr NativeFieldInfoPtr_Port;
    private static readonly System.IntPtr NativeFieldInfoPtr_LatencySeconds;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_byref_NetBufferOut_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_Void_byref_NetBufferIn_byref_ServerDiscoveryData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147807, XrefRangeEnd = 1147809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Serialize(ref NetBufferOut netBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerDiscoveryData.NativeMethodInfoPtr_Serialize_Public_Void_byref_NetBufferOut_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1147823, RefRangeEnd = 1147824, XrefRangeStart = 1147809, XrefRangeEnd = 1147823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Deserialize(ref NetBufferIn netBuffer, out ServerDiscoveryData server)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) ref netBuffer;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerDiscoveryData.NativeMethodInfoPtr_Deserialize_Public_Static_Void_byref_NetBufferIn_byref_ServerDiscoveryData_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ServerDiscoveryData local = ref server;
      System.IntPtr pointer = zero;
      ServerDiscoveryData serverDiscoveryData = pointer == System.IntPtr.Zero ? (ServerDiscoveryData) null : new ServerDiscoveryData(pointer);
      local = serverDiscoveryData;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147824, XrefRangeEnd = 1147853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ServerDiscoveryData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static ServerDiscoveryData()
    {
      Il2CppClassPointerStore<ServerDiscoveryData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (ServerDiscoveryData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerDiscoveryData>.NativeClassPtr);
      ServerDiscoveryData.NativeFieldInfoPtr_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDiscoveryData>.NativeClassPtr, nameof (VERSION));
      ServerDiscoveryData.NativeFieldInfoPtr_BUFFER_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDiscoveryData>.NativeClassPtr, nameof (BUFFER_SIZE));
      ServerDiscoveryData.NativeFieldInfoPtr_HasData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDiscoveryData>.NativeClassPtr, nameof (HasData));
      ServerDiscoveryData.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDiscoveryData>.NativeClassPtr, nameof (Data));
      ServerDiscoveryData.NativeFieldInfoPtr_Address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDiscoveryData>.NativeClassPtr, nameof (Address));
      ServerDiscoveryData.NativeFieldInfoPtr_Port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDiscoveryData>.NativeClassPtr, nameof (Port));
      ServerDiscoveryData.NativeFieldInfoPtr_LatencySeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDiscoveryData>.NativeClassPtr, nameof (LatencySeconds));
      ServerDiscoveryData.NativeMethodInfoPtr_Serialize_Public_Void_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerDiscoveryData>.NativeClassPtr, 100691183);
      ServerDiscoveryData.NativeMethodInfoPtr_Deserialize_Public_Static_Void_byref_NetBufferIn_byref_ServerDiscoveryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerDiscoveryData>.NativeClassPtr, 100691184);
      ServerDiscoveryData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerDiscoveryData>.NativeClassPtr, 100691185);
    }

    public ServerDiscoveryData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ServerDiscoveryData()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerDiscoveryData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerDiscoveryData>.NativeClassPtr, data));
    }

    public static unsafe byte VERSION
    {
      get
      {
        byte version;
        IL2CPP.il2cpp_field_static_get_value(ServerDiscoveryData.NativeFieldInfoPtr_VERSION, (void*) &version);
        return version;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerDiscoveryData.NativeFieldInfoPtr_VERSION, (void*) &value);
      }
    }

    public static unsafe int BUFFER_SIZE
    {
      get
      {
        int bufferSize;
        IL2CPP.il2cpp_field_static_get_value(ServerDiscoveryData.NativeFieldInfoPtr_BUFFER_SIZE, (void*) &bufferSize);
        return bufferSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerDiscoveryData.NativeFieldInfoPtr_BUFFER_SIZE, (void*) &value);
      }
    }

    public unsafe bool HasData
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDiscoveryData.NativeFieldInfoPtr_HasData));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDiscoveryData.NativeFieldInfoPtr_HasData)) = value;
      }
    }

    public unsafe ServerDiscoveryData.V1 Data
    {
      get
      {
        return *(ServerDiscoveryData.V1*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDiscoveryData.NativeFieldInfoPtr_Data));
      }
      [param: In] set
      {
        *(ServerDiscoveryData.V1*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDiscoveryData.NativeFieldInfoPtr_Data)) = value;
      }
    }

    public unsafe string Address
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDiscoveryData.NativeFieldInfoPtr_Address)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerDiscoveryData.NativeFieldInfoPtr_Address), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int Port
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDiscoveryData.NativeFieldInfoPtr_Port));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDiscoveryData.NativeFieldInfoPtr_Port)) = value;
      }
    }

    public unsafe float LatencySeconds
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDiscoveryData.NativeFieldInfoPtr_LatencySeconds));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDiscoveryData.NativeFieldInfoPtr_LatencySeconds)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct V1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_GameVersion;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerName;
      private static readonly System.IntPtr NativeFieldInfoPtr_UsersConnected;
      private static readonly System.IntPtr NativeFieldInfoPtr_UsersConnectedMax;
      private static readonly System.IntPtr NativeFieldInfoPtr_UsersTaken;
      private static readonly System.IntPtr NativeFieldInfoPtr_InGameDay;
      private static readonly System.IntPtr NativeFieldInfoPtr_HasUser;
      private static readonly System.IntPtr NativeFieldInfoPtr_ActivityLevel;
      private static readonly System.IntPtr NativeFieldInfoPtr_BalanceSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_RequiresPassword;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_byref_NetBufferOut_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_byref_NetBufferIn_Byte_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
      [FieldOffset(0)]
      public int GameVersion;
      [FieldOffset(4)]
      public FixedString512 ServerName;
      [FieldOffset(516)]
      public ushort UsersConnected;
      [FieldOffset(518)]
      public ushort UsersConnectedMax;
      [FieldOffset(520)]
      public ushort UsersTaken;
      [FieldOffset(524)]
      public int InGameDay;
      [FieldOffset(528)]
      public bool HasUser;
      [FieldOffset(529)]
      public ServerActivityLevel ActivityLevel;
      [FieldOffset(532)]
      public ServerGameBalanceSettings BalanceSettings;
      [FieldOffset(1932)]
      public bool RequiresPassword;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1147752, RefRangeEnd = 1147753, XrefRangeStart = 1147742, XrefRangeEnd = 1147752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Serialize(ref NetBufferOut netBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerDiscoveryData.V1.NativeMethodInfoPtr_Serialize_Public_Void_byref_NetBufferOut_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1147768, RefRangeEnd = 1147769, XrefRangeStart = 1147753, XrefRangeEnd = 1147768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Deserialize(ref NetBufferIn netBuffer, byte version)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &version;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerDiscoveryData.V1.NativeMethodInfoPtr_Deserialize_Public_Void_byref_NetBufferIn_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147769, XrefRangeEnd = 1147807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe string ToString()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ServerDiscoveryData.V1.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static V1()
      {
        Il2CppClassPointerStore<ServerDiscoveryData.V1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerDiscoveryData>.NativeClassPtr, nameof (V1));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerDiscoveryData.V1>.NativeClassPtr);
        ServerDiscoveryData.V1.NativeFieldInfoPtr_GameVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDiscoveryData.V1>.NativeClassPtr, nameof (GameVersion));
        ServerDiscoveryData.V1.NativeFieldInfoPtr_ServerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDiscoveryData.V1>.NativeClassPtr, nameof (ServerName));
        ServerDiscoveryData.V1.NativeFieldInfoPtr_UsersConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDiscoveryData.V1>.NativeClassPtr, nameof (UsersConnected));
        ServerDiscoveryData.V1.NativeFieldInfoPtr_UsersConnectedMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDiscoveryData.V1>.NativeClassPtr, nameof (UsersConnectedMax));
        ServerDiscoveryData.V1.NativeFieldInfoPtr_UsersTaken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDiscoveryData.V1>.NativeClassPtr, nameof (UsersTaken));
        ServerDiscoveryData.V1.NativeFieldInfoPtr_InGameDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDiscoveryData.V1>.NativeClassPtr, nameof (InGameDay));
        ServerDiscoveryData.V1.NativeFieldInfoPtr_HasUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDiscoveryData.V1>.NativeClassPtr, nameof (HasUser));
        ServerDiscoveryData.V1.NativeFieldInfoPtr_ActivityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDiscoveryData.V1>.NativeClassPtr, nameof (ActivityLevel));
        ServerDiscoveryData.V1.NativeFieldInfoPtr_BalanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDiscoveryData.V1>.NativeClassPtr, nameof (BalanceSettings));
        ServerDiscoveryData.V1.NativeFieldInfoPtr_RequiresPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDiscoveryData.V1>.NativeClassPtr, nameof (RequiresPassword));
        ServerDiscoveryData.V1.NativeMethodInfoPtr_Serialize_Public_Void_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerDiscoveryData.V1>.NativeClassPtr, 100691186);
        ServerDiscoveryData.V1.NativeMethodInfoPtr_Deserialize_Public_Void_byref_NetBufferIn_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerDiscoveryData.V1>.NativeClassPtr, 100691187);
        ServerDiscoveryData.V1.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerDiscoveryData.V1>.NativeClassPtr, 100691188);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerDiscoveryData.V1>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
