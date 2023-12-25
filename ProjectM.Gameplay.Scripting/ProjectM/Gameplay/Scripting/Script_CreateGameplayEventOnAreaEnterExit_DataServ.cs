// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnAreaEnterExit_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using ProjectM.Scripting;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_CreateGameplayEventOnAreaEnterExit_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_AdditionalExitRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetHitFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnEnterGameplayEventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnExitGameplayEventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExitOnDeath;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreLineOfSight;
    [FieldOffset(0)]
    public float Radius;
    [FieldOffset(4)]
    public float AdditionalExitRadius;
    [FieldOffset(8)]
    public HitFilter TargetHitFilter;
    [FieldOffset(12)]
    public GameplayEventId OnEnterGameplayEventId;
    [FieldOffset(20)]
    public GameplayEventId OnExitGameplayEventId;
    [FieldOffset(28)]
    public bool ExitOnDeath;
    [FieldOffset(29)]
    public bool IgnoreLineOfSight;

    static Script_CreateGameplayEventOnAreaEnterExit_DataServer()
    {
      Il2CppClassPointerStore<Script_CreateGameplayEventOnAreaEnterExit_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_CreateGameplayEventOnAreaEnterExit_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_CreateGameplayEventOnAreaEnterExit_DataServer>.NativeClassPtr);
      Script_CreateGameplayEventOnAreaEnterExit_DataServer.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnAreaEnterExit_DataServer>.NativeClassPtr, nameof (Radius));
      Script_CreateGameplayEventOnAreaEnterExit_DataServer.NativeFieldInfoPtr_AdditionalExitRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnAreaEnterExit_DataServer>.NativeClassPtr, nameof (AdditionalExitRadius));
      Script_CreateGameplayEventOnAreaEnterExit_DataServer.NativeFieldInfoPtr_TargetHitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnAreaEnterExit_DataServer>.NativeClassPtr, nameof (TargetHitFilter));
      Script_CreateGameplayEventOnAreaEnterExit_DataServer.NativeFieldInfoPtr_OnEnterGameplayEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnAreaEnterExit_DataServer>.NativeClassPtr, nameof (OnEnterGameplayEventId));
      Script_CreateGameplayEventOnAreaEnterExit_DataServer.NativeFieldInfoPtr_OnExitGameplayEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnAreaEnterExit_DataServer>.NativeClassPtr, nameof (OnExitGameplayEventId));
      Script_CreateGameplayEventOnAreaEnterExit_DataServer.NativeFieldInfoPtr_ExitOnDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnAreaEnterExit_DataServer>.NativeClassPtr, nameof (ExitOnDeath));
      Script_CreateGameplayEventOnAreaEnterExit_DataServer.NativeFieldInfoPtr_IgnoreLineOfSight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnAreaEnterExit_DataServer>.NativeClassPtr, nameof (IgnoreLineOfSight));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_CreateGameplayEventOnAreaEnterExit_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
