// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.AbilityDragData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityDragData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityId;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityType;
    [FieldOffset(0)]
    public PrefabGUID AbilityId;
    [FieldOffset(4)]
    public VBloodAbilityType AbilityType;

    static AbilityDragData()
    {
      Il2CppClassPointerStore<AbilityDragData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (AbilityDragData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityDragData>.NativeClassPtr);
      AbilityDragData.NativeFieldInfoPtr_AbilityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDragData>.NativeClassPtr, nameof (AbilityId));
      AbilityDragData.NativeFieldInfoPtr_AbilityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDragData>.NativeClassPtr, nameof (AbilityType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityDragData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
