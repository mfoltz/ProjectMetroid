// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnDetectNoMovementOnTick_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_CreateGameplayEventOnDetectNoMovementOnTick_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayEventId;
    [FieldOffset(0)]
    public float MinDistance;
    [FieldOffset(4)]
    public float3 LastPosition;
    [FieldOffset(16)]
    public GameplayEventId GameplayEventId;

    static Script_CreateGameplayEventOnDetectNoMovementOnTick_DataServer()
    {
      Il2CppClassPointerStore<Script_CreateGameplayEventOnDetectNoMovementOnTick_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_CreateGameplayEventOnDetectNoMovementOnTick_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_CreateGameplayEventOnDetectNoMovementOnTick_DataServer>.NativeClassPtr);
      Script_CreateGameplayEventOnDetectNoMovementOnTick_DataServer.NativeFieldInfoPtr_MinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnDetectNoMovementOnTick_DataServer>.NativeClassPtr, nameof (MinDistance));
      Script_CreateGameplayEventOnDetectNoMovementOnTick_DataServer.NativeFieldInfoPtr_LastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnDetectNoMovementOnTick_DataServer>.NativeClassPtr, nameof (LastPosition));
      Script_CreateGameplayEventOnDetectNoMovementOnTick_DataServer.NativeFieldInfoPtr_GameplayEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnDetectNoMovementOnTick_DataServer>.NativeClassPtr, nameof (GameplayEventId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_CreateGameplayEventOnDetectNoMovementOnTick_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
