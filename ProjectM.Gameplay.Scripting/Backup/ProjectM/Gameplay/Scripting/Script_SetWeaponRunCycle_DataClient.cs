// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_SetWeaponRunCycle_DataClient
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_SetWeaponRunCycle_DataClient
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponType;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponRunCycleModificationId;
    [FieldOffset(0)]
    public WeaponType WeaponType;
    [FieldOffset(4)]
    public ModificationId WeaponRunCycleModificationId;

    static Script_SetWeaponRunCycle_DataClient()
    {
      Il2CppClassPointerStore<Script_SetWeaponRunCycle_DataClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_SetWeaponRunCycle_DataClient));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_SetWeaponRunCycle_DataClient>.NativeClassPtr);
      Script_SetWeaponRunCycle_DataClient.NativeFieldInfoPtr_WeaponType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SetWeaponRunCycle_DataClient>.NativeClassPtr, nameof (WeaponType));
      Script_SetWeaponRunCycle_DataClient.NativeFieldInfoPtr_WeaponRunCycleModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SetWeaponRunCycle_DataClient>.NativeClassPtr, nameof (WeaponRunCycleModificationId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_SetWeaponRunCycle_DataClient>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
