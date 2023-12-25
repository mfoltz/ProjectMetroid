// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_GarlicFeverDebuff_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_GarlicFeverDebuff_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorModificationId;
    [FieldOffset(0)]
    public float WeaponLevel;
    [FieldOffset(4)]
    public ModificationId WeaponModificationId;
    [FieldOffset(8)]
    public float SpellLevel;
    [FieldOffset(12)]
    public ModificationId SpellModificationId;
    [FieldOffset(16)]
    public float ArmorLevel;
    [FieldOffset(20)]
    public ModificationId ArmorModificationId;

    static Script_GarlicFeverDebuff_DataServer()
    {
      Il2CppClassPointerStore<Script_GarlicFeverDebuff_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_GarlicFeverDebuff_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_GarlicFeverDebuff_DataServer>.NativeClassPtr);
      Script_GarlicFeverDebuff_DataServer.NativeFieldInfoPtr_WeaponLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_GarlicFeverDebuff_DataServer>.NativeClassPtr, nameof (WeaponLevel));
      Script_GarlicFeverDebuff_DataServer.NativeFieldInfoPtr_WeaponModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_GarlicFeverDebuff_DataServer>.NativeClassPtr, nameof (WeaponModificationId));
      Script_GarlicFeverDebuff_DataServer.NativeFieldInfoPtr_SpellLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_GarlicFeverDebuff_DataServer>.NativeClassPtr, nameof (SpellLevel));
      Script_GarlicFeverDebuff_DataServer.NativeFieldInfoPtr_SpellModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_GarlicFeverDebuff_DataServer>.NativeClassPtr, nameof (SpellModificationId));
      Script_GarlicFeverDebuff_DataServer.NativeFieldInfoPtr_ArmorLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_GarlicFeverDebuff_DataServer>.NativeClassPtr, nameof (ArmorLevel));
      Script_GarlicFeverDebuff_DataServer.NativeFieldInfoPtr_ArmorModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_GarlicFeverDebuff_DataServer>.NativeClassPtr, nameof (ArmorModificationId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_GarlicFeverDebuff_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
