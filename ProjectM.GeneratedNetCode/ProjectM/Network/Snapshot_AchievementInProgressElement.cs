// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_AchievementInProgressElement
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_AchievementInProgressElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AchievementPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompletedAmount;
    [FieldOffset(0)]
    public PrefabGUID AchievementPrefabGuid;
    [FieldOffset(4)]
    public int CompletedAmount;

    static Snapshot_AchievementInProgressElement()
    {
      Il2CppClassPointerStore<Snapshot_AchievementInProgressElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_AchievementInProgressElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_AchievementInProgressElement>.NativeClassPtr);
      Snapshot_AchievementInProgressElement.NativeFieldInfoPtr_AchievementPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_AchievementInProgressElement>.NativeClassPtr, nameof (AchievementPrefabGuid));
      Snapshot_AchievementInProgressElement.NativeFieldInfoPtr_CompletedAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_AchievementInProgressElement>.NativeClassPtr, nameof (CompletedAmount));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_AchievementInProgressElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
