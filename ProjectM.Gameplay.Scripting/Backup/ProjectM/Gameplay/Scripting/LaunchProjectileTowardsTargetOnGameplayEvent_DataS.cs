// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.LaunchProjectileTowardsTargetOnGameplayEvent_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LaunchProjectileTowardsTargetOnGameplayEvent_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NewProjectileEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxTriggers;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentTriggers;
    [FieldOffset(0)]
    public PrefabGUID NewProjectileEntity;
    [FieldOffset(4)]
    public int MaxTriggers;
    [FieldOffset(8)]
    public int CurrentTriggers;

    static LaunchProjectileTowardsTargetOnGameplayEvent_DataServer()
    {
      Il2CppClassPointerStore<LaunchProjectileTowardsTargetOnGameplayEvent_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (LaunchProjectileTowardsTargetOnGameplayEvent_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LaunchProjectileTowardsTargetOnGameplayEvent_DataServer>.NativeClassPtr);
      LaunchProjectileTowardsTargetOnGameplayEvent_DataServer.NativeFieldInfoPtr_NewProjectileEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchProjectileTowardsTargetOnGameplayEvent_DataServer>.NativeClassPtr, nameof (NewProjectileEntity));
      LaunchProjectileTowardsTargetOnGameplayEvent_DataServer.NativeFieldInfoPtr_MaxTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchProjectileTowardsTargetOnGameplayEvent_DataServer>.NativeClassPtr, nameof (MaxTriggers));
      LaunchProjectileTowardsTargetOnGameplayEvent_DataServer.NativeFieldInfoPtr_CurrentTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchProjectileTowardsTargetOnGameplayEvent_DataServer>.NativeClassPtr, nameof (CurrentTriggers));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LaunchProjectileTowardsTargetOnGameplayEvent_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
