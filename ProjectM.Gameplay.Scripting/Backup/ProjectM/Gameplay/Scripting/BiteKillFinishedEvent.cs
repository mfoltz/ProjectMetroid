// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.BiteKillFinishedEvent
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BiteKillFinishedEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Player;
    private static readonly System.IntPtr NativeFieldInfoPtr_Victim;
    [FieldOffset(0)]
    public Entity Player;
    [FieldOffset(8)]
    public Entity Victim;

    static BiteKillFinishedEvent()
    {
      Il2CppClassPointerStore<BiteKillFinishedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (BiteKillFinishedEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BiteKillFinishedEvent>.NativeClassPtr);
      BiteKillFinishedEvent.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BiteKillFinishedEvent>.NativeClassPtr, nameof (Player));
      BiteKillFinishedEvent.NativeFieldInfoPtr_Victim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BiteKillFinishedEvent>.NativeClassPtr, nameof (Victim));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BiteKillFinishedEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
