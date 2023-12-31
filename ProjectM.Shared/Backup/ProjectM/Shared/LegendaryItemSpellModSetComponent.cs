// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.LegendaryItemSpellModSetComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LegendaryItemSpellModSetComponent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StatMods;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityMods0;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityMods1;
    [FieldOffset(0)]
    public SpellModSet StatMods;
    [FieldOffset(72)]
    public SpellModSet AbilityMods0;
    [FieldOffset(144)]
    public SpellModSet AbilityMods1;

    static LegendaryItemSpellModSetComponent()
    {
      Il2CppClassPointerStore<LegendaryItemSpellModSetComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (LegendaryItemSpellModSetComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegendaryItemSpellModSetComponent>.NativeClassPtr);
      LegendaryItemSpellModSetComponent.NativeFieldInfoPtr_StatMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegendaryItemSpellModSetComponent>.NativeClassPtr, nameof (StatMods));
      LegendaryItemSpellModSetComponent.NativeFieldInfoPtr_AbilityMods0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegendaryItemSpellModSetComponent>.NativeClassPtr, nameof (AbilityMods0));
      LegendaryItemSpellModSetComponent.NativeFieldInfoPtr_AbilityMods1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegendaryItemSpellModSetComponent>.NativeClassPtr, nameof (AbilityMods1));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LegendaryItemSpellModSetComponent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
