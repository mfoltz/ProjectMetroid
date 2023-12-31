// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModWeaponTypeData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct SpellModWeaponTypeData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinItemLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponType;
    [FieldOffset(0)]
    public int MinItemLevel;
    [FieldOffset(4)]
    public WeaponType WeaponType;

    static SpellModWeaponTypeData()
    {
      Il2CppClassPointerStore<SpellModWeaponTypeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SpellModWeaponTypeData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModWeaponTypeData>.NativeClassPtr);
      SpellModWeaponTypeData.NativeFieldInfoPtr_MinItemLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModWeaponTypeData>.NativeClassPtr, nameof (MinItemLevel));
      SpellModWeaponTypeData.NativeFieldInfoPtr_WeaponType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModWeaponTypeData>.NativeClassPtr, nameof (WeaponType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellModWeaponTypeData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
