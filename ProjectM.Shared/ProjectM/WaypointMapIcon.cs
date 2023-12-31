// Decompiled with JetBrains decompiler
// Type: ProjectM.WaypointMapIcon
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using ProjectM.Network;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct WaypointMapIcon
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetNetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsLocked;
    [FieldOffset(0)]
    public NetworkId TargetNetworkId;
    [FieldOffset(8)]
    public bool IsLocked;

    static WaypointMapIcon()
    {
      Il2CppClassPointerStore<WaypointMapIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (WaypointMapIcon));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaypointMapIcon>.NativeClassPtr);
      WaypointMapIcon.NativeFieldInfoPtr_TargetNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointMapIcon>.NativeClassPtr, nameof (TargetNetworkId));
      WaypointMapIcon.NativeFieldInfoPtr_IsLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointMapIcon>.NativeClassPtr, nameof (IsLocked));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WaypointMapIcon>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
