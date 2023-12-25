// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ActionBarDragData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ActionBarDragData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemId;
    private static readonly System.IntPtr NativeFieldInfoPtr_SlotIndex;
    [FieldOffset(0)]
    public Entity ItemEntity;
    [FieldOffset(8)]
    public PrefabGUID ItemId;
    [FieldOffset(12)]
    public int SlotIndex;

    static ActionBarDragData()
    {
      Il2CppClassPointerStore<ActionBarDragData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ActionBarDragData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionBarDragData>.NativeClassPtr);
      ActionBarDragData.NativeFieldInfoPtr_ItemEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarDragData>.NativeClassPtr, nameof (ItemEntity));
      ActionBarDragData.NativeFieldInfoPtr_ItemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarDragData>.NativeClassPtr, nameof (ItemId));
      ActionBarDragData.NativeFieldInfoPtr_SlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarDragData>.NativeClassPtr, nameof (SlotIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ActionBarDragData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
