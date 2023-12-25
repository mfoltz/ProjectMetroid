// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_WerewolfChieftain_ToggleGates_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_WerewolfChieftain_ToggleGates_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MakeActivate;
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinionSpawner;
    [FieldOffset(0)]
    public bool MakeActivate;
    [FieldOffset(4)]
    public float Radius;
    [FieldOffset(8)]
    public PrefabGUID MinionSpawner;

    static Script_WerewolfChieftain_ToggleGates_DataShared()
    {
      Il2CppClassPointerStore<Script_WerewolfChieftain_ToggleGates_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_WerewolfChieftain_ToggleGates_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_WerewolfChieftain_ToggleGates_DataShared>.NativeClassPtr);
      Script_WerewolfChieftain_ToggleGates_DataShared.NativeFieldInfoPtr_MakeActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_WerewolfChieftain_ToggleGates_DataShared>.NativeClassPtr, nameof (MakeActivate));
      Script_WerewolfChieftain_ToggleGates_DataShared.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_WerewolfChieftain_ToggleGates_DataShared>.NativeClassPtr, nameof (Radius));
      Script_WerewolfChieftain_ToggleGates_DataShared.NativeFieldInfoPtr_MinionSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_WerewolfChieftain_ToggleGates_DataShared>.NativeClassPtr, nameof (MinionSpawner));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_WerewolfChieftain_ToggleGates_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
