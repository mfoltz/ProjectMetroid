// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.DurabilityInfo
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DurabilityInfo
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentDurability;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDurability;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowRepairCost;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsMana;
    [FieldOffset(0)]
    public float CurrentDurability;
    [FieldOffset(4)]
    public float MaxDurability;
    [FieldOffset(8)]
    public bool ShowRepairCost;
    [FieldOffset(9)]
    public bool IsMana;

    static DurabilityInfo()
    {
      Il2CppClassPointerStore<DurabilityInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (DurabilityInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DurabilityInfo>.NativeClassPtr);
      DurabilityInfo.NativeFieldInfoPtr_CurrentDurability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityInfo>.NativeClassPtr, nameof (CurrentDurability));
      DurabilityInfo.NativeFieldInfoPtr_MaxDurability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityInfo>.NativeClassPtr, nameof (MaxDurability));
      DurabilityInfo.NativeFieldInfoPtr_ShowRepairCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityInfo>.NativeClassPtr, nameof (ShowRepairCost));
      DurabilityInfo.NativeFieldInfoPtr_IsMana = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityInfo>.NativeClassPtr, nameof (IsMana));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DurabilityInfo>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
