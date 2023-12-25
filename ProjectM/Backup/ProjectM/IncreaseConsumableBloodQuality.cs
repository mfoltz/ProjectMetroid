// Decompiled with JetBrains decompiler
// Type: ProjectM.IncreaseConsumableBloodQuality
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct IncreaseConsumableBloodQuality
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusBloodQuality_Min;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusBloodQuality_Max;
    [FieldOffset(0)]
    public int BonusBloodQuality_Min;
    [FieldOffset(4)]
    public int BonusBloodQuality_Max;

    static IncreaseConsumableBloodQuality()
    {
      Il2CppClassPointerStore<IncreaseConsumableBloodQuality>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (IncreaseConsumableBloodQuality));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncreaseConsumableBloodQuality>.NativeClassPtr);
      IncreaseConsumableBloodQuality.NativeFieldInfoPtr_BonusBloodQuality_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncreaseConsumableBloodQuality>.NativeClassPtr, nameof (BonusBloodQuality_Min));
      IncreaseConsumableBloodQuality.NativeFieldInfoPtr_BonusBloodQuality_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncreaseConsumableBloodQuality>.NativeClassPtr, nameof (BonusBloodQuality_Max));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IncreaseConsumableBloodQuality>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
