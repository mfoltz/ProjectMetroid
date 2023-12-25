// Decompiled with JetBrains decompiler
// Type: ProjectM.HailMessageStruct_Server
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HailMessageStruct_Server
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_VERSION;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerTimeUnmodified;
    private static readonly System.IntPtr NativeFieldInfoPtr_BalanceSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrimaryAddress;
    private static readonly System.IntPtr NativeFieldInfoPtr_SecondaryAddress;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_SessionGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserGeneration;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryPort;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReceivedVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasPassword;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShouldCreateCharacter;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_HailMessageStruct_Server_byref_NetBufferOut_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_Boolean_byref_NetBufferIn_byref_HailMessageStruct_Server_0;
    [FieldOffset(0)]
    public double ServerTimeUnmodified;
    [FieldOffset(8)]
    public ServerGameBalanceSettings BalanceSettings;
    [FieldOffset(1408)]
    public ConnectAddress PrimaryAddress;
    [FieldOffset(1456)]
    public ConnectAddress SecondaryAddress;
    [FieldOffset(1504)]
    public FixedString512 Name;
    [FieldOffset(2016)]
    public Il2CppSystem.Guid SessionGuid;
    [FieldOffset(2032)]
    public int UserIndex;
    [FieldOffset(2036)]
    public int UserGeneration;
    [FieldOffset(2040)]
    public ushort QueryPort;
    [FieldOffset(2042)]
    public byte ReceivedVersion;
    [FieldOffset(2043)]
    public bool HasPassword;
    [FieldOffset(2044)]
    public bool ShouldCreateCharacter;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978914, XrefRangeEnd = 978929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Serialize(
      [In] ref HailMessageStruct_Server data,
      ref NetBufferOut netBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HailMessageStruct_Server.NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_HailMessageStruct_Server_byref_NetBufferOut_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 978949, RefRangeEnd = 978950, XrefRangeStart = 978929, XrefRangeEnd = 978949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Deserialize(
      ref NetBufferIn netBufferIn,
      out HailMessageStruct_Server hailData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBufferIn;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hailData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HailMessageStruct_Server.NativeMethodInfoPtr_Deserialize_Public_Static_Boolean_byref_NetBufferIn_byref_HailMessageStruct_Server_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static HailMessageStruct_Server()
    {
      Il2CppClassPointerStore<HailMessageStruct_Server>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (HailMessageStruct_Server));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HailMessageStruct_Server>.NativeClassPtr);
      HailMessageStruct_Server.NativeFieldInfoPtr_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HailMessageStruct_Server>.NativeClassPtr, nameof (VERSION));
      HailMessageStruct_Server.NativeFieldInfoPtr_ServerTimeUnmodified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HailMessageStruct_Server>.NativeClassPtr, nameof (ServerTimeUnmodified));
      HailMessageStruct_Server.NativeFieldInfoPtr_BalanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HailMessageStruct_Server>.NativeClassPtr, nameof (BalanceSettings));
      HailMessageStruct_Server.NativeFieldInfoPtr_PrimaryAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HailMessageStruct_Server>.NativeClassPtr, nameof (PrimaryAddress));
      HailMessageStruct_Server.NativeFieldInfoPtr_SecondaryAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HailMessageStruct_Server>.NativeClassPtr, nameof (SecondaryAddress));
      HailMessageStruct_Server.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HailMessageStruct_Server>.NativeClassPtr, nameof (Name));
      HailMessageStruct_Server.NativeFieldInfoPtr_SessionGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HailMessageStruct_Server>.NativeClassPtr, nameof (SessionGuid));
      HailMessageStruct_Server.NativeFieldInfoPtr_UserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HailMessageStruct_Server>.NativeClassPtr, nameof (UserIndex));
      HailMessageStruct_Server.NativeFieldInfoPtr_UserGeneration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HailMessageStruct_Server>.NativeClassPtr, nameof (UserGeneration));
      HailMessageStruct_Server.NativeFieldInfoPtr_QueryPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HailMessageStruct_Server>.NativeClassPtr, nameof (QueryPort));
      HailMessageStruct_Server.NativeFieldInfoPtr_ReceivedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HailMessageStruct_Server>.NativeClassPtr, nameof (ReceivedVersion));
      HailMessageStruct_Server.NativeFieldInfoPtr_HasPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HailMessageStruct_Server>.NativeClassPtr, nameof (HasPassword));
      HailMessageStruct_Server.NativeFieldInfoPtr_ShouldCreateCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HailMessageStruct_Server>.NativeClassPtr, nameof (ShouldCreateCharacter));
      HailMessageStruct_Server.NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_HailMessageStruct_Server_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HailMessageStruct_Server>.NativeClassPtr, 100675625);
      HailMessageStruct_Server.NativeMethodInfoPtr_Deserialize_Public_Static_Boolean_byref_NetBufferIn_byref_HailMessageStruct_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HailMessageStruct_Server>.NativeClassPtr, 100675626);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HailMessageStruct_Server>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe byte VERSION
    {
      get
      {
        byte version;
        IL2CPP.il2cpp_field_static_get_value(HailMessageStruct_Server.NativeFieldInfoPtr_VERSION, (void*) &version);
        return version;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HailMessageStruct_Server.NativeFieldInfoPtr_VERSION, (void*) &value);
      }
    }
  }
}
