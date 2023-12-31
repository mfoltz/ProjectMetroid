// Decompiled with JetBrains decompiler
// Type: ProjectM.ConnectAddressUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;

#nullable disable
namespace ProjectM
{
  public static class ConnectAddressUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateIPv4_Public_Static_ConnectAddress_String_UInt16_Boolean_0;

    [CallerCount(17)]
    [CachedScanResults(RefRangeStart = 751018, RefRangeEnd = 751035, XrefRangeStart = 751015, XrefRangeEnd = 751018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ConnectAddress CreateIPv4(string address, ushort port, bool useLidgren = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(address);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &port;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &useLidgren;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConnectAddressUtility.NativeMethodInfoPtr_CreateIPv4_Public_Static_ConnectAddress_String_UInt16_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ConnectAddress*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ConnectAddressUtility()
    {
      Il2CppClassPointerStore<ConnectAddressUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ConnectAddressUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectAddressUtility>.NativeClassPtr);
      ConnectAddressUtility.NativeMethodInfoPtr_CreateIPv4_Public_Static_ConnectAddress_String_UInt16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectAddressUtility>.NativeClassPtr, 100666130);
    }

    public ConnectAddressUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
