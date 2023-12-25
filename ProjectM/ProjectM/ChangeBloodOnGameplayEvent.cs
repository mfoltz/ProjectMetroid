// Decompiled with JetBrains decompiler
// Type: ProjectM.ChangeBloodOnGameplayEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ChangeBloodOnGameplayEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodType;
    private static readonly System.IntPtr NativeFieldInfoPtr_GainBloodType;
    [FieldOffset(0)]
    public float BloodValue;
    [FieldOffset(4)]
    public float BloodQuality;
    [FieldOffset(8)]
    public PrefabGUID BloodType;
    [FieldOffset(12)]
    public GainBloodType GainBloodType;

    static ChangeBloodOnGameplayEvent()
    {
      Il2CppClassPointerStore<ChangeBloodOnGameplayEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ChangeBloodOnGameplayEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeBloodOnGameplayEvent>.NativeClassPtr);
      ChangeBloodOnGameplayEvent.NativeFieldInfoPtr_BloodValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeBloodOnGameplayEvent>.NativeClassPtr, nameof (BloodValue));
      ChangeBloodOnGameplayEvent.NativeFieldInfoPtr_BloodQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeBloodOnGameplayEvent>.NativeClassPtr, nameof (BloodQuality));
      ChangeBloodOnGameplayEvent.NativeFieldInfoPtr_BloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeBloodOnGameplayEvent>.NativeClassPtr, nameof (BloodType));
      ChangeBloodOnGameplayEvent.NativeFieldInfoPtr_GainBloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeBloodOnGameplayEvent>.NativeClassPtr, nameof (GainBloodType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChangeBloodOnGameplayEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
