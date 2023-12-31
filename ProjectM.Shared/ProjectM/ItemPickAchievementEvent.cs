// Decompiled with JetBrains decompiler
// Type: ProjectM.ItemPickAchievementEvent
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
  public struct ItemPickAchievementEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Item;
    private static readonly System.IntPtr NativeFieldInfoPtr_Amount;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    [FieldOffset(0)]
    public PrefabGUID Item;
    [FieldOffset(4)]
    public int Amount;
    [FieldOffset(8)]
    public Entity Target;

    static ItemPickAchievementEvent()
    {
      Il2CppClassPointerStore<ItemPickAchievementEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ItemPickAchievementEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemPickAchievementEvent>.NativeClassPtr);
      ItemPickAchievementEvent.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickAchievementEvent>.NativeClassPtr, nameof (Item));
      ItemPickAchievementEvent.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickAchievementEvent>.NativeClassPtr, nameof (Amount));
      ItemPickAchievementEvent.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickAchievementEvent>.NativeClassPtr, nameof (Target));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ItemPickAchievementEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
