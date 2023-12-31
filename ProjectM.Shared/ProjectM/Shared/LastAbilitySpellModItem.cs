// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.LastAbilitySpellModItem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LastAbilitySpellModItem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellModItem;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellModSetSyncId;
    [FieldOffset(0)]
    public Entity SpellModItem;
    [FieldOffset(8)]
    public int SpellModSetSyncId;

    static LastAbilitySpellModItem()
    {
      Il2CppClassPointerStore<LastAbilitySpellModItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (LastAbilitySpellModItem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LastAbilitySpellModItem>.NativeClassPtr);
      LastAbilitySpellModItem.NativeFieldInfoPtr_SpellModItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LastAbilitySpellModItem>.NativeClassPtr, nameof (SpellModItem));
      LastAbilitySpellModItem.NativeFieldInfoPtr_SpellModSetSyncId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LastAbilitySpellModItem>.NativeClassPtr, nameof (SpellModSetSyncId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LastAbilitySpellModItem>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
