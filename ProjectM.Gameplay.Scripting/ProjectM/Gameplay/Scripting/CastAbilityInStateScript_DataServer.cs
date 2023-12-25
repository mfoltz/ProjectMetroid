// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.CastAbilityInStateScript_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastAbilityInStateScript_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_State;
    [FieldOffset(0)]
    public int AbilityIndex;
    [FieldOffset(4)]
    public GenericEnemyState State;

    static CastAbilityInStateScript_DataServer()
    {
      Il2CppClassPointerStore<CastAbilityInStateScript_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (CastAbilityInStateScript_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastAbilityInStateScript_DataServer>.NativeClassPtr);
      CastAbilityInStateScript_DataServer.NativeFieldInfoPtr_AbilityIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastAbilityInStateScript_DataServer>.NativeClassPtr, nameof (AbilityIndex));
      CastAbilityInStateScript_DataServer.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastAbilityInStateScript_DataServer>.NativeClassPtr, nameof (State));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastAbilityInStateScript_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
