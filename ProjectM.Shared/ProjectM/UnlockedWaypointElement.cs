// Decompiled with JetBrains decompiler
// Type: ProjectM.UnlockedWaypointElement
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
  public struct UnlockedWaypointElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Waypoint;
    [FieldOffset(0)]
    public NetworkId Waypoint;

    static UnlockedWaypointElement()
    {
      Il2CppClassPointerStore<UnlockedWaypointElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UnlockedWaypointElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnlockedWaypointElement>.NativeClassPtr);
      UnlockedWaypointElement.NativeFieldInfoPtr_Waypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockedWaypointElement>.NativeClassPtr, nameof (Waypoint));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnlockedWaypointElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
