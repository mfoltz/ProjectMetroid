// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Buff_ApplyNewBuffOnOwnerDeath_DataServer
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
  public struct Script_Buff_ApplyNewBuffOnOwnerDeath_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnTargetDeathListener;
    [FieldOffset(0)]
    public PrefabGUID Buff;
    [FieldOffset(4)]
    public ListenerId OnTargetDeathListener;

    static Script_Buff_ApplyNewBuffOnOwnerDeath_DataServer()
    {
      Il2CppClassPointerStore<Script_Buff_ApplyNewBuffOnOwnerDeath_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Buff_ApplyNewBuffOnOwnerDeath_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Buff_ApplyNewBuffOnOwnerDeath_DataServer>.NativeClassPtr);
      Script_Buff_ApplyNewBuffOnOwnerDeath_DataServer.NativeFieldInfoPtr_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_ApplyNewBuffOnOwnerDeath_DataServer>.NativeClassPtr, nameof (Buff));
      Script_Buff_ApplyNewBuffOnOwnerDeath_DataServer.NativeFieldInfoPtr_OnTargetDeathListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_ApplyNewBuffOnOwnerDeath_DataServer>.NativeClassPtr, nameof (OnTargetDeathListener));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Buff_ApplyNewBuffOnOwnerDeath_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
