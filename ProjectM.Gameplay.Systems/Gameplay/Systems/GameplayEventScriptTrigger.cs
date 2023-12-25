// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Systems.GameplayEventScriptTrigger
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Systems
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GameplayEventScriptTrigger
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ScriptReference;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayEvent;
    [FieldOffset(0)]
    public ScriptMethodReference ScriptReference;
    [FieldOffset(128)]
    public GameplayEvent GameplayEvent;

    static GameplayEventScriptTrigger()
    {
      Il2CppClassPointerStore<GameplayEventScriptTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay.Systems", nameof (GameplayEventScriptTrigger));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayEventScriptTrigger>.NativeClassPtr);
      GameplayEventScriptTrigger.NativeFieldInfoPtr_ScriptReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventScriptTrigger>.NativeClassPtr, nameof (ScriptReference));
      GameplayEventScriptTrigger.NativeFieldInfoPtr_GameplayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventScriptTrigger>.NativeClassPtr, nameof (GameplayEvent));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayEventScriptTrigger>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
