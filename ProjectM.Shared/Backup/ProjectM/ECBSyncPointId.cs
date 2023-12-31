// Decompiled with JetBrains decompiler
// Type: ProjectM.ECBSyncPointId
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ECBSyncPointId
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameSyncPoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameSyncPointCause;
    private static readonly System.IntPtr NativeFieldInfoPtr_HardSyncPoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_HardSyncPointCause;
    [FieldOffset(0)]
    public int FrameSyncPoint;
    [FieldOffset(4)]
    public SystemTypeId FrameSyncPointCause;
    [FieldOffset(8)]
    public int HardSyncPoint;
    [FieldOffset(12)]
    public SystemTypeId HardSyncPointCause;

    static ECBSyncPointId()
    {
      Il2CppClassPointerStore<ECBSyncPointId>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ECBSyncPointId));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ECBSyncPointId>.NativeClassPtr);
      ECBSyncPointId.NativeFieldInfoPtr_FrameSyncPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ECBSyncPointId>.NativeClassPtr, nameof (FrameSyncPoint));
      ECBSyncPointId.NativeFieldInfoPtr_FrameSyncPointCause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ECBSyncPointId>.NativeClassPtr, nameof (FrameSyncPointCause));
      ECBSyncPointId.NativeFieldInfoPtr_HardSyncPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ECBSyncPointId>.NativeClassPtr, nameof (HardSyncPoint));
      ECBSyncPointId.NativeFieldInfoPtr_HardSyncPointCause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ECBSyncPointId>.NativeClassPtr, nameof (HardSyncPointCause));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ECBSyncPointId>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
