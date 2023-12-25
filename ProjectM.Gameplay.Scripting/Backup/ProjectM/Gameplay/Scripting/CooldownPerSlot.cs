// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.CooldownPerSlot
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct CooldownPerSlot
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SlotIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Cooldown;
    [FieldOffset(0)]
    public int SlotIndex;
    [FieldOffset(4)]
    public float Cooldown;

    static CooldownPerSlot()
    {
      Il2CppClassPointerStore<CooldownPerSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (CooldownPerSlot));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CooldownPerSlot>.NativeClassPtr);
      CooldownPerSlot.NativeFieldInfoPtr_SlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CooldownPerSlot>.NativeClassPtr, nameof (SlotIndex));
      CooldownPerSlot.NativeFieldInfoPtr_Cooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CooldownPerSlot>.NativeClassPtr, nameof (Cooldown));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CooldownPerSlot>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
