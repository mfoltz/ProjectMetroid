// Decompiled with JetBrains decompiler
// Type: ProjectM.UserInfoElement_ServerToClient
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Network;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UserInfoElement_ServerToClient
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlatformId;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsAdmin;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_byref_NetBufferOut_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_UserInfoElement_ServerToClient_byref_NetBufferIn_0;
    [FieldOffset(0)]
    public FixedString64 Name;
    [FieldOffset(64)]
    public ulong PlatformId;
    [FieldOffset(72)]
    public NetworkId NetworkId;
    [FieldOffset(80)]
    public bool IsAdmin;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 763110, RefRangeEnd = 763113, XrefRangeStart = 763103, XrefRangeEnd = 763110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Serialize(ref NetBufferOut netBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserInfoElement_ServerToClient.NativeMethodInfoPtr_Serialize_Public_Void_byref_NetBufferOut_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 763120, RefRangeEnd = 763123, XrefRangeStart = 763113, XrefRangeEnd = 763120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe UserInfoElement_ServerToClient Deserialize(ref NetBufferIn netBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserInfoElement_ServerToClient.NativeMethodInfoPtr_Deserialize_Public_Static_UserInfoElement_ServerToClient_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(UserInfoElement_ServerToClient*) IL2CPP.il2cpp_object_unbox(num);
    }

    static UserInfoElement_ServerToClient()
    {
      Il2CppClassPointerStore<UserInfoElement_ServerToClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UserInfoElement_ServerToClient));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserInfoElement_ServerToClient>.NativeClassPtr);
      UserInfoElement_ServerToClient.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoElement_ServerToClient>.NativeClassPtr, nameof (Name));
      UserInfoElement_ServerToClient.NativeFieldInfoPtr_PlatformId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoElement_ServerToClient>.NativeClassPtr, nameof (PlatformId));
      UserInfoElement_ServerToClient.NativeFieldInfoPtr_NetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoElement_ServerToClient>.NativeClassPtr, nameof (NetworkId));
      UserInfoElement_ServerToClient.NativeFieldInfoPtr_IsAdmin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoElement_ServerToClient>.NativeClassPtr, nameof (IsAdmin));
      UserInfoElement_ServerToClient.NativeMethodInfoPtr_Serialize_Public_Void_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoElement_ServerToClient>.NativeClassPtr, 100667418);
      UserInfoElement_ServerToClient.NativeMethodInfoPtr_Deserialize_Public_Static_UserInfoElement_ServerToClient_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoElement_ServerToClient>.NativeClassPtr, 100667419);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserInfoElement_ServerToClient>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
