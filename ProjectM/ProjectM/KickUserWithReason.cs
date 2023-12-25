// Decompiled with JetBrains decompiler
// Type: ProjectM.KickUserWithReason
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct KickUserWithReason
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PlatformId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Reason;
    private static readonly System.IntPtr NativeFieldInfoPtr_LogIfNotFound;
    [FieldOffset(0)]
    public ulong PlatformId;
    [FieldOffset(8)]
    public ConnectionStatusChangeReason Reason;
    [FieldOffset(9)]
    public bool LogIfNotFound;

    static KickUserWithReason()
    {
      Il2CppClassPointerStore<KickUserWithReason>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (KickUserWithReason));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KickUserWithReason>.NativeClassPtr);
      KickUserWithReason.NativeFieldInfoPtr_PlatformId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KickUserWithReason>.NativeClassPtr, nameof (PlatformId));
      KickUserWithReason.NativeFieldInfoPtr_Reason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KickUserWithReason>.NativeClassPtr, nameof (Reason));
      KickUserWithReason.NativeFieldInfoPtr_LogIfNotFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KickUserWithReason>.NativeClassPtr, nameof (LogIfNotFound));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KickUserWithReason>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
