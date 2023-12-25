// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Demount_DataServer
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
  public struct Script_Demount_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DemountMinDamageFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnDamageTakenListener;
    private static readonly System.IntPtr NativeFieldInfoPtr_DemountSpellType;
    [FieldOffset(0)]
    public float DemountMinDamageFactor;
    [FieldOffset(4)]
    public ListenerId OnDamageTakenListener;
    [FieldOffset(12)]
    public PrefabGUID DemountSpellType;

    static Script_Demount_DataServer()
    {
      Il2CppClassPointerStore<Script_Demount_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Demount_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Demount_DataServer>.NativeClassPtr);
      Script_Demount_DataServer.NativeFieldInfoPtr_DemountMinDamageFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Demount_DataServer>.NativeClassPtr, nameof (DemountMinDamageFactor));
      Script_Demount_DataServer.NativeFieldInfoPtr_OnDamageTakenListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Demount_DataServer>.NativeClassPtr, nameof (OnDamageTakenListener));
      Script_Demount_DataServer.NativeFieldInfoPtr_DemountSpellType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Demount_DataServer>.NativeClassPtr, nameof (DemountSpellType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Demount_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
