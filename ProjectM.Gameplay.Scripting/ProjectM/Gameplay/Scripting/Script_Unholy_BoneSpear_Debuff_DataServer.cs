// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Unholy_BoneSpear_Debuff_DataServer
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
  public struct Script_Unholy_BoneSpear_Debuff_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AmplifyFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnDamageTakenListener;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnTargetDeathListener;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnSpellType;
    [FieldOffset(0)]
    public float AmplifyFactor;
    [FieldOffset(4)]
    public ListenerId OnDamageTakenListener;
    [FieldOffset(12)]
    public ListenerId OnTargetDeathListener;
    [FieldOffset(20)]
    public PrefabGUID SpawnSpellType;

    static Script_Unholy_BoneSpear_Debuff_DataServer()
    {
      Il2CppClassPointerStore<Script_Unholy_BoneSpear_Debuff_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Unholy_BoneSpear_Debuff_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Debuff_DataServer>.NativeClassPtr);
      Script_Unholy_BoneSpear_Debuff_DataServer.NativeFieldInfoPtr_AmplifyFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Debuff_DataServer>.NativeClassPtr, nameof (AmplifyFactor));
      Script_Unholy_BoneSpear_Debuff_DataServer.NativeFieldInfoPtr_OnDamageTakenListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Debuff_DataServer>.NativeClassPtr, nameof (OnDamageTakenListener));
      Script_Unholy_BoneSpear_Debuff_DataServer.NativeFieldInfoPtr_OnTargetDeathListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Debuff_DataServer>.NativeClassPtr, nameof (OnTargetDeathListener));
      Script_Unholy_BoneSpear_Debuff_DataServer.NativeFieldInfoPtr_SpawnSpellType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Debuff_DataServer>.NativeClassPtr, nameof (SpawnSpellType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Debuff_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
