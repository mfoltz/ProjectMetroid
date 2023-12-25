// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Buff_Reduce_SpellCooldown_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Buff_Reduce_SpellCooldown_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CooldownReduction;
    private static readonly System.IntPtr NativeFieldInfoPtr_CooldownReductionPerStack;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellCooldownModificationId;
    [FieldOffset(0)]
    public float CooldownReduction;
    [FieldOffset(4)]
    public float CooldownReductionPerStack;
    [FieldOffset(8)]
    public ModificationId SpellCooldownModificationId;

    static Buff_Reduce_SpellCooldown_DataShared()
    {
      Il2CppClassPointerStore<Buff_Reduce_SpellCooldown_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Buff_Reduce_SpellCooldown_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Buff_Reduce_SpellCooldown_DataShared>.NativeClassPtr);
      Buff_Reduce_SpellCooldown_DataShared.NativeFieldInfoPtr_CooldownReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_Reduce_SpellCooldown_DataShared>.NativeClassPtr, nameof (CooldownReduction));
      Buff_Reduce_SpellCooldown_DataShared.NativeFieldInfoPtr_CooldownReductionPerStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_Reduce_SpellCooldown_DataShared>.NativeClassPtr, nameof (CooldownReductionPerStack));
      Buff_Reduce_SpellCooldown_DataShared.NativeFieldInfoPtr_SpellCooldownModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_Reduce_SpellCooldown_DataShared>.NativeClassPtr, nameof (SpellCooldownModificationId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Buff_Reduce_SpellCooldown_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
