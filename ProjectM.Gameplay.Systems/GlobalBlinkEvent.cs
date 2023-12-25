// Decompiled with JetBrains decompiler
// Type: ProjectM.GlobalBlinkEvent
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Runtime;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GlobalBlinkEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetNetworkId;
    [FieldOffset(0)]
    public float3 Position;
    [FieldOffset(12)]
    public NetworkId TargetNetworkId;

    static GlobalBlinkEvent()
    {
      Il2CppClassPointerStore<GlobalBlinkEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (GlobalBlinkEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalBlinkEvent>.NativeClassPtr);
      GlobalBlinkEvent.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalBlinkEvent>.NativeClassPtr, nameof (Position));
      GlobalBlinkEvent.NativeFieldInfoPtr_TargetNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalBlinkEvent>.NativeClassPtr, nameof (TargetNetworkId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalBlinkEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
