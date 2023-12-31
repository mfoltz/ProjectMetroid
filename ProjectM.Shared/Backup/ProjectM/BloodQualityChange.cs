// Decompiled with JetBrains decompiler
// Type: ProjectM.BloodQualityChange
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodQualityChange
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Quality;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodType;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodSource;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForceReapplyBuff;
    [FieldOffset(0)]
    public float Quality;
    [FieldOffset(4)]
    public PrefabGUID BloodType;
    [FieldOffset(8)]
    public PrefabGUID BloodSource;
    [FieldOffset(12)]
    public bool ForceReapplyBuff;

    static BloodQualityChange()
    {
      Il2CppClassPointerStore<BloodQualityChange>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BloodQualityChange));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodQualityChange>.NativeClassPtr);
      BloodQualityChange.NativeFieldInfoPtr_Quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodQualityChange>.NativeClassPtr, nameof (Quality));
      BloodQualityChange.NativeFieldInfoPtr_BloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodQualityChange>.NativeClassPtr, nameof (BloodType));
      BloodQualityChange.NativeFieldInfoPtr_BloodSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodQualityChange>.NativeClassPtr, nameof (BloodSource));
      BloodQualityChange.NativeFieldInfoPtr_ForceReapplyBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodQualityChange>.NativeClassPtr, nameof (ForceReapplyBuff));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodQualityChange>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
