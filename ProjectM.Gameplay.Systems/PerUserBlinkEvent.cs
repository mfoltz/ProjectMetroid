// Decompiled with JetBrains decompiler
// Type: ProjectM.PerUserBlinkEvent
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Runtime;
using ProjectM.Network;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PerUserBlinkEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UserIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetNetworkId;
    [FieldOffset(0)]
    public int UserIndex;
    [FieldOffset(4)]
    public NetworkId TargetNetworkId;

    static PerUserBlinkEvent()
    {
      Il2CppClassPointerStore<PerUserBlinkEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (PerUserBlinkEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PerUserBlinkEvent>.NativeClassPtr);
      PerUserBlinkEvent.NativeFieldInfoPtr_UserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerUserBlinkEvent>.NativeClassPtr, nameof (UserIndex));
      PerUserBlinkEvent.NativeFieldInfoPtr_TargetNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerUserBlinkEvent>.NativeClassPtr, nameof (TargetNetworkId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PerUserBlinkEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
