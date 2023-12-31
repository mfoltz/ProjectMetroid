// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityCastUpdateData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityCastUpdateData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Character;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_Ability;
    private static readonly System.IntPtr NativeFieldInfoPtr_SlotIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsPostCasting;
    [FieldOffset(0)]
    public Entity Character;
    [FieldOffset(8)]
    public Entity AbilityGroup;
    [FieldOffset(16)]
    public Entity Ability;
    [FieldOffset(24)]
    public int SlotIndex;
    [FieldOffset(28)]
    public bool IsPostCasting;

    static AbilityCastUpdateData()
    {
      Il2CppClassPointerStore<AbilityCastUpdateData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AbilityCastUpdateData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityCastUpdateData>.NativeClassPtr);
      AbilityCastUpdateData.NativeFieldInfoPtr_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastUpdateData>.NativeClassPtr, nameof (Character));
      AbilityCastUpdateData.NativeFieldInfoPtr_AbilityGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastUpdateData>.NativeClassPtr, nameof (AbilityGroup));
      AbilityCastUpdateData.NativeFieldInfoPtr_Ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastUpdateData>.NativeClassPtr, nameof (Ability));
      AbilityCastUpdateData.NativeFieldInfoPtr_SlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastUpdateData>.NativeClassPtr, nameof (SlotIndex));
      AbilityCastUpdateData.NativeFieldInfoPtr_IsPostCasting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastUpdateData>.NativeClassPtr, nameof (IsPostCasting));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityCastUpdateData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
