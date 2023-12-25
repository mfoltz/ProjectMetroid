// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ItemLevel
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ItemLevel
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_IsWeapon;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsGrimoire;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsJewel;
    private static readonly System.IntPtr NativeFieldInfoPtr_Level;
    [FieldOffset(0)]
    public bool IsWeapon;
    [FieldOffset(1)]
    public bool IsGrimoire;
    [FieldOffset(2)]
    public bool IsJewel;
    [FieldOffset(4)]
    public float Level;

    static ItemLevel()
    {
      Il2CppClassPointerStore<ItemLevel>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ItemLevel));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemLevel>.NativeClassPtr);
      ItemLevel.NativeFieldInfoPtr_IsWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemLevel>.NativeClassPtr, nameof (IsWeapon));
      ItemLevel.NativeFieldInfoPtr_IsGrimoire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemLevel>.NativeClassPtr, nameof (IsGrimoire));
      ItemLevel.NativeFieldInfoPtr_IsJewel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemLevel>.NativeClassPtr, nameof (IsJewel));
      ItemLevel.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemLevel>.NativeClassPtr, nameof (Level));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ItemLevel>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
