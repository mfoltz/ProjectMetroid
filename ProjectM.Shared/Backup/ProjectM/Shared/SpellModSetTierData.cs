// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModSetTierData
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
  public struct SpellModSetTierData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinSpellMods;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxSpellMods;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinItemLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxItemLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemLevelWeightCurve;
    [FieldOffset(0)]
    public float MinPower;
    [FieldOffset(4)]
    public float MaxPower;
    [FieldOffset(8)]
    public int MinSpellMods;
    [FieldOffset(12)]
    public int MaxSpellMods;
    [FieldOffset(16)]
    public int MinItemLevel;
    [FieldOffset(20)]
    public int MaxItemLevel;
    [FieldOffset(24)]
    public CurveReference ItemLevelWeightCurve;

    static SpellModSetTierData()
    {
      Il2CppClassPointerStore<SpellModSetTierData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SpellModSetTierData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModSetTierData>.NativeClassPtr);
      SpellModSetTierData.NativeFieldInfoPtr_MinPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSetTierData>.NativeClassPtr, nameof (MinPower));
      SpellModSetTierData.NativeFieldInfoPtr_MaxPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSetTierData>.NativeClassPtr, nameof (MaxPower));
      SpellModSetTierData.NativeFieldInfoPtr_MinSpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSetTierData>.NativeClassPtr, nameof (MinSpellMods));
      SpellModSetTierData.NativeFieldInfoPtr_MaxSpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSetTierData>.NativeClassPtr, nameof (MaxSpellMods));
      SpellModSetTierData.NativeFieldInfoPtr_MinItemLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSetTierData>.NativeClassPtr, nameof (MinItemLevel));
      SpellModSetTierData.NativeFieldInfoPtr_MaxItemLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSetTierData>.NativeClassPtr, nameof (MaxItemLevel));
      SpellModSetTierData.NativeFieldInfoPtr_ItemLevelWeightCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSetTierData>.NativeClassPtr, nameof (ItemLevelWeightCurve));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellModSetTierData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
