// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.NetSnapshot
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct NetSnapshot
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPrefabGUID_Public_Static_PrefabGUID_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSnapshotType_Public_Static_NetworkSnapshotType_IntPtr_0;
    [FieldOffset(0)]
    public byte Value;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779624, XrefRangeEnd = 779625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PrefabGUID GetPrefabGUID(System.IntPtr snapshotBufferPtr)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &snapshotBufferPtr;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetSnapshot.NativeMethodInfoPtr_GetPrefabGUID_Public_Static_PrefabGUID_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779625, XrefRangeEnd = 779631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NetworkSnapshotType GetSnapshotType(System.IntPtr snapshotBufferPtr)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &snapshotBufferPtr;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetSnapshot.NativeMethodInfoPtr_GetSnapshotType_Public_Static_NetworkSnapshotType_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NetworkSnapshotType*) IL2CPP.il2cpp_object_unbox(num);
    }

    static NetSnapshot()
    {
      Il2CppClassPointerStore<NetSnapshot>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (NetSnapshot));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetSnapshot>.NativeClassPtr);
      NetSnapshot.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetSnapshot>.NativeClassPtr, nameof (Value));
      NetSnapshot.NativeMethodInfoPtr_GetPrefabGUID_Public_Static_PrefabGUID_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetSnapshot>.NativeClassPtr, 100669041);
      NetSnapshot.NativeMethodInfoPtr_GetSnapshotType_Public_Static_NetworkSnapshotType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetSnapshot>.NativeClassPtr, 100669042);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetSnapshot>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
