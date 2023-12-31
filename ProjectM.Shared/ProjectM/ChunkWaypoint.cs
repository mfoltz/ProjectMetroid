// Decompiled with JetBrains decompiler
// Type: ProjectM.ChunkWaypoint
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ChunkWaypoint
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultUnlocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsLocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomTeleportBuff;
    [FieldOffset(0)]
    public bool DefaultUnlocked;
    [FieldOffset(1)]
    public bool IsLocked;
    [FieldOffset(4)]
    public PrefabGUID CustomTeleportBuff;

    static ChunkWaypoint()
    {
      Il2CppClassPointerStore<ChunkWaypoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ChunkWaypoint));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkWaypoint>.NativeClassPtr);
      ChunkWaypoint.NativeFieldInfoPtr_DefaultUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkWaypoint>.NativeClassPtr, nameof (DefaultUnlocked));
      ChunkWaypoint.NativeFieldInfoPtr_IsLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkWaypoint>.NativeClassPtr, nameof (IsLocked));
      ChunkWaypoint.NativeFieldInfoPtr_CustomTeleportBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkWaypoint>.NativeClassPtr, nameof (CustomTeleportBuff));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkWaypoint>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
