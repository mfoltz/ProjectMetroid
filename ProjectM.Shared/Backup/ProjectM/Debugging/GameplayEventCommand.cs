// Decompiled with JetBrains decompiler
// Type: ProjectM.Debugging.GameplayEventCommand
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Debugging
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GameplayEventCommand
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayEventType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Listener;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayEventResultData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResultEnum;
    [FieldOffset(0)]
    public GameplayEventTypeEnum GameplayEventType;
    [FieldOffset(4)]
    public Entity Listener;
    [FieldOffset(12)]
    public GameplayEventResultData GameplayEventResultData;
    [FieldOffset(32)]
    public GameplayEventResultEnum ResultEnum;

    static GameplayEventCommand()
    {
      Il2CppClassPointerStore<GameplayEventCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Debugging", nameof (GameplayEventCommand));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayEventCommand>.NativeClassPtr);
      GameplayEventCommand.NativeFieldInfoPtr_GameplayEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventCommand>.NativeClassPtr, nameof (GameplayEventType));
      GameplayEventCommand.NativeFieldInfoPtr_Listener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventCommand>.NativeClassPtr, nameof (Listener));
      GameplayEventCommand.NativeFieldInfoPtr_GameplayEventResultData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventCommand>.NativeClassPtr, nameof (GameplayEventResultData));
      GameplayEventCommand.NativeFieldInfoPtr_ResultEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventCommand>.NativeClassPtr, nameof (ResultEnum));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayEventCommand>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
