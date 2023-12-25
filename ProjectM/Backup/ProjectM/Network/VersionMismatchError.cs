// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.VersionMismatchError
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct VersionMismatchError
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClientVersion;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_VersionMismatchError_String_0;
    [FieldOffset(0)]
    public int ServerVersion;
    [FieldOffset(4)]
    public int ClientVersion;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1153795, RefRangeEnd = 1153796, XrefRangeStart = 1153787, XrefRangeEnd = 1153795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string Serialize()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(VersionMismatchError.NativeMethodInfoPtr_Serialize_Public_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1153803, RefRangeEnd = 1153804, XrefRangeStart = 1153796, XrefRangeEnd = 1153803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe VersionMismatchError Deserialize(string data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(data);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VersionMismatchError.NativeMethodInfoPtr_Deserialize_Public_Static_VersionMismatchError_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(VersionMismatchError*) IL2CPP.il2cpp_object_unbox(num);
    }

    static VersionMismatchError()
    {
      Il2CppClassPointerStore<VersionMismatchError>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (VersionMismatchError));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionMismatchError>.NativeClassPtr);
      VersionMismatchError.NativeFieldInfoPtr_ServerVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionMismatchError>.NativeClassPtr, nameof (ServerVersion));
      VersionMismatchError.NativeFieldInfoPtr_ClientVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionMismatchError>.NativeClassPtr, nameof (ClientVersion));
      VersionMismatchError.NativeMethodInfoPtr_Serialize_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionMismatchError>.NativeClassPtr, 100691748);
      VersionMismatchError.NativeMethodInfoPtr_Deserialize_Public_Static_VersionMismatchError_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionMismatchError>.NativeClassPtr, 100691749);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VersionMismatchError>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
