// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.NetworkSnapshot
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
  public struct NetworkSnapshot
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkSnapshotType_0;
    [FieldOffset(0)]
    public readonly NetworkSnapshotType Type;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 184798, RefRangeEnd = 184809, XrefRangeStart = 184798, XrefRangeEnd = 184809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NetworkSnapshot(NetworkSnapshotType type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &type;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSnapshot.NativeMethodInfoPtr__ctor_Public_Void_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NetworkSnapshot()
    {
      Il2CppClassPointerStore<NetworkSnapshot>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (NetworkSnapshot));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkSnapshot>.NativeClassPtr);
      NetworkSnapshot.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkSnapshot>.NativeClassPtr, nameof (Type));
      NetworkSnapshot.NativeMethodInfoPtr__ctor_Public_Void_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshot>.NativeClassPtr, 100669121);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkSnapshot>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
